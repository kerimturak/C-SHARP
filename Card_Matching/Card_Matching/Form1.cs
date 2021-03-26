using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Matching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int move = 1;
        int slct = 1;
        int pic1 = 0;
        int pic2 = -1;
        int state = 0;
        int choice = 0;
        int second = 40;
        int minute = 01;
        int pair1 = 0;
        int pair2 = 0;

    private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblSecond.Text = second.ToString();
            second --;
            lblSecond.Text = Convert.ToString(second);
            lblMinute.Text = "0"+Convert.ToString(minute)+" :";
            if (second == 0)
            {
                minute--;
                lblMinute.Text = "0" + Convert.ToString(minute) + " :";
                second = 60;
            }

            if (lblMinute.Text == "-1")
            {
                lblMinute.Text = "00";
                lblSecond.Text = "00";
                this.BackColor = Color.Red;
            }

            progressBar1.Value += 1;

            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                btnRigth.Enabled = false;
                btnLeft.Enabled = false;
                btnSelect.Enabled = false;
                btnStart.Enabled = false;
                MessageBox.Show("Game Over!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            panel1.BackColor = Color.LightCoral;
            btnStart.Enabled = false;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnRigth.Enabled = true;
            btnLeft.Enabled = true;
            btnSelect.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (pair1 == 1)
            {
                if (move == 3)
                {
                    move = 2;
                }
                else if (move == 2)
                {
                    move = 3;
                }
            }
            else if (pair2 == 1)
            {
                if (move == 1)
                {
                    move = 4;
                }
                else if (move == 4)
                {
                    move = 1;
                }
            }
            else
            {
                if (move == 1)
                {
                    move = 2;
                }
                else if (move == 2)
                {
                    move = 1;
                }
                else if (move == 3)
                {
                    move = 4;
                }
                else
                {
                    move = 3;
                }
            }
            switch (move)
            {
                case 1:
                    panel1.BackColor = Color.LightCoral;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 2:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.LightCoral;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 3:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.LightCoral;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 4:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.LightCoral;
                    break;
                default:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pair1 == 1)
            {
                if (move == 3)
                {
                    move = 2;
                }
                else if (move == 2)
                {
                    move = 3;
                }
            }
            else if (pair2 == 1)
            {
                if (move == 1)
                {
                    move = 4;
                }
                else if (move == 4)
                {
                    move = 1;
                }
            }
            else
            {
                if (move == 1)
                {
                    move = 2;
                }
                else if (move == 2)
                {
                    move = 1;
                }
                else if (move == 3)
                {
                    move = 4;
                }
                else
                {
                    move = 3;
                }
            }

            switch (move)
            {
                case 1:
                    panel1.BackColor = Color.LightCoral;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 2:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.LightCoral;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 3:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.LightCoral;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 4:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.LightCoral;
                    break;
                default:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
            }
        }

        private void btnRigth_Click(object sender, EventArgs e)
        {
            if (pair1 ==1)
            {
                if (move == 2)
                {
                    move = 3;
                }
                else if (move == 3)
                {
                    move = 2;
                }
            }
            else if (pair2 == 1)
            {
                if (move == 1)
                {
                    move = 4;
                }
                else if (move == 4)
                {
                    move = 1;
                }
            }
            else
            {
                if (move == 1)
                {
                    move = 3;
                }
                else if (move == 2)
                {
                    move = 4;
                }
                else if (move == 3)
                {
                    move = 1;
                }
                else
                {
                    move = 2;
                }
            }
            switch (move)
            {
                case 1:
                    panel1.BackColor = Color.LightCoral;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 2:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.LightCoral;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 3:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.LightCoral;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 4:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.LightCoral;
                    break;
                default:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            /////Moving Part////
            if (pair1 == 1)
            {
                if (move == 2)
                {
                    move = 3;
                }
                else if (move == 3)
                {
                    move = 2;
                }
            }
            else if (pair2 == 1)
            {
                if (move == 1)
                {
                    move = 4;
                }
                else if (move == 4)
                {
                    move = 1;
                }
            }
            else
            {
                if (move == 1)
                {
                    move = 3;
                }
                else if (move == 2)
                {
                    move = 4;
                }
                else if (move == 3)
                {
                    move = 1;
                }
                else
                {
                    move = 2;
                }
            }

            switch (move)
            {
                case 1:
                    panel1.BackColor = Color.LightCoral;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 2:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.LightCoral;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 3:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.LightCoral;
                    panel4.BackColor = Color.RosyBrown;
                    break;
                case 4:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.LightCoral;
                    break;
                default:
                    panel1.BackColor = Color.RosyBrown;
                    panel2.BackColor = Color.RosyBrown;
                    panel3.BackColor = Color.RosyBrown;
                    panel4.BackColor = Color.RosyBrown;
                    break;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
/////////////////////////////// Firts cart chosen start///////////////////////////
            if (slct == 1)
            {
                if (move == 1)
                {
                    pictureBox1.Visible = true;
                    pic1 = 1;
                    slct++;
                    choice = 1;
                }
                else if (move == 2)
                {
                    pictureBox2.Visible = true;
                    pic1 = 2;
                    slct++;
                    choice = 2;
                }
                else if (move == 3)
                {
                    pictureBox3.Visible = true;
                    pic1 = 2;
                    slct++;
                    choice = 3;
                }
                else if (move == 4)
                {
                    pictureBox4.Visible = true;
                    pic1 = 1;
                    slct++;
                    choice = 4;
                }
            }
/////////////////////////////// Firts cart chosen end///////////////////////////



/////////////////// Second cart chosen and will check for matching//////////////
            else if (slct == 2)
            {
                if (move == 1 && choice !=1)
                {
                    pictureBox1.Visible = true;
                    pic2 = 1;
                    if(pic1 == pic2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox4.Visible = false;
                        panel1.Visible = false;
                        panel4.Visible = false;
                        slct ++;
                        move = 2;
                        state ++;
                        pair1 = 1;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        slct = 1;
                    }
                }
                else if (move == 2 && choice != 2)
                {
                    pictureBox2.Visible = true;
                    pic2 = 2;
                    if (pic1 == pic2)
                    {
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        panel2.Visible = false;
                        panel3.Visible = false;
                        slct  ++;
                        move = 1;
                        state++;
                        pair2 = 1;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox4.Visible = false;
                        slct = 1;
                    }
                }
                else if (move == 3 && choice != 3)
                {
                    pictureBox3.Visible = true;
                    pic2 = 2;
                    if (pic1 == pic2)
                    {
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        panel2.Visible = false;
                        panel3.Visible = false;
                        slct  ++;
                        move = 1;
                        state++;
                        pair2 = 1;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        slct = 1;
                    }
                }
                else if (move == 4 && choice != 4)
                {
                    pictureBox4.Visible = true;
                    pic2 = 1;
                    if (pic1 == pic2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox4.Visible = false;
                        panel1.Visible = false;
                        panel4.Visible = false;
                        slct  ++;
                        move = 2;
                        state++;
                        pair1 = 1;
                    }
                    else
                    {
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        slct = 1;
                    }
                }
////////////////////////////////////////////////////////////////
            }
            if (slct == 3)
            {
                if(state == 2)
                {
                    btnUp.Enabled     = false;
                    btnDown.Enabled   = false;
                    btnRigth.Enabled  = false;
                    btnLeft.Enabled   = false;
                    btnSelect.Enabled = false;
                    btnStart.Enabled  = false;
                    lblMinute.Text = "00";
                    lblSecond.Text = "00";
                    progressBar1.Value = 100;
                    timer1.Stop();
                    MessageBox.Show("Congratulations!");
                }
                else
                {
                    slct = 1;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                }
            }
        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }
    }
}
