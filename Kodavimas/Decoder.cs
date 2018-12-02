using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodavimas
{
    class Decoder
    {

        public string Decode(string jumbledVector, int m, int r, GMatrix gMatrix)
        {
            List<int> cAmountL = new List<int>();
            List<int> cAmountR = new List<int>();
            List<string> combosList = new List<string>();

            int n = 1;
            for (int q = 1; q <= r; q++)                                    // suranda kiek turės būti žodžių
            {
                cAmountL.Add(q);
                cAmountR.Add(Utils.Combinations(m, q));
                Console.WriteLine("n = " + n);
                n += Utils.Combinations(m, q);
            }
            Console.WriteLine("[DECODER]Turėtų būti k = " + n + " žodžių");

            List<string> result = cCombos(m, cAmountL.Last(), n);


            string e = codingIterationRemoval(n, m, jumbledVector, result, gMatrix);

            char[] c = e.ToArray();
            Array.Reverse(c);
            e = new string(c);

            return e;
        }


        private string subtractBitStrings(string a, string b)       // atima bitų eilutę iš bitų eilutės
        {
            char[] cA = a.ToCharArray();
            char[] cB = b.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<cB.Length; i++)
            {
                int c = int.Parse(cA[i].ToString()) - int.Parse(cB[i].ToString());
                if (c < 0) c = 1;
                if (c > 1) c = 0;
                sb.Append(Convert.ToString(c));
            }
            return sb.ToString();
        }


        private string codingIterationRemoval(int n, int m, string yVector, List<string> combosList, GMatrix gMatrix) // sugeneruoja atkoduotą vektorių
        {
            string lastVal = gMatrix.Value.Last();                      // Neteisingoj vietoj gmatricos elementas. Pataisau tai.
            List<string> temp = new List<string>(gMatrix.Value);
            temp.Remove(temp.Last());
            temp.Insert(0, lastVal);
            gMatrix.Value = temp.ToArray();


            string allNumbersUntillLength = "";
            for (int i = 0; i < m; i++)
            {
                allNumbersUntillLength = allNumbersUntillLength + Convert.ToString(i + 1);
            }

            combosList.Reverse();
            combosList.Add("0");
            int comboLength;
            string sectionVector = yVector;
            int previousComboLength = combosList.First().Length;
            int j = 0;
            int gMatrixFollower = 1;
            StringBuilder sb = new StringBuilder();
            List<string> comboIterations = new List<string>();          // skirtas suskaldyti a į skyrius 
            for (int i=0; i < combosList.ToArray().Length; i++)                            // eina per kiekvieną a() nuo galo  
            {

                
                comboLength = combosList[i].Length;

                if (comboLength != previousComboLength || combosList[i] == "0")          // jeigu prieš tai buvusio a ilgis toks pats kaip dabartinio reiškia skaldyt dar nereikia
                {

                    List<string> multiplicationResults = new List<string>();

                    foreach (string comboIteration in comboIterations)      // kai turiu atskirą skyrių tada reikia iš y atimti to skyriaus balsų sudaugintų su reikiamom gMatricos eilutėm sumą
                    {

                        List<string> voterWords = voterWordGeneration(new List<string>(Utils.GetF(m)), comboIteration, allNumbersUntillLength);
                        string calculatedVotes = calculateVotes(comboIteration.Length, voterWords, sectionVector);
                        sb.Append(calculatedVotes);
                        if (sb.Length == n) return sb.ToString();

                        // gmatricos eilute galime gauti pagal combo[i] -> i?

                        // reikia patikrinti 1) ar teisingai atrenkamos gmatricos eilut4s, 2) ar teisingai sudaugina ... 

                        // funkcija sudauginanti gmatricos eilutę su balsu. Reikia kažkaip gauti reikiamą gmatricos eilutę


                        string multiplicationResult = multiplyVoteWithRelevantVectors(calculatedVotes, gMatrix.Value[gMatrix.Value.Length - gMatrixFollower]);
                        gMatrixFollower++;
                        multiplicationResults.Add(multiplicationResult);

                    }
                    sectionVector = subtractSectionVectorFromY(sectionVector, sumMultiplicationResults(multiplicationResults));
                    
                    multiplicationResults.Clear();
                    comboIterations.Clear();
                    if (combosList[i] == "0") comboIterations.Add(combosList[i]);
                    i--;
                    
                }
                else
                {
                    comboIterations.Add(combosList[i]);
                }

                previousComboLength = comboLength;
                j++;
            }

            return sectionVector;
        }

        private string sumMultiplicationResults(List<string> multiplicationResults)     // susumuoja visus sąrašo elementus mod2
        {
            string[] multiplicationResultsArr = multiplicationResults.ToArray();
            char[][] result = multiplicationResultsArr.Select(item => item.ToArray()).ToArray();

            int r;
            string res = "";
            for (int j = 0; j < result[1].GetLength(0); j++)
            {
                r = 0;
                for (int k = 0; k < result.GetLength(0); k++)
                {
                    r += (int)Char.GetNumericValue(result[k][j]);
                    if (r > 1) r = 0;
                }
                res += Convert.ToString(r);
            }

            return res;
        }

        private string subtractSectionVectorFromY(string y, string sectionVector)                       // Atima pvz.: (a(1)*v1 + a(2) * v2 + a(3)*v3) - (a(1,2)*(v1* v3) +... a(2,3)*(v2*v3)
        {
            char[] sectionVectorInChars = sectionVector.ToCharArray();
            char[] yInChars = y.ToCharArray();
            string res = "";


            for(int i = 0; i < sectionVectorInChars.Length; i++)
            {
                int temp = int.Parse(yInChars[i].ToString()) - int.Parse(sectionVectorInChars[i].ToString());

                if(temp < 0)
                {
                    temp = 1;
                }
                res = res + Convert.ToString(temp);
            }  

            return res;
        }


        private string multiplyVoteWithRelevantVectors(string vote, string gMatrixLine)         // Sudaugina pvz.: a(1,2) su (v1*v2) ir grąžina rezultatą
        {
            
            char[] temp = gMatrixLine.ToCharArray();                                // Apsuku eilutę
            Array.Reverse(temp);
            string revGMatrixLine = new string(temp);
            StringBuilder sb = new StringBuilder();
            
            foreach(char c in revGMatrixLine)
            {
                sb.Append(int.Parse(c.ToString()) * int.Parse(vote));
            }


            char[] temp2 = sb.ToString().ToCharArray();                                // Apsuku eilutę
            Array.Reverse(temp2);
            string revSb = new string(temp2);


            return revSb;
        }


        private string calculateVotes(int comboLength, List<string> voterWords, string yVector) // Suskaičiuoja balsus ir išveda išvadą(0 arba 1)
        {
            List<int> votes = new List<int>();
            List<string> wIndexes = new List<string>();

            for (int j = 0; j < voterWords.ToArray().Length; j++)
            {
                string bits = Convert.ToString(j, 2);
                while (bits.Length < Convert.ToString(voterWords.ToArray().Length - 1, 2).Length)
                {
                    bits = "0" + bits;
                }


                wIndexes.Add(bits);
            }

            int i = 0;
            string[] f = wIndexes.ToArray();
            foreach (string s in voterWords)
            {
                votes.Add(getVote(comboLength, s, yVector, f[i]));
                i++;
            }

            IEnumerable<int> ones = (from v in votes
                                     where v == 1
                                     select v);

            IEnumerable<int> zeros = (from v in votes
                                      where v == 0
                                      select v);

            if (ones.ToArray().Length > zeros.ToArray().Length)
            {
                return "1";
            }

            return "0";
        }

        private int getVote(int comboLength, string voterWord, string yVector, string t)
        {
            int vote = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < voterWord.Length; i++)
            {
                if (voterWord[i] == '1')
                {
                    sb.Append(yVector[i]);
                }
            }

            string releventBits = sb.ToString();
            foreach (char c in releventBits)
            {
                vote += Int32.Parse(c.ToString());
                if (vote == 2) vote = 0; // mod 2
            }

            return vote;
        }


        private List<string> voterWordGeneration(List<string> fList, string aCombo, string allNumbersUntillLength)    // įdedami F baziniai žodžiai, skaičiukai iš kurių gausim skirtumą, sudaugintų vektorių indeksai; išeina sąrašas balsuotojų vektorių
        {
            string l = "";

            foreach (char c in allNumbersUntillLength)          // atliekama skirtumo gavimo operacija
            {
                if (!aCombo.Contains(c))
                {
                    l += c;
                }
            }


            string[] wIndexes = Utils.GetF(l.Length);
            List<string> wordList = new List<string>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < wIndexes.Length; i++)
            {
                foreach (string s in fList)      // šitas pereis per F ir patikrins kas yra reikiamose pozicijose
                {
                    sb.Append(checkStringPositions(s, l, wIndexes[i]));
                }
                wordList.Add(sb.ToString());
                sb.Clear();
            }

            return wordList;
        }


        private string checkStringPositions(string sToCheck, string indexes, string values)       // 001, 2, 0   ;   101, 12, 00
        {
            string tempValues = values;
            char[] c = sToCheck.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < c.Length; i++)
            {
                if (indexes.Length != 0 && i + 1 == int.Parse(indexes.First().ToString())) // patikrina ar teisingoj vietoj ir ar turi ką tikrint vėliau
                {

                    indexes = indexes.Substring(1);
                    if (c[i] == values.First())
                    {
                        sb.Append("1");
                    }
                    else
                    {
                        sb.Append("0");
                    }
                    values = values.Substring(1);

                }
            }

            string result = sb.ToString();

            return isAllOnes(result) ? "1" : "0";
        }


        private bool isAllOnes(string s)
        {
            foreach (char c in s)
            {
                if (c != '1')
                {
                    return false;
                }
            }
            return true;
        }


        private List<string> cCombos(int maxNum, int vectorLength, int vectorAmount)        // sugeneruoja indeksus žodžių kurie buvo sudauginti gaminant užkoduotą vektorių
        {
            List<int> numList = new List<int>();
            List<string> combinationNumList = new List<string>();

            for (int i = 1; i <= maxNum; i++)                                                // pirmiausiai sukuriu sąrašą skaičiukų iki kurio skaičiaus reikės generuoti
            {
                numList.Add(i);
            }

            numList.ForEach(x => combinationNumList.Add(Convert.ToString(x)));              // sukonvertuoju skaičiukus į stringus

            int j = 0;
            int test = combinationNumList.ToArray().Length;
            while (combinationNumList.Last().Length != vectorLength || combinationNumList.ToArray().Length != vectorAmount-1)  // vis dadedinėju simbolį iš dešinės kol turiu reikalingą kiekį vektorių
            {

                foreach (int z in numList)
                {
                    if (!combinationNumList[j].Contains(Convert.ToString(z)) && !checkIfRepeats(combinationNumList, combinationNumList[j] + Convert.ToString(z))) // patikrinu ar nebuvo šių skaičių kombinacijos anksčiau
                    {
                        combinationNumList.Add(combinationNumList[j] + Convert.ToString(z));
                    }
                }
                j++;
            }
            return combinationNumList;
        }


        private bool checkIfRepeats(List<string> sList, string sToCheck)            // patikrina ar jau buvo šitų skaičių kombinacija
        {                                                                           // surikiuoja sList string elementų simbolius ir sToCheck simbolius ir patikrina ar tokie jau buvo 
            List<string> arrangedSList = new List<string>();

            char[] c;

            foreach (string s in sList)
            {
                c = s.ToArray();
                Array.Sort(c);
                arrangedSList.Add(new string(c));
            }

            c = sToCheck.ToArray();
            Array.Sort(c);
            sToCheck = new string(c);

            foreach (string st in arrangedSList)
            {
                if (st == sToCheck)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
