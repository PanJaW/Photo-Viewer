using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Emgu.Util;
using Emgu.CV.Util;


namespace FizykaObrazu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Crop_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(ImageX.Text);
            int y = Int32.Parse(ImageY.Text);
            int width = Int32.Parse(ImageChangedX.Text);
            int height = Int32.Parse(ImageChangedY.Text);
            Rectangle cropRect = new Rectangle(x, y, width, height);
            Bitmap NewImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = NewImage.Clone(cropRect, NewImage.PixelFormat);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackbarValue.Text = trackBar1.Value.ToString();
            if (pictureBox2 != null)
            {
                Bitmap NewImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                PointF offset = new PointF((float)pictureBox1.Image.Width / 2, (float)pictureBox1.Image.Height / 2);
                NewImage.SetResolution(pictureBox1.Image.HorizontalResolution, pictureBox1.Image.VerticalResolution);
                Graphics g = Graphics.FromImage(NewImage);
                g.TranslateTransform(offset.X, offset.Y);
                g.RotateTransform(trackBar1.Value);
                g.TranslateTransform(-offset.X, -offset.Y);
                g.DrawImage(pictureBox1.Image, new PointF(0, 0));
                pictureBox2.Image = NewImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackbar2Value.Text = trackBar2.Value.ToString();
            if (pictureBox2 != null)
            {
                Bitmap NewImage = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                Graphics g = Graphics.FromImage(NewImage);
                g.ScaleTransform(trackBar2.Value, trackBar2.Value);
                g.DrawImage(pictureBox1.Image, new PointF(0, 0));
                pictureBox2.Image = NewImage;
            }
        }

        private void ColorTransformation_Click(object sender, EventArgs e)
        {
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    if (comboBox1.SelectedItem == "grayscale1")
                    {
                        int colorAll = Convert.ToInt32((float)(r + g + b) / 3);
                        outputImg.SetPixel(x, y, Color.FromArgb(a, colorAll, colorAll, colorAll));

                    }
                    else if (comboBox1.SelectedItem == "grayscale2")
                    {
                        int colorAll = Convert.ToInt32((float)0.299 * r + (float)0.587 * g + (float)0.114 * b);
                        outputImg.SetPixel(x, y, Color.FromArgb(a, colorAll, colorAll, colorAll));
                    }
                    else if (comboBox1.SelectedItem == "grayscale3")
                    {
                        int colorAll = Convert.ToInt32((float)0.11 * r + (float)0.59 * g + (float)0.3 * b);
                        outputImg.SetPixel(x, y, Color.FromArgb(a, colorAll, colorAll, colorAll));
                    }
                    else if (comboBox1.SelectedItem == "sepia")
                    {
                        int r1 = Convert.ToInt32((float)0.393 * r + (float)0.769 * g + (float)0.189 * b);
                        int g1 = Convert.ToInt32((float)0.349 * r + (float)0.686 * g + (float)0.168 * b);
                        int b1 = Convert.ToInt32((float)0.272 * r + (float)0.534 * g + (float)0.131 * b);
                        if (r1 > 255)
                        {
                            r1 = 255;
                        }
                        if (g1 > 255)
                        {
                            g1 = 255;
                        }
                        if (b1 > 255)
                        {
                            b1 = 255;
                        }
                        outputImg.SetPixel(x, y, Color.FromArgb(a, r1, g1, b1));

                    }
                    else if (comboBox1.SelectedItem == "negatyw")
                    {
                        int r1 = 255 - r;
                        int g1 = 255 - g;
                        int b1 = 255 - b;
                        outputImg.SetPixel(x, y, Color.FromArgb(a, r1, g1, b1));
                    }
                    else if (comboBox1.SelectedItem == "magic")
                    {
                        int colorAll = Convert.ToInt32((float)(r + g + b) / 3);
                        int r1 = 255 - colorAll;
                        int g1 = 255 - colorAll;
                        int b1 = 255 - colorAll;
                        outputImg.SetPixel(x, y, Color.FromArgb(a, r1, g1, b1));
                    }

                }
            }
            pictureBox2.Image = outputImg;
        }

        private void gammaCorrection_Scroll(object sender, EventArgs e)
        {
            float GV = (float)gammaCorrection.Value / 10;
            double GV2 = Convert.ToDouble(GV);
            gammaValue.Text = GV.ToString();
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    double r1 = (255 * Math.Pow(r / 255.0, 1 / GV));
                    double g1 = (255 * Math.Pow(g / 255.0, 1 / GV));
                    double b1 = (255 * Math.Pow(b / 255.0, 1 / GV));
                    int r11 = Convert.ToInt32(r1);
                    int g11 = Convert.ToInt32(g1);
                    int b11 = Convert.ToInt32(b1);
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r11, g11, b11));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void binTransformation_Scroll(object sender, EventArgs e)
        {
            binValue.Text = binTransformation.Value.ToString();
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    if ((r + g + b) > binTransformation.Value)
                    {
                        if (binColorUp.SelectedItem == "Czarny")
                        {
                            r = 255;
                            g = 255;
                            b = 255;
                        }
                        else if (binColorUp.SelectedItem == "Bialy")
                        {
                            r = 0;
                            b = 0;
                            g = 0;
                        }
                        else if (binColorUp.SelectedItem == "Czerwony")
                        {
                            r = 255;
                            g = 0;
                            b = 0;
                        }
                        else if (binColorUp.SelectedItem == "Zielony")
                        {
                            r = 0;
                            g = 255;
                            b = 0;

                        }
                        else if (binColorUp.SelectedItem == "Niebieski")
                        {
                            r = 0;
                            g = 0;
                            b = 255;
                        }

                    }
                    else if ((r + g + b) <= binTransformation.Value)
                    {
                        if (binColorUp.SelectedItem == "Czarny")
                        {
                            r = 255;
                            g = 255;
                            b = 255;
                        }
                        else if (binColorUp.SelectedItem == "Bialy")
                        {
                            r = 0;
                            b = 0;
                            g = 0;
                        }
                        else if (binColorUp.SelectedItem == "Czerwony")
                        {
                            r = 255;
                            g = 0;
                            b = 0;
                        }
                        else if (binColorUp.SelectedItem == "Zielony")
                        {
                            r = 0;
                            g = 255;
                            b = 0;

                        }
                        else if (binColorUp.SelectedItem == "Niebieski")
                        {
                            r = 0;
                            g = 0;
                            b = 255;
                        }
                    }
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    if (comboBox2.SelectedItem == "onlyR")
                    {
                        outputImg.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    }
                    else if (comboBox2.SelectedItem == "onlyG")
                    {
                        outputImg.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    }
                    else if (comboBox2.SelectedItem == "onlyB")
                    {
                        outputImg.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            double contrast = Math.Pow((100.0 + trackBar3.Value) / 100, 2);
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    double r1 = ((((r / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    double g1 = ((((g / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    double b1 = ((((b / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    if (r1 > 255)
                    {
                        r1 = 255;
                    }
                    if (g1 > 255)
                    {
                        g1 = 255;
                    }
                    if (b1 > 255)
                    {
                        b1 = 255;
                    }
                    if (r1 < 0)
                    {
                        r1 = 0;
                    }
                    if (g1 < 0)
                    {
                        g1 = 0;
                    }
                    if (b1 < 0)
                    {
                        b1 = 0;
                    }
                    int r11 = Convert.ToInt32(r1);
                    int g11 = Convert.ToInt32(g1);
                    int b11 = Convert.ToInt32(b1);
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r11, g11, b11));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void trackBarJasnosc_Scroll(object sender, EventArgs e)
        {
            double percent = trackBarJasnosc.Value;
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    percent = 100 - trackBarJasnosc.Value;
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    double r1 = Math.Round((double)r * (percent - 1.0) / 100.0) + Math.Round(255.0 - percent / 100.0 * 255.0);
                    double g1 = Math.Round((double)g * (percent - 1.0) / 100.0) + Math.Round(255.0 - percent / 100.0 * 255.0);
                    double b1 = Math.Round((double)b * (percent - 1.0) / 100.0) + Math.Round(255.0 - percent / 100.0 * 255.0);
                    if (r1 > 255)
                    {
                        r1 = 255;
                    }
                    if (g1 > 255)
                    {
                        g1 = 255;
                    }
                    if (b1 > 255)
                    {
                        b1 = 255;
                    }
                    if (r1 < 0)
                    {
                        r1 = 0;
                    }
                    if (g1 < 0)
                    {
                        g1 = 0;
                    }
                    if (b1 < 0)
                    {
                        b1 = 0;
                    }
                    int r11 = Convert.ToInt32(r1);
                    int g11 = Convert.ToInt32(g1);
                    int b11 = Convert.ToInt32(b1);
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r11, g11, b11));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void trackBarCiemnosc_Scroll(object sender, EventArgs e)
        {
            double percent = trackBarCiemnosc.Value;
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < cloneImg.Height; y++)
            {
                for (int x = 0; x < cloneImg.Width; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = colorPixel.R;
                    int g = colorPixel.G;
                    int b = colorPixel.B;
                    double r1 = r - Math.Round(r * percent / 100);
                    double g1 = g - Math.Round(g * percent / 100);
                    double b1 = b - Math.Round(b * percent / 100);
                    if (r1 > 255)
                    {
                        r1 = 255;
                    }
                    if (g1 > 255)
                    {
                        g1 = 255;
                    }
                    if (b1 > 255)
                    {
                        b1 = 255;
                    }
                    if (r1 < 0)
                    {
                        r1 = 0;
                    }
                    if (g1 < 0)
                    {
                        g1 = 0;
                    }
                    if (b1 < 0)
                    {
                        b1 = 0;
                    }
                    int r11 = Convert.ToInt32(r1);
                    int g11 = Convert.ToInt32(g1);
                    int b11 = Convert.ToInt32(b1);
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r11, g11, b11));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBox1.Image = bit;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    width.Text = pictureBox1.Width.ToString();
                    height.Text = pictureBox1.Height.ToString();
                    imageResH.Text = bit.HorizontalResolution.ToString();
                    imageResW.Text = bit.VerticalResolution.ToString();
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                pictureBox1.Image.Save(@"C:\Users\nt22\Desktop\fizyka obrazu\obrazki\1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                pictureBox1.Image.Save(@"C:\Users\nt22\Desktop\fizyka obrazu\obrazki\2.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(save.FileName);
            }
        }

        private void openInBothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {

                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBox1.Image = bit;
                    pictureBox2.Image = bit;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    width.Text = pictureBox1.Width.ToString();
                    height.Text = pictureBox1.Height.ToString();
                    imageResH.Text = bit.HorizontalResolution.ToString();
                    imageResW.Text = bit.VerticalResolution.ToString();

                    FileInfo fileinfo = new FileInfo(open.FileName);

                    ImageDescription.Items.Clear();
                    ImageDescription2.Items.Clear();

                    ImageDescription.Items.Add("Nazwa pliku: " + fileinfo.Name);
                    ImageDescription.Items.Add("Rozmiar pliku: " + fileinfo.Length);
                    ImageDescription.Items.Add("Nazwa katalogu: " + fileinfo.DirectoryName);
                    ImageDescription.Items.Add("Rozszerzenie/format: " + fileinfo.Extension);
                    ImageDescription.Items.Add("Atrybuty: " + fileinfo.Attributes);
                    ImageDescription.Items.Add("Data utworzenia: " + fileinfo.CreationTime);
                    ImageDescription.Items.Add("Data dostępu: " + fileinfo.LastAccessTime);
                    ImageDescription.Items.Add("Data ostatniej modyfikacji: " + fileinfo.LastWriteTime);

                    ImageDescription2.Items.Add("Nazwa pliku: " + fileinfo.Name);
                    ImageDescription2.Items.Add("Rozmiar pliku: " + fileinfo.Length);
                    ImageDescription2.Items.Add("Nazwa katalogu: " + fileinfo.DirectoryName);
                    ImageDescription2.Items.Add("Rozszerzenie/format: " + fileinfo.Extension);
                    ImageDescription2.Items.Add("Atrybuty: " + fileinfo.Attributes);
                    ImageDescription2.Items.Add("Data utworzenia: " + fileinfo.CreationTime);
                    ImageDescription2.Items.Add("Data dostępu: " + fileinfo.LastAccessTime);
                    ImageDescription2.Items.Add("Data ostatniej modyfikacji: " + fileinfo.LastWriteTime);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    pictureBox2.Image = bit;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


                    FileInfo fileinfo = new FileInfo(open.FileName);

                    ImageDescription2.Items.Clear();

                    ImageDescription2.Items.Add("Nazwa pliku: " + fileinfo.Name);
                    ImageDescription2.Items.Add("Rozmiar pliku: " + fileinfo.Length);
                    ImageDescription2.Items.Add("Nazwa katalogu: " + fileinfo.DirectoryName);
                    ImageDescription2.Items.Add("Rozszerzenie/format: " + fileinfo.Extension);
                    ImageDescription2.Items.Add("Atrybuty: " + fileinfo.Attributes);
                    ImageDescription2.Items.Add("Data utworzenia: " + fileinfo.CreationTime);
                    ImageDescription2.Items.Add("Data dostępu: " + fileinfo.LastAccessTime);
                    ImageDescription2.Items.Add("Data ostatniej modyfikacji: " + fileinfo.LastWriteTime);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void rotateXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2 != null)
            {
                Bitmap NewImage = new Bitmap(pictureBox2.Image);
                NewImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox2.Image = NewImage;
            }
        }

        private void rotateYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2 != null)
            {
                Bitmap NewImage = new Bitmap(pictureBox2.Image);
                NewImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox2.Image = NewImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);

            int num11 = Convert.ToInt32(matrix11.Text);
            int num12 = Convert.ToInt32(matrix12.Text);
            int num13 = Convert.ToInt32(matrix13.Text);
            int num21 = Convert.ToInt32(matrix21.Text);
            int num22 = Convert.ToInt32(matrix22.Text);
            int num23 = Convert.ToInt32(matrix23.Text);
            int num31 = Convert.ToInt32(matrix31.Text);
            int num32 = Convert.ToInt32(matrix32.Text);
            int num33 = Convert.ToInt32(matrix33.Text);
            int[,] w = new int[,] { { num11, num12, num13 }, { num21, num22, num23 }, { num31, num32, num33 } };
            int sum = num11 + num12 + num13 + num21 + num22 + num23 + num31 + num32 + num33;
            if (sum == 0)
            {
                sum = 1;
            }

            for (int y = 1; y < cloneImg.Height - 1; y++)
            {
                for (int x = 1; x < cloneImg.Width - 1; x++)
                {
                    Color colorPixel = cloneImg.GetPixel(x, y);
                    int a = colorPixel.A;
                    int r = 0;
                    int g = 0;
                    int b = 0;

                    for (int hw = -1; hw < 2; hw++)
                    {
                        for (int wi = -1; wi < 2; wi++)
                        {
                            r += cloneImg.GetPixel(x + hw, y + wi).R * w[hw + 1, wi + 1];
                            g += cloneImg.GetPixel(x + hw, y + wi).G * w[hw + 1, wi + 1];
                            b += cloneImg.GetPixel(x + hw, y + wi).B * w[hw + 1, wi + 1];
                        }
                    }
                    r = r / sum;
                    g = g / sum;
                    b = b / sum;
                    if (r > 255)
                        r = 255;
                    if (g > 255)
                        g = 255;
                    if (b > 255)
                        b = 255;
                    if (r < 0)
                        r = 0;
                    if (g < 0)
                        g = 0;
                    if (b < 0)
                        b = 0;
                    int r1 = Convert.ToInt32(r);
                    int g1 = Convert.ToInt32(g);
                    int b1 = Convert.ToInt32(b);
                    outputImg.SetPixel(x, y, Color.FromArgb(a, r1, g1, b1));
                }
            }
            pictureBox2.Image = outputImg;
        }

        private void houghTransformToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Bitmap cloneImg = new Bitmap(pictureBox1.Image);
            Bitmap outputImg = new Bitmap(pictureBox1.Image);
            Image<Bgr, Byte> img = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);

            //grayscale conversion and noise filtering
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);

            UMat pyrDown = new UMat();
            CvInvoke.PyrDown(uimage, pyrDown);
            CvInvoke.PyrUp(pyrDown, uimage);

            //circle detection
            double minDist = f2.minDist;
            double cannyThreshold = f2.param1;
            double circleAccumulatorThreshold = f2.param2;
            CircleF[] circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, minDist, cannyThreshold, circleAccumulatorThreshold, f2.minRadius, f2.maxRadius);



            //edge detection
            double cannyThresholdLinking = 100.0;
            UMat cannyEdges = new UMat();
            CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);
            double rho = f2.rho;
            double theta = f2.theta;
            int treshold = f2.treshold;
            double minLineWidth = f2.minLineWidth;
            double maxGap = f2.maxGap;

            LineSegment2D[] lines = CvInvoke.HoughLinesP(cannyEdges, rho, Math.PI / theta, treshold, minLineWidth, maxGap);

            //find triangles and rectangles
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<RotatedRect> boxList = new List<RotatedRect>(); 

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                int count = contours.Size;
                for (int i = 0; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    using (VectorOfPoint approxContour = new VectorOfPoint())
                    {
                        CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                        if (CvInvoke.ContourArea(approxContour, false) > 200)
                        {
                            if (approxContour.Size == 3) 
                            {
                                Point[] pts = approxContour.ToArray();
                                triangleList.Add(new Triangle2DF(
                                   pts[0],
                                   pts[1],
                                   pts[2]
                                   ));
                            }
                            else if (approxContour.Size == 4) 
                            {
                                bool isRectangle = true;
                                Point[] pts = approxContour.ToArray();
                                LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                                for (int j = 0; j < edges.Length; j++)
                                {
                                    double angle = Math.Abs(
                                       edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
                                    if (angle < 80 || angle > 100)
                                    {
                                        isRectangle = false;
                                        break;
                                    }
                                }

                                if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
                            }
                        }
                    }
                }
            }
            //drawning rectangles, triangles and circles
            Image<Bgr, Byte> triangleRectangleCircleImage = img;
            foreach (Triangle2DF triangle in triangleList)
                triangleRectangleCircleImage.Draw(triangle, new Bgr(Color.DarkBlue), 5);
            foreach (RotatedRect box in boxList)
                triangleRectangleCircleImage.Draw(box, new Bgr(Color.DarkOrange), 5);
            foreach (CircleF circle in circles)
                triangleRectangleCircleImage.Draw(circle, new Bgr(Color.Brown), 5);
            pictureBox2.Image = triangleRectangleCircleImage.ToBitmap();
        }

    }
}
