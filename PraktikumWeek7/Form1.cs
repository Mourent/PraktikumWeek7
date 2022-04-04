using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        private void btnKonversi_Click(object sender, EventArgs e)
        {
            string outputHasil = "";
            string inputKalimat = tBoxInputKalimat.Text.ToUpper();
            char inputHuruf = Convert.ToChar(tBoxInputHuruf.Text.ToUpper());
            char inputMenjadi = Convert.ToChar(tBoxMenjadi.Text.ToUpper());
            int selisihAngka = inputHuruf - inputMenjadi;
            for (int i = 0; i<= inputKalimat.Length-1; i++)
            {
                for (int k = 0; k <= 25; k++)
                {

                    if (inputKalimat[i] == Convert.ToChar(alphabet[k]))
                    {
                        if (k - selisihAngka > 25)
                        {
                            outputHasil = outputHasil + alphabet[k - selisihAngka - 26];
                        }
                        else if (k - selisihAngka <= 25 && k - selisihAngka >= 0)
                        {
                            outputHasil = outputHasil + alphabet[k - selisihAngka];
                        }
                        else if (k - selisihAngka < 0)
                        {
                            outputHasil = outputHasil + alphabet[k - selisihAngka + 26];
                        }
                    }
                }
                if (Convert.ToString(inputKalimat[i]) == " ")
                {
                    outputHasil = outputHasil + " ";
                }
            }
            labelOutput.Text = outputHasil.ToUpper();
        }
    }
}
