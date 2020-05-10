using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        Bitmap off;
        int fup1 = -1;
        int fup2 = 0;
        int GO=0;
        int flag = 0;
        CActor pHero1 = new CActor();
        public static int ct=0;
        Bitmap im = new Bitmap("222.bmp");
     
        string str = "GAME OVER";
        Font F = new Font("Times New Roman", 50,FontStyle.Bold);

        string str1 = "Try Again";
        Font F1 = new Font("Times New Roman", 30, FontStyle.Bold);
        Bitmap bWhole2;
        Timer t = new Timer();
        public class CActor
        {
            public int X, Y;
            public int X1, Y1;
            public Bitmap im;
            public int fch;
            public int oldx, oldy;

        }

        int XS = 0;
        int YS = 0;
        CActor pHero = new CActor();
        List<CActor> L = new List<CActor>();
        List<CActor> L1 = new List<CActor>();
        List<CActor> L3 = new List<CActor>();
        Bitmap bWhole;
        Bitmap bWhole1;
        Bitmap bWhole3;
        int ct1 = 0;
        int flag1 = 0;
        List<CActor> L2 = new List<CActor>();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.MouseDown += Form1_MouseDown;
            this.KeyUp += Form1_KeyUp;
            t.Tick += T_Tick;
            t.Interval = 150;
               t.Start();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F)
            {
                flag = 0;
            }
            Graphics g = this.CreateGraphics();
            DrawDubb(g);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==System.Windows.Forms.MouseButtons.Left)
            {

                if (e.X > L1[0].X
                             && e.X < (L1[0].X + L1[0].X1)
                             && e.Y > L1[0].Y
                             && e.Y < (L1[0].Y + L1[0].Y1)
                             )
                {
                    //GO = 0;
                }
            }
            Graphics g = this.CreateGraphics();
            DrawDubb(g);
        }
        int counttick = 0;
        int countcircle = 0;
        int counttick2 = 0;
        int counttick1= 0;
        int countcircle1 = 0;
        private void car2()
        {

            Random s1 = new Random();
            int swr1 = s1.Next(0, 20);

            if (counttick2 % 20 == 0)
            {
                for (int i = 0; i < 1; i++)

                {
                    Random N1 = new Random();
                    int RR = N1.Next(400, 410);
                    int RR1 = N1.Next(600, 620);
                    // int RR2 = N.Next(0, 290);
                    //int RR3 = N.Next(400, this.ClientSize.Height - 70);

                    CActor pnn = new CActor();
                    
                    pnn.X = this.ClientSize.Width;
                    // pnn1.X = this.ClientSize.Width;
                    if (countcircle1 % 2 == 0)
                    {
                        pnn.Y = 460;
                        if (swr1 % 2 == 0)
                        {
                            pnn.im = new Bitmap("RC.png");
                            pnn.fch = 0;

                        }
                        if (swr1 % 2 == 1)
                        {
                            pnn.im = new Bitmap("RS.png");
                            pnn.fch = 1;
                        }


                    }
                    if (countcircle1 % 2 != 0)
                    {
                        pnn.Y = 560;

                        if (swr1 % 2 == 0)
                        {
                            pnn.im = new Bitmap("RC.png");
                            pnn.fch = 0;


                        }
                        if (swr1 % 2 == 1)
                        {
                            pnn.im = new Bitmap("RS.png");
                            pnn.fch = 1;
                        }
                    }
                    pnn.im.MakeTransparent(pnn.im.GetPixel(0, 0));
                    L2.Add(pnn);
                   
                    countcircle1++;
                }
            }
            for (int i = 0; i < L2.Count; i++)
            {
                L2[i].X -= 40;
            }

            for (int i = 0; i < L2.Count; i++)
            {
                CActor ptrav = L2[i];

                if ((pHero1.X1 + pHero1.im.Width > ptrav.X - ptrav.im.Width + 60 && pHero1.X1 < (ptrav.X + ptrav.im.Width)
                     && pHero1.Y1 + pHero1.im.Height >= ptrav.Y && pHero1.Y1 <= ptrav.Y)
                   )

                {
                    if (ptrav.fch == 0)
                    {
                        ptrav.X = 10000;
                        ct1++;
                    }
                    if (ptrav.fch == 1)
                    {
                          GameOver();
                    }
                }
            }

                counttick2++;
        }
        private void car1()
        {
            Random c = new Random();
            int f = c.Next(0, 100);
            Random s = new Random();
            int swr = s.Next(0, 20);

            if (counttick % 20 == 0)
            {
                for (int i = 0; i < 1; i++)

                {
                    Random N = new Random();
                    int RR = N.Next(90, 110);
                    int RR1 = N.Next(190, 220);
                    // int RR2 = N.Next(0, 290);
                    //int RR3 = N.Next(400, this.ClientSize.Height - 70);

                    CActor pnn = new CActor();
                    CActor pnn1 = new CActor();
                    pnn.X = this.ClientSize.Width;
                    // pnn1.X = this.ClientSize.Width;
                    if (countcircle % 2 == 0)
                    {
                        pnn.Y = 99;
                        if (swr % 2 == 0)
                        {
                            pnn.im = new Bitmap("S.png");
                            pnn.fch = 0;

                        }
                        if (swr % 2 == 1)
                        {
                            pnn.im = new Bitmap("C.png");
                            pnn.fch = 1;
                        }


                    }
                    if (countcircle % 2 != 0)
                    {
                        pnn.Y = 176;

                        if (swr % 2 == 0)
                        {
                            pnn.im = new Bitmap("S.png");
                            pnn.fch = 0;


                        }
                        if (swr % 2 == 1)
                        {
                            pnn.im = new Bitmap("C.png");
                            pnn.fch = 1;
                        }
                    }
                    pnn.im.MakeTransparent(pnn.im.GetPixel(0, 0));
                    L.Add(pnn);
                    countcircle++;
                    //countcircle1++;
                }
            }
            //////////////////
            for (int i = 0; i < L.Count; i++)
            {
                L[i].X -= 60;

            }

        }
        private void Coins(int ct)
        {
            string str2 = "Score = " + ct;
            Font F2 = new Font("Times New Roman", 30, FontStyle.Bold);

            Graphics g = this.CreateGraphics();

            SizeF sz2 = g.MeasureString(str2, F2);
            int W12 = (int)sz2.Width;
            int H12 = (int)sz2.Height;
            bWhole2 = new Bitmap(W12, H12);

            Graphics gRender2 = Graphics.FromImage(bWhole2);
            gRender2.DrawString(str2, F2, Brushes.AliceBlue, 0, 0);

            ////////////////
            string str3 = "Score = " + ct1;
            Font F3 = new Font("Times New Roman", 30, FontStyle.Bold);

            

            SizeF sz23 = g.MeasureString(str3, F3);
            int W123 = (int)sz23.Width;
            int H123 = (int)sz23.Height;
            bWhole3 = new Bitmap(W123, H123);

            Graphics gRender3 = Graphics.FromImage(bWhole3);
            gRender3.DrawString(str3, F3, Brushes.AliceBlue, 0, 0);



        }
        private void T_Tick(object sender, EventArgs e)
        {
           
            if (XS > 50)
            {
                XS = 60;

            }
            //pHero.X += 5;
            //pHero1.X1 += 5;
            //XS += 5;

            /////////////////////////////////
            if (fup1 % 2 == 0)
            {

                pHero.Y = 170;

            }
            if (fup1 % 2 == 1)

            {
                pHero.Y = 60;
            }
            ////////////////////////////
            if (fup2 % 2 == 0)
            {

                pHero1.Y1 = 450;

            }
            if (fup2 % 2 == 1)

            {
                pHero1.Y1 = 560;
            }

            //////////////////////// car1
            for (int i = 0; i < L.Count; i++)
            {
                CActor ptrav = L[i];

                if ((pHero.X + pHero.im.Width > ptrav.X - ptrav.im.Width + 10 &&pHero.X < (ptrav.X + ptrav.im.Width)
                     && pHero.Y + pHero.im.Height >= ptrav.Y && pHero.Y<=ptrav.Y )
                   )

                {
                    if (ptrav.fch == 0)
                    {
                        L[i].X = 10000;
                        ct++;
                    }
                    if (ptrav.fch == 1)
                    {
                        GameOver();
                    }
                }

            }
            /////////////////////////car2
            if (flag == 1)
            {
                CActor pnn = new CActor();
                pnn.X = pHero.X + pHero.im.Width - 20;
                pnn.Y = pHero.Y + 30;
                pnn.im = new Bitmap("f.jpg");
                pnn.im.MakeTransparent(pnn.im.GetPixel(0, 0));
                L3.Add(pnn);
                flag1 = 1;


            }

            if (flag1 == 1)
            {
                for (int k = 0; k < L3.Count; k++)
                {
                    L3[k].X += 20;

                }
               for(int i=0;i<L3.Count;i++)
                {
                    CActor ptrav1 = L3[i];
                    for(int k=0;k<L.Count;k++)
                    {
                        
                        if (L[k].fch == 1)
                        {
                            CActor ptrav = L[k];

                            if ((ptrav1.X + ptrav1.im.Width > ptrav.X - ptrav.im.Width + 60 && ptrav1.X < (ptrav.X + ptrav.im.Width)
                                 && ptrav1.Y + ptrav1.im.Height >= ptrav.Y && ptrav1.Y - 40 <= ptrav.Y)
                               )

                            {
                                L3[i].X = 10000;
                                L[k].X = 10000;
                            }
                        }

                    }

                }

            }
            Coins(ct);
            car2();
            car1();

            Graphics g = this.CreateGraphics();
            DrawDubb(g);
            counttick++;
            //counttick1++;
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                // pHero.Y += 10;
                fup2++;
            }
            if (e.KeyCode == Keys.Up)
            {
                // pHero.Y -= 10;
                fup1++;
            }
            if (e.KeyCode == Keys.F)
            {
                flag = 1;
              
            }
        }

        private void GameOver()
        {
            GO = 1;
            Graphics g = this.CreateGraphics();
           
            SizeF sz = g.MeasureString(str, F);
            int W1 = (int)sz.Width;
            int H1 = (int)sz.Height;
            bWhole = new Bitmap(W1, H1);

            Graphics gRender = Graphics.FromImage(bWhole);
            gRender.DrawString(str, F, Brushes.Gold, 0, 0);



            SizeF sz1 = g.MeasureString(str1, F1);
            int W11 = (int)sz1.Width;
            int H11 = (int)sz1.Height;
            bWhole1 = new Bitmap(W11, H11);

            Graphics gRender1 = Graphics.FromImage(bWhole1);
            gRender1.DrawString(str1, F1, Brushes.DarkGoldenrod, 0, 0);


            CActor pnn = new CActor();
            pnn.X = this.ClientSize.Width / 2 + 100;
            pnn.Y = this.ClientSize.Height / 2 - 25;
            pnn.X1 = 40;
            pnn.Y1 = 40;
            L1.Add(pnn);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            DrawDubb(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            
            pHero.X = 50;
            pHero.Y = 60;
            pHero.im = new Bitmap("1.bmp");
           // pHero.X1 = XS;
            //pHero.Y1 = YS;
            pHero.im.MakeTransparent(pHero.im.GetPixel(0, 0));


            pHero1.X1 = 50;
            pHero1.Y1 = 450;
            pHero1.im = new Bitmap("3.bmp");
            // pHero.X1 = XS;
            //pHero.Y1 = YS;
            pHero1.im.MakeTransparent(pHero1.im.GetPixel(0, 0));
            Coins(ct);

        }

        void DrawScene(Graphics g2)
        {
            
            g2.Clear(Color.Black);
           
            Rectangle rcD;
            Rectangle rcS;
            if (GO == 0)
            {
                rcD = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                rcS = new Rectangle(XS, YS, 200, 250);
                g2.DrawImage(im, rcD, rcS, GraphicsUnit.Pixel);
                SolidBrush s = new SolidBrush(Color.LightBlue);
                g2.FillRectangle(s, 0, 170, 100000, 3);
                g2.FillRectangle(s, 0, 550, 100000, 3);

               g2.DrawImage(bWhole2, this.ClientSize.Width - 200,20);
                g2.DrawImage(bWhole3, this.ClientSize.Width - 200, 650);

                g2.DrawImage(pHero.im, pHero.X, pHero.Y);
                g2.DrawImage(pHero1.im, pHero1.X1, pHero1.Y1);
                for (int i = 0; i < L.Count; i++)
                {
                    g2.DrawImage(L[i].im, L[i].X, L[i].Y);

                }

                for (int i = 0; i < L2.Count; i++)
                {
                    g2.DrawImage(L2[i].im, L2[i].X, L2[i].Y);

                }
                for (int i = 0; i < L3.Count; i++)
                {
                    g2.DrawImage(L3[i].im, L3[i].X, L3[i].Y);

                }

            }
            if (GO == 1)
            {
                g2.Clear(Color.Black);

                g2.DrawImage(bWhole, this.ClientSize.Width / 2-200, this.ClientSize.Height/2-100 );
                g2.DrawImage(bWhole1, this.ClientSize.Width / 2 - 86, this.ClientSize.Height / 2 - 25);
                SolidBrush s = new SolidBrush(Color.Goldenrod);
                g2.FillEllipse(s,L1[0].X,L1[0].Y,L1[0].X1,L1[0].Y1);
            }
            
            
            /*rcD = new Rectangle(pHero.X, pHero.Y, this.ClientSize.Width, this.ClientSize.Height);
            rcS = new Rectangle(pHero.X1, pHero.Y1, 950,800 );
            g2.DrawImage(pHero.im, rcD, rcS, GraphicsUnit.Pixel);*/

        }

        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);

            g.DrawImage(off, 0, 0);
        }
    }
}
