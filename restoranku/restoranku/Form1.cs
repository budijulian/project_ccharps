using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace restoranku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            txtwaktu.Text = "Time : " + dt.DayOfWeek + ":" + dt.Hour + ":" + dt.Minute;

            txtnasig.Text = "Rp. 15.000 ";
            txtayam.Text = "Rp. 28.000 ";
            txtsate.Text = "Rp. 30.000 ";
            txtmie.Text = "Rp. 17.500";
            txtburger.Text = "Rp. 25.000";
            txttahu.Text = "Rp. 4.000";

            // harga minuman
            txtjeruk.Text = "Rp. 14.000";
            txtcoffe.Text = "Rp. 20.000";
            txtteh.Text = "Rp. 5.000";
            txtalpukat.Text = "Rp.17.000";
            txtair.Text = "Rp. 3.000";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            double jeruk, teh, alpukat, air, coffe;
            double  kembali, bayar;


            // harga makanan
            txtnasig.Text = "Rp. 15.000 ";
            txtayam.Text = "Rp. 28.000 ";
            txtsate.Text = "Rp. 30.000 ";
            txtmie.Text = "Rp. 17.500";
            txtburger.Text = "Rp. 25.000";
            txttahu.Text = "Rp. 4.000";

            // harga minuman
            txtjeruk.Text = "Rp. 14.000";
            txtcoffe.Text = "Rp. 20.000";
            txtteh.Text = "Rp. 5.000";
            txtalpukat.Text = "Rp.17.000";
            txtair.Text = "Rp. 3.000";
            
            double ayam = double.Parse(n_ayam.Text);
            double sate = double.Parse(n_sate.Text);
            double mie = double.Parse(n_mie.Text);
            double tahu = double.Parse(n_tahu.Text);
            double burger = double.Parse(n_burger.Text);
            double nasi = double.Parse(n_burger.Text);

            jeruk = double.Parse(n_jeruk.Text);
            air = double.Parse(n_air.Text);
            teh = double.Parse(n_teh.Text);
            alpukat = double.Parse(n_alpukat.Text);
            coffe = double.Parse(n_coffe.Text);

            double t_ayam = 28000 * ayam;
            double t_sate = 30000 * sate;
            double t_mie = 17500 * mie;
            double t_tahu = 4000 * tahu;
            double t_burger = 25000 * burger;
            double t_nasi = 15000 * nasi;

            double t_jeruk = 14000 * jeruk;
            double t_air = 3000 * air;
            double t_teh = 5000 * teh;
            double t_alpukat = 17000 * alpukat;
            double t_coffe = 20000 * coffe;


            double total = t_ayam + t_sate + t_mie + t_tahu + t_burger + t_nasi + t_jeruk + t_air + t_teh + t_alpukat + t_coffe;
            double pajak = 0.1;
            double ppn = total * pajak;
            double biaya_dikurang = total - ppn;
            txt_pajak.Text = "Rp. " + ppn.ToString();

            txt_totalbiaya.Text = "Rp. " + total.ToString("N");
            bayar = double.Parse(text_uang.Text);
            kembali = bayar - biaya_dikurang;
            txt_kembali.Text = "Rp. " + kembali.ToString("N");

            MessageBox.Show(" Terima Kasih... Kembalian Anda sebesar :Rp. " + kembali.ToString());
            n_nasi.Focus();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeric_ayam_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_totalbiaya_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numeric_tahu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_sate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_mie_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_burger_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeric_jeruk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_minuman_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void text_uang_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtwaktu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin keluar?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No);

            else
            {
                Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // membersihkan layar jika tombol reset di klik

            n_burger.Clear();
            n_nasi.Clear();
            n_sate.Clear();
            n_mie.Clear();
            n_tahu.Clear();
            n_ayam.Clear();

            n_air.Clear();
            n_alpukat.Clear();
            n_teh.Clear();
            n_jeruk.Clear();
            n_coffe.Clear();

            txt_kembali.Clear();
            txt_pajak.Clear();
            txt_totalbiaya.Clear();
            text_uang.Clear();
          
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 close = new form2();
            close.Show(); // untuk membuka layar form2
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            n_burger.Clear();
            n_nasi.Clear();
            n_sate.Clear();
            n_mie.Clear();
            n_tahu.Clear();
            n_ayam.Clear();

            n_air.Clear();
            n_alpukat.Clear();
            n_teh.Clear();
            n_jeruk.Clear();
            n_coffe.Clear();

            txt_kembali.Clear();
            txt_pajak.Clear();
            txt_totalbiaya.Clear();
            text_uang.Clear();
        }

        private void txtayam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
