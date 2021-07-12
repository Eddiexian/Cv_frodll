using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cv_frodll
{
    class Class1
    {
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll")]
        public static extern void loadimage();
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "BGR2Gray")]
        public static extern void BGR2Gray(IntPtr img, IntPtr dst, int width, int height, int step);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "HistEqul")]
        public static extern void HistEqul(IntPtr img, IntPtr dst, int width, int height, int step);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "FindLine")]
        public static extern void FindLine(IntPtr img, IntPtr dst, int width, int height, int step);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "Blur")]
        public static extern void Blur(IntPtr img, int width, int height, int step, int type, int blursize);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "Dilation")]
        public static extern void Dilation(IntPtr img, int width, int height, int step, int size, int type);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "Erode")]
        public static extern void Erode(IntPtr img, int width, int height, int step, int size, int type);
        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "Resize")]
        public static extern void Resize(IntPtr src, IntPtr dst, int width, int height, int step, int size);

        [DllImport(@"C:\Users\polo1\source\repos\cv_lib\x64\Debug\cv_lib.dll", EntryPoint = "Morphology_Operate")]
        public static extern void Morphology_Operate(IntPtr src, int width, int height, int step, int morph_operator, int type, int size);
        public Bitmap ImageRead(string path)
        {

            Bitmap image = null;
            using (FileStream fs = File.OpenRead(path))
            {   //OpenRead
                int filelength = 0;
                filelength = (int)fs.Length; //获得文件长度 
                Byte[] image1 = new Byte[filelength]; //建立一个字节数组 
                fs.Read(image1, 0, filelength); //按字节流读取
                image = (Bitmap)System.Drawing.Image.FromStream(fs);
                fs.Close();

                return image;
            }

        }

        public Bitmap ImageBlur(Bitmap src, int type, int blursize)
        {
            try
            {

                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                Blur(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, type, blursize);
                src.UnlockBits(bitmapData);

                return src;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageBGR2Gray(Bitmap src, Bitmap dst)
        {
            try
            {

                BitmapData dstData = dst.LockBits(new Rectangle(0, 0, dst.Width, dst.Height), ImageLockMode.ReadWrite,PixelFormat.Format8bppIndexed);
                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BGR2Gray(bitmapData.Scan0, dstData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride);
                src.UnlockBits(bitmapData);
                dst.UnlockBits(dstData);

                return dst;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageHistEqul(Bitmap src, Bitmap dst)
        {
            try
            {

                BitmapData dstData = dst.LockBits(new Rectangle(0, 0, dst.Width, dst.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                HistEqul(bitmapData.Scan0, dstData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride);
                src.UnlockBits(bitmapData);
                dst.UnlockBits(dstData);

                return dst;
            }
            catch (Exception e) { return src; }
        }


        public Bitmap FindLine(Bitmap src, Bitmap dst)
        {
            try
            {

                BitmapData dstData = dst.LockBits(new Rectangle(0, 0, dst.Width, dst.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
                FindLine(bitmapData.Scan0, dstData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride);
                src.UnlockBits(bitmapData);
                dst.UnlockBits(dstData);

                return dst;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageDilation(Bitmap src, int type, int size)
        {
            try
            {

                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                Dilation(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, size, type);
                src.UnlockBits(bitmapData);

                return src;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageErode(Bitmap src, int type, int size)
        {
            try
            {

                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                Erode(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, size, type);
                src.UnlockBits(bitmapData);

                return src;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageResize(Bitmap src, Bitmap dst, int size)
        {
            try
            {
                BitmapData dstData = dst.LockBits(new Rectangle(0, 0, dst.Width, dst.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                Resize(bitmapData.Scan0, dstData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, size);
                src.UnlockBits(bitmapData);
                dst.UnlockBits(dstData);

                return dst;
            }
            catch (Exception e) { return src; }
        }

        public Bitmap ImageMorphology_Operate(Bitmap src, int op, int size, int type)
        {
            try
            {
                BitmapData bitmapData = src.LockBits(new Rectangle(0, 0, src.Width, src.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                Morphology_Operate(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride, op, type, size);
                src.UnlockBits(bitmapData);


                return src;
            }
            catch (Exception e) { return src; }
        }


        public static ColorPalette GenerateGrayscalePalette(Image img)
        {
           
                ColorPalette palette = img.Palette;
                for (int i = 0; i < 256; i++)
                {
                    palette.Entries[i] = Color.FromArgb(i, i, i);
                }
                return palette;
            
        }
    }
}
