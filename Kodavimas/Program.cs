using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodavimas
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());


            //GMatrixGenerator gg = new GMatrixGenerator(3, 1);
            ////string[] aa = gg.CreateWordArray(3, 2, gg.GetF(3));
            //Console.WriteLine("Sukurti [" + aa.Length + "] žodžiai");

            string asd = Console.ReadLine();
        }
    }
}
