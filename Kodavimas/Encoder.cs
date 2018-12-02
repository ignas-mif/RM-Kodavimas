using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodavimas
{
    static class Encoder
    {
        public static string EncodeBitstring(string initialBitstring, string[] gMatrix)                 //Priima gMatricą ir pradinį vektoriu, išveda užkoduotą vektorių
        {
            List<string> resultList = new List<string>();

            string lastVal = gMatrix.Last();                      // Neteisingoj vietoj gmatricos elementas. Pataisau tai.
            List<string> temp = new List<string>(gMatrix);
            temp.Remove(temp.Last());
            temp.Insert(0, lastVal);
            gMatrix = temp.ToArray();


            int i = 0;
            foreach(char a in initialBitstring)
            {
                resultList.Add(multiplyWithVector((int)Char.GetNumericValue(a), gMatrix[i]));
                i++;
            }
            //Console.WriteLine("RESULT VECTOR: [" + resultVector + "]");

            char[][] resultCharArray= resultList.ToArray().Select(item => item.ToArray()).ToArray();

            int r;
            string res = "";
            int asd = resultCharArray[1].GetLength(0);

            for (int j=0; j < resultCharArray[1].GetLength(0); j++)
            {
                r = 0;
                for(int k=0; k<resultCharArray.GetLength(0); k++)
                {
                    r += (int) Char.GetNumericValue(resultCharArray[k][j]);
                    if (r > 1) r = 0;
                }
                res += Convert.ToString(r);
            }
            Console.WriteLine("ENCODING RESULT: [" + res + "]");
            return res;
        }

        private static string multiplyWithVector(int i, string vector)
        {
            List<int> result = new List<int>();
            //Console.WriteLine("i: ["+ Convert.ToString(i) + "] " + "VECTOR: [" + vector+ "]");
            foreach (char c in vector)
            {
                
                int r = i * (int) Char.GetNumericValue(c);
               
                result.Add(r);
            }

            string rString = "";
            foreach(int j in result)
            {
                rString += Convert.ToString(j);
            }

            Console.WriteLine("NUMERIC VALUE: [" + rString + "]");

            return rString;
        }
    }
}
