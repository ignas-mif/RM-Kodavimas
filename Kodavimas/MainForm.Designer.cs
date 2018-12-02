namespace Kodavimas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.bitStringTab = new System.Windows.Forms.TabPage();
            this.RezultatasBitString = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bitStringTextBoxWithCoding = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mistakeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.encodedVectorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receivedVectorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ParametraiBitString = new System.Windows.Forms.GroupBox();
            this.decoderButton = new System.Windows.Forms.Button();
            this.errorProbability = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.rMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bitStringRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bitStringLabel = new System.Windows.Forms.Label();
            this.rmLabel = new System.Windows.Forms.Label();
            this.textFieldTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFieldRichTextBoxNoCoding = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFieldRichTextBoxWithCoding = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qTextBox2 = new System.Windows.Forms.TextBox();
            this.startButton1 = new System.Windows.Forms.Button();
            this.rTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textFieldRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tekstoLaukasLabel = new System.Windows.Forms.Label();
            this.rmLabel1 = new System.Windows.Forms.Label();
            this.imageTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoCoding = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxWithCoding = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qTextBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.mTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.bitStringTab.SuspendLayout();
            this.RezultatasBitString.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ParametraiBitString.SuspendLayout();
            this.textFieldTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.imageTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoCoding)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithCoding)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.bitStringTab);
            this.tabControl.Controls.Add(this.textFieldTab);
            this.tabControl.Controls.Add(this.imageTab);
            this.tabControl.Location = new System.Drawing.Point(-2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(952, 374);
            this.tabControl.TabIndex = 0;
            // 
            // bitStringTab
            // 
            this.bitStringTab.Controls.Add(this.RezultatasBitString);
            this.bitStringTab.Controls.Add(this.ParametraiBitString);
            this.bitStringTab.Location = new System.Drawing.Point(4, 22);
            this.bitStringTab.Name = "bitStringTab";
            this.bitStringTab.Padding = new System.Windows.Forms.Padding(3);
            this.bitStringTab.Size = new System.Drawing.Size(944, 348);
            this.bitStringTab.TabIndex = 0;
            this.bitStringTab.Text = "Bitų eilutės kodavimas";
            this.bitStringTab.UseVisualStyleBackColor = true;
            // 
            // RezultatasBitString
            // 
            this.RezultatasBitString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RezultatasBitString.Controls.Add(this.tableLayoutPanel1);
            this.RezultatasBitString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezultatasBitString.Location = new System.Drawing.Point(237, 6);
            this.RezultatasBitString.Name = "RezultatasBitString";
            this.RezultatasBitString.Size = new System.Drawing.Size(704, 336);
            this.RezultatasBitString.TabIndex = 1;
            this.RezultatasBitString.TabStop = false;
            this.RezultatasBitString.Text = "Rezultatas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bitStringTextBoxWithCoding, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mistakeRichTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.encodedVectorRichTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.receivedVectorRichTextBox, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.50725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 307);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dekoduotas vektorius:";
            // 
            // bitStringTextBoxWithCoding
            // 
            this.bitStringTextBoxWithCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitStringTextBoxWithCoding.Location = new System.Drawing.Point(352, 24);
            this.bitStringTextBoxWithCoding.Name = "bitStringTextBoxWithCoding";
            this.bitStringTextBoxWithCoding.ReadOnly = true;
            this.bitStringTextBoxWithCoding.Size = new System.Drawing.Size(343, 119);
            this.bitStringTextBoxWithCoding.TabIndex = 7;
            this.bitStringTextBoxWithCoding.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Įvykusios klaidos:";
            // 
            // mistakeRichTextBox
            // 
            this.mistakeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mistakeRichTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mistakeRichTextBox.Location = new System.Drawing.Point(352, 172);
            this.mistakeRichTextBox.Name = "mistakeRichTextBox";
            this.mistakeRichTextBox.ReadOnly = true;
            this.mistakeRichTextBox.Size = new System.Drawing.Size(343, 132);
            this.mistakeRichTextBox.TabIndex = 9;
            this.mistakeRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Užkoduotas vektorius:";
            // 
            // encodedVectorRichTextBox
            // 
            this.encodedVectorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encodedVectorRichTextBox.Location = new System.Drawing.Point(3, 24);
            this.encodedVectorRichTextBox.Name = "encodedVectorRichTextBox";
            this.encodedVectorRichTextBox.ReadOnly = true;
            this.encodedVectorRichTextBox.Size = new System.Drawing.Size(343, 119);
            this.encodedVectorRichTextBox.TabIndex = 10;
            this.encodedVectorRichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Iš kanalo išėjęs vektorius:";
            // 
            // receivedVectorRichTextBox
            // 
            this.receivedVectorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receivedVectorRichTextBox.Location = new System.Drawing.Point(3, 172);
            this.receivedVectorRichTextBox.Name = "receivedVectorRichTextBox";
            this.receivedVectorRichTextBox.Size = new System.Drawing.Size(343, 132);
            this.receivedVectorRichTextBox.TabIndex = 12;
            this.receivedVectorRichTextBox.Text = "";
            // 
            // ParametraiBitString
            // 
            this.ParametraiBitString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ParametraiBitString.Controls.Add(this.decoderButton);
            this.ParametraiBitString.Controls.Add(this.errorProbability);
            this.ParametraiBitString.Controls.Add(this.startButton);
            this.ParametraiBitString.Controls.Add(this.rMaskedTextBox);
            this.ParametraiBitString.Controls.Add(this.mMaskedTextBox);
            this.ParametraiBitString.Controls.Add(this.bitStringRichTextBox);
            this.ParametraiBitString.Controls.Add(this.bitStringLabel);
            this.ParametraiBitString.Controls.Add(this.rmLabel);
            this.ParametraiBitString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParametraiBitString.Location = new System.Drawing.Point(3, 6);
            this.ParametraiBitString.Name = "ParametraiBitString";
            this.ParametraiBitString.Size = new System.Drawing.Size(228, 336);
            this.ParametraiBitString.TabIndex = 0;
            this.ParametraiBitString.TabStop = false;
            this.ParametraiBitString.Text = "Parametrai";
            // 
            // decoderButton
            // 
            this.decoderButton.Location = new System.Drawing.Point(127, 299);
            this.decoderButton.Name = "decoderButton";
            this.decoderButton.Size = new System.Drawing.Size(95, 31);
            this.decoderButton.TabIndex = 9;
            this.decoderButton.Text = "Dekoduoti";
            this.decoderButton.UseVisualStyleBackColor = true;
            this.decoderButton.Click += new System.EventHandler(this.decoderButton_Click);
            // 
            // errorProbability
            // 
            this.errorProbability.Location = new System.Drawing.Point(183, 26);
            this.errorProbability.Name = "errorProbability";
            this.errorProbability.Size = new System.Drawing.Size(39, 24);
            this.errorProbability.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Location = new System.Drawing.Point(8, 298);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 32);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Koduoti";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rMaskedTextBox
            // 
            this.rMaskedTextBox.Location = new System.Drawing.Point(137, 26);
            this.rMaskedTextBox.Name = "rMaskedTextBox";
            this.rMaskedTextBox.Size = new System.Drawing.Size(39, 24);
            this.rMaskedTextBox.TabIndex = 6;
            // 
            // mMaskedTextBox
            // 
            this.mMaskedTextBox.Location = new System.Drawing.Point(92, 26);
            this.mMaskedTextBox.Name = "mMaskedTextBox";
            this.mMaskedTextBox.Size = new System.Drawing.Size(39, 24);
            this.mMaskedTextBox.TabIndex = 5;
            // 
            // bitStringRichTextBox
            // 
            this.bitStringRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitStringRichTextBox.Location = new System.Drawing.Point(8, 77);
            this.bitStringRichTextBox.Name = "bitStringRichTextBox";
            this.bitStringRichTextBox.Size = new System.Drawing.Size(214, 215);
            this.bitStringRichTextBox.TabIndex = 4;
            this.bitStringRichTextBox.Text = "";
            // 
            // bitStringLabel
            // 
            this.bitStringLabel.AutoSize = true;
            this.bitStringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitStringLabel.Location = new System.Drawing.Point(4, 55);
            this.bitStringLabel.Name = "bitStringLabel";
            this.bitStringLabel.Size = new System.Drawing.Size(75, 18);
            this.bitStringLabel.TabIndex = 3;
            this.bitStringLabel.Text = "Bitų eilutė:";
            // 
            // rmLabel
            // 
            this.rmLabel.AutoSize = true;
            this.rmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLabel.Location = new System.Drawing.Point(4, 26);
            this.rmLabel.Name = "rmLabel";
            this.rmLabel.Size = new System.Drawing.Size(84, 18);
            this.rmLabel.TabIndex = 0;
            this.rmLabel.Text = "Rm(m, r) q:";
            // 
            // textFieldTab
            // 
            this.textFieldTab.Controls.Add(this.groupBox1);
            this.textFieldTab.Controls.Add(this.groupBox2);
            this.textFieldTab.Location = new System.Drawing.Point(4, 22);
            this.textFieldTab.Name = "textFieldTab";
            this.textFieldTab.Padding = new System.Windows.Forms.Padding(3);
            this.textFieldTab.Size = new System.Drawing.Size(944, 348);
            this.textFieldTab.TabIndex = 1;
            this.textFieldTab.Text = "Texto lauko kodavimas";
            this.textFieldTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textFieldRichTextBoxNoCoding);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textFieldRichTextBoxWithCoding);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(237, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 336);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultatas";
            // 
            // textFieldRichTextBoxNoCoding
            // 
            this.textFieldRichTextBoxNoCoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFieldRichTextBoxNoCoding.Location = new System.Drawing.Point(6, 201);
            this.textFieldRichTextBoxNoCoding.Name = "textFieldRichTextBoxNoCoding";
            this.textFieldRichTextBoxNoCoding.ReadOnly = true;
            this.textFieldRichTextBoxNoCoding.Size = new System.Drawing.Size(682, 129);
            this.textFieldRichTextBoxNoCoding.TabIndex = 9;
            this.textFieldRichTextBoxNoCoding.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teksto laukas be kodavimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teksto laukas su kodavimu:";
            // 
            // textFieldRichTextBoxWithCoding
            // 
            this.textFieldRichTextBoxWithCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFieldRichTextBoxWithCoding.Location = new System.Drawing.Point(6, 47);
            this.textFieldRichTextBoxWithCoding.Name = "textFieldRichTextBoxWithCoding";
            this.textFieldRichTextBoxWithCoding.ReadOnly = true;
            this.textFieldRichTextBoxWithCoding.Size = new System.Drawing.Size(688, 118);
            this.textFieldRichTextBoxWithCoding.TabIndex = 7;
            this.textFieldRichTextBoxWithCoding.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.qTextBox2);
            this.groupBox2.Controls.Add(this.startButton1);
            this.groupBox2.Controls.Add(this.rTextBox2);
            this.groupBox2.Controls.Add(this.mTextBox2);
            this.groupBox2.Controls.Add(this.textFieldRichTextBox);
            this.groupBox2.Controls.Add(this.tekstoLaukasLabel);
            this.groupBox2.Controls.Add(this.rmLabel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametrai";
            // 
            // qTextBox2
            // 
            this.qTextBox2.Location = new System.Drawing.Point(185, 26);
            this.qTextBox2.Name = "qTextBox2";
            this.qTextBox2.Size = new System.Drawing.Size(35, 24);
            this.qTextBox2.TabIndex = 8;
            // 
            // startButton1
            // 
            this.startButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton1.Location = new System.Drawing.Point(6, 292);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(214, 32);
            this.startButton1.TabIndex = 7;
            this.startButton1.Text = "Pradėti kodavimą";
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // rTextBox2
            // 
            this.rTextBox2.Location = new System.Drawing.Point(139, 26);
            this.rTextBox2.Name = "rTextBox2";
            this.rTextBox2.Size = new System.Drawing.Size(39, 24);
            this.rTextBox2.TabIndex = 6;
            // 
            // mTextBox2
            // 
            this.mTextBox2.Location = new System.Drawing.Point(94, 26);
            this.mTextBox2.Name = "mTextBox2";
            this.mTextBox2.Size = new System.Drawing.Size(39, 24);
            this.mTextBox2.TabIndex = 5;
            // 
            // textFieldRichTextBox
            // 
            this.textFieldRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFieldRichTextBox.Location = new System.Drawing.Point(8, 77);
            this.textFieldRichTextBox.Name = "textFieldRichTextBox";
            this.textFieldRichTextBox.Size = new System.Drawing.Size(214, 209);
            this.textFieldRichTextBox.TabIndex = 4;
            this.textFieldRichTextBox.Text = "";
            // 
            // tekstoLaukasLabel
            // 
            this.tekstoLaukasLabel.AutoSize = true;
            this.tekstoLaukasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstoLaukasLabel.Location = new System.Drawing.Point(4, 55);
            this.tekstoLaukasLabel.Name = "tekstoLaukasLabel";
            this.tekstoLaukasLabel.Size = new System.Drawing.Size(105, 18);
            this.tekstoLaukasLabel.TabIndex = 3;
            this.tekstoLaukasLabel.Text = "Teksto laukas:";
            // 
            // rmLabel1
            // 
            this.rmLabel1.AutoSize = true;
            this.rmLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmLabel1.Location = new System.Drawing.Point(4, 26);
            this.rmLabel1.Name = "rmLabel1";
            this.rmLabel1.Size = new System.Drawing.Size(84, 18);
            this.rmLabel1.TabIndex = 0;
            this.rmLabel1.Text = "Rm(m, r) q:";
            // 
            // imageTab
            // 
            this.imageTab.Controls.Add(this.groupBox4);
            this.imageTab.Controls.Add(this.groupBox3);
            this.imageTab.Location = new System.Drawing.Point(4, 22);
            this.imageTab.Name = "imageTab";
            this.imageTab.Size = new System.Drawing.Size(944, 348);
            this.imageTab.TabIndex = 2;
            this.imageTab.Text = "Paveiksliuko kodavimas";
            this.imageTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(237, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(707, 342);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rezultatai";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.pictureBoxNoCoding);
            this.groupBox6.Location = new System.Drawing.Point(365, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(332, 313);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Be kodavimo";
            // 
            // pictureBoxNoCoding
            // 
            this.pictureBoxNoCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNoCoding.Location = new System.Drawing.Point(6, 23);
            this.pictureBoxNoCoding.Name = "pictureBoxNoCoding";
            this.pictureBoxNoCoding.Size = new System.Drawing.Size(320, 284);
            this.pictureBoxNoCoding.TabIndex = 0;
            this.pictureBoxNoCoding.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxWithCoding);
            this.groupBox5.Location = new System.Drawing.Point(6, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 313);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Su kodavimu";
            // 
            // pictureBoxWithCoding
            // 
            this.pictureBoxWithCoding.Location = new System.Drawing.Point(6, 23);
            this.pictureBoxWithCoding.Name = "pictureBoxWithCoding";
            this.pictureBoxWithCoding.Size = new System.Drawing.Size(341, 284);
            this.pictureBoxWithCoding.TabIndex = 0;
            this.pictureBoxWithCoding.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.qTextBox3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.rTextBox3);
            this.groupBox3.Controls.Add(this.mTextBox3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 330);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametrai";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Įdėti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 201);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // qTextBox3
            // 
            this.qTextBox3.Location = new System.Drawing.Point(185, 26);
            this.qTextBox3.Name = "qTextBox3";
            this.qTextBox3.Size = new System.Drawing.Size(35, 24);
            this.qTextBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(6, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pradėti kodavimą";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rTextBox3
            // 
            this.rTextBox3.Location = new System.Drawing.Point(139, 26);
            this.rTextBox3.Name = "rTextBox3";
            this.rTextBox3.Size = new System.Drawing.Size(39, 24);
            this.rTextBox3.TabIndex = 6;
            // 
            // mTextBox3
            // 
            this.mTextBox3.Location = new System.Drawing.Point(94, 26);
            this.mTextBox3.Name = "mTextBox3";
            this.mTextBox3.Size = new System.Drawing.Size(39, 24);
            this.mTextBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Paveiksliukas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rm(m, r) q:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 367);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "[Kodavimo Teorija]  Rydo-Miulerio (Reed, Muller) kodas RM(m,r)";
            this.tabControl.ResumeLayout(false);
            this.bitStringTab.ResumeLayout(false);
            this.RezultatasBitString.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ParametraiBitString.ResumeLayout(false);
            this.ParametraiBitString.PerformLayout();
            this.textFieldTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.imageTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoCoding)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithCoding)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage bitStringTab;
        private System.Windows.Forms.TabPage textFieldTab;
        private System.Windows.Forms.TabPage imageTab;
        private System.Windows.Forms.GroupBox RezultatasBitString;
        private System.Windows.Forms.GroupBox ParametraiBitString;
        private System.Windows.Forms.RichTextBox mistakeRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox bitStringTextBoxWithCoding;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MaskedTextBox rMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox mMaskedTextBox;
        private System.Windows.Forms.RichTextBox bitStringRichTextBox;
        private System.Windows.Forms.Label bitStringLabel;
        private System.Windows.Forms.Label rmLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textFieldRichTextBoxNoCoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textFieldRichTextBoxWithCoding;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startButton1;
        private System.Windows.Forms.MaskedTextBox rTextBox2;
        private System.Windows.Forms.MaskedTextBox mTextBox2;
        private System.Windows.Forms.RichTextBox textFieldRichTextBox;
        private System.Windows.Forms.Label tekstoLaukasLabel;
        private System.Windows.Forms.Label rmLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox encodedVectorRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox receivedVectorRichTextBox;
        private System.Windows.Forms.TextBox errorProbability;
        private System.Windows.Forms.Button decoderButton;
        private System.Windows.Forms.TextBox qTextBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox qTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox rTextBox3;
        private System.Windows.Forms.MaskedTextBox mTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxNoCoding;
        private System.Windows.Forms.PictureBox pictureBoxWithCoding;
    }
}