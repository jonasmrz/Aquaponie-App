using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquaponie_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void modifCycle_Click(object sender, EventArgs e)
        {
            debutCycle.Enabled = true;
            transferCycle.Enabled = true;
        }

        private void modifFrequence_Click(object sender, EventArgs e)
        {
            freqTemp.Enabled = true;
            freqTransfer.Enabled = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
