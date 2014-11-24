using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

    
        private void byte__Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 - 255"); 
        }

    
        private void ulong__Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 - 18 446 744 073 709 551 615");
        }

        private void short__Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32 768 - 32767");
        }

        private void uint__Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 - 4 294 967 295");
        }

        private void ushort__Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 - 65 535");
        }

        private void long__Click(object sender, EventArgs e)
        {
            MessageBox.Show("-9 223 372 036 854 775 808 - 9 223 372 036 854 775 807");
        }

        private void sbyte__Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128 - 127");
        }

        private void int__Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2 147 483 648 - 2 147 483 647");
        }
    }
}
