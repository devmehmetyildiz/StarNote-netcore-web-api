using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace StarNote.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdDProductbase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Productguid = table.Column<string>(type: "text", nullable: true),
                    Stockguid = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdDProductbase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADOrderproduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Groupname = table.Column<string>(type: "text", nullable: true),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Baseprice = table.Column<double>(type: "double", nullable: false),
                    Totalprice = table.Column<double>(type: "double", nullable: false),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADOrderproduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ADProductoption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Productguid = table.Column<string>(type: "text", nullable: true),
                    Optionproductguid = table.Column<string>(type: "text", nullable: true),
                    Totalprice = table.Column<double>(type: "double", nullable: false),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Baseprice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADProductoption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLCase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLCase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLCostumertype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLCostumertype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLLisance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LisansAdı = table.Column<string>(type: "text", nullable: true),
                    Ürünanahtarı = table.Column<string>(type: "text", nullable: true),
                    Sonaermetarihi = table.Column<string>(type: "text", nullable: true),
                    Durum = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLLisance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLNote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLNote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLPaymenttype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Parametersmallname = table.Column<string>(type: "text", nullable: true),
                    Dailygoal = table.Column<double>(type: "double", nullable: false),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLPaymenttype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLProcesstype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Stockmovementvalue = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLProcesstype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLProducttype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLProducttype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLReminding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Remindingtype = table.Column<string>(type: "text", nullable: true),
                    Cycletype = table.Column<string>(type: "text", nullable: true),
                    Cycleper = table.Column<string>(type: "text", nullable: true),
                    Reporttype = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Users = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLReminding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Rolename = table.Column<string>(type: "text", nullable: true),
                    Rolevalue = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLSalesman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLSalesman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLSalestype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLSalestype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Producttype = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Incomeprice = table.Column<double>(type: "double", nullable: false),
                    Outcomeprice = table.Column<string>(type: "text", nullable: true),
                    Tax = table.Column<string>(type: "text", nullable: true),
                    Discount = table.Column<double>(type: "double", nullable: false),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLStock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLTax",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLTax", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Parametergroup = table.Column<string>(type: "text", nullable: true),
                    Parametername = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GLUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Authory = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPCompany",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Companyname = table.Column<string>(type: "text", nullable: true),
                    Companyaddress = table.Column<string>(type: "text", nullable: true),
                    Taxno = table.Column<string>(type: "text", nullable: true),
                    Taxname = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPCostumer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Costumerid = table.Column<string>(type: "text", nullable: true),
                    Phonenumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Town = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPCostumer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPCostumerorder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Orderno = table.Column<string>(type: "text", nullable: true),
                    Costumertype = table.Column<string>(type: "text", nullable: true),
                    Salestype = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Costumerid = table.Column<string>(type: "text", nullable: true),
                    Phonenumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Town = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Registerdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deliverydate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Salesman = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Pricewaiting = table.Column<double>(type: "double", nullable: false),
                    Tax = table.Column<string>(type: "text", nullable: true),
                    Companyname = table.Column<string>(type: "text", nullable: true),
                    Companyaddress = table.Column<string>(type: "text", nullable: true),
                    Taxno = table.Column<string>(type: "text", nullable: true),
                    Taxname = table.Column<string>(type: "text", nullable: true),
                    Processtype = table.Column<string>(type: "text", nullable: true),
                    Paymenttype = table.Column<string>(type: "text", nullable: true),
                    Processcase = table.Column<string>(type: "text", nullable: true),
                    Info = table.Column<string>(type: "text", nullable: true),
                    Savetype = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPCostumerorder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPFilemanagement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Mainid = table.Column<int>(type: "int", nullable: false),
                    Typename = table.Column<string>(type: "text", nullable: true),
                    Typedetailname = table.Column<string>(type: "text", nullable: true),
                    Companyname = table.Column<string>(type: "text", nullable: true),
                    Fileno = table.Column<string>(type: "text", nullable: true),
                    Costumername = table.Column<string>(type: "text", nullable: true),
                    Filename = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPFilemanagement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPJoborder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Costumerorder = table.Column<string>(type: "text", nullable: true),
                    Joborderno = table.Column<string>(type: "text", nullable: true),
                    Product = table.Column<string>(type: "text", nullable: true),
                    Propducttype = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Processcase = table.Column<string>(type: "text", nullable: true),
                    Info = table.Column<string>(type: "text", nullable: true),
                    Guid = table.Column<string>(type: "text", nullable: true),
                    Createduser = table.Column<string>(type: "text", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Createdtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modifiedtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Isactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Modifieduser = table.Column<string>(type: "text", nullable: true),
                    Vieworder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPJoborder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdDProductbase");

            migrationBuilder.DropTable(
                name: "ADMenus");

            migrationBuilder.DropTable(
                name: "ADOrderproduct");

            migrationBuilder.DropTable(
                name: "ADProductoption");

            migrationBuilder.DropTable(
                name: "GLCase");

            migrationBuilder.DropTable(
                name: "GLCostumertype");

            migrationBuilder.DropTable(
                name: "GLLisance");

            migrationBuilder.DropTable(
                name: "GLNote");

            migrationBuilder.DropTable(
                name: "GLPaymenttype");

            migrationBuilder.DropTable(
                name: "GLProcesstype");

            migrationBuilder.DropTable(
                name: "GLProducttype");

            migrationBuilder.DropTable(
                name: "GLReminding");

            migrationBuilder.DropTable(
                name: "GLRoles");

            migrationBuilder.DropTable(
                name: "GLSalesman");

            migrationBuilder.DropTable(
                name: "GLSalestype");

            migrationBuilder.DropTable(
                name: "GLStock");

            migrationBuilder.DropTable(
                name: "GLTax");

            migrationBuilder.DropTable(
                name: "GLUnit");

            migrationBuilder.DropTable(
                name: "GLUser");

            migrationBuilder.DropTable(
                name: "SPCompany");

            migrationBuilder.DropTable(
                name: "SPCostumer");

            migrationBuilder.DropTable(
                name: "SPCostumerorder");

            migrationBuilder.DropTable(
                name: "SPFilemanagement");

            migrationBuilder.DropTable(
                name: "SPJoborder");
        }
    }
}
