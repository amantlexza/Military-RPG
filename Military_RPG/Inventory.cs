using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_RPG
{
    public class Inventory
    {

        //fields 
        private int _invId;
        private string _invName;
        private float _weight;

        // Properties
        public int InventoryID { get=> this._invId; set=> this._invId = value; }
        public string InventoryName { get => this._invName; set => this._invName = value; }
        public float Weight { get => this._weight; set => this._weight = value; }

        //Default Constructor 
        public Inventory(){}


        //Paramatized Constructor 
        public Inventory(int invId, string invName, float weight) 
        {

            this._invId = invId;
            this._invName = invName;
            this._weight = weight;
        }





    }
}
