using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numberque = 0, ans_corr = 0, ans_wrng = 0;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            answer.Text = btnA.Text;

            if(correctAns.Text == answer.Text)
            {
                ans_corr++;
                pictureBox2.Visible = true;
                lblTrue.Text = ans_corr.ToString();
            }
            else
            {
                ans_wrng++;
                pictureBox3.Visible = true;
                lblFalse.Text = ans_wrng.ToString();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            answer.Text = btnB.Text;

            if (correctAns.Text == answer.Text)
            {
                ans_corr++;
                pictureBox2.Visible = true;
                lblTrue.Text = ans_corr.ToString();
            }
            else
            {
                ans_wrng++;
                pictureBox3.Visible = true;
                lblFalse.Text = ans_wrng.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            answer.Text = btnC.Text;

            if (correctAns.Text == answer.Text)
            {
                ans_corr++;
                pictureBox2.Visible = true;
                lblTrue.Text = ans_corr.ToString();
            }
            else
            {
                ans_wrng++;
                pictureBox3.Visible = true;
                lblFalse.Text = ans_wrng.ToString();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            answer.Text = btnD.Text;

            if (correctAns.Text == answer.Text)
            {
                ans_corr++;
                pictureBox2.Visible = true;
                lblTrue.Text = ans_corr.ToString();
            }
            else
            {
                ans_wrng++;
                pictureBox3.Visible = true;
                lblFalse.Text = ans_wrng.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            numberque++;
            lblnumberque.Text = numberque.ToString();

            if(numberque == 1)
            {
                richTextBox1.Text = "Where did Mehmet Akif write the Turkish National Anthem??";
                btnA.Text = "Ankara - Ayasofya";
                btnB.Text = "Ankara - Keçiören Camisi";
                btnC.Text = "Ankara - Ayaş Dergahı";
                btnD.Text = "Ankara - Taceddin Dergahı";
                correctAns.Text = "Ankara - Taceddin Dergahı";
            }

            if(numberque == 2)
            {
                richTextBox1.Text = "Atatürk'ün yurt gezilerinde (1935-1938) yılları arasında kullandığı trenin adı nedir?";
                btnA.Text = "Beyaz Tren";
                btnB.Text = "Kara Tren";
                btnC.Text = "Demir Türk";
                btnD.Text = "Anadolu";
                correctAns.Text = "Beyaz Tren";
            }

            if (numberque == 3)
            {
                richTextBox1.Text = "Türkiye'nin ilk Safari Parkı hangi ilimizde açılmıştır?";
                btnA.Text = "Ankara";
                btnB.Text = "İzmir";
                btnC.Text = "Gaziantep";
                btnD.Text = "Manisa";
                correctAns.Text = "Gaziantep";
            }

            if (numberque == 4)
            {
                richTextBox1.Text = "Birleşmiş Milletler Dünya Turizm Örgütü'nün kısa adı hangisidir?";
                btnA.Text = "UNWTO";
                btnB.Text = "WTO";
                btnC.Text = "UWT";
                btnD.Text = "UNOWT";
                correctAns.Text = "UNWTO";
                btnNext.Text = "Sonuçlar";
            }

            if (numberque == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Doğru: " + ans_corr + "\n" + "Yanlış: " + ans_wrng);
            }
        }
    }
}
