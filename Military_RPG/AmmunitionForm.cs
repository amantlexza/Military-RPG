using System;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AmmunitionForm_Load(object sender, EventArgs e)
        {
            DataHandler inventoryData = new DataHandler();
            dgvFromDB.DataSource = inventoryData.populateAmmoDGV();
        }
    }
}
