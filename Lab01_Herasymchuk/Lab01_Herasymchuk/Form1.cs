using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace Lab01_Herasymchuk
{
    public partial class Form1 : Form
    {
        string login = File.ReadAllText(@"c:\UNIVER\RTF\Labs\Lab01_Herasymchuk\Lab01_Herasymchuk\login.txt", Encoding.Default);
        string password = File.ReadAllText(@"c:\UNIVER\RTF\Labs\Lab01_Herasymchuk\Lab01_Herasymchuk\password.txt", Encoding.Default);
        public Form1()
        {
           // login = "58d7ea82e6716d7d8712695cb2da50d817effe6355bc70553f0d73141169ae40";//GER
           //password = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5";//12345
            InitializeComponent();
          textBox_password.UseSystemPasswordChar = true;
        }
        private static string ComputeSha256Hash(string s)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            var result = new StringBuilder();
            for (int i = 0; i <bytes.Length; i++)
                result.Append(bytes[i].ToString("x2"));
            return result.ToString();
            }
        private void button_OK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(login);
            //MessageBox.Show(ComputeSha256Hash(textBox_login.Text));
            //MessageBox.Show(password);
            //MessageBox.Show(ComputeSha256Hash(textBox_password.Text));
            if (ComputeSha256Hash(textBox_login.Text) == login && ComputeSha256Hash(textBox_password.Text) == password)
            {
                OK.BackColor = Color.Green;
                MessageBox.Show("Welcome!");
            }
            else
            {
                OK.BackColor = Color.Red;
                MessageBox.Show("Incorrect login or password");
                       }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

       private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          if (checkPass.Checked)
          {
             textBox_password.UseSystemPasswordChar = false;
           }
           else
           {
               textBox_password.UseSystemPasswordChar = true;
           }
        }
    }
}
