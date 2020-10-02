﻿using System;
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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            DataHandler inventoryData = new DataHandler();
            dgvFromDB.DataSource = inventoryData.populateInventoryDGV();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate type lbl
            Name.Text = "Inventory Name";
            Weight.Text = "Weight";
            // show button
            AddBtn.Show();
            //Declare object 
            DataGridViewRow row = dgvFromDB.Rows[e.RowIndex];
            nameLbl.Text = row.Cells[1].Value.ToString();
            weightLbl.Text = row.Cells[1].Value.ToString();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AmmunitionForm ammunitionForm = new AmmunitionForm();
            ammunitionForm.Show();
            this.Hide();
        }
    }
}
