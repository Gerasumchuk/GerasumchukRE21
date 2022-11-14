namespace Lab02_Herasymchuk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxC16 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.textBoxP10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKey2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKey10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPOUT = new System.Windows.Forms.TextBox();
            this.textBoxKOUT = new System.Windows.Forms.TextBox();
            this.textBoxCOUT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "P(16)=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key(2)=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "C(16) =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "XOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Прибрати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.TextChanged += new System.EventHandler(this.button_clean_Click);
            this.button2.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(150, 30);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(125, 27);
            this.textBoxP.TabIndex = 10;
            this.textBoxP.TextChanged += new System.EventHandler(this.textBoxP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "=C(16)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "=Key(16)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "=P(16)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(150, 141);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(125, 27);
            this.textBoxKey.TabIndex = 14;
            // 
            // textBoxC16
            // 
            this.textBoxC16.Location = new System.Drawing.Point(150, 278);
            this.textBoxC16.Name = "textBoxC16";
            this.textBoxC16.ReadOnly = true;
            this.textBoxC16.Size = new System.Drawing.Size(125, 27);
            this.textBoxC16.TabIndex = 15;
            this.textBoxC16.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(150, 63);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.ReadOnly = true;
            this.textBoxP2.Size = new System.Drawing.Size(125, 27);
            this.textBoxP2.TabIndex = 16;
            this.textBoxP2.TextChanged += new System.EventHandler(this.textBoxP2_TextChanged);
            // 
            // textBoxP10
            // 
            this.textBoxP10.Location = new System.Drawing.Point(150, 96);
            this.textBoxP10.Name = "textBoxP10";
            this.textBoxP10.ReadOnly = true;
            this.textBoxP10.Size = new System.Drawing.Size(125, 27);
            this.textBoxP10.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Key (16)=";
            // 
            // textBoxKey2
            // 
            this.textBoxKey2.Location = new System.Drawing.Point(150, 183);
            this.textBoxKey2.Name = "textBoxKey2";
            this.textBoxKey2.ReadOnly = true;
            this.textBoxKey2.Size = new System.Drawing.Size(125, 27);
            this.textBoxKey2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "P(2) =";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "P(10) =";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxKey10
            // 
            this.textBoxKey10.Location = new System.Drawing.Point(150, 229);
            this.textBoxKey10.Name = "textBoxKey10";
            this.textBoxKey10.ReadOnly = true;
            this.textBoxKey10.Size = new System.Drawing.Size(125, 27);
            this.textBoxKey10.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Key(10)=";
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(150, 311);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.ReadOnly = true;
            this.textBoxC2.Size = new System.Drawing.Size(125, 27);
            this.textBoxC2.TabIndex = 25;
            // 
            // textBoxC10
            // 
            this.textBoxC10.Location = new System.Drawing.Point(150, 344);
            this.textBoxC10.Name = "textBoxC10";
            this.textBoxC10.ReadOnly = true;
            this.textBoxC10.Size = new System.Drawing.Size(125, 27);
            this.textBoxC10.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "C(2) =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "C(10)=";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBoxPOUT
            // 
            this.textBoxPOUT.Location = new System.Drawing.Point(484, 148);
            this.textBoxPOUT.Name = "textBoxPOUT";
            this.textBoxPOUT.Size = new System.Drawing.Size(125, 27);
            this.textBoxPOUT.TabIndex = 29;
            this.textBoxPOUT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxKOUT
            // 
            this.textBoxKOUT.Location = new System.Drawing.Point(483, 89);
            this.textBoxKOUT.Name = "textBoxKOUT";
            this.textBoxKOUT.Size = new System.Drawing.Size(125, 27);
            this.textBoxKOUT.TabIndex = 30;
            // 
            // textBoxCOUT
            // 
            this.textBoxCOUT.Location = new System.Drawing.Point(483, 37);
            this.textBoxCOUT.Name = "textBoxCOUT";
            this.textBoxCOUT.Size = new System.Drawing.Size(125, 27);
            this.textBoxCOUT.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 412);
            this.Controls.Add(this.textBoxCOUT);
            this.Controls.Add(this.textBoxKOUT);
            this.Controls.Add(this.textBoxPOUT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxC10);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxKey10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxKey2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxP10);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxC16);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.textBox_P);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBoxP;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxKey;
        private TextBox textBoxC16;
        private TextBox textBoxP2;
        private TextBox textBoxP10;
        private Label label7;
        private TextBox textBoxKey2;
        private Label label8;
        private Label label9;
        private TextBox textBoxKey10;
        private Label label10;
        private TextBox textBoxC2;
        private TextBox textBoxC10;
        private Label label11;
        private Label label12;
        private TextBox textBoxPOUT;
        private TextBox textBoxKOUT;
        private TextBox textBoxCOUT;
    }
}