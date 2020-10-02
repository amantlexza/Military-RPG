using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_RPG
{
    public class Ammunition
    {

        //fields 
        private int _ammoID;
        private string _ammoType;
        
        //properties 
        public int AmmoID { get => this._ammoID; set => this._ammoID = value; }
        public string AmmoType { get => this._ammoType; set => this._ammoType = value; }

        //Default Constructor
        public Ammunition()
        {

        }

        //Default Constructor
        public Ammunition(int ammoID, string ammoType)
        {
            this._ammoID = ammoID;
            this._ammoType = ammoType;
        }



    }
}
