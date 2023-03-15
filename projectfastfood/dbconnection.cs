using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projectfastfood
{
    internal class dbconnection
    {
        public static MySqlConnection conn = new MySqlConnection();
        public static bool result;
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataReader dr;
        public static MySqlDataAdapter da;
        public static int i;
        public static bool dbconn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.ConnectionString = "server=localhost;user=root;password=;port=3306;database=fastfood_db";
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
                MessageBox.Show("Server Not Connected !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
    }
}
