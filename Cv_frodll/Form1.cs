using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cv_frodll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        
           
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            string filepath = this.textBox1.Text;
            Bitmap img = _lib.ImageRead(@filepath);
            Bitmap img1 = new Bitmap(256,256);
            _lib.ImageResize(img, img1,256);
            pictureBox1.Image = img1;
            pictureBox2.Image = img1;
            pictureBox3.Image = img1;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            int type=1,blursize = 3;
            ComboboxItem item = comboBox1.Items[comboBox1.SelectedIndex] as ComboboxItem;
            type = Int32.Parse(item.Value.ToString());

            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(pictureBox1.Image);
            img = _lib.ImageBlur(img,type,blursize);
            pictureBox2.Image = null;
            pictureBox2.Image = img;
            */

            Form2 f = new Form2();
            f.Owner = this;
            if(this.usingnow.Checked)
            {
                f.srcpic.Image = pictureBox3.Image;
            }
            else if(this.usinglast.Checked)
            {
                f.srcpic.Image = pictureBox2.Image;
            }
            else
            {
                f.srcpic.Image = pictureBox1.Image;
            }
             
            f.Show();

            

        }




     
        

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        

        private void btn_select_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            
            openFileDialog1.Title = "請選擇檔案";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg";
            openFileDialog1.ShowDialog();
            this.textBox1.Text = openFileDialog1.FileName;


            Class1 _lib = new Class1();
            string filepath = this.textBox1.Text;
            Bitmap img = _lib.ImageRead(@filepath);
            Bitmap img1 = new Bitmap(256, 256);
            _lib.ImageResize(img, img1, 256);

            pictureBox1.Image = img1;
            pictureBox2.Image = img1;
            pictureBox3.Image = img1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Owner = this;
            if (this.usingnow.Checked)
            {
                f.srcpic.Image = pictureBox3.Image;
            }
            else if (this.usinglast.Checked)
            {
                f.srcpic.Image = pictureBox2.Image;
            }
            else
            {
                f.srcpic.Image = pictureBox1.Image;
            }

            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap img1 = new Bitmap(256,256,PixelFormat.Format8bppIndexed);
            _lib.ImageBGR2Gray(img, img1);
 
            img1.Palette = Class1.GenerateGrayscalePalette(img1);
            pictureBox2.Image = img1;
            pictureBox3.Image = img1;
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Class1 _lib = new Class1();
            Bitmap img = new Bitmap(256, 256, PixelFormat.Format8bppIndexed);
            img = (Bitmap)pictureBox2.Image;
            Bitmap img1 = new Bitmap(256, 256, PixelFormat.Format8bppIndexed);
            _lib.ImageHistEqul(img, img1);
            img1.Palette = Class1.GenerateGrayscalePalette(img1);
            pictureBox3.Image = img1;
        }
    }
}
