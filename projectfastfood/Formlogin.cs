using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectfastfood
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
        string connString = "server=localhost;user=root;password=;port=3306;database=fastfood_db";
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            Formaccount FormAccount = new Formaccount();
            FormAccount.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM user_db WHERE user_name=@username AND password=@password";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", Tboxuser.Text);
                command.Parameters.AddWithValue("@password", Tboxpass.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Formmain formmain = new Formmain(GetUsername(), GetPassword());
                    formmain.Show();
                    this.Hide();
                    MessageBox.Show("ได้ทำการล็อกอินสำเร็จแล้ว");
                    return;
                }
                else if (count == 0 && Tboxuser.Text != "" && Tboxpass.Text != "")
                {
                    MessageBox.Show("Username และ Password ไม่ถูกต้อง");
                }
                else if (count == 0 && (Tboxuser.Text == "" || Tboxpass.Text == ""))
                {
                    MessageBox.Show("กรุณากรอก Username และ Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public string GetUsername()
        {
            return Tboxuser.Text;
        }

        public string GetPassword()
        {
            return Tboxpass.Text;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tboxpass_TextChanged(object sender, EventArgs e)
        {
            Tboxpass.PasswordChar = '*';
        }
    }
}
