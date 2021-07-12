using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv_frodll
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string[] blurtype = new string[] { "Average", "Gaussian", "Median", "Bilateral" };
        private void Form2_Load(object sender, EventArgs e)
        {
            this.sizebar.Maximum = 5;
            this.sizebar.Minimum = 1;
            this.typebar.Maximum = 4;
            this.typebar.Minimum = 1;
            

            
        
            this.label2.Text = (sizebar.Value * 2 - 1).ToString();
            this.label4.Text = blurtype[typebar.Value - 1];

           

        }

        private void sizebar_ValueChanged(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            img = _lib.ImageBlur(img, typebar.Value, sizebar.Value * 2 - 1);
            
            dstpic.Image = img;
        }

        private void typebar_ValueChanged(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            img = _lib.ImageBlur(img, typebar.Value, sizebar.Value * 2 - 1);

            dstpic.Image = img;
        }

        private void sizebar_Scroll(object sender, EventArgs e)
        {
            this.label2.Text = (sizebar.Value * 2 - 1).ToString();
        }

        private void typebar_Scroll(object sender, EventArgs e)
        {
            this.label4.Text = blurtype[typebar.Value - 1];
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            PictureBox f1_dst = (PictureBox)this.Owner.Controls.Find("pictureBox3", true)[0];
            PictureBox f1_last = (PictureBox)this.Owner.Controls.Find("pictureBox2", true)[0];
            
            f1_last.Image = srcpic.Image;
            f1_dst.Image = dstpic.Image;
            this.Close();
        }
    }
}
