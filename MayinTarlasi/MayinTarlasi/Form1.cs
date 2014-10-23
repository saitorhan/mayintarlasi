using System;
using System.Drawing;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class FormMayinTarlasi : Form
    {
        private int puan;
        public FormMayinTarlasi()
        {
            InitializeComponent();
        }

        private void FormMayinTarlasi_Load(object sender, EventArgs e)
        {
            TarlayiHazirla();
        }

        private void TarlayiHazirla()
        {
            puan = 0;
            panelTarla.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button b=new Button();
                    b.Name = "_" + i + "" + j;
                    b.Size=new Size(50,50);
                    b.Text = "*";
                    b.TextAlign=ContentAlignment.MiddleCenter;
                    b.Location=new Point(i*50,j*50);
                    b.Tag = "-";
                    b.Click += b_Click;
                    panelTarla.Controls.Add(b);
                }
            }

            int s = 0;
            while (s < 10)
            {
                Random r = new Random();
                int sayi = r.Next(0, 100);
                int satir = sayi%10;
                int sutun = sayi/10;
                Button button = panelTarla.Controls["_" + satir + "" + sutun] as Button;

                if ((string) button.Tag=="-")
                {
                    button.Tag = "+";
                    s++;
                }
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string durum = (string) button.Tag;
            if (durum.Equals("-"))
            {
                puan += 10;
                button.Text = ":)";
                button.Enabled = false;
            }
            else
            {
                DialogResult result = MessageBox.Show(String.Format("Oyun bitti.\nPuanınız: {0}\nTekrar oynamak ister misiniz?", puan), "Mayın Tarlası", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result==DialogResult.Yes)
                {
                    TarlayiHazirla();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
