using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SozlukPRo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BOV3B8B\SQLEXPRESS;Initial Catalog=TrIngSozluk;Integrated Security=True");
        int randomWordId;
        int time = 90;
        int word = 0;
        string turkish = "turkish", english = "english";
        string selected = "turkish";




        void restartTimer()
        {
            time = 90;
            lblSure.Text = time.ToString();
            word = 0;
            lblKelime.Text = word.ToString();
            timer1.Stop();
            timer1.Start();
        }

        void increaseWord()
        {
            word++;
            lblKelime.Text = word.ToString();
        }

        void randomWord()
        {
            Random random = new Random();
            randomWordId = random.Next(1, 11);
        }

        void listEnglish()
        {
            try
            {
                randomWord();
                txtIng.Enabled = false;
                txtTr.Enabled = true;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TblKelimeler where id=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", randomWordId);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblDogrulama.Text = dr[1].ToString();
                    txtIng.Text = dr[2].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void listTurkish()
        {
            try
            {
                randomWord();
                txtIng.Enabled = true;
                txtTr.Enabled = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TblKelimeler where id=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", randomWordId);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblDogrulama.Text = dr[2].ToString();
                    txtTr.Text = dr[1].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            listEnglish();
            txtTr.Focus();
        }

        private void txtTr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (lblDogrulama.Text == txtTr.Text)
                    {
                        increaseWord();
                        listEnglish();
                        txtTr.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong answer!!", "Wrong Answer!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        listEnglish();
                        txtTr.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir değer giriniz!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblSure.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show("Your Score: " + word.ToString(), "Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {  
            listTurkish();
            restartTimer();
            txtIng.Text = "";
            txtIng.Focus();
        }

        private void pictureReturn2_Click(object sender, EventArgs e)
        {
            listEnglish();
            restartTimer();
            txtTr.Text = "";
            txtTr.Focus();
        }

        private void txtIng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (lblDogrulama.Text == txtIng.Text)
                    {
                        increaseWord();
                        listTurkish();
                        txtIng.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong answer!!", "Wrong Answer!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        listTurkish();
                        txtIng.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir değer giriniz!!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
