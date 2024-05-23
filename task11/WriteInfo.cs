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
    public partial class WriteInfo : Form
    {
        public static string WriteFileName;
        public WriteInfo()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            WriteFileName = textBoxFileName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void WriteInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
