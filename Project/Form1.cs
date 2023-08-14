using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    

    public partial class Form1 : Form
    {
        List<Image> Resimler = new List<Image>();
        public void list()
        {
            
            Resimler.Add(Image.FromFile(@"images\armut (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\armut (2).jpg"));
            Resimler.Add(Image.FromFile(@"images\çilek (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\çilek (2).jpg"));
            Resimler.Add(Image.FromFile(@"images\elma (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\elma (2).jpg"));
            Resimler.Add(Image.FromFile(@"images\mandalina (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\mandalina (2).jpg"));
            Resimler.Add(Image.FromFile(@"images\greyfurt (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\greyfurt (2).jpg"));
            Resimler.Add(Image.FromFile(@"images\portakal (1).jpg"));
            Resimler.Add(Image.FromFile(@"images\portakal (2).jpg"));
        }

        int zaman = 60;
        double toplamPure = 0;
        double toplamVitA = 0;
        double toplamVitC = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxNarinciye.Enabled = false;
            listBoxKati.Enabled = false;
            btnKati.Enabled = false;
            btnNarinciye.Enabled = false;

            lblsayac.Text = zaman.ToString();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            list();
            toplamPure = 0;
            toplamVitA = 0;
            toplamVitC = 0;


            listBoxKati.Items.Clear();
            listBoxNarinciye.Items.Clear();

            lblPure.Text = "0";
            lblVitA.Text = "0";
            lblVitC.Text = "0";
            lblToplamPure.Text = "0";
            lblToplamA.Text = "0";
            lblToplamC.Text = "0";



            zaman = 60;
            timer1.Start();

            var rand = new Random();

            Resim.Image = Resimler[rand.Next(0,11)];
            Resim.SizeMode = PictureBoxSizeMode.StretchImage;

            listBoxNarinciye.Enabled = true;
            listBoxKati.Enabled = true;
            btnKati.Enabled = true;
            btnNarinciye.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (zaman > 0)
            {
                timer1.Interval = 1000;
                int zaman1 = zaman--;
                lblsayac.Text = zaman.ToString();
                btnStart.Enabled = false;
            }
            else
            {
                listBoxNarinciye.Enabled = false;
                listBoxKati.Enabled = false;
                btnKati.Enabled = false;
                btnNarinciye.Enabled = false;
                btnStart.Enabled = true;
                timer1.Stop();
            }
        }

        private void btnNarinciye_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            portakal portakal = new portakal();
            mandalina mandalina = new mandalina();
            greyfurt greyfurt = new greyfurt();

            portakal.SonucPortakal() ;
            mandalina.SonucMandalina();
            greyfurt.SonucGreyfurt();

            if (Resim.Image==Resimler[6]||Resim.Image==Resimler[7])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxNarinciye.Items.Add("Mandalina(" + mandalina.nAgirlik + ")");

                lblPure.Text = mandalina.nSivi.ToString();
                lblVitA.Text = mandalina.nVitA.ToString();
                lblVitC.Text = mandalina.nVitC.ToString();
                toplamPure += mandalina.nSivi;
                toplamVitA += mandalina.nVitA;
                toplamVitC += mandalina.nVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
            else if(Resim.Image == Resimler[8] || Resim.Image == Resimler[9])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxNarinciye.Items.Add("Greyfurt(" + greyfurt.nAgirlik + ")");

                lblPure.Text = greyfurt.nSivi.ToString();
                lblVitA.Text = greyfurt.nVitA.ToString();
                lblVitC.Text = greyfurt.nVitC.ToString();
                toplamPure += greyfurt.nSivi;
                toplamVitA += greyfurt.nVitA;
                toplamVitC += greyfurt.nVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
            else if(Resim.Image == Resimler[10] || Resim.Image == Resimler[11])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxNarinciye.Items.Add("Portakal(" + portakal.nAgirlik + ")");

                lblPure.Text = portakal.nSivi.ToString();
                lblVitA.Text = portakal.nVitA.ToString();
                lblVitC.Text = portakal.nVitC.ToString();
                toplamPure += portakal.nSivi;
                toplamVitA += portakal.nVitA;
                toplamVitC += portakal.nVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
        }
        private void btnKati_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            elma elma = new elma();
            armut armut = new armut();
            cilek cilek = new cilek();

            elma.SonucElma();
            armut.SonucArmut();
            cilek.SonucCilek();

            if (Resim.Image == Resimler[0] || Resim.Image == Resimler[1])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxKati.Items.Add("Armut(" + armut.kAgirlik + ")");

                lblPure.Text = armut.kSivi.ToString();
                lblVitA.Text = armut.kVitA.ToString();
                lblVitC.Text = armut.kVitC.ToString();
                toplamPure += armut.kSivi;
                toplamVitA += armut.kVitA;
                toplamVitC += armut.kVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
            else if (Resim.Image == Resimler[2] || Resim.Image == Resimler[3])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxKati.Items.Add("Çilek(" + cilek.kAgirlik + ")");

                lblPure.Text = cilek.kSivi.ToString();
                lblVitA.Text = cilek.kVitA.ToString();
                lblVitC.Text = cilek.kVitC.ToString();
                toplamPure += cilek.kSivi;
                toplamVitA += cilek.kVitA;
                toplamVitC += cilek.kVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
            else if (Resim.Image == Resimler[4] || Resim.Image == Resimler[5])
            {
                Resim.Image = Resimler[rand.Next(0, 11)];

                listBoxKati.Items.Add("Elma(" + elma.kAgirlik + ")");

                lblPure.Text = elma.kSivi.ToString();
                lblVitA.Text = elma.kVitA.ToString();
                lblVitC.Text = elma.kVitC.ToString();
                toplamPure += elma.kSivi;
                toplamVitA += elma.kVitA;
                toplamVitC += elma.kVitC;
                lblToplamPure.Text = toplamPure.ToString();
                lblToplamA.Text = toplamVitA.ToString();
                lblToplamC.Text = toplamVitC.ToString();
            }
        }

        
    }
}
