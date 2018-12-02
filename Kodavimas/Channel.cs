using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodavimas
{
    static class Channel
    {
        public static string Transmit(string message, double q)
        {
            char[] messageChars = message.ToCharArray();

            Random rn = new Random();

            for (int i=0; i<messageChars.Length; i++)
            {
                if((q * 100) > rn.Next(0, 100))
                {
                    messageChars[i] = switchZeroOne(messageChars[i]);
                }
            }

            return new string(messageChars);
        }

        private static char switchZeroOne(char c)
        {
            return (c == '0') ? '1' : '0';
        }

    }
}
