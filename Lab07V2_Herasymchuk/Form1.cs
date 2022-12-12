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
            comboBoxAdd.Text = "������(30 � hex ������)";
        }

        private void BInFile_Click(object sender, EventArgs e) //������� ����
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

        private void BOutFile_Click(object sender, EventArgs e) //�������� ����
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
            FileInfo file = new(text);     //���������� ���̲��
            long size = file.Length;
            int INTsize = Convert.ToInt32(size);
            double dsize = Convert.ToDouble(size);
            string STRnull = "null";
            if (INTsize < 1024)
            {
                string STRsize = INTsize.ToString() + "����";
                return STRsize;
            }
            if (INTsize > 1024 && INTsize <= 1048576)
            {
                double Dsize = dsize / 1024.00;
                string STRsize = Dsize.ToString("F2");
                STRsize = STRsize + "��";
                return STRsize;
            }
            if (INTsize > 1048576)
            {
                double Dsize = dsize / 1048576.00;
                string STRsize = Dsize.ToString("F2");
                STRsize = STRsize + "��";
                return STRsize;
            }
            return STRnull;
        }
        private static string StringHEX(byte[] randomArray)
        {
            BitArray randomBitArray = new(randomArray); // byte[] -> bits
            // ��������  randomBitArray.CopyTo(randomArray, 0); // bits -> byte[]
            //    string digits = ToDigitString(randomBitArray); // bits -> string (� BIN �������)
            string textHEX = BitConverter.ToString(randomArray); // byte[] -> string (� HEX ������)
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
        private void ButtonINstart_CLICK(object sender, EventArgs e)//���������
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

        private void ButtonOUTstart_CLICK(object sender, EventArgs e)//������������
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

        private void ButtonVectorRandom_Click(object sender, EventArgs e)       //��������� ����������� ������
        {
            if (checkBox_hand.Checked) ;
            else
            {
                byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
                string textBoxVector2 = StringHEX(randomArray);
                textBoxVector.Text = InTextBOX(textBoxVector2);
            }
        }

        private void ComboBoxBIT_CHANGE(object sender, EventArgs e)                    //���� ������� ������
        {
            byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
            string textBoxKEY2 = StringHEX(randomArray);
            textBoxKEY.Text = InTextBOX(textBoxKEY2);
            if (checkBox_hand.Checked)
            {
                textBoxVector.ReadOnly = true;
                string zero = "";
                int j = 0;
                for (int i = 0; i != int.Parse(comboBoxBIT.Text) / 4; i++)          //��������� 0�� ������� ��� ��� �������� ��
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

        private void ButtonKEY_Random_Click(object sender, EventArgs e)             //��������� ����������� ������
        {
            byte[] randomArray = KeyGen.generator_Key(int.Parse(comboBoxBIT.Text));
            string textBoxKEY2 = StringHEX(randomArray);
            textBoxKEY.Text = InTextBOX(textBoxKEY2);
        }
        private static string InTextBOX(string textBoxKEY2)                      //����� ������� �� ������ ����� "-" ��� ������ �� � ������ ����
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
            if (checkBox_hand.Checked)                                      //c�������� 0�� ������� ��� ����� ²=0
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
        private string CUT(byte[] load)                                     //������ �� �������� ������������ � ����� ������ �� �������
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
                if (comboBoxAdd.Text == "������(30 � hex ������)")                       //���������� 0
                {
                    for (int i = k; i <= (Int32.Parse(comboBoxBIT.Text) / 4) - k; i++)
                    {
                        STRload = STRload + "30";
                        i++;
                    }
                }
                if (comboBoxAdd.Text == "Space(20 � hex ������)")                       //���������� Space���
                {
                    for (int i = k; i <= (Int32.Parse(comboBoxBIT.Text) / 4) - k; i++)
                    {
                        STRload = STRload + "20";
                        i++;
                    }
                }
                if (comboBoxAdd.Text == "Random")                                        //���������� ������
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
                if (varSaveLoad == 1)                                   //�������� ����/������
                {
                    File.WriteAllBytes(pathKeySave, save);
                    MessageBox.Show("������ ��������!");
                }
                if (varSaveLoad == 2)                                   //����������� ����/������
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
                    else { MessageBox.Show("����� ������ ²=0 ��� ������������"); }
                }
            }
        }
        private void SaveVector_�lick(object sender, EventArgs e)
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