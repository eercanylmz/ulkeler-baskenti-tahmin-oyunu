using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulkeler_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 private void renkler()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }
        int sayaç = 0;
        int puan = 0;
        int süre = 50;

        private void BtnAktiflik()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
             button5.Enabled = true;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Properties\\Alone__Cv5bP2x1xG8__.wav";
            ses.Play();
            sayaç++;
            label1.Visible = false;
            button5.Text = "SONRAKİ";
            label2.Text = " ";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            if (sayaç == 1)
            {

                label3.Text = "Türkiye'ninbaşkenti neresidir";
                pictureBox1.ImageLocation = @"C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\indir.jpeg";
                button1.Text = "Antalya'nın başkenti neresidir";
                button2.Text = "izmir";
                button3.Text = "istanbul";
                button4.Text = "Ankara";
                label1.Text = "Ankara";
                renkler();
             
            }
          
            if (sayaç == 2)
            {
                
                pictureBox1.ImageLocation = @"C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\png-transparent-berlin-germany-berlin-reichstag-renaissance-gothic.png";
                label3.Text = "Almanya'nın başkenti nresidir";
                label1.Text = "Berlin";
                button1.Text = "Dortmund";
                button2.Text = "Berlin";
                button3.Text = "Hamburg";
                button4.Text = "Thüringen";
                renkler();
            }
            if (sayaç == 3)
            {
                pictureBox1.ImageLocation = @"C:\Users\yilma\source\repos\ulkeler oyunu\ulkeler oyunu\Resources\indir (1).jpeg";
                button1.Text = "Kalifornia";
                button2.Text = "Texas";
                button3.Text = "Washington";
                button4.Text = "Havaii";
                label3.Text = "Amerika'nın başkenti neresidir";
                label1.Text = "Washington";
                renkler();
              
            }
            if (sayaç == 4)
            {
                pictureBox1.ImageLocation = @"C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\tokyo.png";
                label3.Text = "Japonya'nın başkenti neresidir";
                button1.Text = "Kyoto";
                button2.Text = "Kamakura";
                button3.Text = "Tokyo";
                button4.Text = "Sapporo";
                label1.Text = "Tokyo";
                renkler();
            }
            if (sayaç == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\lovepik-madrid-white-classical-architecture-png-image_401480644_wh1200.png";
                label3.Text = "İspanya'nın başkemti neresidir ";
                button1.Text = "Madrid";
                button2.Text = "Barselona";
                button3.Text = "Malaga";
                button4.Text = "Kurtuba";
                label1.Text = "Madrid";
                renkler();
            }
            if (sayaç == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\1661954496-Untitleddesign-2022-08-31T180053459.png";
                label3.Text = "Suudi Arabistan'ın başkenti neresidir";
                button1.Text = "Mekke";
                button2.Text = "Medine";
                button3.Text = "Cidde";
                button4.Text = "Riyad";
                label1.Text = "Riyad";
                renkler();
            }
            if (sayaç == 7)
            {
                pictureBox1.ImageLocation = "C:\\Users\\yilma\\source\\repos\\ulkeler oyunu\\ulkeler oyunu\\Resources\\ancient-rome-landscape-ruins-png-favpng-zLFyzAfRgr9Vfytd5PTC13Jvk.jpg";
                label3.Text = "İtalya'nın başkenti neresidir";
                button1.Text = "Venedik";
                button2.Text = "Roma";
                button3.Text = "Milano";
                button4.Text = "Floransa";
                label1.Text = "Roma";
                renkler();
            }
            if (sayaç == 8)
            {
                label3.Text = "Mısır'ın başlenti neresidir";
                button1.Text = "Kahire";
                button2.Text = "Dimyat";
                button3.Text = "Süveyş";
                button4.Text = "İskenderiye";
                label1.Text = "Kahire";
                renkler();
                button5.Enabled = true;
            }
            if (sayaç == 9)
            {
                
                int a = puan + Convert.ToInt32(süre);
                label5.Text = a.ToString();
                timer1.Stop();
                MessageBox.Show("TEBRİKLER OYUN BİTTİ\n" +"PUANINIZ= "+ a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = button1.Text;
            if (label1.Text == button1.Text)
            {
                button1.BackColor = Color.Green;
                puan += 10;
                label5.Text = puan.ToString();
            }
            else
            {
                button1.BackColor = Color.Red;
                puan -= 5;
                label5.Text = puan.ToString();
            }
            BtnAktiflik();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = button2.Text;
            if (label1.Text == button2.Text)
            {
                button2.BackColor = Color.Green;
                puan += 10;
                label5.Text = puan.ToString();
            }
            else
            {
                button2.BackColor = Color.Red;
                puan -= 5;
                label5.Text = puan.ToString();
            }
            BtnAktiflik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = button3.Text;
            if (label1.Text == button3.Text)
            {
                button3.BackColor = Color.Green;
                puan += 10;
                label5.Text = puan.ToString();
                
            }
            else
            {
                button3.BackColor = Color.Red;
                puan -= 5;
                label5.Text = puan.ToString();
            }
            BtnAktiflik();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = button4.Text;

            if (label1.Text == button4.Text)
            {
                button4.BackColor = Color.Green;
                puan += 10;
                label5.Text = puan.ToString();
            }
            else
            {
                button4.BackColor = Color.Red;
                puan -= 5;
                label5.Text = puan.ToString();
            }
            BtnAktiflik();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label6.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
            }
        }
    }
}
