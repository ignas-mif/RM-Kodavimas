using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kodavimas
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }



        //Kodavimas bitų eilutės

        public int RInteger
        {
            get { return Convert.ToInt32(this.rMaskedTextBox.Text); }
        }

        public int MInteger
        {
            get { return Convert.ToInt32(this.mMaskedTextBox.Text); }
        }

        public string BitStringTextBox
        {
            get { return this.bitStringRichTextBox.Text; }
        }

        public string BitStringTextBoxWithCoding
        {
            get { return this.bitStringTextBoxWithCoding.Text; }
            set { this.bitStringTextBoxWithCoding.Text = value; }
        }
        public string MistakeRichTextBox
        {
            get { return this.mistakeRichTextBox.Text; }
            set { this.mistakeRichTextBox.Text = value; }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Utils.checkIfInt(mMaskedTextBox.Text) && Utils.checkIfInt(rMaskedTextBox.Text) && Utils.checkIfInt(bitStringRichTextBox.Text))
            {
                GMatrixGenerator gg = new GMatrixGenerator(MInteger, RInteger);
                GMatrix gm = new GMatrix(gg.wordArray);

                Console.WriteLine("Sukurti [" + gm.Value.Length + "] žodžiai");


                if(BitStringTextBox.Length != gm.Value.Length)
                {
                    MessageBox.Show("Žinutė turi būti " + Convert.ToString(gm.Value.Length) + " simbolių ilgio");
                }
                else
                {
                    encodedVectorRichTextBox.Text = Encoder.EncodeBitstring(BitStringTextBox, gm.Value); // užkoduotas vektorius
                    receivedVectorRichTextBox.Text = Channel.Transmit(encodedVectorRichTextBox.Text, Convert.ToDouble(errorProbability.Text));  // iš kanalo gautas vektorius
                    mistakeRichTextBox.Text = mistakeString();
                    //bitStringTextBoxWithCoding.Text = String.Join("\r\n", gm.Value);    // gmatrica
                }

                
            }
            else
            {
                MessageBox.Show("Įvesta gali būti tik skaičiai, joks laukas negali būti tuščias");
            }


        }
        private string mistakeString()
        {
            string mv = Utils.getMistakeVector(receivedVectorRichTextBox.Text, encodedVectorRichTextBox.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append(receivedVectorRichTextBox.Text);
            sb.Append("\r\n");
            sb.Append(mv);
            sb.Append("\r\n");
            sb.Append("Klaidų rasta: " + Utils.mistakesFound(mv));

            return sb.ToString();
        }

        private void decoderButton_Click(object sender, EventArgs e)
        {
            Decoder d = new Decoder();
            GMatrixGenerator gg = new GMatrixGenerator(MInteger, RInteger);
            GMatrix gm = new GMatrix(gg.wordArray);
            bitStringTextBoxWithCoding.Text = d.Decode(receivedVectorRichTextBox.Text, MInteger, RInteger, gm);
        }


        private void startButton1_Click(object sender, EventArgs e) //teksto kodavimo prad4jimo mygtukas
        {
            //teksto gabaliukų paruošimas
            TextFieldCoding tfc = new TextFieldCoding(textFieldRichTextBox.Text, Convert.ToInt32(rTextBox2.Text), Convert.ToInt32(mTextBox2.Text));

            textFieldRichTextBoxNoCoding.Text = "";
            textFieldRichTextBoxWithCoding.Text = "";

            if (Utils.checkIfInt(rTextBox2.Text) && Utils.checkIfInt(mTextBox2.Text) && textFieldRichTextBox.Text.Length != 0)
            {
                GMatrixGenerator gg = new GMatrixGenerator(Convert.ToInt32(mTextBox2.Text), Convert.ToInt32(rTextBox2.Text));
                GMatrix gm = new GMatrix(gg.wordArray);
                List<string> toSend = tfc.divideTextFieldToBitList();

                if (toSend[0].Length != gm.Value.Length)
                {
                    MessageBox.Show("Žinutė turi būti " + Convert.ToString(gm.Value.Length) + " simbolių ilgio");
                }

                else
                {

                    Decoder d = new Decoder();
                    string tempDecodedText;
                    string tempEncodedText;
                    string tempChannelSeentText;
                    StringBuilder sbWithCoding = new StringBuilder();
                    StringBuilder sbNoCoding = new StringBuilder();

                    List<string> sl = new List<string>();

                    foreach (string s in toSend)    // čia prasideda siuntimas. Kiekvieną sąrašo teksto eilutę užkoduoju, persiunčiu, dekoduoju, paverčiu atgal į tekstą iš bitų eilutės
                    {
                        GMatrixGenerator gg2 = new GMatrixGenerator(Convert.ToInt32(mTextBox2.Text), Convert.ToInt32(rTextBox2.Text));
                        GMatrix gm2 = new GMatrix(gg2.wordArray);


                        tempEncodedText = Encoder.EncodeBitstring(s, gm2.Value); 
                        tempChannelSeentText = Channel.Transmit(tempEncodedText, Convert.ToDouble(qTextBox2.Text));
                        tempDecodedText = d.Decode(tempChannelSeentText, Convert.ToInt32(mTextBox2.Text), Convert.ToInt32(rTextBox2.Text), gm2);

                        sbWithCoding.Append(tempDecodedText);


                        tempChannelSeentText = Channel.Transmit(s, Convert.ToDouble(qTextBox2.Text));
                        sbNoCoding.Append(tempChannelSeentText);
                        sl.Add(tempChannelSeentText);
                        
                    }


                    textFieldRichTextBoxNoCoding.Text = tfc.bitStringToText(sbNoCoding.ToString());
                    textFieldRichTextBoxWithCoding.Text = tfc.bitStringToText(sbWithCoding.ToString());



                }


            }
            else
            {
                MessageBox.Show("Į parametrus įvesta gali būti tik skaičiai, joks laukas negali būti tuščias");
            }

        }

        private void button2_Click(object sender, EventArgs e)          // Nepavykusio įgyvendinti laiku paveiksliuko kodavimas
        {
            //openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";    //paveiksliuko įkėlimas
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }


            PictureCoding pc = new PictureCoding(new Bitmap(pictureBox1.Image), Convert.ToInt32(rTextBox3.Text), Convert.ToInt32(mTextBox3.Text));


            if (Utils.checkIfInt(rTextBox3.Text) && Utils.checkIfInt(mTextBox3.Text))
            {
                GMatrixGenerator gg = new GMatrixGenerator(Convert.ToInt32(mTextBox3.Text), Convert.ToInt32(rTextBox3.Text));
                GMatrix gm = new GMatrix(gg.wordArray);
                List<string> toSend = pc.dividePictureBoxToBitList();

                if (toSend[0].Length != gm.Value.Length)
                {
                    MessageBox.Show("Žinutė turi būti " + Convert.ToString(gm.Value.Length) + " simbolių ilgio");
                }

                else
                {

                    Decoder d = new Decoder();
                    string tempDecodedText;
                    string tempEncodedText;
                    string tempChannelSeentText;
                    StringBuilder sbWithCoding = new StringBuilder();
                    StringBuilder sbNoCoding = new StringBuilder();

                    List<string> sl = new List<string>();

                    foreach (string s in toSend)    // čia prasideda siuntimas. Kiekvieną sąrašo teksto eilutę užkoduoju, persiunčiu, dekoduoju, paverčiu atgal į tekstą iš bitų eilutės
                    {
                        GMatrixGenerator gg2 = new GMatrixGenerator(Convert.ToInt32(mTextBox3.Text), Convert.ToInt32(rTextBox3.Text));
                        GMatrix gm2 = new GMatrix(gg2.wordArray);


                        tempEncodedText = Encoder.EncodeBitstring(s, gm2.Value);
                        tempChannelSeentText = Channel.Transmit(tempEncodedText, Convert.ToDouble(qTextBox3.Text));
                        tempDecodedText = d.Decode(tempChannelSeentText, Convert.ToInt32(mTextBox3.Text), Convert.ToInt32(rTextBox3.Text), gm2);

                        sbWithCoding.Append(tempDecodedText); //1000100101010000 
                                                              //"1000100101010000


                        tempChannelSeentText = Channel.Transmit(s, Convert.ToDouble(qTextBox3.Text));
                        sbNoCoding.Append(tempChannelSeentText);
                        sl.Add(tempChannelSeentText);

                    }


                    
                    

                    pictureBoxNoCoding.Image = pc.bitStringToImage(sbNoCoding.ToString());
                    pictureBoxWithCoding.Image = pc.bitStringToImage(sbWithCoding.ToString());

                }
            }
            else
            {
                MessageBox.Show("Į parametrus įvesta gali būti tik skaičiai, joks laukas negali būti tuščias");
            }

        }
    }


}
