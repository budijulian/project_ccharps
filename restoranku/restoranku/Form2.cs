using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace restoranku
{
    public partial class form2 : Form
    {
        MySqlConnection con = connecctionServise.getConnection();
        public form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login1_Click(object sender, EventArgs e)
        {
            
            if (login(txt_unsername.Text,txt_password.Text))
            {              
                Form1 oform1 = new Form1();
                oform1.ShowDialog(); // menuju ke form1 jika login benar
                this.Hide(); // untuk menyembunyikan form1
                Close();
            }
            else
            {
               
                MessageBox.Show("Maaf, Username or Password Anda Salah!");
            }
            txt_unsername.Focus();

        }
         private Boolean login(string username ,string password)
            {
                string SQL = "SELECT username,password FROM user"; /// ini berguna untuk membaca password dan unsername yang di simpan di database
                con.Open();
                MySqlCommand cmd = new MySqlCommand (SQL,con);
                MySqlDataReader reader = cmd.ExecuteReader();
             
                     
                while (reader.Read())
                {
                    if ((username == reader.GetString(0)) && (password == reader.GetString(1)))
                    {
                        con.Close();
                        return true;
                    }
                    else if ((username != reader.GetString(0)) && (password != reader.GetString(1)))
                    { 
                        
                    }
                }
                     
                con.Close();
                return false;
                
        }

        private void form2_Load(object sender, EventArgs e)
        {
            txt_unsername.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string config = "datasource = localhost;port=login;username = root;password=root";
            string Query = "insert into database.user(username,password) values(' " + this.txt_unsername.Text + "','" + this.txt_password.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(config);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myreader;

            try
            {
                conDataBase.Open();
                myreader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Data di simpan");

                while (myreader.Read()) 
                {
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
