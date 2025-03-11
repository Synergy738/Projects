using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitanicSyndrome
{
    public class Person
    {
        /*
        - Person object that contains details related to the person
        - information from here is stored in the db for that person
        */

        public List<int> aChange = new List<int> { 6, 2, 3, 4, 5 };
        public List<int> dChange = new List<int> { 3, 3, 3, 3, 3 };
        public List<int> iChange = new List<int> { 3, 2, 4, 4, 4 };

        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string job { get; set; }
        public string test { get; set; }

        public string company { get; set; }
        public string password { get; set; }

        public Person(string name, string surname, string email, string phone, int age, string gender, string job, string company, string test, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
            this.age = age;
            this.gender = gender;
            this.job = job;
            this.company = company;
            this.test = test;
            this.password = password;
        }

        

        public List<(string category, int sum)> pairedScores()
        {
            /*
            Calculates the total for each category, sorts them in descending order, 
            and returns the corresponding list of category names with their sums.
            */

            // Dictionary to store category names and their respective sums
            List<(string category, int sum)> pairedScores = new List<(string, int)>()
            {
                ("aChange", aChange.Sum()),
                ("dChange", dChange.Sum()),
                ("iChange", iChange.Sum())
            };

            // Sort the list of tuples by sum in descending order
            pairedScores.Sort((x, y) => y.sum.CompareTo(x.sum));

            return pairedScores;
        }


        public List<String> calcScores()
        {
            /*
            Calculates the total for each category, sorts them in descending order, 
            and returns the corresponding list of characters.
            */

            // Categories represented by characters
            List<char> scores = new List<char>() { 'a', 'd', 'i' };

            // Sums of each category's scores
            List<int> sumScores = new List<int>()
            {
                aChange.Sum(),
                dChange.Sum(),
                iChange.Sum()
            };

            // Create a list of tuples (char, sum) to pair categories with their sums
            List<(char category, int sum)> pairedScores = new List<(char, int)>()
            {
                (scores[0], sumScores[0]),
                (scores[1], sumScores[1]),
                (scores[2], sumScores[2])
            };

            // Sort the list of tuples by sum in descending order
            pairedScores.Sort((x, y) => y.sum.CompareTo(x.sum));

            // Extract the sorted list of characters as strings
            List<string> sortedScores = pairedScores.Select(pair => pair.category.ToString()).ToList();

            return sortedScores;
        }

        public List<String> calcScores(int achange, int dchange, int ichange)
        {
            /*
            Calculates the total for each category, sorts them in descending order, 
            and returns the corresponding list of characters.
            */

            // Categories represented by characters
            List<char> scores = new List<char>() { 'a', 'd', 'i' };

            // Sums of each category's scores
            List<int> sumScores = new List<int>()
            {
                achange,
                dchange,
                ichange
            };

            // Create a list of tuples (char, sum) to pair categories with their sums
            List<(char category, int sum)> pairedScores = new List<(char, int)>()
            {
                (scores[0], sumScores[0]),
                (scores[1], sumScores[1]),
                (scores[2], sumScores[2])
            };

            // Sort the list of tuples by sum in descending order
            pairedScores.Sort((x, y) => y.sum.CompareTo(x.sum));

            // Extract the sorted list of characters as strings
            List<string> sortedScores = pairedScores.Select(pair => pair.category.ToString()).ToList();

            return sortedScores;
        }

        public int totalScore() 
            {
                /*
                 Calculates and returns the total score of the person
                 */
                int totalSum = aChange.Sum() + dChange.Sum() + iChange.Sum();
                return totalSum;
            }    

    }
}
