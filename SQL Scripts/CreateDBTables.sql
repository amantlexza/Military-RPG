USE [MilitaryDB]
GO
/****** Object:  Table [dbo].[AirAmmo]    Script Date: 10/2/2020 11:16:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirAmmo](
	[AirAmmoID] [int] IDENTITY(101,1) NOT NULL,
	[AircraftID] [int] NULL,
	[AmmoID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AirAmmoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aircraft]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aircraft](
	[AircraftID] [int] IDENTITY(101,1) NOT NULL,
	[AirCraft] [varchar](50) NULL,
	[Fuel] [float] NULL,
	[Altitude] [float] NULL,
	[Speed] [float] NULL,
	[MaxWeight] [float] NULL,
	[CraftTypeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AircraftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AircraftType]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AircraftType](
	[CraftTypeID] [int] IDENTITY(101,1) NOT NULL,
	[CraftType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CraftTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AirInv]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AirInv](
	[AirInvID] [int] IDENTITY(101,1) NOT NULL,
	[AircraftID] [int] NULL,
	[InventoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AirInvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AmmunitionType]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmmunitionType](
	[AmmoID] [int] IDENTITY(101,1) NOT NULL,
	[AmmoType] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AmmoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camp]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camp](
	[CampID] [int] IDENTITY(101,1) NOT NULL,
	[TargetY] [int] NULL,
	[TargetX] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CampID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CampSection]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CampSection](
	[CampSectionID] [int] IDENTITY(101,1) NOT NULL,
	[TargetY] [int] NULL,
	[TargetX] [int] NULL,
	[CampID] [int] NULL,
	[SectionID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CampSectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryID] [int] IDENTITY(101,1) NOT NULL,
	[InvName] [varchar](50) NULL,
	[Weight] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obstacles]    Script Date: 10/2/2020 11:16:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obstacles](
	[ObsID] [int] IDENTITY(101,1) NOT NULL,
	[Height] [float] NOT NULL,
	[TargetY] [int] NULL,
	[TargetX] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ObsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 10/2/2020 11:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[SectionID] [int] IDENTITY(101,1) NOT NULL,
	[SectionName] [varchar](50) NULL,
	[PrioriyLevel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aircraft] ON 

INSERT [dbo].[Aircraft] ([AircraftID], [AirCraft], [Fuel], [Altitude], [Speed], [MaxWeight], [CraftTypeID]) VALUES (101, N'F-16 Fighting Falcon', 1000, 65000, 2414, 20300, 102)
INSERT [dbo].[Aircraft] ([AircraftID], [AirCraft], [Fuel], [Altitude], [Speed], [MaxWeight], [CraftTypeID]) VALUES (102, N'McDonnell Douglas F-15 Eagle', 7500, 78000, 3017, 48000, 103)
INSERT [dbo].[Aircraft] ([AircraftID], [AirCraft], [Fuel], [Altitude], [Speed], [MaxWeight], [CraftTypeID]) VALUES (103, N'Lockheed AC-130', 6700, 50000, 482, 80000, 105)
SET IDENTITY_INSERT [dbo].[Aircraft] OFF
SET IDENTITY_INSERT [dbo].[AircraftType] ON 

INSERT [dbo].[AircraftType] ([CraftTypeID], [CraftType]) VALUES (101, N'Attack')
INSERT [dbo].[AircraftType] ([CraftTypeID], [CraftType]) VALUES (102, N'Fighter')
INSERT [dbo].[AircraftType] ([CraftTypeID], [CraftType]) VALUES (103, N'Multirole')
INSERT [dbo].[AircraftType] ([CraftTypeID], [CraftType]) VALUES (104, N'Air Superiority Fighter')
INSERT [dbo].[AircraftType] ([CraftTypeID], [CraftType]) VALUES (105, N'VC-25A')
SET IDENTITY_INSERT [dbo].[AircraftType] OFF
SET IDENTITY_INSERT [dbo].[Inventory] ON 

INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (101, N'FoodPack1', 7000)
INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (102, N'FoodPack2', 2500)
INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (103, N'Medic Supplies ', 1000)
INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (104, N'Toiletries', 1000)
INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (105, N'Blankets', 10000)
INSERT [dbo].[Inventory] ([InventoryID], [InvName], [Weight]) VALUES (106, N'Ammunition', 20000)
SET IDENTITY_INSERT [dbo].[Inventory] OFF
SET IDENTITY_INSERT [dbo].[Section] ON 

INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (101, N'Medic', 5)
INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (102, N'Baracks', 3)
INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (103, N'MessHall', 3)
INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (104, N'Tank Hall', 2)
INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (105, N'Officers Quaters ', 3)
INSERT [dbo].[Section] ([SectionID], [SectionName], [PrioriyLevel]) VALUES (106, N'Armory', 1)
SET IDENTITY_INSERT [dbo].[Section] OFF
ALTER TABLE [dbo].[AirAmmo]  WITH CHECK ADD FOREIGN KEY([AircraftID])
REFERENCES [dbo].[Aircraft] ([AircraftID])
GO
ALTER TABLE [dbo].[AirAmmo]  WITH CHECK ADD FOREIGN KEY([AmmoID])
REFERENCES [dbo].[AmmunitionType] ([AmmoID])
GO
ALTER TABLE [dbo].[Aircraft]  WITH CHECK ADD FOREIGN KEY([CraftTypeID])
REFERENCES [dbo].[AircraftType] ([CraftTypeID])
GO
ALTER TABLE [dbo].[AirInv]  WITH CHECK ADD FOREIGN KEY([AircraftID])
REFERENCES [dbo].[Aircraft] ([AircraftID])
GO
ALTER TABLE [dbo].[AirInv]  WITH CHECK ADD FOREIGN KEY([InventoryID])
REFERENCES [dbo].[Inventory] ([InventoryID])
GO
ALTER TABLE [dbo].[CampSection]  WITH CHECK ADD FOREIGN KEY([CampID])
REFERENCES [dbo].[Camp] ([CampID])
GO
ALTER TABLE [dbo].[CampSection]  WITH CHECK ADD FOREIGN KEY([SectionID])
REFERENCES [dbo].[Section] ([SectionID])
GO
