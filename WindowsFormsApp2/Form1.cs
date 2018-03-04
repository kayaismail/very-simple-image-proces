using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string DosyaAdiGetir()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;
            else
                return "";
        }

        public static Mat HistogramGetir(Image<Gray, byte> griFoto)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 256));
            hist.Calculate(new Image<Gray, Byte>[] { griFoto }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            return m;
        }
        private static Image<Gray, byte> GriGetir(Image<Bgr, byte> renkliFoto)
        {
            Image<Gray, byte> gri = renkliFoto.Convert<Gray, byte>();
            return gri;
        }
        public static Image<Gray, byte> BinaryGetir(Image<Gray, byte> gri)
        {
            int threshold = 70;
            Image<Gray, byte> binary = gri.ThresholdBinary(new Gray(threshold), new Gray(255));
            return binary;
        }
        private void HistogramBox_Load(object sender, EventArgs e)
        {

        }

        private void OrginalFotoImageBox_Click(object sender, EventArgs e)
        {

        }

        private void GriImageBox_Click_1(object sender, EventArgs e)
        {

        }

        private void BinaryImageBox_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnFotoSec_Click_1(object sender, EventArgs e)
        {

            string FotoGetir = DosyaAdiGetir();
            Image<Bgr, byte> renkliFoto = new Image<Bgr, byte>(FotoGetir);
            FotoImageBox.Image = renkliFoto;
            //gri image
            Image<Gray, byte> griFoto = GriGetir(renkliFoto);
            GriImageBox.Image = griFoto;
            //binary image
            Image<Gray, byte> binaryFoto = BinaryGetir(griFoto);
            BinaryImageBox.Image = binaryFoto;

            //histogram
            Mat m = HistogramGetir(griFoto);
            HistogramBox.ClearHistogram();
            HistogramBox.AddHistogram("Gri Histogram", Color.Gray, m, 256, new float[] { 0.0f, 256.0f });
            HistogramBox.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
