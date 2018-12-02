using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kodavimas
{
    class GMatrixGenerator
    {
        private readonly string[] r11 = { "00", "01", "10", "11" };
        int r;
        int m;
        public string[] wordArray { get; set; }

        public GMatrixGenerator(int m, int r)
        {
            this.r = r;
            this.m = m;
            wordArray = CreateWordArray(m, r, Utils.GetF(m));
        }

        private string[] CreateWordArray(int m, int r, string[] FArray) // Metodas skirtas sukurti kodavimo žodžius
        {
            StringBuilder sb = new StringBuilder();
            List<string> wordArray = new List<string>();

            
            for (int i=0; i<m; i++)                                    // Kodo dalis generuojanti V1, V2, ... , Vm
            {
                foreach(string s in FArray)
                {
                    if(CheckIfSymbolAtIndexIsCorrect(i, s, '0'))
                    {
                        sb.Append('1');
                    }
                    else
                    {
                        sb.Append('0');
                    }
                }

                wordArray.Add(sb.ToString());
                sb.Clear();
            }

            int n = 1;
            for(int q=1; q<=r; q++)                                    // suranda kiek turės būti žodžių
            {
                Console.WriteLine("n = " + n);
                n += Utils.Combinations(m, q);
            }
            Console.WriteLine("Turėtų būti k = " + n + " žodžių");

            if(wordArray.ToArray().Length != n - 1) wordArray = GenerateAdditionWords(wordArray);
            while (wordArray.ToArray().Length < n-1)
            {
                wordArray = GenerateAdditionWords(wordArray);
            }

            wordArray.Add(Utils.OneVector((int)Math.Pow(2,m)));                   // Įdedam vienetukų v0 vektorių į pradžią sąrašo
            List<string> revWordArray = new List<string>();
            foreach(string word in wordArray)
            {

                char[] temp = word.ToCharArray();
                //Array.Reverse(temp);
                revWordArray.Add(new string(temp));
            }

            revWordArray.ForEach(x => Console.WriteLine(x));

            
            return revWordArray.ToArray();
        }


        private List<string> GenerateAdditionWords(List<string> wordList)
        {

            int z = wordList.ToArray().Length;
            string[] wordArray = wordList.ToArray();

            for (int i=0; i<z; i++) {
                for(int j=0; j<z; j++)
                {
                    wordList.Add(WordSum(wordArray[i], wordArray[j]));
                }
            }

            return wordList.Distinct().ToList();
        }

        private string WordSum(String wordL, String wordR)
        {
            Char[] wordLChars = wordL.ToArray();
            Char[] wordRChars = wordR.ToArray();
            List<Char> resultChars = new List<Char>();


            for(int i=0; i<wordLChars.Length; i++)
            {
                double asd = Char.GetNumericValue(wordLChars[i]);
                double asdd = Char.GetNumericValue(wordLChars[i]);
                Char asddd = Convert.ToChar((int)(asd * asdd));
              

                resultChars.Add(Convert.ToChar((int)(Char.GetNumericValue(wordLChars[i]) * Char.GetNumericValue(wordRChars[i]))));       // sudauginami vienas su kitu žodžiai
            }

            byte[] stringBytes = Encoding.Unicode.GetBytes(new string(resultChars.ToArray()));
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("{0:X}", (int)c));

            return builder.ToString();
        }

        private bool CheckIfSymbolAtIndexIsCorrect(int index, string s, char symbol)
        {
            char[] sc = s.ToCharArray();

            return (sc[index] == symbol) ? true : false;
        }

    }
}
