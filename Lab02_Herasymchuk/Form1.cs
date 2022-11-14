using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab02_Herasymchuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string P16 = textBoxP.Text;
            string Key16 = textBoxKey.Text;
           // if (IsValid(textBoxP.Text) == true || IsValid(textBoxKey.Text) == true) { MessageBox.Show("Заповніть поля P та Key у HEX форматі!"); }
            if (textBoxP.Text == "" || textBoxKey.Text == "") { MessageBox.Show("Заповніть поля P та Key"); }
            else
            {
                //P
                int intP2 = Int32.Parse(P16, System.Globalization.NumberStyles.HexNumber);//HEX TO BIN
                string P2 = Convert.ToString(intP2, 2);
                textBoxP2.Text = P2;
                string P10 = Convert.ToString(intP2, 10);
                textBoxP10.Text = P10;

                //KEY
                int intK2 = Int32.Parse(Key16, System.Globalization.NumberStyles.HexNumber);//HEX TO BIN
                string K2 = Convert.ToString(intK2, 2);//BIN STRING
                textBoxKey2.Text = K2;//BIN print
                string K10 = Convert.ToString(intK2, 10);//BIN TO DEC
                textBoxKey10.Text = K10;
                //C
                int intC = intP2 ^ intK2;
                string strC = Convert.ToString(intC, 2);
                textBoxC2.Text = strC;
                string strC10 = Convert.ToString(intC, 10);
                textBoxC10.Text = strC10;
                string strC16 = Convert.ToString(intC, 16);
                textBoxC16.Text = strC16;
                //Decipher
                textBoxCOUT.Text = strC16;
                textBoxKOUT.Text = Key16;
                int intPOUT = (intK2 ^ intC);
                string strPOUT = Convert.ToString(intPOUT, 16);
                textBoxPOUT.Text = strPOUT;
            }
        }
        


        private void button_clean_Click(object sender, EventArgs e)//Clear
        {
            textBoxP.Text = "";
            textBoxP2.Text = "";
            textBoxP10.Text = "";

            textBoxKey.Text = "";
            textBoxKey2.Text = "";
            textBoxKey10.Text = "";

            textBoxC2.Text = "";
            textBoxC10.Text = "";
            textBoxC16.Text = ""; 

        }

        private void textBox_P(object sender, EventArgs e)
        {

        }

        private void textBoxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
 
    }