using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Documents;
using System.Drawing;
using System.Windows.Controls;
using Image = System.Drawing.Image;
using System.Data.SqlClient;


namespace projectfastfood
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        string ConnectionString = "server=localhost;user=root;password=;port=3306;database=fastfood_db";
            public void Load_Items()
            {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT order_num, order_name, balance, order_img FROM orders_db", connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    ControlFoods controlFoods = new ControlFoods();
                    controlFoods.Pnumber = reader["order_num"].ToString();
                    controlFoods.Pname = reader["order_name"].ToString();
                    controlFoods.Pbalance = reader["balance"].ToString() + " ฿";

                    byte[] imageData = (byte[])reader["order_img"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        controlFoods.PImage = Image.FromStream(ms);
                    }

                    flowLayoutPanel1.Controls.Add(controlFoods);
                }
                reader.Close();
                }
            }

        private void Load_data()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT order_num, order_name, balance, datatime FROM orders_db", connection);
                DataTable dt = new DataTable();

                dt.Load(command.ExecuteReader());
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, row["order_num"], row["order_name"], row["balance"], row["datatime"]);
                }
                connection.Close();
            }
        }

        private void new_order()
        {
            dataGridViewOrders.Rows.Clear();
            TboxAmount.Clear();
            TboxTotle.Clear();
            TboxBalance.Clear();
            Listorder.Clear();
        }
        private void btnmanage_Click(object sender, EventArgs e)
        {
            Forminsert form = new Forminsert();
            form.Show();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TboxAmount.Text))
            {
                MessageBox.Show("กรุณากรอกจำนวนเงิน", "ข้อความ");
                return;
            }
            if (Convert.ToDecimal(TboxBalance.Text) < 0)
            {
                MessageBox.Show("ไม่สามารถทำการชำระออเดอร์ได้", "ข้อความ");
                return;
            }
            if (MessageBox.Show("ทำการชำระออเดอร์", "ข้อความ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("ได้ทำการชำระออเดอร์เเล้ว", "ข้อความ");
                new_order();
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT order_num, order_name, balance, datatime FROM orders_db WHERE order_num LIKE @Search OR order_name LIKE @Search", connection);

                command.Parameters.AddWithValue("@Search", "%" + textBox1.Text + "%");

                DataTable dt = new DataTable();

                dt.Load(command.ExecuteReader());
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, row["order_num"], row["order_name"], row["balance"], row["datatime"]);
                }
                connection.Close();
            }
        }

        private void TboxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double grandtotal = 0;
                for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)
                {
                    grandtotal += Convert.ToDouble(dataGridViewOrders.Rows[i].Cells[5].Value);
                }
                TboxBalance.Text = (Convert.ToDecimal(TboxAmount.Text) - Convert.ToDecimal(grandtotal)).ToString("#,##0.00");

            }
            catch (Exception ex)
            {

            }
        }

        private void Get_grandTotal()
        {
            try
            {
                double grandtotal = 0;
                for (int i = 0; i < dataGridViewOrders.Rows.Count; i++)
                {
                    grandtotal += Convert.ToDouble(dataGridViewOrders.Rows[i].Cells[5].Value);
                }
                TboxTotle.Text = grandtotal.ToString("#,##0.00 ฿");
                lbl_tot.Text = grandtotal.ToString();
            }
            catch (Exception ex)
            {
             
            }
        }

        private void TboxSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT order_num, order_name, balance,order_img FROM orders_db WHERE order_num LIKE @Search OR order_name LIKE @Search", connection);
                command.Parameters.AddWithValue("@Search", "%" + TboxSearch.Text + "%");

                MySqlDataReader reader = command.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    ControlFoods resultLabel = new ControlFoods();
                    resultLabel.Text = "" + reader["order_num"].ToString() + "\n" +
                                       "" + reader["order_name"].ToString() + "\n" +
                                       "" + reader["balance"].ToString();

                    resultLabel.AutoSize = true;

                    flowLayoutPanel1.Controls.Add(resultLabel);
                }
                reader.Close();
                connection.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการออกจากระบบหรือไม่?", "ยืนยันการออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Close();
                string message = "ได้ทำการออกจากระบบแล้ว";
                MessageBox.Show(message);

                Formlogin FormLogout = new Formlogin();
                FormLogout.Show();
                this.Hide();
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn1.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn1.BackColor = Color.LawnGreen;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn2.BackColor = Color.Red;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn2.BackColor = Color.LawnGreen;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn3.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn3.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn4.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn4.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn5.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn5.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn6.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn6.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn7.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn7.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn8.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn8.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn9.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn9.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn10.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn10.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn11.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn11.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn12.BackColor = Color.Red;
                Red++;
                LawnGreen--;
            }
            else
            {
                if (MessageBox.Show("คุณต้องการจะจองโต๊ะใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel)
                    == DialogResult.OK) btn12.BackColor = Color.LawnGreen;
                Red--;
                LawnGreen++;
            }

        }
        int Red, LawnGreen;

        private void btnTable_Click(object sender, EventArgs e)
        {
            pnlPosition.Height = btnTable.Height;
            pnlPosition.Top = btnTable.Top;
            panelTable.Visible = true;
            panelOrders.Visible = false;
            panelOrder.Visible = false;
            panelAct.Visible = false;
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            pnlPosition.Height = btnFoods.Height;
            pnlPosition.Top = btnFoods.Top;
            panelTable.Visible = false;
            panelOrders.Visible = true;
            panelOrder.Visible = false;
            panelAct.Visible = false;
        }

        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {
            Load_data();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            pnlPosition.Height = btnAct.Height;
            pnlPosition.Top = btnAct.Top;
            panelTable.Visible = false;
            panelOrders.Visible = false;
            panelOrder.Visible = false;
            panelAct.Visible = true;
        }

        private void panelOrders_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Get_grandTotal();
            Load_Items();
        }

        private void btnNeworder_Click(object sender, EventArgs e)
        {
            new_order();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlPosition.Height = btnOrder.Height;
            pnlPosition.Top = btnOrder.Top;
            panelTable.Visible = false;
            panelOrders.Visible = false;
            panelOrder.Visible = true;
            panelAct.Visible = false;
        }
    }
}