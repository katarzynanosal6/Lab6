using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class GameForm : Form
    {
        private int[,] mapaPola;
        private int pozostalyCzas;
        private int pozostaleDydelfy;
        private bool czekajNaKlikKrokodyla = false;

        public GameForm()
        {
            InitializeComponent();


            int x = GlobalneUstawienia.X;
            int y = GlobalneUstawienia.Y;
            pozostalyCzas = GlobalneUstawienia.Czas;
            pozostaleDydelfy = GlobalneUstawienia.LiczbaDydelfow;

            mapaPola = new int[x, y];


            LosujPozycje(x, y);


            RysujPrzyciski(x, y);


            lblTimer.Text = pozostalyCzas.ToString() + " s";
            gameTimer.Start();
        }

        private void LosujPozycje(int x, int y)
        {
            Random rand = new Random();

            for (int i = 0; i < GlobalneUstawienia.LiczbaDydelfow; i++)
            {
                int dx, dy;
                do { dx = rand.Next(x); dy = rand.Next(y); } while (mapaPola[dx, dy] != 0);
                mapaPola[dx, dy] = 1;
            }

            for (int i = 0; i < GlobalneUstawienia.LiczbaSzopow; i++)
            {
                int sx, sy;
                do { sx = rand.Next(x); sy = rand.Next(y); } while (mapaPola[sx, sy] != 0);
                mapaPola[sx, sy] = 2;
            }

            for (int i = 0; i < GlobalneUstawienia.LiczbaKrokodyli; i++)
            {
                int kx, ky;
                do { kx = rand.Next(x); ky = rand.Next(y); } while (mapaPola[kx, ky] != 0);
                mapaPola[kx, ky] = 3;
            }
        }

        private void RysujPrzyciski(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(20 + (i * 55), 70 + (j * 55));
                    btn.BackColor = Color.Gray;
                    btn.Tag = new Point(i, j);
                    btn.Click += Przycisk_Click;
                    this.Controls.Add(btn);
                }
            }
        }

        private void Przycisk_Click(object? sender, EventArgs? e)
        {
            Button? klikniety = sender as Button;
            Point poz = (Point)klikniety.Tag;
            int zawartosc = mapaPola[poz.X, poz.Y];

            if (zawartosc == 1)
            {
                klikniety.BackColor = Color.Pink;
                klikniety.Text = "D";
                klikniety.Enabled = false;
                pozostaleDydelfy--;
                if (pozostaleDydelfy == 0) Sukces();
            }
            else if (zawartosc == 2)
            {
                klikniety.BackColor = Color.Brown;
                klikniety.Text = "S";

                System.Windows.Forms.Timer timerSzopa = new System.Windows.Forms.Timer();
                timerSzopa.Interval = 2000; 

                timerSzopa.Tick += (s, ev) => {
                    timerSzopa.Stop();
                    timerSzopa.Dispose();

                    
                    klikniety.BackColor = Color.Gray;
                    klikniety.Text = "";
                    klikniety.Enabled = true;

                    ZamknijSasiadow(poz.X, poz.Y);
                };
                timerSzopa.Start();

            }
            else if (zawartosc == 3)
            {
                if (czekajNaKlikKrokodyla)
                {
                    czekajNaKlikKrokodyla = false;
                    klikniety.BackColor = Color.Gray;
                    klikniety.Text = "";
                }
                else
                {
                    czekajNaKlikKrokodyla = true;
                    klikniety.BackColor = Color.Green;
                    klikniety.Text = "K";

                    System.Windows.Forms.Timer tKrok = new System.Windows.Forms.Timer();
                    tKrok.Interval = 2000; 
                    tKrok.Tick += (s, ev) =>
                    {
                        tKrok.Stop();
                        tKrok.Dispose();
                        if (czekajNaKlikKrokodyla)
                        {
                            
                            Porazka("Krokodyl Cię złapał!");
                        }
                    };
                    tKrok.Start();


                }
            }
            else
            {
                klikniety.BackColor = Color.White;
                klikniety.Enabled = false;
            }
        }

        private void ZamknijSasiadow(int x, int y)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button b && b.Tag is Point p)
                {
                    if (Math.Abs(p.X - x) <= 1 && Math.Abs(p.Y - y) <= 1)
                    {
                        b.BackColor = Color.Gray;
                        b.Text = "";
                        b.Enabled = true;
                    }
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (pozostalyCzas > 0)
            {
                pozostalyCzas--;
                lblTimer.Text = pozostalyCzas + " s";
            }
            else
            {
                Porazka("Czas upłynął!");
            }
        }

        private void Sukces()
        {
            gameTimer.Stop();
            MessageBox.Show("Sukces! Odnaleziono wszystkie Dydelfy.");
            this.Close();
        }

        private void Porazka(string powód)
        {
            gameTimer.Stop();
            MessageBox.Show("Porażka: " + powód);
            this.Close();
        }
    }
}
