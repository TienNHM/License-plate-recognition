using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

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
                lblPlate.Text = dlg.FileName;
                picImage.Image = new Bitmap(dlg.FileName);
                //OCR();
            }
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            //Program.process();
        }

        private void OCR()
        {
            var ocrengine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
            var img = Pix.LoadFromFile(lblPlate.Text);
            //Pix.LoadFromMemory(null);
            var res = ocrengine.Process(img);
            MessageBox.Show(res.GetText());
        }
    }
}
