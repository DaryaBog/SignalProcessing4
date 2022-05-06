using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Emgu;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace SignalProcessing4
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> inputImage = null;
        private Image<Bgr, byte> inputImageBin = null;
        private Random _rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputImage = new Image<Bgr, byte>(openFileDialog1.FileName);
                    inputImageBin = new Image<Bgr, byte>(openFileDialog1.FileName);

                    pictureBox1.Image = inputImage.Bitmap;
                }
                else
                {
                    MessageBox.Show("Файл не выбран", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunProcessing(Bitmap bitmap) 
        {
            var pixels = GetPixels(bitmap);
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
            Bitmap newBmp = new Bitmap(outputImage.Width, outputImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            foreach (var pixel in pixels)
            {
                int pixelFilterR = (int)(pixel.Color.R * 0.30);
                int pixelFilterB = (int)(pixel.Color.B * 0.11);
                int pixelFilterG = (int)(pixel.Color.G * 0.59);
               // var colorFilter = pixel.Color(pixelFilterR + pixelFilterB + pixelFilterG);
                newBmp.SetPixel(pixel.Point.X, pixel.Point.Y, Color.FromArgb(pixelFilterR, pixelFilterB, pixelFilterG));
                //outputImage.Convert.bitmap(pixel.Point.X, pixel.Point.Y);
            }
            
            pictureBox2.Image = newBmp;
            inputImageBin.Bitmap = newBmp;
        }
        private void RunProcessingBinary(Bitmap bitmap)
        {
            var pixels = GetPixels(bitmap);
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
            Bitmap newBmp = new Bitmap(outputImage.Width, outputImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            foreach (var pixel in pixels)
            {
                int pixelFilterR;
                int pixelFilterB;
                int pixelFilterG;
                if (pixel.Color.R > 50) 
                { 
                    pixelFilterR = 0;
                }
                else
                {
                    pixelFilterR = 255;
                }
                if (pixel.Color.G> 200)
                {
                    pixelFilterG = 0;
                }
                else
                {
                    pixelFilterG = 255;
                }
                if (pixel.Color.B > 10)
                {
                    pixelFilterB = 0;
                }
                else
                {
                    pixelFilterB = 255;
                }

                // var colorFilter = pixel.Color(pixelFilterR + pixelFilterB + pixelFilterG);
                newBmp.SetPixel(pixel.Point.X, pixel.Point.Y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                //outputImage.Convert.bitmap(pixel.Point.X, pixel.Point.Y);
            }

            pictureBox2.Image = newBmp;
        }

        private void RunProcessingNegative(Bitmap bitmap)
        {
            var pixels = GetPixels(bitmap);
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
            Bitmap newBmp = new Bitmap(outputImage.Width, outputImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            foreach (var pixel in pixels)
            {
                int pixelFilterR = (int)(255-pixel.Color.R);
                int pixelFilterB = (int)(255-pixel.Color.B);
                int pixelFilterG = (int)(255-pixel.Color.G);
                // var colorFilter = pixel.Color(pixelFilterR + pixelFilterB + pixelFilterG);
                newBmp.SetPixel(pixel.Point.X, pixel.Point.Y, Color.FromArgb(pixelFilterR, pixelFilterB, pixelFilterG));
                //outputImage.Convert.bitmap(pixel.Point.X, pixel.Point.Y);
            }

            pictureBox2.Image = newBmp;
        }

        private void RunProcessingLog(Bitmap bitmap)
        {
            var pixels = GetPixels(bitmap);
            Image<Gray, byte> outputImage = new Image<Gray, byte>(inputImage.Width, inputImage.Height, new Gray(0));
            Bitmap newBmp = new Bitmap(outputImage.Width, outputImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            foreach (var pixel in pixels)
            {
                int c = 50;
                int pixelFilterR = (int)(c * Math.Log10(1 + pixel.Color.R));
                int pixelFilterB = (int)(c * Math.Log10(1 + pixel.Color.B));
                int pixelFilterG = (int)(c * Math.Log10(1 + pixel.Color.G));
                newBmp.SetPixel(pixel.Point.X, pixel.Point.Y, Color.FromArgb(pixelFilterR, pixelFilterB, pixelFilterG));
            }

            pictureBox2.Image = newBmp;
        }

        /// /////
        /// 
        // Lab 5

        private void RunProcessingNCh1(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (1 * clr11.R + 1 * clr12.R + 1 * clr13.R + 1 * clr21.R + 1 * clr22.R + 1 * clr23.R + 1 * clr31.R + 1 * clr32.R + 1 * clr33.R) / 9;
                    pixelFilterG = (1 * clr11.G + 1 * clr12.G + 1 * clr13.G + 1 * clr21.G + 1 * clr22.G + 1 * clr23.G + 1 * clr31.G + 1 * clr32.G + 1 * clr33.G) / 9;
                    pixelFilterB = (1 * clr11.B + 1 * clr12.B + 1 * clr13.B + 1 * clr21.B + 1 * clr22.B + 1 * clr23.B + 1 * clr31.B + 1 * clr32.B + 1 * clr33.B) / 9;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //
        private void RunProcessingNCh2(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (1 * clr11.R + 1 * clr12.R + 1 * clr13.R + 1 * clr21.R + 2 * clr22.R + 1 * clr23.R + 1 * clr31.R + 1 * clr32.R + 1 * clr33.R) / 10;
                    pixelFilterG = (1 * clr11.G + 1 * clr12.G + 1 * clr13.G + 1 * clr21.G + 2 * clr22.G + 1 * clr23.G + 1 * clr31.G + 1 * clr32.G + 1 * clr33.G) / 10;
                    pixelFilterB = (1 * clr11.B + 1 * clr12.B + 1 * clr13.B + 1 * clr21.B + 2 * clr22.B + 1 * clr23.B + 1 * clr31.B + 1 * clr32.B + 1 * clr33.B) / 10;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }
        //
        private void RunProcessingNCh3(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (1 * clr11.R + 2 * clr12.R + 1 * clr13.R + 2 * clr21.R + 4 * clr22.R + 2 * clr23.R + 1 * clr31.R + 2 * clr32.R + 1 * clr33.R) / 16;
                    pixelFilterG = (1 * clr11.G + 2 * clr12.G + 1 * clr13.G + 2 * clr21.G + 4 * clr22.G + 2 * clr23.G + 1 * clr31.G + 2 * clr32.G + 1 * clr33.G) / 16;
                    pixelFilterB = (1 * clr11.B + 2 * clr12.B + 1 * clr13.B + 2 * clr21.B + 4 * clr22.B + 2 * clr23.B + 1 * clr31.B + 2 * clr32.B + 1 * clr33.B) / 16;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //

        private void RunProcessingMed(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;

                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    List<int> clrR = new List<int>() { clr11.R, clr12.R, clr13.R, clr21.R, clr22.R, clr23.R, clr31.R, clr32.R, clr33.R };
                    List<int> clrB = new List<int>() { clr11.B, clr12.B, clr13.B, clr21.B, clr22.B, clr23.B, clr31.B, clr32.B, clr33.B };
                    List<int> clrG = new List<int>() { clr11.G, clr12.G, clr13.G, clr21.G, clr22.G, clr23.G, clr31.G, clr32.G, clr33.G };

                    clrR.Sort();
                    clrG.Sort();
                    clrB.Sort();

                    pixelFilterR = clrR[4];
                    pixelFilterG = clrG[4];
                    pixelFilterB = clrB[4];

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //  vCh

        private void RunProcessingH4(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (0 * clr11.R + (-1) * clr12.R + 0 * clr13.R + (-1) * clr21.R + 5 * clr22.R + (-1) * clr23.R + 0 * clr31.R + (-1) * clr32.R + 0 * clr33.R);
                    pixelFilterG = (0 * clr11.G + (-1) * clr12.G + 0 * clr13.G + (-1) * clr21.G + 5 * clr22.G + (-1) * clr23.G + 0 * clr31.G + (-1) * clr32.G + 0 * clr33.G);
                    pixelFilterB = (0 * clr11.B + (-1) * clr12.B + 0 * clr13.B + (-1) * clr21.B + 5 * clr22.B + (-1) * clr23.B + 0 * clr31.B + (-1) * clr32.B + 0 * clr33.B);
                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;
                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //


        private void RunProcessingH5(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = ((-1) * clr11.R + (-1) * clr12.R + (-1) * clr13.R + (-1) * clr21.R + 9 * clr22.R + (-1) * clr23.R + (-1) * clr31.R + (-1) * clr32.R + (-1) * clr33.R);
                    pixelFilterG = ((-1) * clr11.G + (-1) * clr12.G + (-1) * clr13.G + (-1) * clr21.G + 9 * clr22.G + (-1) * clr23.G + (-1) * clr31.G + (-1) * clr32.G + (-1) * clr33.G);
                    pixelFilterB = ((-1) * clr11.B + (-1) * clr12.B + (-1) * clr13.B + (-1) * clr21.B + 9 * clr22.B + (-1) * clr23.B + (-1) * clr31.B + (-1) * clr32.B + (-1) * clr33.B);

                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //

        private void RunProcessingH6(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;


                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (1 * clr11.R + (-2) * clr12.R + 1 * clr13.R + (-2) * clr21.R + 5 * clr22.R + (-2) * clr23.R + 1 * clr31.R + (-2) * clr32.R + 1 * clr33.R);
                    pixelFilterG = (1 * clr11.G + (-2) * clr12.G + 1 * clr13.G + (-2) * clr21.G + 5 * clr22.G + (-2) * clr23.G + 1 * clr31.G + (-2) * clr32.G + 1 * clr33.G);
                    pixelFilterB = (1 * clr11.B + (-2) * clr12.B + 1 * clr13.B + (-2) * clr21.B + 5 * clr22.B + (-2) * clr23.B + 1 * clr31.B + (-2) * clr32.B + 1 * clr33.B);

                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //
        
        private void RunProcessingH7(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;

                    int U = Convert.ToInt32(uBox.Text);

                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (0 * clr11.R + (-1) * clr12.R + 0 * clr13.R + (-1) * clr21.R + (U + 4) * clr22.R + (-1) * clr23.R + 0 * clr31.R + (-1) * clr32.R + 0 * clr33.R);
                    pixelFilterG = (0 * clr11.G + (-1) * clr12.G + 0 * clr13.G + (-1) * clr21.G + (U + 4) * clr22.G + (-1) * clr23.G + 0 * clr31.G + (-1) * clr32.G + 0 * clr33.G);
                    pixelFilterB = (0 * clr11.B + (-1) * clr12.B + 0 * clr13.B + (-1) * clr21.B + (U + 4) * clr22.B + (-1) * clr23.B + 0 * clr31.B + (-1) * clr32.B + 0 * clr33.B);

                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //

        private void RunProcessingH8(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;

                    int U = Convert.ToInt32(uBox.Text);

                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = ((-1) * clr11.R + (-1) * clr12.R + (-1) * clr13.R + (-1) * clr21.R + (U + 8) * clr22.R + (-1) * clr23.R + (-1) * clr31.R + (-1) * clr32.R + (-1) * clr33.R);
                    pixelFilterG = ((-1) * clr11.G + (-1) * clr12.G + (-1) * clr13.G + (-1) * clr21.G + (U + 8) * clr22.G + (-1) * clr23.G + (-1) * clr31.G + (-1) * clr32.G + (-1) * clr33.G);
                    pixelFilterB = ((-1) * clr11.B + (-1) * clr12.B + (-1) * clr13.B + (-1) * clr21.B + (U + 8) * clr22.B + (-1) * clr23.B + (-1) * clr31.B + (-1) * clr32.B + (-1) * clr33.B);

                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }

        //

        private void RunProcessingH9(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(bitmap.Width + 2, bitmap.Height + 2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    newBmp.SetPixel(x, y, bitmap.GetPixel(x - 1, y - 1));
                }
            }
            for (int y = 1; y < newBmp.Height - 1; y++)
            {
                for (int x = 1; x < newBmp.Width - 1; x++)
                {
                    Color clr = newBmp.GetPixel(x, y);
                    int pixelFilterR;
                    int pixelFilterB;
                    int pixelFilterG;

                    int U = Convert.ToInt32(uBox.Text);

                    Color clr11 = newBmp.GetPixel(x - 1, y - 1);
                    Color clr12 = newBmp.GetPixel(x, y - 1);
                    Color clr13 = newBmp.GetPixel(x + 1, y - 1);

                    Color clr21 = newBmp.GetPixel(x - 1, y);
                    Color clr22 = newBmp.GetPixel(x, y);
                    Color clr23 = newBmp.GetPixel(x + 1, y);

                    Color clr31 = newBmp.GetPixel(x - 1, y + 1);
                    Color clr32 = newBmp.GetPixel(x, y + 1);
                    Color clr33 = newBmp.GetPixel(x + 1, y + 1);

                    pixelFilterR = (1 * clr11.R + (-2) * clr12.R + 1 * clr13.R + (-2) * clr21.R + (U + 4) * clr22.R + (-2) * clr23.R + 1 * clr31.R + (-2) * clr32.R + 1 * clr33.R);
                    pixelFilterG = (1 * clr11.G + (-2) * clr12.G + 1 * clr13.G + (-2) * clr21.G + (U + 4) * clr22.G + (-2) * clr23.G + 1 * clr31.G + (-2) * clr32.G + 1 * clr33.G);
                    pixelFilterB = (1 * clr11.B + (-2) * clr12.B + 1 * clr13.B + (-2) * clr21.B + (U + 4) * clr22.B + (-2) * clr23.B + 1 * clr31.B + (-2) * clr32.B + 1 * clr33.B);

                    if (pixelFilterG > 255) pixelFilterG = 255;
                    if (pixelFilterR > 255) pixelFilterR = 255;
                    if (pixelFilterB > 255) pixelFilterB = 255;
                    if (pixelFilterG < 0) pixelFilterG = 0;
                    if (pixelFilterR < 0) pixelFilterR = 0;
                    if (pixelFilterB < 0) pixelFilterB = 0;

                    newBmp.SetPixel(x, y, Color.FromArgb(pixelFilterR, pixelFilterG, pixelFilterB));
                }
            }
            pictureBox2.Image = newBmp;
        }
        ///////
        private void RunProcessingNoise(Bitmap bitmap)
        {
            var pixels = GetPixels(bitmap);
            var pixelProc = ((bitmap.Width * bitmap.Height) / 100)*5;

            for(int i = 0; i < pixelProc; i++)
            {
                var index = _rnd.Next(pixels.Count);
                pixels[index].Color = Color.Black;

            }
            var currentBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            foreach (var pixel in pixels)
                currentBitmap.SetPixel(pixel.Point.X, pixel.Point.Y, pixel.Color);
            pictureBox1.Image = currentBitmap;
        }
        /// <summary>
        /// ///////////////
        /// </summary>


        private List<Pixel> GetPixels(Bitmap bitmap) 
        {
            var pixels = new List<Pixel>(bitmap.Width*bitmap.Height);
            for (int y = 0; y < bitmap.Height; y++)//значения по вертикали
            {
                for (int x = 0; x < bitmap.Width; x++)//значения по горизонтали
                {
                    pixels.Add(new Pixel()
                    {
                        Color = bitmap.GetPixel(x, y),
                        Point = new Point() {X = x, Y = y }
                    });
                }
            }
            return pixels;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void найтиКонтурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                Image<Gray, byte> outputImage = inputImage.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));

                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(outputImage, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                CvInvoke.DrawContours(inputImage, contours, -1, new MCvScalar(255, 0, 0));
                pictureBox2.Image = inputImage.Bitmap;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int R, G, B;
                var bitmap = inputImage.Bitmap;
                RunProcessing(bitmap);
                for (int y = 0; y < bitmap.Height; y++)//значения по вертикали
                {
                    for (int x = 0; x < 3*bitmap.Width; x++)//значения по горизонтали
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void чБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var bitmap = inputImageBin.Bitmap;
                RunProcessingBinary(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void негативToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = inputImageBin.Bitmap;
            RunProcessingNegative(bitmap);
        }

        private void логПреобразованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = inputImage.Bitmap;
            RunProcessingLog(bitmap);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void нЧToolStripMenuItem_Click(object sender, EventArgs e)
        {

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void шумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = inputImage.Bitmap;
            RunProcessingNoise(bitmap);
        }

        private void h3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingNCh3(bitmap);
        }

        private void h1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingNCh1(bitmap);
        }

        private void h2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingNCh2(bitmap);
        }

        private void медианныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingMed(bitmap);
        }

        private void маскаH4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH4(bitmap);
        }

        private void маскаH5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH5(bitmap);
        }

        private void маскаH6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH6(bitmap);
        }

        private void маскаH7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH7(bitmap);
        }

        private void маскаH8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH8(bitmap);
        }

        private void маскаH9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(pictureBox1.Image);
            RunProcessingH9(bitmap);
        }
    }
}
