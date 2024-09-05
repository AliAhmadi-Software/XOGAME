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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            TowPlayer f2 = new TowPlayer();
            //this.Close();
            f2.Show();   
        }
    }
}
