using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nontimer
{
    public partial class Sleep : Form
    {
        public Sleep()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okay, your computer will shutdown in " + this.shutHours +
                " hours");
        }

       
    }
}
