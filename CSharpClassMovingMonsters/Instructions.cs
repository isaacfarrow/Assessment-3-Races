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
    public partial class Instructions : Form
    {
        public Instructions()
        {

            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Minimize current window
            this.WindowState = FormWindowState.Minimized;
            Home f = new Home();
            f.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }


    }
}
