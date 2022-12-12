using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Media;


namespace Lab07V2_Herasymchuk
{
    static class KeyGen
    {
        static public byte[] generator_Key(int lenKey, string numKey = "з нулями")
        {
            lenKey = lenKey / 8;
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            byte[] randomArray = new byte[lenKey];

            switch (numKey)
            {
                case "з нулями":
                    rng.GetBytes(randomArray);
                    break;
                case "без нулів":
                    rng.GetNonZeroBytes(randomArray);
                    break;
                default:
                    // проблема
                    break;
            }

            return randomArray;
        }
    }
}

