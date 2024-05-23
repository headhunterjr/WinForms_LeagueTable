using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task11
{
    public partial class SortOrder : Form
    {
        public SortOrder()
        {
            InitializeComponent();
        }

        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            Form1.sortOrder = false;
        }

        private void buttonOkClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonAsc_CheckedChanged(object sender, EventArgs e)
        {
            Form1.sortOrder = true;
        }
    }
}
