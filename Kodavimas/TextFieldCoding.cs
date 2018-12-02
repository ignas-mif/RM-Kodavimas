using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodavimas
{
    class TextFieldCoding
    {
        string _TextField { set; get; }
        int _r { set; get; }
        int _m { set; get; }
        int _n { set; get; } // žinutės ilgis
        int leftLength;

        public TextFieldCoding(string TextField, int r, int m)
        {
            _TextField = TextField;
            _r = r;
            _m = m;

            _n = 1;
            for (int q = 1; q <= r; q++)                                    // suranda koks žodžio ilgis
            {
                _n += Utils.Combinations(m, q);
            }

        }


        public List<string> divideTextFieldToBitList()                    // padalinu bitsringą į reikalingo dydžio gabaliukus
        {

            string bitString = textToBitString(_TextField); 
            List<string> bitStringListToSend = new List<string>();
            StringBuilder sb = new StringBuilder();

            int messageIndex = 0;
            while(bitString.Length >= _n)
            {
                for (int i = 0; i < _n; i++)
                {
                    sb.Append(bitString[i]);
                    
                }
                bitStringListToSend.Add(sb.ToString());
                bitString = bitString.Substring(_n);
                sb.Clear();
            }
            leftLength = bitString.Length;

            return bitStringListToSend;
        }



        private string textToBitString(string text)
        {
            byte[] toBytes = Encoding.ASCII.GetBytes(text);

            return ToBinaryString(Encoding.UTF8, text);
        }

        public string bitStringToText(string bitstring)
        {
            for(int i = 0; i< leftLength; i++)                                                      // tarnybinė informacija. Pridedami vietą užimantys bitukai kad būtų pradinio ilgio žinutė
            {
                bitstring = bitstring + "0";
            }

            byte[] b = getBitwiseByteArray(bitstring);


            char[] temp = Encoding.ASCII.GetString(b).ToCharArray();                                // Apsuku eilutę
            Array.Reverse(temp);

            return new string(temp);
        }


        static string ToBinaryString(Encoding encoding, string text) //https://social.msdn.microsoft.com/Forums/vstudio/en-US/a04472e3-c143-4626-bc1d-dc8f6f4c68c1/net-c-string-to-bit-array?forum=netfxbcl
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        private static byte[] getBitwiseByteArray(string input) //https://vbktech.wordpress.com/2011/07/08/c-net-converting-a-string-of-bits-to-a-byte-array/
        {
            List<byte> byteList = new List<byte>();
            for (int i = input.Length - 1; i >= 0; i -= 8)
            {
                string byteString = "";
                for (int j = 0; (i - j) >= 0 && j < 8; j++)
                {
                    byteString = input[i - j] + byteString;
                }
                if (byteString != "")
                {
                    byteList.Add(Convert.ToByte(byteString, 2));
                }
            }
            return byteList.ToArray();
        }

  


    }
}
