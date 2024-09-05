using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XOGAME
{
    public partial class TowPlayer : Form
    {
        int[,] ary = new int[3, 3];
        int ap = 1;
        public void BoldF()
        {
            UnShowT(C1);
            UnShowT(C2);
            UnShowT(C3);
            UnShowT(C4);
            UnShowT(C5);
            UnShowT(C6);
            UnShowT(C7);
            UnShowT(C8);
            UnShowT(C9);
        }
        void s(DevComponents.DotNetBar.ButtonX Btn)
        {
            if (Btn.Text == "")
            {
                Btn.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
            }
        }
        void us(DevComponents.DotNetBar.ButtonX Btn)
        {
            Btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
        }
        void sp()
        {
            if (ap == 1)
            {
                ap = 2;
                LblTurn.Text = "بازیکن O";
            }

            else if (ap == 2)
            {
                ap = 1;
                LblTurn.Text = "بازیکن X";
            }
        }
        int ch()
        {
            int temp = 0;
            if (ary[0, 0] == 1 && ary[1, 1] == 1 && ary[2, 2] == 1) 
            {
                temp = 1;
                ShowT(ShowB(0, 0), ShowB(1, 1), ShowB(2, 2));
            }
            else if (ary[0, 2] == 1 && ary[1, 1] == 1 && ary[2, 0] == 1)
            {
                temp = 1;
                ShowT(ShowB(0, 2), ShowB(1, 1), ShowB(2, 0));
            }
            else if (ary[0, 0] == 2 && ary[1, 1] == 2 && ary[2, 2] == 2)
            {
                temp = 2;
                ShowT(ShowB(0, 0), ShowB(1, 1), ShowB(2, 2));
            }
            else if (ary[0, 2] == 2 && ary[1, 1] == 2 && ary[2, 0] == 2)
            {
                temp = 2;
                ShowT(ShowB(0, 2), ShowB(1, 1), ShowB(2, 0));
            }    
            for (int i = 0; i < 3; i++)
            {
                if (ary[i, 0] == 1 && ary[i, 1] == 1 && ary[i, 2] == 1)
                {
                    temp = 1;
                    ShowT(ShowB(i, 0), ShowB(i, 1), ShowB(i, 2));
                }
                else if (ary[0, i] == 1 && ary[1, i] == 1 && ary[2, i] == 1)
                {
                    temp = 1;
                    ShowT(ShowB(0, i), ShowB(1, i), ShowB(2, i));
                }    
                else if (ary[0, i] == 2 && ary[1, i] == 2 && ary[2, i] == 2)
                {
                    temp = 2;
                    ShowT(ShowB(0, i), ShowB(1, i), ShowB(2, i));
                }
                else if (ary[i, 0] == 2 && ary[i, 1] == 2 && ary[i, 2] == 2)
                {
                    temp = 2;
                    ShowT(ShowB(i, 0), ShowB(i, 1), ShowB(i, 2));
                }
                    
            }
            return temp;
        }
        int x = 0, o = 0, e = 0;
        void end(int a)
        {
            if (a == 1)
                x++;
            else if (a == 2)
                o++;
            if (a == 1 || a == 2)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        ary[i, j] = 0;
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                C4.Text = "";
                C5.Text = "";
                C6.Text = "";
                C7.Text = "";
                C8.Text = "";
                C9.Text = "";
                ap = 2;
                LblWin.Text = string.Format("[{0}]X [{1}]O",o,x);
                BoldF();
            }
        }
        void restart()
        {
            string str = C1.Text + C2.Text + C3.Text + C4.Text + C5.Text + C6.Text + C7.Text + C8.Text + C9.Text;
            if (str.Length == 9)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        ary[i, j] = 0;
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                C4.Text = "";
                C5.Text = "";
                C6.Text = "";
                C7.Text = "";
                C8.Text = "";
                C9.Text = "";
                ap = 2;
                e++;
                //**************
                timer1.Stop();
                int s, m = 0;
                s = int.Parse(lblTime1.Text);
                m = int.Parse(LblTime2.Text);
                MessageBox.Show("Equal\n" + "\n" + m + ":" + s);
                lblTime1.Text = "0";
                LblTime2.Text = "0";
                timer1.Start();
            }
            LblE.Text = e.ToString();
        }
        void ShowT(DevComponents.DotNetBar.ButtonX Btn1, DevComponents.DotNetBar.ButtonX Btn2, DevComponents.DotNetBar.ButtonX Btn3)
        {
            Btn1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            Btn2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            Btn3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
        }
        void UnShowT(DevComponents.DotNetBar.ButtonX Btn)
        {
            Btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
        }
        DevComponents.DotNetBar.ButtonX ShowB(int i, int j)
        {
            if (i == 0 && j == 0)
                return C1;
            else if (i == 0 && j == 1)
                return C2;
            else if (i == 0 && j == 2)
                return C3;
            else if (i == 1 && j == 0)
                return C4;
            else if (i == 1 && j == 1)
                return C5;
            else if (i == 1 && j == 2)
                return C6;
            else if (i == 2 && j == 0)
                return C7;
            else if (i == 2 && j == 1)
                return C8;
            else if (i == 2 && j == 2)
                return C9;
            else
                return null;
        }
        void Add(DevComponents.DotNetBar.ButtonX Btn, int a, int x, int y)
        {
            int temp = 0;
            if (ary[x, y] == 0)
            {
                ary[x, y] = a;
                if (a == 1)
                    Btn.Text = "X";
                if (a == 2)
                    Btn.Text = "O";
                restart();
                temp = ch();
                if (temp == 1 || temp == 2)
                {
                    if(temp==1)
                    {
                        timer1.Stop();
                        int s, m = 0;
                        s = int.Parse(lblTime1.Text);
                        m = int.Parse(LblTime2.Text);
                        MessageBox.Show("X Win\n" + "\n" + m + ":" + s);
                        lblTime1.Text = "0";
                        LblTime2.Text = "0";
                        //BlackF();
                        timer1.Start();
                    }
                    else if (temp == 2)
                    {
                        timer1.Stop();
                        int s, m = 0;
                        s = int.Parse(lblTime1.Text);
                        m = int.Parse(LblTime2.Text);
                        MessageBox.Show("O Win\n" + "\n" + m + ":" + s);
                        lblTime1.Text = "0";
                        LblTime2.Text = "0";
                        //BlackF();
                        timer1.Start();
                    }
                    end(temp);
                }
                sp();
            }
        }
        public TowPlayer()
        {
            InitializeComponent();
            //*****
            timer1.Start();
        }

        private void TowPlayer_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    ary[i, j] = 0;
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Add(C1, ap, 0, 0);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Add(C2, ap, 0, 1);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Add(C3, ap, 0, 2);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Add(C4, ap, 1, 0);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            Add(C5, ap, 1, 1);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            Add(C6, ap, 1, 2);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            Add(C7, ap, 2, 0);
        }

        private void C8_Click(object sender, EventArgs e)
        {
            Add(C8, ap, 2, 1);
        }

        private void C9_Click(object sender, EventArgs e)
        {
            Add(C9, ap, 2, 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s = int.Parse(lblTime1.Text);
            int m = 0;
            s++;
            lblTime1.Text = s.ToString();
            if (s == 60)
            {
                m = int.Parse(LblTime2.Text);
                m++;
                LblTime2.Text = m.ToString();
                s = 0;
                lblTime1.Text = s.ToString();
            }
        }

        private void C1_MouseMove(object sender, MouseEventArgs e)
        {
            s(C1);
        }

        private void C2_MouseMove(object sender, MouseEventArgs e)
        {
            s(C2);
        }

        private void C3_MouseMove(object sender, MouseEventArgs e)
        {
            s(C3);
        }

        private void C4_MouseMove(object sender, MouseEventArgs e)
        {
            s(C4);
        }

        private void C5_MouseMove(object sender, MouseEventArgs e)
        {
            s(C5);
        }

        private void C6_MouseMove(object sender, MouseEventArgs e)
        {
            s(C6);
        }

        private void C7_MouseMove(object sender, MouseEventArgs e)
        {
            s(C7);
        }

        private void C8_MouseMove(object sender, MouseEventArgs e)
        {
            s(C8);
        }

        private void C9_MouseMove(object sender, MouseEventArgs e)
        {
            s(C9);
        }

        private void C1_MouseLeave(object sender, EventArgs e)
        {
            us(C1);
        }

        private void C2_MouseLeave(object sender, EventArgs e)
        {
            us(C2);
        }

        private void C3_MouseLeave(object sender, EventArgs e)
        {
            us(C3);
        }

        private void C4_MouseLeave(object sender, EventArgs e)
        {
            us(C4);
        }

        private void C5_MouseLeave(object sender, EventArgs e)
        {
            us(C5);
        }

        private void C6_MouseLeave(object sender, EventArgs e)
        {
            us(C6);
        }

        private void C7_MouseLeave(object sender, EventArgs e)
        {
            us(C7);
        }

        private void C8_MouseLeave(object sender, EventArgs e)
        {
            us(C8);
        }

        private void C9_MouseLeave(object sender, EventArgs e)
        {
            us(C9);
        }

        private void BtnAgain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا میخواهید بازی دوباره اجرا شود؟") == DialogResult.OK)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        ary[i, j] = 0;
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                C4.Text = "";
                C5.Text = "";
                C6.Text = "";
                C7.Text = "";
                C8.Text = "";
                C9.Text = "";
                ap = 2;
                //**************
                timer1.Stop();
                lblTime1.Text = "0";
                LblTime2.Text = "0";
                LblWin.Text = "[0]X [0] O";
                timer1.Start();
            }
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
