using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Military_RPG
{
    public class DataHandler
    {
        public DataHandler()
        {

        }
        //Create connection string
        string connString = @"Data Source=DESKTOP-LATTHOF\AMANTLE;Initial Catalog=MilitaryDB;Integrated Security=True";
        //Declare SqlConnection object
        SqlConnection conn;
        //Declare SqlCommand object
        SqlCommand command;
        //Declare SqlDataReader object
        SqlDataReader reader;


        //Declare Objects
        Inventory inventory = new Inventory();
        AirCraft airCraft = new AirCraft();
        Ammunition ammunition = new Ammunition();

        //Relavant Lists
        List<Inventory> inventories = new List<Inventory>();
        List<AirCraft> aircrafts = new List<AirCraft>();
        List<Ammunition> ammunitions = new List<Ammunition>();


        //Populate Inventory Form Datagridview
        public List<Inventory> populateInventoryDGV()
        {
            string query = @"SELECT * FROM Inventory";

            //connect
            conn = new SqlConnection(connString);

            conn.Open();

            command = new SqlCommand(query, conn);

            //run query command
            try
            {
                //read data SqlDataReader
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    foreach (var item in reader)
                    {
                        //Store each collumn value in user class variables/field
                        inventory.InventoryID = int.Parse(reader[0].ToString());
                        inventory.InventoryName = reader[1].ToString();
                        inventory.Weight = float.Parse(reader[2].ToString());
                        //Add field values to a usre type list
                        inventories.Add(new Inventory(inventory.InventoryID, inventory.InventoryName, inventory.Weight));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //Return the user list
            return inventories;
        }

        //Populate AirCraft Form Datagridview
        public List<AirCraft> populateAirCraftDGV()
        {
            string query = @"SELECT * FROM Aircraft";

            //connect
            conn = new SqlConnection(connString);

            conn.Open();

            command = new SqlCommand(query, conn);

            //run query command
            try
            {
                //read data SqlDataReader
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    foreach (var item in reader)
                    {
                        //Store each collumn value in user class variables/field
                        airCraft.AirCraftID = int.Parse(reader[0].ToString());
                        airCraft.AirCraftName = reader[1].ToString();
                        airCraft.Fuel = float.Parse(reader[2].ToString());
                        airCraft.Speed = float.Parse(reader[3].ToString());
                        airCraft.MaxWeight = float.Parse(reader[4].ToString());
                        airCraft.CraftypeId = int.Parse(reader[5].ToString());
                        //Add field values to a Aircraft type list
                        aircrafts.Add(new AirCraft(airCraft.AirCraftID, airCraft.AirCraftName, airCraft.Fuel, airCraft.Speed, airCraft.MaxWeight, airCraft.CraftypeId));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //Return the aircrafts list
            return aircrafts;
        }

        //Populate Ammunition Form Datagridview
        public List<Ammunition> populateAmmoDGV()
        {
            string query = @"SELECT * FROM AmmunitionType";

            //connect
            conn = new SqlConnection(connString);

            conn.Open();

            command = new SqlCommand(query, conn);

            //run query command
            try
            {
                //read data SqlDataReader
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    foreach (var item in reader)
                    {
                        //Store each collumn value in user class variables/field
                        ammunition.AmmoID = int.Parse(reader[0].ToString());
                        ammunition.AmmoType = reader[1].ToString();
                        //Add field values to a ammo type list
                        ammunitions.Add(new Ammunition(ammunition.AmmoID, ammunition.AmmoType));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            //Return the ammunition list
            return ammunitions;
        }


    }

 }
