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
    public partial class AirCraftForm : Form
    {
        public AirCraftForm()
        {
            InitializeComponent();
        }

        private void dgvFromDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //Create an object of type DataGridViewRow

            DataGridViewRow row = dgvFromDB.Rows[rowIndex];
           
            airCraftLbl.Text = Convert.ToString(row.Cells[0].Value);
            fuelLbl.Text = Convert.ToString(row.Cells[1].Value);
            altitudeLbl.Text = Convert.ToString(row.Cells[2].Value);
            speedLbl.Text = Convert.ToString(row.Cells[3].Value);
            maxWeightLbl.Text = Convert.ToString(row.Cells[4].Value);
            altitudeLbl.Text = Convert.ToString(row.Cells[5].Value);
        }

        private void AirCraft_Load(object sender, EventArgs e)
        {
            DataHandler inventoryData = new DataHandler();
            dgvFromDB.DataSource = inventoryData.populateAirCraftDGV();

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            //Save to DB

            //Open New Form, close current
            AmmunitionForm ammunitionForm = new AmmunitionForm();
            ammunitionForm.Show();
            this.Hide();
           
        }

      
    }
}
