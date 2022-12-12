using System.Collections;

namespace Lab07V2_Herasymchuk
{
    public partial class Form1 : Form
    {
        byte[] randomArray = Array.Empty<byte>();
        public Form1()
        {
            InitializeComponent();
            comboBoxBIT.SelectedItem = "128";
            checkBox_hand.Checked = true;
            rb_AES.Checked = true;
            comboBoxAdd.Text = "Нулями(30 в hex форматі)";
        }

        private void BInFile_Click(object sender, EventArgs e) //вхідний файл
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string fileINpath = openFileDialog.FileName;
                tInFilePath.Text = fileINpath;
                string sizeIN = SizeBIT(tInFilePath.Text);
                labelsizeIN.Text = sizeIN;
            }
        }

        private void BOutFile_Click(object sender, EventArgs e) //вихідний файл
        {
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileOUTpath = saveFileDialog.FileName;
                tOutFilePath.Text = fileOUTpath;
                string sizeOUT = SizeBIT(tOutFilePath.Text);
                labelsizeOUT.Text = sizeOUT;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private static string SizeBIT(string text)
        {
            FileInfo file = new(text);     //РОЗРАХУНОК РОЗМІРУ
            long size = file.Length;
            int INTsize = Convert.ToInt32(size);
            double dsize = Convert.ToDouble(size);
            string STRnull = "null";
            if (INTsize < 1024)
            {
                string STRsize = INTsize.ToString() + "байт";
                return STRsize;
            }
            if (INTsize > 1024 && INTsize <= 1048576)
            {
                double Dsize = dsize / 1024.00;
                string STRsize = Dsize.ToString("F2");
                STRsize = STRsize + "КБ";
                return STRsize;
            }
            if (INTsize > 1048576)
            {
                double Dsize = dsize / 1048576.00;
                string STRsize = Dsize.ToString("F2");
                STRsize = STRsize + "МБ";
                return STRsize;
            }
            return STRnull;
        }
        private static string StringHEX(byte[] randomArray)
        {
            BitArray randomBitArray = new(randomArray); // byte[] -> bits
            // Перевірка  randomBitArray.CopyTo(randomArray, 0); // bits -> byte[]
            //    string digits = ToDigitString(randomBitArray); // bits -> string (в BIN форматы)
            string textHEX = BitConverter.ToString(randomArray); // byte[] -> string (в HEX форматі)
            return textHEX.Replace("-", "");
        }
        public static byte[] StringToByteArray(string textHEX) // stringHEX -> byte[] 
        {
            //textHEX = textHEX.Replace(" - ", "");

            // https://pcheruku.wordpress.com/2008/10/21/sample-c-code-to-convert-hexadecimal-string-to-bytes/
            int len = textHEX.Length;
            if (len % 2 == 1)
            {
                textHEX = "0" + textHEX;
                len++;
            }
            int len_half = len / 2;
            byte[] bs = new byte[len_half];
            //convert the hexstring to bytes
            for (int i = 0; i != len_half; i++)
            {
                bs[i] = (byte)Int32.Parse(textHEX.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            return bs;
        }
        private void ButtonINstart_CLICK(object sender, EventArgs e)//ШИФРУВАТИ
        {
            byte[] Encrypt = Array.Empty<byte>();
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            label_time.Text = "00:00.00";
            timeStart = DateTime.Now;
            string tempKEY = textBoxKEY.Text.Replace("-", "");
            string tempVector = textBoxVector.Text.Replace("-", "");
            byte[] goKEY = StringToByteArray(tempKEY);
            byte[] goVector = StringToByteArray(tempVector);
            if (checkBox_hand.Checked) { goVector = goKEY; }
            string goInArr = BitConverter.ToString(File.ReadAllBytes(tInFilePath.Text));
            if (rb_AES.Checked == true)
            {
                Encrypt = AesExample.EncryptStringToBytes_Aes(goInArr, goKEY, goVector);//AES
            }
            if (rb_3DES.Checked == true)
            {
                Encrypt = TripleDESSample.Encrypt(goInArr, goKEY, goVector);//3DESS
            }
            File.WriteAllBytes(tOutFilePath.Text, Encrypt);

            string sizeOUT = SizeBIT(tOutFilePath.Text);
            labelsizeOUT.Text = sizeOUT;
            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            label_time.Text = timeAll.ToString(@"hh\:mm\:ss");
        }

        private void ButtonOUTstart_CLICK(object sender, EventArgs e)//Розшифрувати
        {
            string tempDecrypt = "";
            DateTime timeStart;
            DateTime timeFinish;
            TimeSpan timeAll;
            label_time.Text = "00:00.00";
            timeStart = DateTime.Now;
            string tempKEY = textBoxKEY.Text.Replace("-", "");
            string tempVector = textBoxVector.Text.Replace("-", "");
            byte[] goKEY = StringToByteArray(tempKEY);
            byte[] goVector = StringToByteArray(tempVector);
            if (checkBox_hand.Checked) { goVector = goKEY; }
            byte[] goInArr = File.ReadAllBytes(tInFilePath.Text);
            if (rb_AES.Checked == true)
            {
                tempDecrypt = AesExample.DecryptStringFromBytes_Aes(goInArr, goKEY, goVector); //AES
            }
            if (rb_3DES.Checked == true)
            {
                tempDecrypt = TripleDESSample.Decrypt(goInArr, goKEY, goVector);              //3DESS
            }
            tempDecrypt = tempDecrypt.Replace("-", "");
            byte[] Decrypt = StringToByteArray(tempDecrypt);
            File.WriteAllBytes(tOutFilePath.Text, Decrypt);
            string sizeOUT = SizeBIT(tOutFilePath.Text);
            labelsizeOUT.Text = sizeOUT;
            timeFinish = DateTime.Now;
            timeAll = timeFinish - timeStart;
            label_time.Text = timeAll.ToString(@"hh\:mm\:ss");
        }

        private void ButtonVectorRandom_Click(object sender, EventArgs e)       //генерація випадкового паролю
        {
            if (checkBox_hand.Checked) ;
            else
            {
                byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
                string textBoxVector2 = StringHEX(randomArray);
                textBoxVector.Text = InTextBOX(textBoxVector2);
            }
        }

        private void ComboBoxBIT_CHANGE(object sender, EventArgs e)                    //зміна довжини паролю
        {
            byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
            string textBoxKEY2 = StringHEX(randomArray);
            textBoxKEY.Text = InTextBOX(textBoxKEY2);
            if (checkBox_hand.Checked)
            {
                textBoxVector.ReadOnly = true;
                string zero = "";
                int j = 0;
                for (int i = 0; i != int.Parse(comboBoxBIT.Text) / 4; i++)          //створення 0го вектору при зміні кількость біт
                {
                    zero = zero + "0";
                    j++;
                }
                textBoxVector.Text = InTextBOX(zero);
            }
            else
            {
                textBoxVector.ReadOnly = false;
            }
        }

        private void ButtonKEY_Random_Click(object sender, EventArgs e)             //генерація випадкового паролю
        {
            byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
            string textBoxKEY2 = StringHEX(randomArray);
            textBoxKEY.Text = InTextBOX(textBoxKEY2);
        }
        private static string InTextBOX(string textBoxKEY2)                      //запис векторів та паролів через "-" для виводу їх у тектові поля
        {
            string temp = "";
            int j = 0;
            while (j != textBoxKEY2.Length)
            {
                for (int i = 0; i != 4; i++)
                {
                    temp = temp + textBoxKEY2[j];
                    j++;
                }
                if (textBoxKEY2.Length - j >= 4)
                {
                    temp = temp + "-";
                }
            }
            return temp;
        }

        private void CheckBox_hand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hand.Checked)                                      //cтворення 0го вектора для умови ВІ=0
            {
                textBoxVector.ReadOnly = true;
                string zero = "";
                int j = 0;
                for (int i = 0; i != int.Parse(comboBoxBIT.Text) / 4; i++)
                {
                    zero = zero + "0";
                    j++;
                }
                textBoxVector.Text = InTextBOX(zero);
            }
            else
            {
                textBoxVector.ReadOnly = false;
            }
        }
        private string CUT(byte[] load)                                     //обрізка та доповння завантажених з файлів паролів чи векторів
        {
            if (load is null)
            {
                throw new ArgumentNullException(nameof(load));
            }
            string STRload = StringHEX(this.randomArray);
            int LengthCut = Int32.Parse(comboBoxBIT.Text) / 4;
            int k = STRload.Length;
        cheak:
            if (STRload.Length > LengthCut)
            {
                STRload = STRload.Substring(0, LengthCut);
            }
            if (STRload.Length < LengthCut)
            {
                if (comboBoxAdd.Text == "Нулями(30 в hex форматі)")                       //заповнення 0
                {
                    for (int i = k; i <= (Int32.Parse(comboBoxBIT.Text) / 4) - k; i++)
                    {
                        STRload = STRload + "30";
                        i++;
                    }
                }
                if (comboBoxAdd.Text == "Space(20 в hex форматі)")                       //заповнення Spaceами
                {
                    for (int i = k; i <= (Int32.Parse(comboBoxBIT.Text) / 4) - k; i++)
                    {
                        STRload = STRload + "20";
                        i++;
                    }
                }
                if (comboBoxAdd.Text == "Random")                                        //Заповнення сміттям
                {
                    Random random = new();
                    while (STRload.Length < Int32.Parse(comboBoxBIT.Text) / 4)
                    {
                        STRload = STRload + random.Next().ToString("X");
                    }
                }
                goto cheak;
            }
            STRload = InTextBOX(STRload);
            return STRload;
        }
        private void SaveDialog(string textSave, int varSaveLoad, int chooseOUT)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            textSave = textSave.Replace("-", " ");
            byte[] save = StringToByteArray(textSave);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathKeySave = openFileDialog.FileName;
                if (varSaveLoad == 1)                                   //ЗБЕРЕГТИ КЛЮЧ/ВЕКТОР
                {
                    File.WriteAllBytes(pathKeySave, save);
                    MessageBox.Show("Успішно збережно!");
                }
                if (varSaveLoad == 2)                                   //Завантажити КЛЮЧ/ВЕКТОР
                {
                    this.randomArray = File.ReadAllBytes(pathKeySave);
                    string load = CUT(this.randomArray);

                    if (chooseOUT == 1)
                    {
                        textBoxKEY.Text = load;
                    }
                    if (chooseOUT == 2 && textBoxVector.ReadOnly == false)
                    {
                        textBoxVector.Text = load;
                    }
                    else { MessageBox.Show("Зніміть відмітку ВІ=0 для завантаження"); }
                }
            }
        }
        private void SaveVector_Сlick(object sender, EventArgs e)
        {
            SaveDialog(textBoxVector.Text, 1, 0);
        }

        private void SaveKey_Click(object sender, EventArgs e)
        {
            SaveDialog(textBoxKEY.Text, 1, 0);
        }

        private void LoadKey_Click(object sender, EventArgs e)
        {
            SaveDialog(textBoxKEY.Text, 2, 1);
        }

        private void ComboBoxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadVector_click(object sender, EventArgs e)
        {
            SaveDialog(textBoxKEY.Text, 2, 2);
        }
    }
}