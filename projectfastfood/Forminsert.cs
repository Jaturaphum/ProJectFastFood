using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using Vintasoft.Imaging.Annotation.Comments;
using System.Diagnostics.Eventing.Reader;

namespace projectfastfood
{
    public partial class Forminsert : Form
    {
        public Forminsert()
        {
            InitializeComponent();
        }

        string connString = "server=localhost;user=root;password=;port=3306;database=fastfood_db";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roundPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog pop = new OpenFileDialog();
            if (pop.ShowDialog() != DialogResult.Cancel)
            {
                roundPicture.Image = Image.FromFile(pop.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string ordername = TboxOrder_name.Text;
            string balance = TboxBalance.Text;
            string numId = TboxNum.Text;

            byte[] Imageuser = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                roundPicture.Image.Save(ms, ImageFormat.Jpeg);
                Imageuser = ms.ToArray();
            } 

            conn.Open();
            string sqlCheckDuplicate = "SELECT COUNT(*) FROM orders_db WHERE order_name = @Odname OR order_num = @Ordernum";
            MySqlCommand checkDuplicateCommand = new MySqlCommand(sqlCheckDuplicate, conn);
            checkDuplicateCommand.Parameters.AddWithValue("@Odname", ordername);
            checkDuplicateCommand.Parameters.AddWithValue("@Ordernum", numId);
            int count = Convert.ToInt32(checkDuplicateCommand.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("ได้มีออเดอร์นี้อยู่เเล้ว");
                return;
            }

            string sqlInsert = "INSERT INTO orders_db (order_name, balance, order_img, order_num) VALUES (@Odname, @Balance, @Img, @Ordernum)";
            MySqlCommand insertCommand = new MySqlCommand(sqlInsert, conn);
            insertCommand.Parameters.AddWithValue("@Odname", ordername);
            insertCommand.Parameters.AddWithValue("@Balance", balance);
            insertCommand.Parameters.AddWithValue("@Ordernum", numId);
            insertCommand.Parameters.AddWithValue("@Img", Imageuser);
            insertCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("ได้เพิ่มออเดอร์สินค้าแล้ว");

            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string ordername = TboxOrder_name.Text;
            string balance = TboxBalance.Text;
            string numId = TboxNum.Text;

            byte[] Imageuser = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                roundPicture.Image.Save(ms, ImageFormat.Jpeg);
                Imageuser = ms.ToArray();
            }

            conn.Open();
            string sqlUpdate = "UPDATE orders_db SET order_name = @Odname, balance = @Balance, order_img = @Img WHERE order_num = @Ordernum";
            MySqlCommand updateCommand = new MySqlCommand(sqlUpdate, conn);
            updateCommand.Parameters.AddWithValue("@Odname", ordername);
            updateCommand.Parameters.AddWithValue("@Balance", balance);
            updateCommand.Parameters.AddWithValue("@Ordernum", numId);
            updateCommand.Parameters.AddWithValue("@Img", Imageuser);
            updateCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("อัปเดตออเดอร์สินค้าแล้ว");

            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string numId = TboxNum.Text;

            conn.Open();
            string sqlDelete = "DELETE FROM orders_db WHERE order_num = @Ordernum";
            MySqlCommand deleteCommand = new MySqlCommand(sqlDelete, conn);
            deleteCommand.Parameters.AddWithValue("@Ordernum", numId);
            deleteCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("ได้ลบออเดอร์สินค้าแล้ว");

            Clear();
        }

        private void Clear()
        {
            TboxOrder_name.Text = "202300";
            TboxBalance.Text = "";
            TboxNum.Text = "";
            roundPicture.Image = null;
        }

        private void TboxNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string search = TboxSearch.Text;

            if (search == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะค้นหา");
                return;
            }

            string query = "SELECT * FROM orders_db WHERE order_num = @ordernumber";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ordernumber", search);

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TboxOrder_name.Text = reader["order_name"].ToString();
                TboxNum.Text = reader["order_num"].ToString();
                TboxBalance.Text = reader["balance"].ToString();
                byte[] imgData = (byte[])reader["order_img"];
                if (imgData != null && imgData.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(imgData);
                    roundPicture.Image = Image.FromStream(ms);
                }
            }
            reader.Close();
            conn.Close();
        }
    }
}
