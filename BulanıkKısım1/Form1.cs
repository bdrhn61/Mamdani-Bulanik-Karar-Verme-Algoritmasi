using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BulanıkKısım1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap Giris=new Bitmap(100,100);
            for(int i=0;i<100;i++)
            Giris.SetPixel(50, i, Color.Black);
            pictureBox1.Image = Giris;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap Giris = new Bitmap(101, 101);
            //for (int i = 0; i < 100; i++)
            //    Giris.SetPixel(50, i, Color.Black);


            for (int i = 0; i < 100; i++)
                Giris.SetPixel(i, (int)ucgenciz(i, 0, 0, 50), Color.Black);

            for (int i = 0; i < 100; i++)
                Giris.SetPixel(i, (int)ucgenciz(i, 0, 50, 100), Color.Red);

            for (int i = 0; i < 100; i++)
                Giris.SetPixel(i, (int)ucgenciz(i, 50, 100, 100), Color.Blue);

            pictureBox1.Image = Giris;
            pictureBox2.Image = Giris;
            pictureBox3.Image = Giris;
           
            Bitmap dusuk = new Bitmap(101, 101); //  DÜŞÜK
            for (int i = 0; i < 100; i++)
                dusuk.SetPixel(i, (int)ucgenciz(i, 0, 0, 50), Color.Black);
           
            Bitmap orta = new Bitmap(101, 101);
            for (int i = 0; i < 100; i++)
                orta.SetPixel(i, (int)ucgenciz(i, 0, 50, 100), Color.Red);

            Bitmap yuksek = new Bitmap(101, 101);
            for (int i = 0; i < 100; i++)
                yuksek.SetPixel(i, (int)ucgenciz(i, 50, 100, 100), Color.Blue);

            pictureBox4.Image = dusuk;
            pictureBox5.Image = dusuk;
            pictureBox6.Image = dusuk;
            pictureBox16.Image = dusuk;


            pictureBox9.Image = orta;
            pictureBox7.Image = yuksek;
            pictureBox8.Image = yuksek;
            pictureBox17.Image = orta;


            pictureBox10.Image = yuksek;
            pictureBox11.Image = orta;
            pictureBox12.Image = orta;
            pictureBox18.Image = yuksek;

            pictureBox13.Image = dusuk;
            pictureBox14.Image = yuksek;
            pictureBox15.Image = yuksek;
            pictureBox19.Image = dusuk;
          
            
            pictureBox28.Image = dusuk;
            pictureBox27.Image = orta;
            pictureBox26.Image = orta;
            pictureBox25.Image = dusuk;
          
            
            pictureBox33.Image = orta;
            pictureBox32.Image = dusuk;
            pictureBox31.Image = dusuk;
            pictureBox30.Image = orta;
          
            
            pictureBox38.Image = orta;
            pictureBox37.Image = orta;
            pictureBox36.Image = orta;
            pictureBox35.Image = orta;
            
            
            pictureBox43.Image = yuksek;
            pictureBox42.Image = dusuk;
            pictureBox41.Image = dusuk;
            pictureBox40.Image = yuksek;

            pictureBox48.Image = yuksek;
            pictureBox47.Image = yuksek;
            pictureBox46.Image = yuksek;
            pictureBox45.Image = yuksek;


        }

        private double ucgenciz(double x, double a, double b, double c)
        {

            if (x <= a)
            {
                return Math.Abs(0-99);
            }
            else if (a <= x && x <= b)
            {
                return Math.Abs(((x - a) / (b - a))*100-100);
            }
            else if (b <= x && x <= c)
            {
                return Math.Abs(((c - x) / (c - b))*100-100);
            }
            else if (c <= x)
            {
                return Math.Abs(0 - 99);
            }
            else
                return Math.Abs(0 - 99);
        }

        private double ucgencoor(double x, double a, double b, double c)
        {

            if (x <= a)
            {
                return 0 ;
            }
            else if (a <= x && x <= b)
            {
                return ((x - a) / (b - a)) ;
            }
            else if (b <= x && x <= c)
            {
                return ((c - x) / (c - b)) ;
            }
            else if (c <= x)
            {
                return 0 ;
            }
            else
                return 0 ;
        }

        private double min(double x,double y,double z)
        {
            double i = 1;
            if (x < i)
            {
                i = x;
            }
            if (y < i)
            {
                i = y;
            }
            if (z < i)
            {
                i = z;
            }
            return i;
        }

         class MZ
        {

            public double m;
            public double z;
            public void setm(double f)
            {
                this.m = f;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MZ []f= new MZ[9] ;
            for(int i=0;i<9;i++)
                 f[i] = new MZ();
          
           Convert.ToDouble(textBox1.Text);
           Convert.ToInt32(textBox1.Text);
          
            int x = Convert.ToInt32(textBox1.Text);
            double fx = 0;
            fx=ucgencoor(x, 0, 0, 50);
            label198.Text = "MX = "+ fx.ToString();

            double y = Convert.ToDouble(textBox2.Text);
            y = y * 100;
            double fy = 0;
            fy = ucgencoor(y, 0, 0, 50);
            label199.Text = "MY = " + fy.ToString();

            double z = Convert.ToDouble(textBox3.Text);
            z = z * 100;
            double fz = 0;
            fz = ucgencoor(z, 0, 0, 50);
            label200.Text = "MZ = " + fz.ToString();
            f[0].m = min(fx, fy, fz);
            label214.Text = f[0].m.ToString();  ////////////////////////////
            f[0].z = 0;

            int x1 = Convert.ToInt32(textBox1.Text);
            double fx1 = 0;
            fx1 = ucgencoor(x, 0, 50, 100);
            label201.Text = "MX = " + fx1.ToString();

            double y1 = Convert.ToDouble(textBox2.Text);
            y1 = y1 * 100;
            double fy1 = 0;
            fy1 = ucgencoor(y, 50, 100, 100);
            label202.Text = "MY = " + fy1.ToString();

            double z1 = Convert.ToDouble(textBox3.Text);
            z1 = z1 * 100;
            double fz1 = 0;
            fz1 = ucgencoor(z, 50, 100, 100);
            label203.Text = "MZ = " + fz1.ToString();
            f[1].m = min(fx1, fy1, fz1);
            label215.Text = f[1].m.ToString(); /////////////////////////////////
            f[1].z = 0.5;

            int x2 = Convert.ToInt32(textBox1.Text);
            double fx2 = 0;
            fx2 = ucgencoor(x, 50, 100, 100);
            label204.Text = "MX = " + fx2.ToString();

            double y2 = Convert.ToDouble(textBox2.Text); ;
            y2 = y2 * 100;
            double fy2 = 0;
            fy2 = ucgencoor(y, 0, 50, 100);
            label205.Text = "MY = " + fy2.ToString();

            double z2 = Convert.ToDouble(textBox3.Text);
            z2 = z2 * 100;
            double fz2 = 0;
            fz2 = ucgencoor(z, 0, 50, 100);
            label206.Text = "MZ = " + fz2.ToString();
            f[2].m = min(fx2, fy2, fz2);
            label216.Text = f[2].m.ToString(); /////////////////////////////////
            f[2].z = 1;

            int x3 = Convert.ToInt32(textBox1.Text);
            double fx3 = 0;
            fx3 = ucgencoor(x, 0, 0, 50);
            label207.Text = "MX = " + fx3.ToString();

            double y3 = Convert.ToDouble(textBox2.Text);
            y3 = y3 * 100;
            double fy3 = 0;
            fy3 = ucgencoor(y, 50, 100, 100);
            label208.Text = "MY = " + fy3.ToString();

            double z3 = Convert.ToDouble(textBox3.Text);
            z3 = z3 * 100;
            double fz3 = 0;
            fz3 = ucgencoor(z, 50, 100, 100);
            label209.Text = "MZ = " + fz3.ToString();
            f[3].m = min(fx3, fy3, fz3);
            label217.Text = f[3].m.ToString(); /////////////////////////////////
            f[3].z = 0;

            int x4 = Convert.ToInt32(textBox1.Text);
            double fx4 = 0;
            fx4 = ucgencoor(x, 0, 0, 50);
            label222.Text = "MX = " + fx4.ToString();

            double y4 = Convert.ToDouble(textBox2.Text);
            y4 = y4 * 100;
            double fy4 = 0;
            fy4 = ucgencoor(y, 0, 50, 100);
            label221.Text = "MY = " + fy4.ToString();

            double z4 = Convert.ToDouble(textBox3.Text);
            z4 = z4 * 100;
            double fz4 = 0;
            fz4 = ucgencoor(z, 0, 50, 100);
            label220.Text = "MZ = " + fz4.ToString();
            f[4].m = min(fx4, fy4, fz4);
            label218.Text = f[4].m.ToString(); /////////////////////////////////
            f[4].z = 0;

            int x5 = Convert.ToInt32(textBox1.Text);
            double fx5 = 0;
            fx5 = ucgencoor(x, 0, 50, 100);
            label263.Text = "MX = " + fx5.ToString();

            double y5 = Convert.ToDouble(textBox2.Text);
            y5 = y5 * 100;
            double fy5 = 0;
            fy5 = ucgencoor(y, 0, 0, 50);
            label262.Text = "MY = " + fy5.ToString();

            double z5 = Convert.ToDouble(textBox3.Text);
            z5 = z5 * 100;
            double fz5 = 0;
            fz5 = ucgencoor(z, 0, 0, 50);
            label261.Text = "MZ = " + fz5.ToString();
            f[5].m = min(fx5, fy5, fz5);
            label259.Text = f[5].m.ToString(); /////////////////////////////////
            f[5].z = 0.5;

            int x6 = Convert.ToInt32(textBox1.Text);
            double fx6 = 0;
            fx6 = ucgencoor(x, 0, 50, 100);
            label304.Text = "MX = " + fx6.ToString();

            double y6 = Convert.ToDouble(textBox2.Text);
            y6 = y6 * 100;
            double fy6 = 0;
            fy6 = ucgencoor(y, 0, 50, 100);
            label303.Text = "MY = " + fy6.ToString();

            double z6 = Convert.ToDouble(textBox3.Text);
            z6 = z6 * 100;
            double fz6 = 0;
            fz6 = ucgencoor(z, 0, 50, 100);
            label302.Text = "MZ = " + fz6.ToString();
            f[6].m = min(fx6, fy6, fz6);
            label300.Text = f[6].m.ToString(); /////////////////////////////////
            f[6].z = 0.5;

            int x7 = Convert.ToInt32(textBox1.Text);
            double fx7 = 0;
            fx7 = ucgencoor(x, 50, 100, 100);
            label345.Text = "MX = " + fx7.ToString();

            double y7 = Convert.ToDouble(textBox2.Text);
            y7 = y7 * 100;
            double fy7 = 0;
            fy7 = ucgencoor(y, 0, 0, 50);
            label344.Text = "MY = " + fy7.ToString();

            double z7 = Convert.ToDouble(textBox3.Text);
            z7 = z7 * 100;
            double fz7 = 0;
            fz7 = ucgencoor(z, 0, 0, 50);
            label343.Text = "MZ = " + fz7.ToString();
            f[7].m = min(fx7, fy7, fz7);
            label341.Text = f[7].m.ToString(); /////////////////////////////////
            f[7].z = 1;

            int x8 = Convert.ToInt32(textBox1.Text);
            double fx8 = 0;
            fx8 = ucgencoor(x, 50, 100, 100);
            label386.Text = "MX = " + fx8.ToString();

            double y8 = Convert.ToDouble(textBox2.Text);
            y8 = y8 * 100;
            double fy8 = 0;
            fy8 = ucgencoor(y, 50, 100, 100);
            label385.Text = "MY = " + fy8.ToString();

            double z8 = Convert.ToDouble(textBox3.Text);
            z8 = z8 * 100;
            double fz8 = 0;
            fz8 = ucgencoor(z, 50, 100, 100);
            label384.Text = "MZ = " + fz8.ToString();
            f[8].m = min(fx8, fy8, fz8);
            label382.Text = f[8].m.ToString(); /////////////////////////////////
            f[8].z = 1;

            double pay = 0;
            double payda = 0;
            double sonuc = 0;
            for(int i = 0; i < 9; i++)
            {
                pay += f[i].m * f[i].z;
                payda += f[i].m;
            }
            sonuc = pay / payda;
            label423.Text = sonuc.ToString();
        }
         

    }
}
