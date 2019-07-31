using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpClassMovingMonsters
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //minimize current window
            this.WindowState = FormWindowState.Minimized;
            Form1 f = new Form1();
            f.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
