using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kodavimas
{
    static class Utils
    {
        public static bool checkIfInt(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }


        public static string getMistakeVector(string vectorA, string vectorB)       // sukuria simbolių eilutę nurodančia kur įvyko klaida
        {
            char[] vectorAArray = vectorA.ToCharArray();
            char[] vectorBArray = vectorB.ToCharArray();
            List<char> mistakeVector = new List<char>();

            for (int i = 0; i < vectorAArray.Length; i++)
            {
                if (vectorAArray[i] != vectorBArray[i])
                {
                    mistakeVector.Add('^');
                }
                else
                {
                    mistakeVector.Add('-');
                }
            }

            return new string(mistakeVector.ToArray());
        }


        public static int mistakesFound(string mv)                                  // suskaičiuoja kiek klaidų klaidų vektorius parodo
        {
            int i = 0;
            foreach (char c in mv)
            {
                if (c == '^')
                {
                    i++;
                }
            }
            return i;
        }

        public static string[] AddArraysLastElementToStart(string[] sArray)
        {

            List<string> sList = new List<string>(sArray);

            string temp = sList.Last();
            sList.Remove(sArray.ToArray().Last());
            sList.Insert(0, temp);


            return sList.ToArray();
        }




        public static int Combinations(int m, int r)                                // suranda C 
        {
            int test = Factorial(m) / (Factorial(r) * Factorial(m - r));

            return Factorial(m) / (Factorial(r) * Factorial(m - r));
        }

        private static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }



        public static string OneVector(int length)
        {
            string vector = "";

            while (vector.Length != length)                              // Sukuriamas reikalingo ilgio vienetukų vektorius.                       
            {
                vector = "1" + vector;
            }

            return vector;
        }



        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        public static string[] GetF(int m)                                 // Metodas skirtas sugeneruoti F
        {
            List<int> result = new List<int>();
            List<string> resultString = new List<string>();
            string vector = OneVector(m);                                     // Sukuriamas reikalingo ilgio vienetukų vektorius.      
            int i = 0;

            result.Add(i);

            while (i != Convert.ToInt32(vector, 2))                // Sveikieji skaičiai kurie yra mažesni už reikalingo ilgio vienetukų vektorių yra sudedami į sąrašą.
            {
                i++;
                result.Add(i);
            }

            foreach (int v in result)                              // Kadangi Convert.ToString(x, 2) sugeneruoja bitų žodžius be nulių iš kairės, juos reikia pridėti. Tai daro šis kodo gabaliukas.
            {
                string toAdd = Convert.ToString(v, 2);
                while (toAdd.Length != m)
                {
                    toAdd = "0" + toAdd;
                }
                resultString.Add(toAdd);
            }

            return resultString.ToArray();
        }

    }
}
