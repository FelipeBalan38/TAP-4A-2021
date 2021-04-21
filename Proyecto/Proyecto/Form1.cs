using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        NombrePlayer N = new NombrePlayer();
        SoundPlayer Player;
        SoundPlayer men;
        Random aleatorio;
        Image sonocF = null;
        Image menu = null;
        Image reprobado1 = null;
        Image fondo = null;
        Image Personaje = null;
        Image Logo = null;
        String nombre;
        String letra;
        int puntuacion;
        int x = 0, y = 0;
        int fx, fy, y2;
        int xobj, xobj2, xobj3, xobj4, yobj, yobj2, yobj3, yobj4, yobj5, yobj6, yobj7, yobj8, yobj9, yobj10, yobj11, yobj12, yobj13;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void again_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

            // xobj = 0; xobj2 = 0; xobj3 = 0;
            xobj4 = 0; yobj = 0; yobj2 = 0; yobj3 = 0; yobj4 = 0; yobj5 = 0; yobj6 = 0; yobj7 = 0; yobj8 = 0; yobj9 = 0; yobj10 = 0; yobj11 = 0; yobj12 = 0;
            men.Stop();
            LabelFinal.Visible = false;
            label1.Visible = true;
            panel2.Enabled = false;
            panel2.Visible = false;
            panel1.Enabled = false;
            panel1.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
            Player = new SoundPlayer();
            Player.SoundLocation = "Recursos/nosexd.Wav";
            Player.PlayLooping();
            aleatorio = new Random();
            menu = Image.FromFile("Recursos\\autobus.gif");
            sonocF = Image.FromFile("Recursos\\AmimirConMamaCOCO.gif");
            reprobado1 = Image.FromFile("Recursos\\5_grandote.png");
            fondo = Image.FromFile("Recursos\\claeFondo.gif");
            Personaje = Image.FromFile("Recursos\\Sanic.png");
            x = 100;
            y = 480;
            y2 = 650;
            fx = fy = 0;
            puntuacion = 0;
            tipo = false;
            timer1.Enabled = true;
            perder = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer4.Interval = 1000;
            timer3.Interval = 20;
            timer2.Interval = 50;
            timer1.Interval = 1000;
            colisionx1 = x + 67;
            colisionx2 = x + 137;
            panel2.Enabled = false;
            panel2.Visible = false;


        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Names_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonNombre_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void botonNombre_Click(object sender, EventArgs e)
        {
           
            N.Show();
       
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.DrawImage(Logo, new Rectangle(340,0, 500, 300));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            puntuacion+=1;
            label1.Text = "puntuacion " + puntuacion;
        }

       
        

        private void panel1_Click(object sender, EventArgs e)
        {
            men.Stop();
            LabelFinal.Visible = false;
            botonNombre.Enabled = false;
            botonNombre.Visible = false;
            label1.Visible = true;
            panel1.Enabled = false;
            panel1.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
            Player = new SoundPlayer();
            Player.SoundLocation = "Recursos/nosexd.Wav";
            Player.PlayLooping();
            aleatorio = new Random();
            menu = Image.FromFile("Recursos\\autobus.gif");
            reprobado1 = Image.FromFile("Recursos\\5_grandote.png");
            fondo = Image.FromFile("Recursos\\claeFondo.gif");
            Personaje = Image.FromFile("Recursos\\Sanic.png");
            x = 100;
            y = 480;
            y2 = 650;
            fx = fy = 0;
            puntuacion = 0;
            tipo = false;
            timer1.Enabled = true;
            perder = false;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer4.Interval = 1000;
            timer3.Interval = 20;
            timer2.Interval = 50;
            timer1.Interval = 1000;
            colisionx1 = x + 67;
            colisionx2 = x + 137;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int colisionx1, colisionx2;
        int mono = 0;
        bool tipo, perder;
        public Form1()
        {

            InitializeComponent();
            LabelFinal.Visible = false;
            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            men = new SoundPlayer();
            Logo = Image.FromFile("Recursos\\Logos.png");
            men.SoundLocation = "Recursos/Menu.Wav";
            men.PlayLooping();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            if (e.KeyChar == 'a'|| e.KeyChar == 'A')
            {
                timer1.Interval = 50;
                timer2.Interval = 50;
                Console.WriteLine("moviendose");
                x = x-20;
                letra = "a";
                colisionx1 = x + 67;
                colisionx2 = x + 137;
                tipo = true;
                timer1.Interval = 50;
                timer2.Interval = 50;


            }
            if (e.KeyChar == 'd'|| e.KeyChar == 'D')
            {
                Console.WriteLine("moviendose");
                x = x+20;
                colisionx1 = x + 67;
                colisionx2 = x + 137;
                tipo = true;
                letra = "d";
                timer1.Interval = 50;
                timer2.Interval = 50;

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            tipo = false;
            timer2.Interval = 20;
            timer1.Interval = 1000;
            timer3.Interval = 20;
            AreaTrabajo.Invalidate();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void AreaTrabajo_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            AreaTrabajo.Invalidate();
            xobj = aleatorio.Next(1, 4);
            xobj2 = aleatorio.Next(4, 7);
            xobj3 = aleatorio.Next(7, 14);
            xobj4 = aleatorio.Next(10, 14);

            timer2.Enabled = false;

        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            switch (xobj)
            {
                case 1:

                    if (timer2.Enabled == false)
                    {
                        yobj += 10;

                    }


                    break;
                case 2:
                    if (timer2.Enabled == false)
                    {
                        yobj2 += 10;

                    }


                    break;
                case 3:
                    if (timer2.Enabled == false)
                    {
                        yobj3 += 10;
                    }

                    break;
            }
            switch (xobj2)
            {
                case 4:
                    if (timer2.Enabled == false)
                    {
                        yobj4 += 10;
                    }
                    break;
                case 5:
                    if (timer2.Enabled == false)
                    {
                        yobj5 += 10;
                    }
                    break;
                case 6:
                    if (timer2.Enabled == false)
                    {
                        yobj6 += 10;
                    }
                    break;
            }
            switch (xobj3)
            {
                case 7:
                    if (timer2.Enabled == false)
                    {
                        yobj7 += 10;
                    }
                    break;


                case 8:
                    if (timer2.Enabled == false)
                    {
                        yobj8 += 10;
                    }
                    break;
                case 9:
                    if (timer2.Enabled == false)
                    {
                        yobj9 += 10;
                    }
                    break;

            }
            switch (xobj4)
            {
                case 10:
                    if (timer2.Enabled == false)
                    {
                        yobj10 += 10;
                    }
                    break;
                case 11:
                    if (timer2.Enabled == false)
                    {
                        yobj11 += 10;
                    }
                    break;
                case 12:
                    if (timer2.Enabled == false)
                    {
                        yobj12 += 10;
                    }
                    break;
                case 13:
                    if (timer2.Enabled == false)
                    {
                        yobj13 += 10;
                    }
                    break;
            }
            collisionCheck();
            AreaTrabajo.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            mono++;
            if (mono >= 3) mono = 0;
            if (tipo)
            { 
                if(letra=="a")
                { 
                    fy = 500;
                }
                if (letra == "d")
                {
                    fy = 250;
                }

            }
            else
            {
                fy = 0;

            }
            Console.WriteLine("Mono: " + mono);
            collisionCheck();
            AreaTrabajo.Invalidate();

            Console.WriteLine("fy: " + fy);
        }

        private void collisionCheck()
        {
            SoundPlayer finalizar = new SoundPlayer();
            finalizar.SoundLocation = "Recursos/perdido.Wav";
            if ((x + 250) > (AreaTrabajo.Width - 100))
            {
                x = (AreaTrabajo.Width - 100) - 250;
            }
            if (x <= 100)
            {
                x = 100;
            }

            if ((yobj + 50) >= y)
            {
                if (250 >= colisionx1 && 250 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (180 >= colisionx1 && 180 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj2 + 50) >= y)
            {
                if (320 >= colisionx1 && 320 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (250 >= colisionx1 && 250 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj3 + 50) >= y)
            {
                if (390 >= colisionx1 && 390 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (320 >= colisionx1 && 320 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj4 + 50) >= y)
            {
                if (460 >= colisionx1 && 460 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (390 >= colisionx1 && 390 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj5 + 50) >= y)
            {
                if (530 >= colisionx1 && 530 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (460 >= colisionx1 && 460 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }

            if ((yobj6 + 50) >= y)
            {
                if (600 >= colisionx1 && 600 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (530 >= colisionx1 && 530 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj7 + 50) >= y)
            {
                if (670 >= colisionx1 && 670 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (600 >= colisionx1 && 600 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj8 + 50) >= y)
            {
                if (740 >= colisionx1 && 740 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (670 >= colisionx1 && 670 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj9 + 50) >= y)
            {
                if (810 >= colisionx1 && 810 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (740 >= colisionx1 && 740 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj10 + 50) >= y)
            {
                if (880 >= colisionx1 && 880 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (810 >= colisionx1 && 810 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj11 + 50) >= y)
            {
                if (950 >= colisionx1 && 950 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (880 >= colisionx1 && 880 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }
            if ((yobj12 + 50) >= y)
            {
                if (1020 >= colisionx1 && 1020 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }

                if (950 >= colisionx1 && 950 <= colisionx2)
                {
                    perder = true;
                    Player.Stop();
                    finalizar.Play();
                }
            }

            if (yobj == y2)
            {
                yobj = 0;
                timer2.Enabled = true;
            }
            if (yobj2 == y2)
            {
                yobj2 = 0;
                timer2.Enabled = true;
            }
            if (yobj3 == y2)
            {
                yobj3 = 0;
                timer2.Enabled = true;
            }
            if (yobj4 == y2)
            {
                yobj4 = 0;
                timer2.Enabled = true;
            }
            if (yobj5 == y2)
            {
                yobj5 = 0;
                timer2.Enabled = true;
            }
            if (yobj6 == y2)
            {
                yobj6 = 0;
                timer2.Enabled = true;
            }
            if (yobj7 == y2)
            {
                yobj7 = 0;
                timer2.Enabled = true;
            }
            if (yobj8 == y2)
            {
                yobj8 = 0;
                timer2.Enabled = true;
            }
            if (yobj9 == y2)
            {
                yobj9 = 0;
                timer2.Enabled = true;
            }
            if (yobj10 == y2)
            {
                yobj10 = 0;
                timer2.Enabled = true;
            }
            if (yobj11 == y2)
            {
                yobj11 = 0;
                timer2.Enabled = true;
            }
            if (yobj12 == y2)
            {
                yobj12 = 0;
                timer2.Enabled = true;
            }

            End();
        }

        private void End()
        {
            if (perder == true)
            {
                label1.Visible = false;
                panel2.Enabled = true;
                panel2.Visible = true;
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                pictureBox1.Enabled = false;
                pictureBox1.Visible = false;
                nombre = N.DevNombre();
                LabelFinal.Visible = true;
                LabelFinal.BackColor = Color.FromArgb(100, 0, 0, 0);
                LabelFinal.Text= "NOOOO "+nombre+" DÓNDE TE SENTASTE?\n"
                  +  " Puntuacion: "+puntuacion;
                menu = Image.FromFile("Recursos\\autobus.gif");
                reprobado1 = Image.FromFile("Recursos\\5_grandote.png");
                fondo = Image.FromFile("Recursos\\claeFondo.gif");
                Personaje = Image.FromFile("Recursos\\Sanic.png");
                tipo = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.DrawImage(fondo, new Rectangle(0, 0, 1200, 800));
            G.DrawImage(Personaje, new Rectangle(x, y, 250, 250),
            fx + mono * 250, fy, 250, 250, GraphicsUnit.Pixel);
            G.DrawImage(reprobado1, new Rectangle(180, yobj, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(250, yobj2, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(320, yobj3, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(390, yobj4, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(460, yobj5, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(530, yobj6, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(600, yobj7, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(670, yobj8, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(740, yobj9, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(810, yobj10, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(880, yobj11, 70, 70));
            G.DrawImage(reprobado1, new Rectangle(950, yobj12, 70, 70));
        }
    }
}
