namespace Lab06_Herasymchuk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_fileKey_out = new System.Windows.Forms.TextBox();
            this.button_fileKey_out = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_viewPassWord = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label_fileSave = new System.Windows.Forms.Label();
            this.label_fileCipher = new System.Windows.Forms.Label();
            this.label_fileOpen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_fileCipher = new System.Windows.Forms.Button();
            this.imageList_XOR = new System.Windows.Forms.ImageList(this.components);
            this.button_fileSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_fileOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_bits = new System.Windows.Forms.Label();
            this.comboBox_keyLength_byte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_passWord = new System.Windows.Forms.RadioButton();
            this.radioButton_keyGen = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
            this.imageList_KeyGen = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.linkLabel_author = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(46, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 142);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл з ключем";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_fileKey_out);
            this.groupBox2.Controls.Add(this.button_fileKey_out);
            this.groupBox2.Location = new System.Drawing.Point(24, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шлях до файлу:";
            // 
            // textBox_fileKey_out
            // 
            this.textBox_fileKey_out.Location = new System.Drawing.Point(6, 39);
            this.textBox_fileKey_out.Name = "textBox_fileKey_out";
            this.textBox_fileKey_out.Size = new System.Drawing.Size(555, 27);
            this.textBox_fileKey_out.TabIndex = 1;
            // 
            // button_fileKey_out
            // 
            this.button_fileKey_out.Location = new System.Drawing.Point(584, 39);
            this.button_fileKey_out.Name = "button_fileKey_out";
            this.button_fileKey_out.Size = new System.Drawing.Size(28, 27);
            this.button_fileKey_out.TabIndex = 0;
            this.button_fileKey_out.Text = "...";
            this.button_fileKey_out.UseVisualStyleBackColor = true;
            this.button_fileKey_out.Click += new System.EventHandler(this.button_fileKey_out_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ключ у HEX форматі";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_hand);
            this.groupBox3.Controls.Add(this.textBox_Key);
            this.groupBox3.Location = new System.Drawing.Point(22, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 80);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ключ (HEX формат)";
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_hand.Image")));
            this.checkBox_hand.Location = new System.Drawing.Point(561, 15);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(77, 59);
            this.checkBox_hand.TabIndex = 1;
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.checkBox_hand_CheckedChanged);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(6, 26);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(539, 27);
            this.textBox_Key.TabIndex = 0;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.checkBox_viewPassWord);
            this.tabPage3.Controls.Add(this.textBox_password);
            this.tabPage3.Controls.Add(this.la);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 109);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власний пароль";
            // 
            // checkBox_viewPassWord
            // 
            this.checkBox_viewPassWord.AutoSize = true;
            this.checkBox_viewPassWord.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_viewPassWord.Image")));
            this.checkBox_viewPassWord.Location = new System.Drawing.Point(575, 36);
            this.checkBox_viewPassWord.Name = "checkBox_viewPassWord";
            this.checkBox_viewPassWord.Size = new System.Drawing.Size(96, 65);
            this.checkBox_viewPassWord.TabIndex = 2;
            this.checkBox_viewPassWord.UseVisualStyleBackColor = true;
            this.checkBox_viewPassWord.CheckedChanged += new System.EventHandler(this.checkBox_viewPassWord_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(17, 54);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(552, 27);
            this.textBox_password.TabIndex = 1;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(17, 18);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(337, 20);
            this.la.TabIndex = 0;
            this.la.Text = "Придумайте свій пароль і запишіть його сюди:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.label_fileSave);
            this.tabPage4.Controls.Add(this.label_fileCipher);
            this.tabPage4.Controls.Add(this.label_fileOpen);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.button_fileCipher);
            this.tabPage4.Controls.Add(this.button_fileSave);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button_fileOpen);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(677, 109);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Файл XOR Ключ";
            // 
            // label_fileSave
            // 
            this.label_fileSave.AutoSize = true;
            this.label_fileSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileSave.ForeColor = System.Drawing.Color.Red;
            this.label_fileSave.Location = new System.Drawing.Point(519, 63);
            this.label_fileSave.Name = "label_fileSave";
            this.label_fileSave.Size = new System.Drawing.Size(59, 19);
            this.label_fileSave.TabIndex = 12;
            this.label_fileSave.Text = "(нема)";
            // 
            // label_fileCipher
            // 
            this.label_fileCipher.AutoSize = true;
            this.label_fileCipher.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileCipher.ForeColor = System.Drawing.Color.Red;
            this.label_fileCipher.Location = new System.Drawing.Point(227, 63);
            this.label_fileCipher.Name = "label_fileCipher";
            this.label_fileCipher.Size = new System.Drawing.Size(59, 19);
            this.label_fileCipher.TabIndex = 12;
            this.label_fileCipher.Text = "(нема)";
            // 
            // label_fileOpen
            // 
            this.label_fileOpen.AutoSize = true;
            this.label_fileOpen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fileOpen.ForeColor = System.Drawing.Color.Red;
            this.label_fileOpen.Location = new System.Drawing.Point(38, 63);
            this.label_fileOpen.Name = "label_fileOpen";
            this.label_fileOpen.Size = new System.Drawing.Size(59, 19);
            this.label_fileOpen.TabIndex = 11;
            this.label_fileOpen.Text = "(нема)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(486, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "3.";
            // 
            // button_fileCipher
            // 
            this.button_fileCipher.ImageIndex = 0;
            this.button_fileCipher.ImageList = this.imageList_XOR;
            this.button_fileCipher.Location = new System.Drawing.Point(308, 33);
            this.button_fileCipher.Name = "button_fileCipher";
            this.button_fileCipher.Size = new System.Drawing.Size(172, 58);
            this.button_fileCipher.TabIndex = 9;
            this.button_fileCipher.UseVisualStyleBackColor = true;
            this.button_fileCipher.Click += new System.EventHandler(this.button_fileCipher_Click);
            // 
            // imageList_XOR
            // 
            this.imageList_XOR.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_XOR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_XOR.ImageStream")));
            this.imageList_XOR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_XOR.Images.SetKeyName(0, "step2(1).PNG");
            this.imageList_XOR.Images.SetKeyName(1, "step2(2).PNG");
            // 
            // button_fileSave
            // 
            this.button_fileSave.Image = ((System.Drawing.Image)(resources.GetObject("button_fileSave.Image")));
            this.button_fileSave.Location = new System.Drawing.Point(603, 34);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(63, 57);
            this.button_fileSave.TabIndex = 8;
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(200, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "2.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Зберегти файл:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Шифрування:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "1.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_fileOpen
            // 
            this.button_fileOpen.Image = ((System.Drawing.Image)(resources.GetObject("button_fileOpen.Image")));
            this.button_fileOpen.Location = new System.Drawing.Point(136, 34);
            this.button_fileOpen.Name = "button_fileOpen";
            this.button_fileOpen.Size = new System.Drawing.Size(58, 58);
            this.button_fileOpen.TabIndex = 1;
            this.button_fileOpen.UseVisualStyleBackColor = true;
            this.button_fileOpen.Click += new System.EventHandler(this.button_fileOpen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Відкрити файл:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_bits);
            this.groupBox1.Controls.Add(this.comboBox_keyLength_byte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton_passWord);
            this.groupBox1.Controls.Add(this.radioButton_keyGen);
            this.groupBox1.Location = new System.Drawing.Point(46, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключ";
            // 
            // label_bits
            // 
            this.label_bits.AutoSize = true;
            this.label_bits.Location = new System.Drawing.Point(181, 76);
            this.label_bits.Name = "label_bits";
            this.label_bits.Size = new System.Drawing.Size(0, 20);
            this.label_bits.TabIndex = 8;
            // 
            // comboBox_keyLength_byte
            // 
            this.comboBox_keyLength_byte.FormattingEnabled = true;
            this.comboBox_keyLength_byte.Items.AddRange(new object[] {
            "8",
            "16",
            "24",
            "32",
            "12500000"});
            this.comboBox_keyLength_byte.Location = new System.Drawing.Point(181, 19);
            this.comboBox_keyLength_byte.Name = "comboBox_keyLength_byte";
            this.comboBox_keyLength_byte.Size = new System.Drawing.Size(151, 28);
            this.comboBox_keyLength_byte.TabIndex = 7;
            this.comboBox_keyLength_byte.TextChanged += new System.EventHandler(this.comboBox_keyLength_byte_TextChanged);
            this.comboBox_keyLength_byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_keyLength_byte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Довжина ключа (біти):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Довжина ключа (байти):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ключ  генерується розширенням пароля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "псевдовипадкових послідовностей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ключ з криптографічного генератора";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radioButton_passWord
            // 
            this.radioButton_passWord.AutoSize = true;
            this.radioButton_passWord.Location = new System.Drawing.Point(360, 80);
            this.radioButton_passWord.Name = "radioButton_passWord";
            this.radioButton_passWord.Size = new System.Drawing.Size(17, 16);
            this.radioButton_passWord.TabIndex = 1;
            this.radioButton_passWord.TabStop = true;
            this.radioButton_passWord.UseVisualStyleBackColor = true;
            this.radioButton_passWord.CheckedChanged += new System.EventHandler(this.radioButton_passWord_CheckedChanged);
            // 
            // radioButton_keyGen
            // 
            this.radioButton_keyGen.AutoSize = true;
            this.radioButton_keyGen.Location = new System.Drawing.Point(360, 27);
            this.radioButton_keyGen.Name = "radioButton_keyGen";
            this.radioButton_keyGen.Size = new System.Drawing.Size(17, 16);
            this.radioButton_keyGen.TabIndex = 0;
            this.radioButton_keyGen.TabStop = true;
            this.radioButton_keyGen.UseVisualStyleBackColor = true;
            this.radioButton_keyGen.CheckedChanged += new System.EventHandler(this.radioButton_keyGen_CheckedChanged);
            // 
            // button_OK
            // 
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_OK.ImageIndex = 0;
            this.button_OK.ImageList = this.imageList_KeyGen;
            this.button_OK.Location = new System.Drawing.Point(46, 299);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(165, 29);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "Згенерувати ключ";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // imageList_KeyGen
            // 
            this.imageList_KeyGen.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_KeyGen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_KeyGen.ImageStream")));
            this.imageList_KeyGen.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_KeyGen.Images.SetKeyName(0, "keyYellow.PNG");
            this.imageList_KeyGen.Images.SetKeyName(1, "keyGreen.PNG");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Тривалість розрахунків (мін.:сек.):";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(653, 308);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 20);
            this.label_time.TabIndex = 4;
            // 
            // linkLabel_author
            // 
            this.linkLabel_author.AutoSize = true;
            this.linkLabel_author.Location = new System.Drawing.Point(691, 20);
            this.linkLabel_author.Name = "linkLabel_author";
            this.linkLabel_author.Size = new System.Drawing.Size(51, 20);
            this.linkLabel_author.TabIndex = 5;
            this.linkLabel_author.TabStop = true;
            this.linkLabel_author.Text = "Автор";
            this.linkLabel_author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_author_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 359);
            this.Controls.Add(this.linkLabel_author);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Генератор ключа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private RadioButton radioButton_passWord;
        private RadioButton radioButton_keyGen;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox_keyLength_byte;
        private Label label5;
        private Button button_OK;
        private GroupBox groupBox2;
        private TextBox textBox_fileKey_out;
        private Button button_fileKey_out;
        private Label label6;
        private Label label_bits;
        private Label label_time;
        private GroupBox groupBox3;
        private CheckBox checkBox_hand;
        private TextBox textBox_Key;
        private CheckBox checkBox_viewPassWord;
        private TextBox textBox_password;
        private Label la;
        private Label label8;
        private Button button_fileOpen;
        private Label label7;
        private Button button_fileCipher;
        private Button button_fileSave;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label_fileOpen;
        private Label label12;
        private Label label_fileSave;
        private Label label_fileCipher;
        private ImageList imageList_KeyGen;
        private LinkLabel linkLabel_author;
        private ImageList imageList_XOR;
    }
}