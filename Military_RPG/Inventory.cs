using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_RPG
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server=DESKTOP-LATTHOF\AMANTLE; Initial Catalog=MilitaryDB; Integrated Security=SSPI");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * From Inventory", connection);
                SqlDataReader reader = command.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = reader;
                dataGridView1.DataSource = source;
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
