namespace Lab07V2_Herasymchuk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelsizeIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bInFile = new System.Windows.Forms.Button();
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.OUT = new System.Windows.Forms.GroupBox();
            this.labelsizeOUT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bOutFile = new System.Windows.Forms.Button();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOUTstart = new System.Windows.Forms.Button();
            this.buttonINstart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_3DES = new System.Windows.Forms.RadioButton();
            this.rb_AES = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.loadVector = new System.Windows.Forms.Button();
            this.saveVector = new System.Windows.Forms.Button();
            this.textBoxVector = new System.Windows.Forms.TextBox();
            this.buttonVectorRandom = new System.Windows.Forms.Button();
            this.checkBox_hand = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.loadKey = new System.Windows.Forms.Button();
            this.saveKey = new System.Windows.Forms.Button();
            this.textBoxKEY = new System.Windows.Forms.TextBox();
            this.buttonKEY_Random = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxBIT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.OUT.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelsizeIN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bInFile);
            this.groupBox1.Controls.Add(this.tInFilePath);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідний";
            // 
            // labelsizeIN
            // 
            this.labelsizeIN.AutoSize = true;
            this.labelsizeIN.Location = new System.Drawing.Point(633, 82);
            this.labelsizeIN.Name = "labelsizeIN";
            this.labelsizeIN.Size = new System.Drawing.Size(30, 20);
            this.labelsizeIN.TabIndex = 10;
            this.labelsizeIN.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Розмір:";
            // 
            // bInFile
            // 
            this.bInFile.Location = new System.Drawing.Point(669, 40);
            this.bInFile.Name = "bInFile";
            this.bInFile.Size = new System.Drawing.Size(35, 27);
            this.bInFile.TabIndex = 8;
            this.bInFile.Text = "...";
            this.bInFile.UseVisualStyleBackColor = true;
            this.bInFile.Click += new System.EventHandler(this.BInFile_Click);
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(17, 40);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(646, 27);
            this.tInFilePath.TabIndex = 6;
            // 
            // OUT
            // 
            this.OUT.Controls.Add(this.labelsizeOUT);
            this.OUT.Controls.Add(this.label2);
            this.OUT.Controls.Add(this.bOutFile);
            this.OUT.Controls.Add(this.tOutFilePath);
            this.OUT.Location = new System.Drawing.Point(27, 130);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(724, 114);
            this.OUT.TabIndex = 1;
            this.OUT.TabStop = false;
            this.OUT.Text = "Вихідний";
            // 
            // labelsizeOUT
            // 
            this.labelsizeOUT.AutoSize = true;
            this.labelsizeOUT.Location = new System.Drawing.Point(633, 86);
            this.labelsizeOUT.Name = "labelsizeOUT";
            this.labelsizeOUT.Size = new System.Drawing.Size(30, 20);
            this.labelsizeOUT.TabIndex = 11;
            this.labelsizeOUT.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Розмір:";
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(669, 44);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(35, 29);
            this.bOutFile.TabIndex = 9;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.BOutFile_Click);
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(17, 46);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(646, 27);
            this.tOutFilePath.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_time);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonOUTstart);
            this.groupBox3.Controls.Add(this.buttonINstart);
            this.groupBox3.Location = new System.Drawing.Point(27, 660);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 63);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дії";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(461, 30);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(63, 20);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "00:00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Час розрахунку:";
            // 
            // buttonOUTstart
            // 
            this.buttonOUTstart.Location = new System.Drawing.Point(169, 26);
            this.buttonOUTstart.Name = "buttonOUTstart";
            this.buttonOUTstart.Size = new System.Drawing.Size(129, 29);
            this.buttonOUTstart.TabIndex = 1;
            this.buttonOUTstart.Text = "Розшифрувати";
            this.buttonOUTstart.UseVisualStyleBackColor = true;
            this.buttonOUTstart.Click += new System.EventHandler(this.ButtonOUTstart_CLICK);
            // 
            // buttonINstart
            // 
            this.buttonINstart.Location = new System.Drawing.Point(19, 26);
            this.buttonINstart.Name = "buttonINstart";
            this.buttonINstart.Size = new System.Drawing.Size(127, 29);
            this.buttonINstart.TabIndex = 0;
            this.buttonINstart.Text = "Зашифрувати";
            this.buttonINstart.UseVisualStyleBackColor = true;
            this.buttonINstart.Click += new System.EventHandler(this.ButtonINstart_CLICK);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_3DES);
            this.groupBox2.Controls.Add(this.rb_AES);
            this.groupBox2.Location = new System.Drawing.Point(27, 588);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Алгоритм шифрування";
            // 
            // rb_3DES
            // 
            this.rb_3DES.AutoSize = true;
            this.rb_3DES.Location = new System.Drawing.Point(98, 24);
            this.rb_3DES.Name = "rb_3DES";
            this.rb_3DES.Size = new System.Drawing.Size(65, 24);
            this.rb_3DES.TabIndex = 1;
            this.rb_3DES.TabStop = true;
            this.rb_3DES.Text = "3DES";
            this.rb_3DES.UseVisualStyleBackColor = true;
            // 
            // rb_AES
            // 
            this.rb_AES.AutoSize = true;
            this.rb_AES.Location = new System.Drawing.Point(19, 24);
            this.rb_AES.Name = "rb_AES";
            this.rb_AES.Size = new System.Drawing.Size(56, 24);
            this.rb_AES.TabIndex = 0;
            this.rb_AES.TabStop = true;
            this.rb_AES.Text = "AES";
            this.rb_AES.UseVisualStyleBackColor = true;
            this.rb_AES.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.loadVector);
            this.groupBox4.Controls.Add(this.saveVector);
            this.groupBox4.Controls.Add(this.textBoxVector);
            this.groupBox4.Controls.Add(this.buttonVectorRandom);
            this.groupBox4.Controls.Add(this.checkBox_hand);
            this.groupBox4.Location = new System.Drawing.Point(27, 490);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вектор ініціалізації";
            // 
            // loadVector
            // 
            this.loadVector.Location = new System.Drawing.Point(461, 63);
            this.loadVector.Name = "loadVector";
            this.loadVector.Size = new System.Drawing.Size(129, 29);
            this.loadVector.TabIndex = 4;
            this.loadVector.Text = "Завантажити";
            this.loadVector.UseVisualStyleBackColor = true;
            this.loadVector.Click += new System.EventHandler(this.LoadVector_click);
            // 
            // saveVector
            // 
            this.saveVector.Location = new System.Drawing.Point(596, 63);
            this.saveVector.Name = "saveVector";
            this.saveVector.Size = new System.Drawing.Size(94, 29);
            this.saveVector.TabIndex = 5;
            this.saveVector.Text = "Зберегти";
            this.saveVector.UseVisualStyleBackColor = true;
            this.saveVector.Click += new System.EventHandler(this.SaveVector_Сlick);
            // 
            // textBoxVector
            // 
            this.textBoxVector.Location = new System.Drawing.Point(17, 26);
            this.textBoxVector.Name = "textBoxVector";
            this.textBoxVector.Size = new System.Drawing.Size(687, 27);
            this.textBoxVector.TabIndex = 4;
            // 
            // buttonVectorRandom
            // 
            this.buttonVectorRandom.Location = new System.Drawing.Point(191, 58);
            this.buttonVectorRandom.Name = "buttonVectorRandom";
            this.buttonVectorRandom.Size = new System.Drawing.Size(155, 29);
            this.buttonVectorRandom.TabIndex = 3;
            this.buttonVectorRandom.Text = "Випадковий вектор";
            this.buttonVectorRandom.UseVisualStyleBackColor = true;
            this.buttonVectorRandom.Click += new System.EventHandler(this.ButtonVectorRandom_Click);
            // 
            // checkBox_hand
            // 
            this.checkBox_hand.AutoSize = true;
            this.checkBox_hand.Location = new System.Drawing.Point(376, 63);
            this.checkBox_hand.Name = "checkBox_hand";
            this.checkBox_hand.Size = new System.Drawing.Size(62, 24);
            this.checkBox_hand.TabIndex = 2;
            this.checkBox_hand.Text = "BI=0";
            this.checkBox_hand.UseVisualStyleBackColor = true;
            this.checkBox_hand.CheckedChanged += new System.EventHandler(this.CheckBox_hand_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.loadKey);
            this.groupBox5.Controls.Add(this.saveKey);
            this.groupBox5.Controls.Add(this.textBoxKEY);
            this.groupBox5.Controls.Add(this.buttonKEY_Random);
            this.groupBox5.Location = new System.Drawing.Point(27, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(724, 94);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ключ";
            // 
            // loadKey
            // 
            this.loadKey.Location = new System.Drawing.Point(461, 59);
            this.loadKey.Name = "loadKey";
            this.loadKey.Size = new System.Drawing.Size(129, 29);
            this.loadKey.TabIndex = 3;
            this.loadKey.Text = "Завантажити";
            this.loadKey.UseVisualStyleBackColor = true;
            this.loadKey.Click += new System.EventHandler(this.LoadKey_Click);
            // 
            // saveKey
            // 
            this.saveKey.Location = new System.Drawing.Point(596, 59);
            this.saveKey.Name = "saveKey";
            this.saveKey.Size = new System.Drawing.Size(94, 29);
            this.saveKey.TabIndex = 2;
            this.saveKey.Text = "Зберегти";
            this.saveKey.UseVisualStyleBackColor = true;
            this.saveKey.Click += new System.EventHandler(this.SaveKey_Click);
            // 
            // textBoxKEY
            // 
            this.textBoxKEY.Location = new System.Drawing.Point(17, 26);
            this.textBoxKEY.Name = "textBoxKEY";
            this.textBoxKEY.Size = new System.Drawing.Size(687, 27);
            this.textBoxKEY.TabIndex = 1;
            // 
            // buttonKEY_Random
            // 
            this.buttonKEY_Random.Location = new System.Drawing.Point(191, 59);
            this.buttonKEY_Random.Name = "buttonKEY_Random";
            this.buttonKEY_Random.Size = new System.Drawing.Size(155, 29);
            this.buttonKEY_Random.TabIndex = 0;
            this.buttonKEY_Random.Text = "Випадковий ключ";
            this.buttonKEY_Random.UseVisualStyleBackColor = true;
            this.buttonKEY_Random.Click += new System.EventHandler(this.ButtonKEY_Random_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.comboBoxAdd);
            this.groupBox6.Controls.Add(this.comboBoxBIT);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(27, 259);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(724, 125);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Параметри";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Чим доповнювати короткі ключі:";
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Items.AddRange(new object[] {
            "Нулями(30 в hex форматі)",
            "Space(20 в hex форматі)",
            "Random"});
            this.comboBoxAdd.Location = new System.Drawing.Point(351, 60);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(239, 28);
            this.comboBoxAdd.TabIndex = 2;
            this.comboBoxAdd.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAdd_SelectedIndexChanged);
            // 
            // comboBoxBIT
            // 
            this.comboBoxBIT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxBIT.FormattingEnabled = true;
            this.comboBoxBIT.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.comboBoxBIT.Location = new System.Drawing.Point(58, 60);
            this.comboBoxBIT.Name = "comboBoxBIT";
            this.comboBoxBIT.Size = new System.Drawing.Size(159, 28);
            this.comboBoxBIT.TabIndex = 1;
            this.comboBoxBIT.TextChanged += new System.EventHandler(this.ComboBoxBIT_CHANGE);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Довжина ключа та вектора в бітах";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 738);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OUT.ResumeLayout(false);
            this.OUT.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bInFile;
        private TextBox tInFilePath;
        private GroupBox OUT;
        private Button bOutFile;
        private TextBox tOutFilePath;
        private GroupBox groupBox3;
        private Button buttonOUTstart;
        private Button buttonINstart;
        private GroupBox groupBox2;
        private RadioButton rb_AES;
        private Label labelsizeIN;
        private Label label1;
        private Label labelsizeOUT;
        private Label label2;
        private RadioButton rb_3DES;
        private Label label_time;
        private Label label3;
        private GroupBox groupBox4;
        private TextBox textBoxVector;
        private Button buttonVectorRandom;
        private CheckBox checkBox_hand;
        private GroupBox groupBox5;
        private TextBox textBoxKEY;
        private Button buttonKEY_Random;
        private GroupBox groupBox6;
        private ComboBox comboBoxBIT;
        private Label label4;
        private ColorDialog colorDialog1;
        private Button saveVector;
        private Button saveKey;
        private Button loadVector;
        private Button loadKey;
        private ComboBox comboBoxAdd;
        private Label label5;
    }
}