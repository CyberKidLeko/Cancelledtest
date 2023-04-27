using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancelledtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2= new Form2();
            myForm2.Show();

        }
    }
}
