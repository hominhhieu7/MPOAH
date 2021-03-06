USE [QLHT]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hovaten] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Tuoi] [int] NULL,
	[Sodienthoai] [bigint] NULL,
	[Ghichu] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Employee]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hovaten] [nvarchar](50) NULL,
	[Diachi] [nvarchar](max) NULL,
	[Sodienthoai] [bigint] NULL,
	[Username] [varchar](20) NULL,
	[Password] [varchar](20) NULL,
	[Position] [varchar](2) NULL,
 CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_ListMedicine]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ListMedicine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Madanhmuc] [nvarchar](50) NULL,
	[Tendanhmuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ListMedicine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Medicine]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Medicine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mathuoc] [varchar](50) NULL,
	[Tenthuoc] [nvarchar](50) NULL,
	[Danhmuc] [nvarchar](50) NULL,
	[Soluong] [float] NOT NULL,
	[Ngaynhap] [datetime] NULL,
	[Gianhap] [money] NULL,
	[Giaban] [money] NULL,
	[Addwho] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Medicine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Order]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[CustomerName] [nvarchar](50) NULL,
	[OrderCode] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [nvarchar](50) NULL,
	[TotalProduct] [int] NULL,
	[TotalMoney] [float] NULL,
 CONSTRAINT [PK_tbl_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_OrderDetail]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [nchar](10) NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
	[PriceProduct] [float] NULL,
	[TotalMoney] [float] NULL,
 CONSTRAINT [PK_tbl_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Thuoc]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Thuoc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Madanhmuc] [nvarchar](50) NULL,
	[Tenthuoc] [nvarchar](50) NULL,
	[Mathuoc] [char](5) NULL,
 CONSTRAINT [PK_tbl_Thuoc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Customer] ON 

INSERT [dbo].[tbl_Customer] ([Id], [Hovaten], [Diachi], [Gioitinh], [Tuoi], [Sodienthoai], [Ghichu]) VALUES (1, N'Nguyen Van A', N'123 Wood Street', N'Nữ', 19, 979383120, N'')
INSERT [dbo].[tbl_Customer] ([Id], [Hovaten], [Diachi], [Gioitinh], [Tuoi], [Sodienthoai], [Ghichu]) VALUES (2, N'Nguyen Van B', N'113 Cong an', N'Nam', 20, 1234, N'')
SET IDENTITY_INSERT [dbo].[tbl_Customer] OFF
SET IDENTITY_INSERT [dbo].[tbl_Employee] ON 

INSERT [dbo].[tbl_Employee] ([Id], [Hovaten], [Diachi], [Sodienthoai], [Username], [Password], [Position]) VALUES (1, N'Hieu AD', N'123 asd', 9090909, N'admin', N'123', N'GD')
INSERT [dbo].[tbl_Employee] ([Id], [Hovaten], [Diachi], [Sodienthoai], [Username], [Password], [Position]) VALUES (3, N'Hieu NV', N'xzczx1', 12121, N'1', N'1', N'NV')
SET IDENTITY_INSERT [dbo].[tbl_Employee] OFF
SET IDENTITY_INSERT [dbo].[tbl_ListMedicine] ON 

INSERT [dbo].[tbl_ListMedicine] ([Id], [Madanhmuc], [Tendanhmuc]) VALUES (1, N'DM1', N'Thuoc te')
INSERT [dbo].[tbl_ListMedicine] ([Id], [Madanhmuc], [Tendanhmuc]) VALUES (2, N'DM2', N'Thuoc gay me')
INSERT [dbo].[tbl_ListMedicine] ([Id], [Madanhmuc], [Tendanhmuc]) VALUES (3, N'DM3', N'Thuoc tay')
INSERT [dbo].[tbl_ListMedicine] ([Id], [Madanhmuc], [Tendanhmuc]) VALUES (4, N'DM4', N'Thuoc tri benh')
SET IDENTITY_INSERT [dbo].[tbl_ListMedicine] OFF
SET IDENTITY_INSERT [dbo].[tbl_Medicine] ON 

INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (1, N'TH002', N'Panadon', N'DM1', 9, CAST(N'2018-12-25 11:08:31.677' AS DateTime), 1500.0000, 3000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (2, N'TH002', N'Panadon', N'DM1', 90, CAST(N'2018-12-25 11:08:06.810' AS DateTime), 120000.0000, 3000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (3, N'TH002', N'Panadon', N'DM1', 100, CAST(N'2018-12-25 11:08:01.163' AS DateTime), 12000.0000, 3000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (5, N'TH002', N'Panadon', N'DM1', 50, CAST(N'2018-12-25 11:07:54.237' AS DateTime), 120000.0000, 3000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (6, N'TH002', N'Panadon', N'DM1', 100, CAST(N'2018-12-25 11:08:12.550' AS DateTime), 120000.0000, 3000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (7, N'TH001', N'Halothan', N'DM2', 10, CAST(N'2018-12-11 13:55:54.437' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (8, N'TH002', N'Panadon', N'DM1', 10, CAST(N'2018-12-11 13:56:20.753' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (9, N'TH004', N'Ketamin', N'DM1', 9, CAST(N'2018-12-11 13:56:28.057' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (10, N'TH001', N'Halothan', N'DM2', 10, CAST(N'2018-12-11 13:56:39.117' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (11, N'TH004', N'Ketamin', N'DM1', 10, CAST(N'2018-12-11 13:56:52.653' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (12, N'TH005', N'Diclofenac', N'DM3', 10, CAST(N'2018-12-11 13:57:01.627' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (13, N'TH005', N'Diclofenac', N'DM3', 10, CAST(N'2018-12-11 13:57:10.200' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
INSERT [dbo].[tbl_Medicine] ([Id], [Mathuoc], [Tenthuoc], [Danhmuc], [Soluong], [Ngaynhap], [Gianhap], [Giaban], [Addwho]) VALUES (14, N'TH003', N'Ibuprofen', N'DM3', 10, CAST(N'2018-12-11 13:57:27.643' AS DateTime), 12000.0000, 20000.0000, N'Hieu Pro')
SET IDENTITY_INSERT [dbo].[tbl_Medicine] OFF
SET IDENTITY_INSERT [dbo].[tbl_Thuoc] ON 

INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (1, N'DM1', N'Panadon', N'TH002')
INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (2, N'DM2', N'Halothan', N'TH001')
INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (3, N'DM3', N'Ibuprofen', N'TH003')
INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (4, N'DM1', N'Ketamin', N'TH004')
INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (5, N'DM3', N'Diclofenac', N'TH005')
INSERT [dbo].[tbl_Thuoc] ([Id], [Madanhmuc], [Tenthuoc], [Mathuoc]) VALUES (6, N'DM4', N'Thuốc ho', N'TH006')
SET IDENTITY_INSERT [dbo].[tbl_Thuoc] OFF
/****** Object:  StoredProcedure [dbo].[sp_Order_Save]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Order_Save]
(
	@Id						int,
	@CustomerId				int,
	@CustomerName			nvarchar(50),
	@OrderCode				varchar(50),
	@CreateBy				nvarchar(50),
	@TotalProduct			int,
	@TotalMoney				float
	
)
AS
BEGIN
	declare @idtb Table (id int)
	if @Id = 0 ---- ADD----
		begin
			Insert into tbl_Order
					( CustomerId,
					  CustomerName,
					  OrderCode,
					  CreateDate,
					  CreateBy,
					  TotalProduct,
					  TotalMoney
					 )
					OUTPUT INSERTED.ID
			values
					(
						@CustomerId,
						@CustomerName,
						@OrderCode,
						getdate(),
						@CreateBy,
						@TotalProduct,
						@TotalMoney
					)
			select id from @idtb
			return
		end
	else
	
	select 0
END
GO
/****** Object:  StoredProcedure [dbo].[sp_OrderDetail_Save]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_OrderDetail_Save]
(
	@OrderId		int,
	@ProductId		int,
	@Quantity		int,
	@PriceProduct	float,
	@TotalMoney		float
)
AS
BEGIN
		begin
			insert into tbl_OrderDetail
						(	OrderId,
							ProductId,
							Quantity,
							PriceProduct,
							TotalMoney
						)
					values
						(	@OrderId,
							@ProductId,
							@Quantity,
							@PriceProduct,
							@TotalMoney
						)
					
		end

		select 'ok'
END
--exec sp_OrderDetail_Save @OrderId=

GO
/****** Object:  StoredProcedure [dbo].[sp_Product_UpdateOrder]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create proc [dbo].[sp_Product_UpdateOrder]
(
	@Id int,
	@Quantity int
)
as
begin
	Update tbl_Medicine set Soluong = Soluong - @Quantity
	Where Id = @Id

	Select 'OK'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportMedicine_List]    Script Date: 12/27/2018 7:23:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ReportMedicine_List]
AS
BEGIN
	select Mathuoc,Tenthuoc, SUM(soluong) as tongsothuoc from tbl_Medicine
	group by Mathuoc,Tenthuoc
END

GO
