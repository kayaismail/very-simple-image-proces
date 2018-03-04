namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FotoImageBox = new Emgu.CV.UI.ImageBox();
            this.GriImageBox = new Emgu.CV.UI.ImageBox();
            this.HistogramBox = new Emgu.CV.UI.HistogramBox();
            this.BinaryImageBox = new Emgu.CV.UI.ImageBox();
            this.BtnFotoSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FotoImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FotoImageBox
            // 
            this.FotoImageBox.Location = new System.Drawing.Point(32, 66);
            this.FotoImageBox.Name = "FotoImageBox";
            this.FotoImageBox.Size = new System.Drawing.Size(365, 240);
            this.FotoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoImageBox.TabIndex = 2;
            this.FotoImageBox.TabStop = false;
            this.FotoImageBox.Click += new System.EventHandler(this.OrginalFotoImageBox_Click);
            // 
            // GriImageBox
            // 
            this.GriImageBox.Location = new System.Drawing.Point(555, 66);
            this.GriImageBox.Name = "GriImageBox";
            this.GriImageBox.Size = new System.Drawing.Size(365, 240);
            this.GriImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GriImageBox.TabIndex = 2;
            this.GriImageBox.TabStop = false;
            this.GriImageBox.Click += new System.EventHandler(this.GriImageBox_Click_1);
            // 
            // HistogramBox
            // 
            this.HistogramBox.Location = new System.Drawing.Point(32, 352);
            this.HistogramBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HistogramBox.Name = "HistogramBox";
            this.HistogramBox.Size = new System.Drawing.Size(365, 240);
            this.HistogramBox.TabIndex = 3;
            this.HistogramBox.Load += new System.EventHandler(this.HistogramBox_Load);
            // 
            // BinaryImageBox
            // 
            this.BinaryImageBox.Location = new System.Drawing.Point(555, 352);
            this.BinaryImageBox.Name = "BinaryImageBox";
            this.BinaryImageBox.Size = new System.Drawing.Size(365, 240);
            this.BinaryImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BinaryImageBox.TabIndex = 2;
            this.BinaryImageBox.TabStop = false;
            this.BinaryImageBox.Click += new System.EventHandler(this.BinaryImageBox_Click_1);
            // 
            // BtnFotoSec
            // 
            this.BtnFotoSec.Location = new System.Drawing.Point(88, 13);
            this.BtnFotoSec.Name = "BtnFotoSec";
            this.BtnFotoSec.Size = new System.Drawing.Size(176, 33);
            this.BtnFotoSec.TabIndex = 4;
            this.BtnFotoSec.Text = "Select photo ";
            this.BtnFotoSec.UseVisualStyleBackColor = true;
            this.BtnFotoSec.Click += new System.EventHandler(this.BtnFotoSec_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(950, 616);
            this.Controls.Add(this.BtnFotoSec);
            this.Controls.Add(this.BinaryImageBox);
            this.Controls.Add(this.HistogramBox);
            this.Controls.Add(this.GriImageBox);
            this.Controls.Add(this.FotoImageBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GriImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ımageBox1;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox ımageBox2;
        private Emgu.CV.UI.ImageBox ımageBox3;
        private Emgu.CV.UI.ImageBox FotoImageBox;
        private Emgu.CV.UI.ImageBox GriImageBox;
        private Emgu.CV.UI.HistogramBox HistogramBox;
        private Emgu.CV.UI.ImageBox BinaryImageBox;
        private System.Windows.Forms.Button BtnFotoSec;
    }
}

