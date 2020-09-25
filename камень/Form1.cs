using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace камень
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                label1.Text = "на лево пойдешь,деньги найдешь";          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "на лево пойдешь,счатье найдешь";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "на лево пойдешь,бан найдешь";
        }
    }
}
