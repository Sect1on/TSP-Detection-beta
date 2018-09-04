using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;


namespace TSP_Detection
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> frame1 = new Image<Bgr, byte>(@"..\..\..\Pictures\demo3-3.jpg");//从文件加载图片
        Image<Bgr, byte> frame2 = new Image<Bgr, byte>(@"..\..\..\Pictures\demo3-3.jpg");//从文件加载图片
        Image<Bgr, byte> histpic = new Image<Bgr, byte>(1930, 100, new Bgr(255, 255, 255));
        Image<Bgr, byte> grayhistpic = new Image<Bgr, byte>(1930, 306, new Bgr(255, 255, 255));

        public void SetRoiRed(Image<Bgr, byte> image, Rectangle roi)//ROI选取函数
        {
            image.ROI = roi;
            //image.ROI = Rectangle.Empty;
        }

        public void startpoints(Image<Bgr, byte> image1, Image<Bgr, byte> image2)
        {
            int n1, n2, gray1, gray2, gray3;
            int average = 0;
            int[] graygrads = new int[1920];
            int[] gray = new int[1920];
            int calnumber1 = 0;
            int calnumber2 = 0;
            int calsum1 = 0;
            int calsum2 = 0;
            int caltranfer1 = 0;
            int caltranfer2 = 0;

            //picOrigin.Image = image2.Bitmap;
            image2.Draw(new Rectangle(450, 1037, 1050, 40), new Bgr(Color.FromArgb(255, Color.Blue)), 3);
            SetRoiRed(image1, new Rectangle(450, 1037, 1050, 40));
            picROI.Image = image1.Bitmap;
            var grayImage = image1.Convert<Gray, Byte>();
            picGray.Image = grayImage.Bitmap;

            for (n1 = 0; n1 < 1045; n1++)
            {
                gray1 = 0;
                gray2 = 0;
                for (n2 = 0; n2 < 40; n2++)
                {
                    //灰度值计算
                    Color pix1 = image1.Bitmap.GetPixel(n1, n2);
                    Color pix2 = image1.Bitmap.GetPixel(n1 + 1, n2);
                    gray1 = gray1 + (int)(pix1.R * 0.30 + pix1.G * 0.59 + pix1.B * 0.11);
                    gray2 = gray2 + (int)(pix2.R * 0.30 + pix2.G * 0.59 + pix2.B * 0.11);
                }
                gray1 = gray1 / 20;
                gray2 = gray2 / 20;
                //梯度计算
                gray1 = Math.Abs(gray1 - gray2);
                graygrads[n1] = gray1;
                average = average + gray1;

            }

            average = average / 1045 + 1;
            for (n1 = 0; n1 < 1044; n1++)
            {
                if (graygrads[n1] <= average)
                {
                    graygrads[n1] = 0;
                }
                else
                {
                    continue;
                }
            }

            for (n1 = 0; n1 < 958; n1++)
            {
                caltranfer1 = 0;
                for (n2 = 0; n2 < 80; n2++)
                {
                    caltranfer1 = caltranfer1 + graygrads[n1 + n2];
                }
                if (caltranfer1 > calsum1)
                {
                    calsum1 = caltranfer1;
                    calnumber1 = n1;
                }
                else
                {
                    continue;
                }
            }

            for (n1 = 958; n1 < 1835; n1++)
            {
                caltranfer2 = 0;
                for (n2 = 0; n2 < 10; n2++)
                {
                    caltranfer2 = caltranfer2 + graygrads[n1 + n2];
                }
                if (caltranfer2 > calsum2)
                {
                    calsum2 = caltranfer2;
                    calnumber2 = n1;
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < 1915; i++)
            {
                histpic.Draw(new Rectangle(i, 100 - graygrads[i] * 4, 1, graygrads[i] * 4), new Bgr(Color.FromArgb(255, Color.Blue)), 1);
            }

            histpic.Draw(new Rectangle(calnumber1, 2, 80, 98), new Bgr(Color.FromArgb(255, Color.Red)), 5);
            histpic.Draw(new Rectangle(calnumber2, 2, 80, 98), new Bgr(Color.FromArgb(255, Color.Red)), 5);

            image2.Draw(new Rectangle(calnumber1 + 450, 1040, 80, 40), new Bgr(Color.FromArgb(255, Color.Red)), 5);
            image2.Draw(new Rectangle(calnumber2 + 100, 1040, 80, 40), new Bgr(Color.FromArgb(255, Color.Red)), 5);

            picOrigin.Image = image2.Bitmap;


            for (n1 = 0; n1 < 1045; n1++)
            {
                gray3 = 0;
                //Color pix3 = image1.Bitmap.GetPixel(n1, n2);
                for (n2 = 0; n2 < 40; n2++)
                {
                    Color pix3 = image1.Bitmap.GetPixel(n1, n2);
                    gray3 = gray3 + (int)(pix3.R * 0.30 + pix3.G * 0.59 + pix3.B * 0.11);

                }
                gray3 = gray3 / 20;
                gray[n1] = gray3;
                grayhistpic.Draw(new Rectangle(n1, 255 - gray[n1], 1, gray[n1]), new Bgr(Color.FromArgb(255, Color.Blue)), 1);
            }




            picHist.Image = histpic.Bitmap;
            picGrayHist.Image = grayhistpic.Bitmap;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startpoints(frame1, frame2);
        }
    }
}
