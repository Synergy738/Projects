import os
import random
import re
import sys

DAMPING = 0.85  
SAMPLES = 10000


def main():
    if len(sys.argv) != 2:
        sys.exit("Usage: python pagerank.py corpus")
    corpus = crawl(sys.argv[1])
    ranks = sample_pagerank(corpus, DAMPING, SAMPLES)
    print(f"PageRank Results from Sampling (n = {SAMPLES})")
    for page in sorted(ranks):
        print(f"  {page}: {ranks[page]:.4f}")
    ranks = iterate_pagerank(corpus, DAMPING)
    print(f"PageRank Results from Iteration")
    for page in sorted(ranks):
        print(f"  {page}: {ranks[page]:.4f}")


def crawl(directory):
    """
    Parse a directory of HTML pages and check for links to other pages.
    Return a dictionary where each key is a page, and values are
    a list of all other pages in the corpus that are linked to by the page.
    """
    pages = dict()

    # Extract all links from HTML files
    for filename in os.listdir(directory):
        if not filename.endswith(".html"):
            continue
        with open(os.path.join(directory, filename)) as f:
            contents = f.read()
            links = re.findall(r"<a\s+(?:[^>]*?)href=\"([^\"]*)\"", contents)
            pages[filename] = set(links) - {filename}

    # Only include links to other pages in the corpus
    for filename in pages:
        pages[filename] = set(
            link for link in pages[filename]
            if link in pages
        )

    return pages


def transition_model(corpus, page, damping_factor):
    """
    Return a probability distribution over which page to visit next,
    given a current page.

    With probability `damping_factor`, choose a link at random
    linked to by `page`. With probability `1 - damping_factor`, choose
    a link at random chosen from all pages in the corpus.
    """
    probabilities = {}
    for link in corpus:
        linkProb = (1 - damping_factor) / len(corpus)
        if link in corpus[page]:
            linkProb += damping_factor / len(corpus[page])
        probabilities[link] = linkProb                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    return probabilities



def sample_pagerank(corpus, damping_factor, n):
    """
    Return PageRank values for each page by sampling `n` pages
    according to transition model, starting with a page at random.

    Return a dictionary where keys are page names, and values are
    their estimated PageRank value (a value between 0 and 1). All
    PageRank values should sum to 1.
    """
    currentPage = random.choice(list(corpus.keys()))
    dtemp = {}
    for i in range(n):
        dtemp[currentPage] = dtemp.get(currentPage, 0) + 1
        probabilities = transition_model(corpus, currentPage, damping_factor)
        currentPage = random.choices(list(probabilities.keys()),weights=list(probabilities.values()))[0]
    sumPages = sum(dtemp.values())
    for page in dtemp:
        dtemp[page] /= sumPages
    return dtemp    




def iterate_pagerank(corpus, damping_factor):
    """
    Return PageRank values for each page by iteratively updating
    PageRank values until convergence.

    Return a dictionary where keys are page names, and values are
    their estimated PageRank value (a value between 0 and 1). All
    PageRank values should sum to 1.
    """
    dRanking = {}
    N = len(corpus)

    for page in corpus:
        dRanking[page] = 1 / N

    while True:
        dtemp = {}
        for page in corpus:
            newRank = (1 - damping_factor) / N
            for linkingPage, linkedPages in corpus.items():
                if page in linkedPages:
                    newRank += damping_factor * (dRanking[linkingPage]/len(linkedPages))
            dtemp[page] = newRank        
        convergence = max(abs(dtemp[page] - dRanking[page]) for page in corpus)
        dRanking = dtemp
        if convergence < 0.001:
            break
        
    return dRanking



if __name__ == "__main__":
    main()
 