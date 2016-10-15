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
            if (!offIn)
            {
                MessageBox.Show("Компьютер выключится через " + this.shutHours +
                    " часов " + this.shutMinutes +" минут");
            }
            else
            {
                MessageBox.Show("Компьютер выключится в ");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            this.offtextBoxIn.Text = d.ToShortTimeString();
        }
    }
}
