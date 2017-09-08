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

namespace CEUAppFM
{
    public partial class CollegesManager : Form
    {
        public CollegesManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            MySqlConnection MySQLConn = new MySqlConnection();
            MySqlCommand comm;

            MySQLConn.ConnectionString = "";

            try
            {
                MySQLConn.Open();
                comm = new MySqlCommand("CALL colleges_add(@1, @2, @3);", MySQLConn);
                comm.Parameters.AddWithValue("1", txtCollegeName.Text);
                comm.Parameters.AddWithValue("2", txtCollegeAbbrev.Text);
                comm.Parameters.AddWithValue("3", rtWebScript.Text);

                comm.ExecuteNonQuery();

                MySQLConn.Close();

                MessageBox.Show("Added");

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                MySQLConn.Dispose();
            }
                        
        }
    }
}
