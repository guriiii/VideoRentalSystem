USE [master]
GO
/****** Object:  Database [MovieRentalDB]    Script Date: 24/09/2019 12:04:00 PM ******/
CREATE DATABASE [MovieRentalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieRentalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MovieRentalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieRentalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MovieRentalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MovieRentalDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieRentalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieRentalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieRentalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieRentalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieRentalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieRentalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieRentalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieRentalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieRentalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieRentalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieRentalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieRentalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieRentalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieRentalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MovieRentalDB] SET  MULTI_USER 
GO
ALTER DATABASE [MovieRentalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieRentalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieRentalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieRentalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieRentalDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MovieRentalDB', N'ON'
GO
ALTER DATABASE [MovieRentalDB] SET QUERY_STORE = OFF
GO
USE [MovieRentalDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 24/09/2019 12:04:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 24/09/2019 12:04:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovie]    Script Date: 24/09/2019 12:04:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovie](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovie] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1, N'Nirmal Singh', N'punjab india', N'9815276871')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1002, N'sandeep singh', N'10 ross avenue papatoetoe', N'0272727030')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1003, N'sukhman singh', N'24 cornail road flatbush', N'0274563876')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1004, N'nitin singh', N'56 /2 hillside road papatoetoe', N'02264578567')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1005, N'ishwar singh', N'54/4 hillside road papatoetoe', N'0237656544')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1006, N'rohit khattri', N'12 shirley road papatoetoe', N'0226465867')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1007, N'jaskirat singh', N'10a barrie avenue papatoetoe', N'0274565898')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1008, N'jarnail singh', N'punjab india', N'9814312856')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1009, N'harman singh', N'punjab india', N'9781412378')
INSERT [dbo].[Customer] ([ID], [Name], [Address], [Phone]) VALUES (1010, N'kamal', N'punjab india', N'9878938738')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'5', N'Titanic1', N'2018', 5.0000, N'5', N'In the Russian wilderness, two brothers face a range of new, conflicting emotions when their father - a man they know only through a single photograph - resurfaces.', N'romance,drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1001, N'5', N'Titanic2', N'2018', 5.0000, N'5', N'In the Russian wilderness, two brothers face a range of new, conflicting emotions when their father - a man they know only through a single photograph - resurfaces.', N'romance,drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1002, N'9.2', N'The Godfather', N'1972', 2.0000, N'2', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', N'drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1003, N'8.9', N' Schindler''s List', N'1993', 2.0000, N'2', N'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', N'drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1004, N'8.9', N'12 Angry Men ', N'1957', 2.0000, N'2', N'A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.', N'drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1005, N'8.6', N'Life Is Beautiful ', N'1997', 2.0000, N'2', N'When an open-minded Jewish librarian and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.', N'comedy')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1006, N'8.8', N'The Good, the Bad and the Ugly ', N'2019', 5.0000, N'5', N'A secret agent exacts revenge on a serial killer through a series of captures and releases.', N'crime')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1007, N'9.3', N'The Shawshank Redemption', N'2015', 5.0000, N'5', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', N'drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1008, N'8.0', N'The Shawshank Redemption', N'2005', 2.0000, N'2', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', N'drama')
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1009, N'8.6', N' Seven Samurai', N'2015', 5.0000, N'5', N'A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.', N'adventure,drama')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[RentedMovie] ON 

INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 1, 1, CAST(N'2019-09-16T00:00:00.000' AS DateTime), CAST(N'2019-09-16T22:32:58.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1001, 1, 1001, CAST(N'2019-09-23T00:00:00.000' AS DateTime), CAST(N'2019-09-23T15:15:01.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1002, 1004, 1002, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:27:13.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1003, 1006, 1002, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:26:59.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1004, 1003, 1004, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:25:53.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1005, 1007, 1007, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:27:05.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1006, 1008, 1006, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:27:18.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1007, 1009, 1008, CAST(N'2019-09-10T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:25:10.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1008, 1004, 1002, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:23:34.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1009, 1, 1003, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:48:57.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1010, 1003, 1002, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:49:05.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1011, 1005, 1002, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:49:13.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1012, 1008, 1006, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:49:20.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1013, 1006, 1005, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:49:28.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1014, 1009, 1009, CAST(N'2019-09-24T00:00:00.000' AS DateTime), CAST(N'2019-09-24T10:49:36.000' AS DateTime))
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1015, 1009, 1009, CAST(N'2019-09-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1016, 1003, 1002, CAST(N'2019-09-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1017, 1004, 1002, CAST(N'2019-09-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1018, 1006, 1008, CAST(N'2019-09-10T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[RentedMovie] OFF
USE [master]
GO
ALTER DATABASE [MovieRentalDB] SET  READ_WRITE 
GO
