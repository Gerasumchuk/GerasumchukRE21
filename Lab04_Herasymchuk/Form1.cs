namespace Lab04_Herasymchuk;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button_fileIN_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //���� �� �����
                string fileINpath = openFileDialog.FileName;
                textBox_fileIN.Text = fileINpath;
            }
        }
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button_fileOUT_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        saveFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
        saveFileDialog.FilterIndex = 2;
        saveFileDialog.RestoreDirectory = true;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            //���� �� �����
            string fileOUTpath = saveFileDialog.FileName;
            textBox_fileOUT.Text = fileOUTpath;
        }
    }

    private void button_fileKEYopen_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //���� �� �����
                string fileKEYPath = openFileDialog.FileName;
                textBox_fileKEY.Text = fileKEYPath;
                  System.IO.FileInfo file = new System.IO.FileInfo(openFileDialog.FileName);     //���������� ���̲��
                long size = file.Length;                                                              
                string STRsize = size.ToString();
                labelsize.Text = STRsize;
                labelsize2.Text = "����";
            }
        }
    }

    private void button_fileKEYsave_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "txt files(*.txt)| *.txt | All files(*.*) | *.*";
        saveFileDialog.FilterIndex = 1;
        saveFileDialog.RestoreDirectory = true;
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            //���� �� �����
            string fileKEYPath = saveFileDialog.FileName;
            textBox_fileKEY.Text = fileKEYPath;
        }
    }

    private void button_KEYgenerator_Click(object sender, EventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("��������� ����� ���� ?", "����a", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResult == DialogResult.Yes)
        {
            Cursor.Current = Cursors.WaitCursor;
            string fileINpath = textBox_fileIN.Text;
            if (File.Exists(fileINpath))
            {
                string fileKEYpath = textBox_fileKEY.Text;
                string dirKEYpath = Path.GetDirectoryName(fileKEYpath);
                if (Directory.Exists(dirKEYpath))
                {
                    //������� �������� ����� � ������
                    long lengthINfile = new FileInfo(fileINpath).Length;
                    //��������� ����� ��������, �� ������� ����
                    byte[] arrKEY = new byte[lengthINfile];
                    RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
                    rngCsp.GetBytes(arrKEY);
                    //���������� �������������� ����� � ���� � ������
                    using (FileStream fs = File.Create(fileKEYpath))
                    {
                        fs.Write(arrKEY, 0, arrKEY.Length);
                        fs.Close();
                    }
                }
                else
                {
                    MessageBox.Show("���� �� ����� �� ��������\n��� ����� ���� �� ����");
                    textBox_fileKEY.Focus();
                }
            }
            else
            {
                MessageBox.Show("������� ���� �� ����");
                button_fileIN.Focus();
            }
            Cursor.Current = Cursors.Default;
        }
    }

    private void button_start_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        string fileINpath = textBox_fileIN.Text;
        string fileOUTpath = textBox_fileOUT.Text;
        string fileKEYpath = textBox_fileKEY.Text;
        if (File.Exists(fileINpath))
        {
            string dirOUTpath = Path.GetDirectoryName(fileOUTpath);
            if (Directory.Exists(dirOUTpath))
            {
                if (File.Exists(fileKEYpath))
                {
                    //������� �������� ����� � ������
                    long lengthINfile = new FileInfo(fileINpath).Length;
                    //������� �������� ����� � ������
                    long lengthKEYfile = new FileInfo(fileKEYpath).Length;
                  //  if (lengthINfile == lengthKEYfile)
                 //   {
                        Stopwatch stopwatch = new Stopwatch();
                        // Begin timing.
                        stopwatch.Start();
                        byte[] arrCipher = myCipherXOR(fileINpath, fileKEYpath);
                        //����������
                        mySaveToFileOUT(arrCipher, fileOUTpath); //���������� � ����
                                                                 // Stop timing.
                        stopwatch.Stop();
                        // Write result.
                        label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
                  //  }
                 //   else
                 //   {
                  //      MessageBox.Show("����� ����� ����� �� �������\n� ������� �������� �����");
                 //       button_fileKEYopen.Focus();
                  //  }
                }
                else
                {
                    MessageBox.Show("���� �� ����� ����� �� ��������\n��� ����� ���� �� ����");
                    textBox_fileKEY.Focus();
                }
            }
            else
            {
                MessageBox.Show("���� �� ��������� ����� �� ��������\n��� ����� ���� �� ����");
                textBox_fileOUT.Focus();
            }
        }
        else
        {
            MessageBox.Show("������� ���� �� ����");
            button_fileIN.Focus();

        }
        Cursor.Current = Cursors.Default;
    }
    /*private byte[] myCipherXOR(string fileINpath, string fileKEYpath)
    {
        byte[] arrIN = File.ReadAllBytes(fileINpath);
        byte[] arrKEY = File.ReadAllBytes(fileKEYpath);
        int lenIN = arrIN.Length;
        byte[] arrCipher = new byte[lenIN];
        for (int i = 0; i<lenIN; i++)
{
            //���������� XOR
            arrCipher[i] = (byte)(arrIN[i] ^ arrKEY[i]);
        }
        return arrCipher;
        }*/
    private byte[] myCipherXOR(string fileINpath, string fileKEYpath)
    {
        byte[] arrIN = File.ReadAllBytes(fileINpath);
        byte[] arrKEY = File.ReadAllBytes(fileKEYpath);
        int lenIN = arrIN.Length;
        byte[] arrCipher = new byte[lenIN];
        int j = 0;
        for (var i = 0; i < lenIN; i++)
        {                                                                                              //����������
                //���������� XOR
                arrCipher[i] = (byte)(arrIN[i] ^ arrKEY[j]);
            j++;
        if (j == arrKEY.Length) {j = 0;}                                                               //���������� ������ �� ����
        }
        return arrCipher;
    }
    private void mySaveToFileOUT(byte[] arrCipher, string fileOUTpath)
    {
        //���������� � ����
        using (FileStream fs = File.Create(fileOUTpath))
        {
            fs.Write(arrCipher, 0, arrCipher.Length);
            fs.Close();
        }
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {

    }
}
