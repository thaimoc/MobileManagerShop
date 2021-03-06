USE [MobilesApplication]
GO
/****** Object:  Table [dbo].[StockSerries]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockSerries](
	[StockRecievedID] [int] NOT NULL,
	[SerryNumber] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [bit] NOT NULL,
	[Price] [money] NOT NULL,
	[UnitPrice] [nvarchar](50) NULL,
	[Image] [nvarchar](150) NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (1, N'IPhone5', 1, 1200.0000, N'1 Unit/ 1Box', N'448_876_160.jpg', CONVERT(TEXT, N'This is Apple''s Production'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (2, N'IPhone 4S', 1, 1000.0000, N'1Unit/ 1Box', N'467_972_160.jpg', CONVERT(TEXT, N'Anyone can make a larger smartphone display. But if you go large for large’s sake, you end up with a phone that feels oversize, awkward, and hard to use. iPhone 5 features a 4-inch display designed the right way: it’s bigger, but it’s the same width as iPhone 4S. So everything you’ve always done with one hand — typing on the keyboard, for instance '))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (3, N'IPhone 4', 1, 800.0000, N'1 Unit/Box', N'thumbs_endstate.jpg', CONVERT(TEXT, N'It’s hard to believe a phone so thin could offer so many features: a larger display, a faster chip, the latest wireless technology, an 8MP iSight camera, and more. All in a beautiful aluminum body designed and made with an unprecedented level of precision. iPhone 5 measures a mere 7.6 millimeters thin and weighs just 112 grams.1 That’s 18 percent thinner and 20 percent lighter than iPhone 4S. The only way to achieve a design like this is by relentlessly considering (and reconsidering) every single detail — including the details you don’t see.'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (4, N'IPhone 3GS', 1, 500.0000, N'1 Unit/Box', N'a6_hero.png', CONVERT(TEXT, N'A remarkably slim design that still makes room for a larger display and a faster chip. Ultrafast wireless that doesn’t sacrifice battery life. And all-new headphones designed to sound great and fit comfortably. So much went into this iPhone. So you could get even more out of it.'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (5, N'Ipad Mini', 0, 239.0000, N'1 Unit/ 1 Box', N'2012-dept-shelf-ipadmini.png', CONVERT(TEXT, N'Everything you love about iPad — the beautiful screen, fast and fluid performance, FaceTime and iSight cameras, thousands of amazing apps, 10-hour battery life2 — is everything you’ll love about iPad mini, too. And you can hold it in one hand.'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (6, N'Iphone 3G', 0, 0.0000, N'', N'460_936_160.jpg', CONVERT(TEXT, N'Pro '))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (7, N'SamSung Galaxy', 1, 700.0000, N'1 Unit/ Box', N'623_1149_160.jpg', CONVERT(TEXT, N'Sam Sung'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (8, N'Ipad new', 1, 600.0000, N'1 Unit / Box', N'456_916_160.jpg', CONVERT(TEXT, N'New Ipad is ipad second generation!'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (9, N'Ipad new new', 1, 900.0000, N'1 Unit / Box', N'gallery_fallback_hero.jpg', CONVERT(TEXT, N''))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (10, N'IPad 2', 1, 1200.0000, N'1 Unit /  Box', N'2012-dept-shelf-ipad2.png', CONVERT(TEXT, N'This is Apple products'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (11, N'Ipad 3', 1, 1200.0000, N'1 Unit/Box', N'459_931_160.jpg', CONVERT(TEXT, N'This is Apple product''s'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (12, N'IPad new new', 1, 1500.0000, N'1 Unit/Box', N'2012-dept-shelf-ipadmini.png', CONVERT(TEXT, N'this is product''s of apple'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (13, N'iPad 5', 1, 0.0000, N'', N'454_906_160.jpg', CONVERT(TEXT, N''))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (14, N'IPhone 9', 1, 2000.0000, N'', N'456_916_160.jpg', CONVERT(TEXT, N'This is Apple product'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (15, N'IPhone 8', 1, 1500.0000, N'1 Unit/Box', N'465_962_160.jpg', CONVERT(TEXT, N'This is Apple product'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (16, N'IPhone 10', 1, 2500.0000, N'1 Unit/Box', N'448_876_160.jpg', CONVERT(TEXT, N'àdsadfasdfasd'))
INSERT [dbo].[Products] ([ID], [Name], [Type], [Price], [UnitPrice], [Image], [Description]) VALUES (17, N'IPad 8', 1, 2600.0000, N'1 Unit/Box', N'461_945_160.jpg', CONVERT(TEXT, N'This  is Apple Product'))
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Table [dbo].[CategoryMembers]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](32) NOT NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_CategoryMembers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoryMembers] ON
INSERT [dbo].[CategoryMembers] ([Id], [Location], [Description]) VALUES (1, N'Admin', N'Người quản trị hệ thống')
INSERT [dbo].[CategoryMembers] ([Id], [Location], [Description]) VALUES (2, N'Saler', N'Nhân viên bán hàng')
INSERT [dbo].[CategoryMembers] ([Id], [Location], [Description]) VALUES (3, N'Custemer', N'Khách hàng')
SET IDENTITY_INSERT [dbo].[CategoryMembers] OFF
/****** Object:  Table [dbo].[Members]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[UseName] [nvarchar](32) NOT NULL,
	[Pass] [nvarchar](32) NOT NULL,
	[FirstName] [nvarchar](34) NOT NULL,
	[LastName] [nvarchar](34) NOT NULL,
	[BirthDate] [datetime] NULL,
	[Gender] [bit] NOT NULL,
	[NumHouse] [int] NULL,
	[Street] [nvarchar](34) NULL,
	[Urban] [nvarchar](34) NULL,
	[Town] [nvarchar](34) NULL,
	[City] [nvarchar](34) NULL,
	[CategoryMemberID] [int] NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[UseName] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'halan', N'123456', N'Minh', N'An', CAST(0x0000878000000000 AS DateTime), 1, 16, N'Hoàng Diệu', N'Phường 2', N'Quận 5', N'Hà Nội', 3)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'hanguyen', N'123456', N'Hạ', N'Nguyễn', CAST(0x000085A600000000 AS DateTime), 0, 28, N'Lý Nam Đế', N'Phường 2', N'Lý Quốc Oai', N'Hà Nội', 3)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'hoangle', N'123456', N'Lê', N'Nguyễn', CAST(0x0000878500000000 AS DateTime), 1, 57, N'Hai Bà Trưng', N'Phường 9', N'Ba Đình', N'Tp. Hồ Chí Minh', 3)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'kimnguyen', N'123456', N'Kim', N'Nguyễn', CAST(0x0000875300000000 AS DateTime), 1, 59, N'Hoàng Diệu', N'Phường 1', N'Ba Đình', N'Hà Nội', 3)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'kimnguyen1', N'123456', N'Kim', N'Nguyễn', CAST(0x0000875300000000 AS DateTime), 1, 59, N'Hoàng Diệu', N'Phường 1', N'Ba Đình', N'Hà Nội', 3)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'ping5', N'Nguyen', N'Minh Anh', N'Hoàng Vũ', CAST(0x0000807E00000000 AS DateTime), 0, 65, N'Lý Thường Kiệt', N'Phường 12', N'Ba Đình', N'Hà Nội', 1)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'pingkudo5', N'123456', N'Hạo', N'Nguyễn', CAST(0x0000852900000000 AS DateTime), 1, 15, N'Lý Quốc Oai', N'Phường 9', N'Hai Bà Trưng', N'Hà Nội', 1)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'pingproone', N'123456', N'Nguyễn An', N'Kim', CAST(0x0000806800000000 AS DateTime), 1, 9, N'Lý Thường Kiệt', N'Phường 8', N'Ba Đình', N'Hà Nội', 1)
INSERT [dbo].[Members] ([UseName], [Pass], [FirstName], [LastName], [BirthDate], [Gender], [NumHouse], [Street], [Urban], [Town], [City], [CategoryMemberID]) VALUES (N'tuanh', N'123456', N'Tú', N'Nguyễn Anh', CAST(0x0000861700000000 AS DateTime), 0, 28, N'Lý Thái Tổ', N'Phường 5', N'Quận Gò Vấp', N'Tp. Hồ Chí Minh', 3)
/****** Object:  Table [dbo].[Bills]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CusID] [nvarchar](32) NOT NULL,
	[SelID] [nvarchar](32) NOT NULL,
	[RequireDate] [datetime] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bills] ON
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (1, N'halan', N'kimnguyen1', CAST(0x0000A11F00000000 AS DateTime), 1)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (2, N'hanguyen', N'kimnguyen1', CAST(0x0000A11F00000000 AS DateTime), 1)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (3, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (4, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 1)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (5, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 1)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (6, N'kimnguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (7, N'hoangle', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (8, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (9, N'hoangle', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (10, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (12, N'hoangle', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (13, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (14, N'kimnguyen1', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (15, N'kimnguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (16, N'tuanh', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (17, N'kimnguyen1', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (18, N'hanguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (19, N'kimnguyen1', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (20, N'kimnguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (21, N'kimnguyen1', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (22, N'hoangle', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (23, N'kimnguyen1', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (24, N'kimnguyen', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (25, N'ping5', N'ping5', CAST(0x0000A13800000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (26, N'hoangle', N'ping5', CAST(0x0000A13900000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (27, N'kimnguyen1', N'ping5', CAST(0x0000A13900000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (28, N'hoangle', N'ping5', CAST(0x0000A13900000000 AS DateTime), 0)
INSERT [dbo].[Bills] ([ID], [CusID], [SelID], [RequireDate], [Deleted]) VALUES (29, N'hoangle', N'ping5', CAST(0x0000A13900000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Bills] OFF
/****** Object:  Table [dbo].[Orders]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CusID] [nvarchar](32) NOT NULL,
	[DateRequire] [datetime] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (1, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (2, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (3, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (4, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (5, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 0)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (6, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (7, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (8, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (9, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (10, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (11, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (12, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (13, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (14, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (15, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (16, N'ping5', CAST(0x0000A11D00000000 AS DateTime), 0)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (17, N'tuanh', CAST(0x0000A11D00000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (18, N'ping5', CAST(0x0000A13400000000 AS DateTime), 1)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (19, N'ping5', CAST(0x0000A13400000000 AS DateTime), 0)
INSERT [dbo].[Orders] ([ID], [CusID], [DateRequire], [Deleted]) VALUES (20, N'ping5', CAST(0x0000A13500000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
/****** Object:  Table [dbo].[StockReceived]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockReceived](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdminID] [nvarchar](32) NOT NULL,
	[DateEstablish] [datetime] NOT NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_StockReceived] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StockReceived] ON
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (1, N'ping5', CAST(0x0000A11300000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (2, N'pingproone', CAST(0x0000A11200000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (3, N'ping5', CAST(0x0000A11100000000 AS DateTime), 1)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (6, N'ping5', CAST(0x0000A11400000000 AS DateTime), 1)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (37, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (38, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (39, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (40, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 1)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (41, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (42, N'pingproone', CAST(0x0000A11700000000 AS DateTime), 1)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (43, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (44, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (45, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (46, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (47, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (48, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (49, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (50, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (51, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (52, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (53, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (54, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (55, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (56, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (57, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 1)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (58, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (59, N'pingproone', CAST(0x0000A11600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (60, N'ping5', CAST(0x0000A13500000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (61, N'ping5', CAST(0x0000A13500000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (62, N'ping5', CAST(0x0000A13500000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (63, N'ping5', CAST(0x0000A13500000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (64, N'ping5', CAST(0x0000A13600000000 AS DateTime), 0)
INSERT [dbo].[StockReceived] ([ID], [AdminID], [DateEstablish], [Deleted]) VALUES (65, N'ping5', CAST(0x0000A13600000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[StockReceived] OFF
/****** Object:  Table [dbo].[WageCoefficients]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WageCoefficients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Point] [float] NOT NULL,
	[AdminID] [nvarchar](32) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DateEstablished] [datetime] NOT NULL,
 CONSTRAINT [PK_WageCoefficients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[WageCoefficients] ON
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (1, 0.5, N'pingproone', 0, CAST(0x0000A11100000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (2, 0.800000011920929, N'pingproone', 0, CAST(0x0000A0FA00000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (3, 1.2000000476837158, N'pingproone', 0, CAST(0x0000A11800000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (4, 2.2999999523162842, N'pingproone', 1, CAST(0x0000A11100000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (5, 3.5999999046325684, N'pingproone', 0, CAST(0x0000A11100000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (6, 4, N'pingproone', 0, CAST(0x0000A11100000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (7, 4, N'ping5', 1, CAST(0x0000A11E00000000 AS DateTime))
INSERT [dbo].[WageCoefficients] ([ID], [Point], [AdminID], [Deleted], [DateEstablished]) VALUES (8, 3.7999999523162842, N'ping5', 0, CAST(0x0000A13700000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[WageCoefficients] OFF
/****** Object:  Table [dbo].[Wages]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wages](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Premium] [money] NOT NULL,
	[TotalDate] [int] NOT NULL,
	[CoefficientsID] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[IsPay] [bit] NOT NULL,
	[DateEstablished] [datetime] NOT NULL,
	[EmployeeID] [nvarchar](32) NOT NULL,
	[AdminID] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_Wages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Wages] ON
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (1, 50.0000, 25, 2, 1, 0, CAST(0x0000A0C800000000 AS DateTime), N'pingproone', N'pingproone')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (2, 25.0000, 26, 6, 0, 0, CAST(0x0000A0B300000000 AS DateTime), N'kimnguyen', N'pingproone')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (3, 49.0000, 20, 3, 0, 0, CAST(0x0000A0BB00000000 AS DateTime), N'ping5', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (4, 50.0000, 23, 3, 0, 0, CAST(0x0000A08300000000 AS DateTime), N'kimnguyen1', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (5, 20.0000, 25, 3, 0, 0, CAST(0x0000A11100000000 AS DateTime), N'pingproone', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (6, 28.0000, 28, 6, 0, 1, CAST(0x0000A11200000000 AS DateTime), N'kimnguyen1', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (7, 50.0000, 26, 3, 0, 0, CAST(0x0000A0AC00000000 AS DateTime), N'kimnguyen1', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (8, 28.0000, 29, 3, 0, 1, CAST(0x0000A10700000000 AS DateTime), N'ping5', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (9, 38.0000, 25, 3, 1, 0, CAST(0x0000A13600000000 AS DateTime), N'pingkudo5', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (11, 28.0000, 28, 5, 0, 0, CAST(0x0000A13700000000 AS DateTime), N'pingproone', N'ping5')
INSERT [dbo].[Wages] ([ID], [Premium], [TotalDate], [CoefficientsID], [Deleted], [IsPay], [DateEstablished], [EmployeeID], [AdminID]) VALUES (12, 29.0000, 26, 5, 0, 0, CAST(0x0000A13700000000 AS DateTime), N'ping5', N'ping5')
SET IDENTITY_INSERT [dbo].[Wages] OFF
/****** Object:  Table [dbo].[StockReceivedDetails]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockReceivedDetails](
	[StockRecievedID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Count] [int] NOT NULL,
 CONSTRAINT [PK_StockReceivedDetails] PRIMARY KEY CLUSTERED 
(
	[StockRecievedID] ASC,
	[ProductID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (1, 1, 1500.0000, 8)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (1, 2, 1500.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (1, 3, 1200.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (1, 5, 689.0000, 2)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (2, 1, 1000.0000, 10)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (2, 3, 1000.0000, 10)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (3, 1, 1200.0000, 6)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (3, 2, 1000.0000, 2)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (3, 3, 120.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (6, 4, 963.0000, 10)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (6, 5, 1200.0000, 10)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (39, 3, 1000.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (39, 7, 3500.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (40, 5, 600.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (41, 1, 1500.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (41, 3, 1200.0000, 6)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (52, 4, 900.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (56, 5, 800.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (57, 1, 500.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (58, 3, 120.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (59, 1, 1500.0000, 1)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (59, 3, 1000.0000, 3)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (59, 6, 12000.0000, 8)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (60, 4, 1500.0000, 12)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (61, 1, 2000.0000, 2)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (61, 5, 1200.0000, 10)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (62, 1, 20000.0000, 9)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (62, 2, 1200.0000, 8)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (63, 2, 1200.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (63, 6, 1100.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (64, 1, 1800.0000, 12)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (64, 3, 1200.0000, 5)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (65, 1, 1900.0000, 8)
INSERT [dbo].[StockReceivedDetails] ([StockRecievedID], [ProductID], [UnitPrice], [Count]) VALUES (65, 2, 1800.0000, 12)
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[SerryNumber] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProID] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[SerryNumber] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (1, 12, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (2, 13, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (3, 13, 2)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (4, 14, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (5, 14, 2)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (6, 15, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (7, 15, 4)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (8, 15, 5)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (9, 16, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (10, 17, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (11, 18, 7)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (12, 18, 4)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (13, 18, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (21, 19, 5)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (22, 19, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (23, 19, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (24, 19, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (25, 19, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (26, 19, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (27, 20, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (28, 20, 1)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (29, 20, 2)
INSERT [dbo].[OrderDetails] ([SerryNumber], [OrderID], [ProID]) VALUES (30, 20, 2)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
/****** Object:  Table [dbo].[BillDetails]    Script Date: 01/01/2013 15:41:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[OrderID] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (1, 16)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (1, 17)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (2, 5)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (2, 6)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (14, 6)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (15, 7)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (16, 19)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (17, 5)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (18, 3)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (19, 3)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (20, 6)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (21, 6)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (22, 2)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (22, 3)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (23, 1)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (23, 8)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (24, 6)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (24, 10)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (25, 4)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (25, 9)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (26, 7)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (27, 11)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (27, 12)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (27, 14)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (28, 15)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (28, 18)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (29, 13)
INSERT [dbo].[BillDetails] ([BillID], [OrderID]) VALUES (29, 17)
/****** Object:  ForeignKey [FK_BillDetails_Bills]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills]
GO
/****** Object:  ForeignKey [FK_BillDetails_Orders]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Orders]
GO
/****** Object:  ForeignKey [FK_Bills_Members2]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Members2] FOREIGN KEY([CusID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Members2]
GO
/****** Object:  ForeignKey [FK_Bills_Members3]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Members3] FOREIGN KEY([SelID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Members3]
GO
/****** Object:  ForeignKey [FK_Members_CategoryMembers]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_CategoryMembers] FOREIGN KEY([CategoryMemberID])
REFERENCES [dbo].[CategoryMembers] ([Id])
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_CategoryMembers]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Orders]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Products]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
/****** Object:  ForeignKey [FK_Orders_Members]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Members] FOREIGN KEY([CusID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Members]
GO
/****** Object:  ForeignKey [FK_StockReceived_Members]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[StockReceived]  WITH CHECK ADD  CONSTRAINT [FK_StockReceived_Members] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[StockReceived] CHECK CONSTRAINT [FK_StockReceived_Members]
GO
/****** Object:  ForeignKey [FK_StockReceivedDetails_Products]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[StockReceivedDetails]  WITH CHECK ADD  CONSTRAINT [FK_StockReceivedDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[StockReceivedDetails] CHECK CONSTRAINT [FK_StockReceivedDetails_Products]
GO
/****** Object:  ForeignKey [FK_StockReceivedDetails_StockReceived]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[StockReceivedDetails]  WITH CHECK ADD  CONSTRAINT [FK_StockReceivedDetails_StockReceived] FOREIGN KEY([StockRecievedID])
REFERENCES [dbo].[StockReceived] ([ID])
GO
ALTER TABLE [dbo].[StockReceivedDetails] CHECK CONSTRAINT [FK_StockReceivedDetails_StockReceived]
GO
/****** Object:  ForeignKey [FK_WageCoefficients_Members]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[WageCoefficients]  WITH CHECK ADD  CONSTRAINT [FK_WageCoefficients_Members] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[WageCoefficients] CHECK CONSTRAINT [FK_WageCoefficients_Members]
GO
/****** Object:  ForeignKey [FK_Wages_Members]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Wages]  WITH CHECK ADD  CONSTRAINT [FK_Wages_Members] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[Wages] CHECK CONSTRAINT [FK_Wages_Members]
GO
/****** Object:  ForeignKey [FK_Wages_Members1]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Wages]  WITH CHECK ADD  CONSTRAINT [FK_Wages_Members1] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Members] ([UseName])
GO
ALTER TABLE [dbo].[Wages] CHECK CONSTRAINT [FK_Wages_Members1]
GO
/****** Object:  ForeignKey [FK_Wages_WageCoefficients1]    Script Date: 01/01/2013 15:41:36 ******/
ALTER TABLE [dbo].[Wages]  WITH CHECK ADD  CONSTRAINT [FK_Wages_WageCoefficients1] FOREIGN KEY([CoefficientsID])
REFERENCES [dbo].[WageCoefficients] ([ID])
GO
ALTER TABLE [dbo].[Wages] CHECK CONSTRAINT [FK_Wages_WageCoefficients1]
GO
