namespace Military_RPG
{
    public class AirCraft
    {
        //Fields 
        int _airCraftID;
        string _airCraftName;
        float _fuel;
        float _speed;
        float _maxWeight;
        int _craftTypeID;


        //Properties 
        public int AirCraftID { get => this._airCraftID; set => this._airCraftID = value; }
        public string AirCraftName { get => this._airCraftName; set => this._airCraftName = value; }
        public float Fuel { get => this._fuel; set => this._fuel = value; }
        public float Speed { get => this._speed; set => this._speed = value; }
        public float MaxWeight { get => this._maxWeight; set => this._maxWeight = value; }
        public int CraftypeId { get => this._craftTypeID; set => this._craftTypeID = value; }




        //Default constructor 
        public AirCraft() { }

        //Paramatized constructor 
        public AirCraft(int airCraftID, string airCraftName, float fuel, float speed, float maxWeight, int craftTypeID) 
        {
            this._airCraftID = airCraftID;
            this._airCraftName = airCraftName;
            this._fuel = fuel;
            this._speed = speed;
            this._maxWeight = maxWeight;
            this._craftTypeID = craftTypeID;
        }
    }

 }
