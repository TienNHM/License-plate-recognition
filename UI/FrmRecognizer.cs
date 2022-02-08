using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recognizer
{
    public partial class FrmRecognizer : Form
    {
        public FrmRecognizer()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Program.FileName = dlg.FileName;
                lblFileName.Text = dlg.FileName;
                picImage.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            Program.process();
        }
    }
}
