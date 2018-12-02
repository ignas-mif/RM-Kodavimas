using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodavimas
{
    class PictureCoding
    {
        Bitmap _Picture { set; get; }
        int _r { set; get; }
        int _m { set; get; }
        int _n { set; get; } // žinutės ilgis
        byte[] Header { set; get; }

        public PictureCoding(Bitmap Picture, int r, int m)
        {
            _Picture = Picture;
            _r = r;
            _m = m;


            _n = 1;
            for (int q = 1; q <= r; q++)                                    // suranda koks žodžio ilgis
            {
                _n += Utils.Combinations(m, q);
            }


        }

        public List<string> dividePictureBoxToBitList()                    // padalinu bitsringą į reikalingo dydžio gabaliukus
        {

            byte[] imgBytes = imageToByteArray(_Picture);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < imgBytes.Length; i++)
            {
                sb.Append(Convert.ToString(imgBytes[i], 2).PadLeft(8, '0'));
            }

            string bitString = sb.ToString();
            sb.Clear();


            List<string> bitStringListToSend = new List<string>();


            int messageIndex = 0;
            while (bitString.Length >= _n)
            {
                for (int i = 0; i < _n; i++)
                {
                    sb.Append(bitString[i]);

                }
                bitStringListToSend.Add(sb.ToString());
                bitString = bitString.Substring(_n);
                sb.Clear();
            }

            foreach (string s in bitStringListToSend)
            {
                sb.Append(s);
            }



            Image text = bitStringToImage(sb.ToString());


            return bitStringListToSend; //"1000100101010000"
        }

        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {

            ImageConverter imgCon = new ImageConverter();

            byte[] pictureFull = (byte[])imgCon.ConvertTo(imageIn, typeof(byte[]));

            Header = pictureFull.Take(100).ToArray();
            byte[] picture = pictureFull.Skip(100).ToArray();


            return picture;

        }




        public Image byteArrayToImage(byte[] byteArrayIn)
        {

       

            byteArrayIn = Header.Concat(byteArrayIn).ToArray(); // prideduheader



            Bitmap bmp;
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var bmp1 = new BitmapData();

                bmp = new Bitmap(ms, true);
            }

            using (Form form = new Form())
            {


                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size(20, 20);

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = bmp;

                form.Controls.Add(pb);
                form.ShowDialog();
            }


            return (Image)bmp;

        }

        //private string bitMapToString(Bitmap bitmap) //https://stackoverflow.com/questions/2368757/easy-way-to-convert-a-bitmap-and-png-image-to-text-and-vice-versa
        //{
        //    MemoryStream memoryStream = new MemoryStream();
        //    bitmap.Save(memoryStream, ImageFormat.Png);
        //    byte[] bitmapBytes = memoryStream.GetBuffer();
        //    string bitmapString = Convert.ToBase64String(bitmapBytes, Base64FormattingOptions.InsertLineBreaks);

        //    return bitmapString;
        //}

        //private string textToBitString(string text)
        //{
        //    byte[] toBytes = Encoding.ASCII.GetBytes(text);

        //    return ToBinaryString(Encoding.UTF8, text);
        //}

        public Image bitStringToImage(string bitstring)
        {
            byte[] b = getBitwiseByteArray(bitstring);
            Array.Reverse(b);

            //char[] temp = Encoding.ASCII.GetString(b).ToCharArray();                                // Apsuku eilutę
            //Array.Reverse(temp);








            //using (Form form = new Form())
            //{
            //    Bitmap img = (Bitmap)byteArrayToImage(b);

            //    form.StartPosition = FormStartPosition.CenterScreen;
            //    form.Size = new Size(20, 20);

            //    PictureBox pb = new PictureBox();
            //    pb.Dock = DockStyle.Fill;
            //    pb.Image = img;

            //    form.Controls.Add(pb);
            //    form.ShowDialog();
            //}







            return byteArrayToImage(b);
        }


        //public Image stringToImage(string bitmapString)
        //{

        //    string text = bitStringToImage(bitmapString);
        //    // jau turiu dekoduotus 1 0
        //    // reikia juos paversti Į base64


        //    byte[] bitmapBytes = Convert.FromBase64String(text);


        //    Image image;
        //    using (MemoryStream ms = new MemoryStream(bitmapBytes))
        //    {
        //        image = Image.FromStream(ms);
        //    }

        //    return image;
        //}

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
