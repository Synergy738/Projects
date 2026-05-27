# PageRank: Web Page Importance Ranking

An implementation of Google's PageRank algorithm to rank web pages by importance. This project demonstrates two approaches: **random surfer sampling** and **iterative convergence**, both producing equivalent results for evaluating web page significance based on link analysis.

## Overview

PageRank models the internet as a directed graph where pages are nodes and hyperlinks are edges. A page's importance is determined by both the quantity and quality of pages linking to it. This project implements the algorithm that powers Google's search engine ranking.

**Key Features:**
- **Markov Chain sampling:** Simulate a random surfer following links to estimate PageRank
- **Iterative calculation:** Mathematical convergence approach using recursive PageRank formula
- **Damping factor:** Handles disconnected networks and avoids rank traps
- **Two equivalent methods** that validate each other

## Algorithm Concepts

### Random Surfer Model

A hypothetical surfer starts on a random page, then repeatedly:
- With probability `d` (damping factor ≈ 0.85): Clicks a random link from the current page
- With probability `1 - d` (≈ 0.15): Jumps to any random page in the corpus

A page's PageRank is the proportion of time the surfer spends on that page over many iterations.

**Why damping factor?** Handles dangling pages (pages with no outlinks) and isolated clusters by ensuring the surfer can always escape to any page, preventing rank accumulation in dead ends.

### Iterative Formula

PageRank is calculated recursively:

```
PR(p) = (1 - d) / N + d * Σ(PR(i) / NumLinks(i))
```

Where:
- `PR(p)` = PageRank of page p
- `d` = damping factor (0.85)
- `N` = total number of pages
- `i` = pages linking to p
- `NumLinks(i)` = number of outgoing links from page i

Iterations continue until convergence (values change < 0.001).

## Project Structure

```
pagerank/
├── pagerank.py        # Main implementation
├── crawl.py          # HTML parser (provided)
├── corpus0/          # Sample corpus (4 pages)
├── corpus1/          # Sample corpus (4 pages)
└── README.md         # This file
```

## Requirements

- Python 3.10+
- No external dependencies (uses only standard library)

## Usage

### Run PageRank on a Corpus

```bash
python pagerank.py corpus0
```

**Output:**
```
PageRank Results from Sampling (n = 10000)
  1.html: 0.2223
  2.html: 0.4303
  3.html: 0.2145
  4.html: 0.1329
PageRank Results from Iteration
  1.html: 0.2202
  2.html: 0.4289
  3.html: 0.2202
  4.html: 0.1307
```

Results from both methods should be similar (sampling varies slightly due to randomness).

## Implementation Details

### `transition_model(corpus, page, damping_factor)`

Returns a probability distribution for the next page a random surfer would visit.

**Logic:**
1. Base probability for each page: `(1 - damping_factor) / N`
2. For each outgoing link from current page: add `damping_factor / NumLinks(page)`
3. If current page has no outgoing links: distribute damping factor equally across all pages

**Example:**
```python
corpus = {"1.html": {"2.html", "3.html"}, "2.html": {"3.html"}, "3.html": {"2.html"}}
transition_model(corpus, "1.html", 0.85)
# Returns: {"1.html": 0.05, "2.html": 0.475, "3.html": 0.475}
```

### `sample_pagerank(corpus, damping_factor, n)`

Estimates PageRank by simulating `n` random surfer walks.

**Algorithm:**
1. Start on a random page
2. For each sample: Use `transition_model()` to pick next page
3. Count visits to each page
4. Return (visits / total_samples) as estimated PageRank

**Convergence:** 10,000 samples typically produces results within ±0.005 of true PageRank.

### `iterate_pagerank(corpus, damping_factor)`

Calculates exact PageRank using the iterative formula.

**Algorithm:**
1. Initialize all pages with rank 1/N
2. Iterate: For each page p, calculate new rank using PR formula
3. Continue until all ranks change by < 0.001
4. Return final ranks

**Convergence:** Typically 20–50 iterations for standard corpora.

## Experimentation & Results

### Comparing Methods

| Aspect | Sampling | Iteration |
|--------|----------|-----------|
| **Computation** | O(n × E) where E = edges | O(I × N × I_p) where I_p = in-degree |
| **Accuracy** | Probabilistic (~10K samples needed) | Exact (0.001 threshold) |
| **Variance** | ±0.005 typical | Zero |
| **Use Case** | Streaming/real-time | Batch/offline ranking |

### Damping Factor Impact

| Factor | Result | Notes |
|--------|--------|-------|
| d = 0.85 | Balanced | Google's standard |
| d = 0.95 | More weight on links | Increases link importance |
| d = 0.50 | More uniform | All pages more equal |
| d = 0.00 | All equal (1/N) | Random jumping only |

**Finding:** 0.85 balances link-based ranking with exploration, preventing rank concentration.

### Handling Edge Cases

**Problem:** What if a page has no outgoing links?  
**Solution:** Treat as having links to all pages (including itself).  
**Result:** Prevents PageRank "sinks" from breaking convergence.

**Problem:** Disconnected clusters of pages?  
**Solution:** Damping factor allows surfer to jump between clusters.  
**Result:** All pages receive non-zero PageRank.

## What Worked Well

✅ **Transition model abstraction:** Separates concern of probability distribution from traversal  
✅ **Damping factor elegance:** Single parameter solves multiple problems (traps, sinks, disconnection)  
✅ **Convergence threshold:** 0.001 balances precision vs. iterations (~30–50 typical)  
✅ **Dictionary representation:** Clean corpus structure supports both algorithms  

## What Required Care

⚠️ **Set initialization:** Must handle sets for corpus values (order-independent links)  
⚠️ **Dangling pages:** Easy to forget pages with zero outgoing links  
⚠️ **Convergence check:** Must compare *all* ranks before declaring convergence  
⚠️ **Probability normalization:** Sampling method requires exact sum = 1.0  

## Real-World Insights

**Why PageRank Matters:**
1. **Link quality weighting:** A link from Wikipedia outranks a link from a spam site
2. **Transitive trust:** Importance flows through the network
3. **Circular logic resolved:** Mathematical framework handles "page A is important if linked by important pages"

**Limitations:**
- Doesn't consider link text or context
- Assumes uniform click behavior (real surfers have patterns)
- Vulnerable to link farming (addressed in modern algorithms)
- Requires full corpus knowledge (not real-time for live web)

## Future Enhancements

- **Link text analysis:** Weight links by anchor text relevance
- **Temporal decay:** Decrease value of old links
- **Topic-sensitive PageRank:** Bias toward particular domains
- **Link spam detection:** Identify artificial link farms
- **Batch processing:** Handle large corpora incrementally

## References

- [The PageRank Citation Ranking](http://infolab.stanford.edu/~backrub/pageranksearch.html) — Brin & Page (1998)
- [CS50 AI Course](https://cs50.harvard.edu/ai/2020/)

## License

Based on CS50's Introduction to Artificial Intelligence with Python (2020), Harvard University's OpenCourseWare.

## Author

Implemented as part of CS50's Introduction to Artificial Intelligence with Python.
