using System;
using System.Drawing;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class FormMayinTarlasi : Form
    {
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
    }
}
