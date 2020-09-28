--Create DB
CREATE DATABASE MilitaryDB

USE MilitaryDB


/*Measurement Unit used 
Height in Feet
Fuel in Gallons
Altitude in Feet
Speed in Kilometers/ hour
Weight in Pounds*/




-- Table for obstacles 
CREATE TABLE Obstacles
(ObsID int primary key Identity(101,1),
Height float not null,
TargetY int,
TargetX int )

--Table for Camp placements
CREATE TABLE Camp 
(CampID int primary key Identity(101,1),
TargetY int,
TargetX int,
)

--Table for Camp Sections 
CREATE TABLE Section
(
SectionID int primary key Identity(101,1),
SectionName varchar(50),
TargetY int,
TargetX int,
PrioriyLevel int,
CampID int FOREIGN KEY References Camp(CampID) )

--Table for Inventory
CREATE TABLE Inventory
(InventoryID int primary key Identity(101,1),
InvName varchar(50),
Weight float
)


-- Table for Aircraft Type
CREATE TABLE AircraftType
(CraftTypeID int primary key Identity(101,1),
CraftType varchar(50),
)

--Table for Aircrafts 
CREATE TABLE Aircraft
(AircraftID int primary key Identity(101,1),
AirCraft varchar(50),
Fuel float,
Altitude float,
Speed float,
MaxWeight float,
CraftTypeID int FOREIGN KEY References AircraftType(CraftTypeID)
)



-- Table for Ammunition/Weapons
CREATE TABLE AmmunitionType
(AmmoID int primary key Identity(101,1),
AmmoType varchar(50)
)


--Secondary Table for Ammunition x Aircraft

CREATE TABLE AirAmmo
(
AirAmmoID int primary key Identity(101,1),
AircraftID int FOREIGN KEY References Aircraft(AircraftID),
AmmoID int FOREIGN KEY References AmmunitionType(AmmoID)
)

--Secondary Table for Inventory x Aircraft

CREATE TABLE AirInv
(
AirInvID int primary key Identity(101,1),
AircraftID int FOREIGN KEY References Aircraft(AircraftID),
InventoryID int FOREIGN KEY References Inventory(InventoryID)
)