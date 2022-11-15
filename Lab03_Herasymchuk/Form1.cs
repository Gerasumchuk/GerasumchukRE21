using System;
using System.Text;
using System.Text.Unicode;
using static System.Net.Mime.MediaTypeNames;


namespace Lab03_Herasymchuk
{
    public partial class Form1 : Form
    {
        private const int V = 16;

        public Form1()
        {
            InitializeComponent();
        }


        void myShowToolTip(TextBox tB, byte[] arr)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//Cyrillic
            //TOOLTIP BIN
            string[] bytehex = arr.Select(x => x.ToString("x2")).ToArray();
            string hexValues = string.Concat(bytehex);
            StringBuilder str = new StringBuilder();
            foreach (char L in hexValues.ToCharArray())//посимвольний переклад в bin
            {
                str.Append(Convert.ToString(L, 2).PadLeft(8, '0'));
            }
            string hexValues2 = str.ToString();
            toolTip_HEX.SetToolTip(tB, hexValues2);
        }
        byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//Cyrillic
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
            byte[] arr_cipher = new byte[len_text];
            string cheakKEY = BitConverter.ToString(arr_key);
            if (string.IsNullOrEmpty(cheakKEY))
            {
                MessageBox.Show("Увага! Ключ не задано. Результат буде надано без кодування");
                for (int i = 0; i < len_text; i++)
                {
                    byte p = arr_text[i];
                    byte c = (byte)(p); //кодування без ключа
                    arr_cipher[i] = c;
                }
            }

            else
            {
   
                for (int i = 0; i < len_text; i++)
                {
                    byte p = arr_text[i];
                    byte k = arr_key[i % len_key]; // mod
                    byte c = (byte)(p ^ k); // XOR
                    arr_cipher[i] = c;
                }
            }
            return arr_cipher;
         }
     string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher= "")
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = tb_text.Text;
          byte[] arr_text;
          if (cipher == "") arr_text = Encoding.GetEncoding(1251).GetBytes(text);
            else arr_text = Encoding.GetEncoding(1251).GetBytes(cipher);
            myShowToolTip(tb_text, arr_text); // Створити підказку
            string key = tb_Key.Text;
            byte[] arr_key = Encoding.GetEncoding(1251).GetBytes(key);//кодування win1251 Cyrillic
            myShowToolTip(tb_Key, arr_key); // Створити підказку
            byte[] arr_cipher = myXOR(arr_text, arr_key);
            cipher = Encoding.GetEncoding(1251).GetString(arr_cipher);
            tb_cipher.Text = cipher;
            myShowToolTip(tb_cipher, arr_cipher); // Створити підказку
            return cipher;
        }
    private void button_XOR_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            if (string.IsNullOrEmpty(textBox_P_IN.Text))
            {
            MessageBox.Show("Задайте повідомлення для кодування");
            }
            string cipher = myCipher(textBox_P_IN, textBox_Key_IN, textBox_C_IN); //  зашифрування
        textBox_P_OUT.Text = textBox_C_IN.Text;
        textBox_Key_OUT.Text = textBox_Key_IN.Text;
        myCipher(textBox_P_OUT, textBox_Key_OUT, textBox_C_OUT, cipher); //розшифрування
         }
        private void button_clean_Click(object sender, EventArgs e)//clear
        {
            textBox_P_IN.Text = "";
            textBox_Key_IN.Text = "";
            textBox_C_IN.Text = "";
            textBox_P_OUT.Text = "";
            textBox_Key_OUT.Text = "";
            textBox_C_OUT.Text = "";
        }





























        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}