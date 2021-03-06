﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_RPG
{
    public partial class AmmunitionForm : Form
    {
        public AmmunitionForm()
        {
            InitializeComponent();
        }

        
        private void AmmunitionForm_Load(object sender, EventArgs e)
        {
            DataHandler inventoryData = new DataHandler();
            dgvFromDB.DataSource = inventoryData.populateAmmoDGV();
            AddBtn.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ContBtn_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
            this.Hide();
        }

        private void dgvFromDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate type lbl
            typeLbl.Text = "Ammunition Type";
            // show button
            AddBtn.Show();
            //Declare object 
            DataGridViewRow row = dgvFromDB.Rows[e.RowIndex];
            AmmunitionText.Text = row.Cells[1].Value.ToString();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //Previous form
            AirCraftForm airCraftForm = new AirCraftForm();
            airCraftForm.Show();
            this.Hide();
        }
    }
}
