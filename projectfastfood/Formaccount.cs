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
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace projectfastfood
{
    public partial class Formaccount : Form
    {
        public Formaccount()
        {
            InitializeComponent();
        }
        string connString = "server=localhost;user=root;password=;port=3306;database=fastfood_db";
        private void btnback_Click(object sender, EventArgs e)
        {
            Formlogin FormLogin = new Formlogin();
            FormLogin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Formlogin FormLogin = new Formlogin();
            FormLogin.Show();
            this.Hide();
        }
        private void Tboxpass1_TextChanged(object sender, EventArgs e)
        {
            Tboxpass1.PasswordChar = '*';
        }

        private void Tboxpass2_TextChanged(object sender, EventArgs e)
        {
            Tboxpass2.PasswordChar = '*';
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string usernum = Tboxid.Text;
            string username = Tboxuser.Text;
            string password1 = Tboxpass1.Text;
            string password2 = Tboxpass2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("กรุณากรอกข้อมูลผู้สมัคร");
                return;
            }
            if (password1 != password2)
            {
                MessageBox.Show("Password ไม่ตรงกัน");
                return;
            }
            
            conn.Open();
            string sqlSelect = "SELECT * FROM user_db WHERE user_name = @username";
            MySqlCommand commandSelect = new MySqlCommand(sqlSelect, conn);
            commandSelect.Parameters.AddWithValue("@username", username);
            int count = Convert.ToInt32(commandSelect.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("มีผู้ใช้งานนี้อยู่เเล้ว");
                return;
            }
            string sqlInsert = "INSERT INTO user_db (user_num, user_name, password) VALUES (@usernum, @username, @password)";
            MySqlCommand command = new MySqlCommand(sqlInsert, conn);
            command.Parameters.AddWithValue("@usernum", usernum);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password1);
            command.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("ทำการสมัครผู้ใช้งานเเล้ว");
            Formlogin FormLogin = new Formlogin();
            FormLogin.Show();
            this.Hide();
        }
    }
}