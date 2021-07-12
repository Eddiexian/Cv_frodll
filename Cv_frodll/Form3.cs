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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("MORPH_RECT");
            comboBox1.Items.Add("MORPH_CROSS");
            comboBox1.Items.Add("MORPH_ELLIPSE");
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            if (comboBox1.SelectedItem.ToString() == "MORPH_RECT")
            {
                type = 0;
            }
            else if(comboBox1.SelectedItem.ToString() == "MORPH_CROSS")
            {
                type = 1;
            }
            else
            {
                type = 2;
            }

            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }
        public int type = 0;
        public int size = 1;
        public int op = 0;

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            size = trackBar1.Value;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }


        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked == true)
            {
                foreach (CheckBox chk in (sender as CheckBox).Parent.Controls)
                {
                    if (chk != sender)
                    {
                        chk.Checked = false;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 0;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 1;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 2;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 3;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 4;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 5;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ckb_CheckedChanged(sender, e);
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(srcpic.Image);
            op = 6;
            img = _lib.ImageMorphology_Operate(img, op, size, type);
            pictureBox2.Image = img;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            PictureBox f1_dst = (PictureBox)this.Owner.Controls.Find("pictureBox3", true)[0];
            PictureBox f1_last = (PictureBox)this.Owner.Controls.Find("pictureBox2", true)[0];
            f1_last.Image = srcpic.Image;
            f1_dst.Image = pictureBox2.Image;
            this.Close();
        }
    }
}
