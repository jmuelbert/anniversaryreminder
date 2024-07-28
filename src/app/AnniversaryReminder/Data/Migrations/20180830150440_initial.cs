/**************************************************************************
 **
 ** SPDX-FileCopyrightText: © 2018-2023 Jürgen Mülbert
 **
 ** SPDX-License-Identifier: EUPL-1.2
 **
 *************************************************************************/

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnniversaryReminder.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChipCard",
                columns: table => new
                {
                    ChipCardId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 25, nullable: false),
                    Locked = table.Column<bool>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipCard", x => x.ChipCardId);
                }
            );

            migrationBuilder.CreateTable(
                name: "CityName",
                columns: table => new
                {
                    CityNameId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityName", x => x.CityNameId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Priority = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                }
            );

            migrationBuilder.CreateTable(
                name: "DeviceName",
                columns: table => new
                {
                    DeviceNameId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceName", x => x.DeviceNameId);
                }
            );

            migrationBuilder.CreateTable(
                name: "DeviceType",
                columns: table => new
                {
                    DeviceTypeId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceType", x => x.DeviceTypeId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Identifier = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryId);
                }
            );

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    PlaceId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Room = table.Column<string>(maxLength: 50, nullable: false),
                    Desk = table.Column<string>(maxLength: 50, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.PlaceId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Processor",
                columns: table => new
                {
                    ProcessorId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ClockRate = table.Column<float>(nullable: false),
                    Cores = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processor", x => x.ProcessorId);
                }
            );

            migrationBuilder.CreateTable(
                name: "ZipCode",
                columns: table => new
                {
                    ZipCodeId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Country = table.Column<string>(maxLength: 20, nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCode", x => x.ZipCodeId);
                }
            );

            migrationBuilder.CreateTable(
                name: "ChipCardProfile",
                columns: table => new
                {
                    ChipCardProfileId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 25, nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ChipCardId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipCardProfile", x => x.ChipCardProfileId);
                    table.ForeignKey(
                        name: "FK_ChipCardProfile_ChipCard_ChipCardId",
                        column: x => x.ChipCardId,
                        principalTable: "ChipCard",
                        principalColumn: "ChipCardId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(maxLength: 50, nullable: true),
                    Supporter = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    Street22 = table.Column<string>(maxLength: 50, nullable: true),
                    ZipCodeId = table.Column<long>(nullable: true),
                    MailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 50, nullable: true),
                    HotlineNumber = table.Column<string>(maxLength: 50, nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerId);
                    table.ForeignKey(
                        name: "FK_Manufacturer_ZipCode_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCode",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "ChipCardDoor",
                columns: table => new
                {
                    ChipCardDoorId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 25, nullable: false),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ChipCardId = table.Column<long>(nullable: true),
                    ChipCardProfileId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChipCardDoor", x => x.ChipCardDoorId);
                    table.ForeignKey(
                        name: "FK_ChipCardDoor_ChipCard_ChipCardId",
                        column: x => x.ChipCardId,
                        principalTable: "ChipCard",
                        principalColumn: "ChipCardId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_ChipCardDoor_ChipCardProfile_ChipCardProfileId",
                        column: x => x.ChipCardProfileId,
                        principalTable: "ChipCardProfile",
                        principalColumn: "ChipCardProfileId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_ChipCardDoor_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_ChipCardDoor_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Fax",
                columns: table => new
                {
                    FaxId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Pin = table.Column<string>(maxLength: 10, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Replace = table.Column<bool>(nullable: false),
                    DeviceNameId = table.Column<long>(nullable: true),
                    DeviceTypeId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    ManufacturerId = table.Column<long>(nullable: true),
                    InventoryId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fax", x => x.FaxId);
                    table.ForeignKey(
                        name: "FK_Fax_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Fax_DeviceName_DeviceNameId",
                        column: x => x.DeviceNameId,
                        principalTable: "DeviceName",
                        principalColumn: "DeviceNameId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Fax_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "DeviceTypeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Fax_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Fax_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Fax_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Mobile",
                columns: table => new
                {
                    MobileId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Pin = table.Column<string>(maxLength: 10, nullable: true),
                    CardNumber = table.Column<string>(maxLength: 30, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Replace = table.Column<bool>(nullable: false),
                    DeviceNameId = table.Column<long>(nullable: true),
                    DeviceTypeId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    ManufacturerId = table.Column<long>(nullable: true),
                    InventoryId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobile", x => x.MobileId);
                    table.ForeignKey(
                        name: "FK_Mobile_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Mobile_DeviceName_DeviceNameId",
                        column: x => x.DeviceNameId,
                        principalTable: "DeviceName",
                        principalColumn: "DeviceNameId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Mobile_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "DeviceTypeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Mobile_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Mobile_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Mobile_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Pin = table.Column<string>(maxLength: 10, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Replace = table.Column<bool>(nullable: false),
                    DeviceNameId = table.Column<long>(nullable: true),
                    DeviceTypeId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    ManufacturerId = table.Column<long>(nullable: true),
                    InventoryId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phone_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Phone_DeviceName_DeviceNameId",
                        column: x => x.DeviceNameId,
                        principalTable: "DeviceName",
                        principalColumn: "DeviceNameId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Phone_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "DeviceTypeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Phone_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Phone_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Phone_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeIdent = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    JobTitleId = table.Column<long>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Street = table.Column<string>(maxLength: 50, nullable: false),
                    ZipCodeId = table.Column<long>(nullable: true),
                    HomePhone = table.Column<string>(maxLength: 50, nullable: true),
                    HomeMobile = table.Column<string>(maxLength: 50, nullable: true),
                    HomeMailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    BusinessMailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    DataCare = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<long>(nullable: true),
                    PhoneId = table.Column<long>(nullable: true),
                    MobileId = table.Column<long>(nullable: true),
                    FaxId = table.Column<long>(nullable: true),
                    ChipCardId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ChipCardDoorId = table.Column<long>(nullable: true),
                    ChipCardProfileId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_ChipCardDoor_ChipCardDoorId",
                        column: x => x.ChipCardDoorId,
                        principalTable: "ChipCardDoor",
                        principalColumn: "ChipCardDoorId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_ChipCard_ChipCardId",
                        column: x => x.ChipCardId,
                        principalTable: "ChipCard",
                        principalColumn: "ChipCardId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_ChipCardProfile_ChipCardProfileId",
                        column: x => x.ChipCardProfileId,
                        principalTable: "ChipCardProfile",
                        principalColumn: "ChipCardProfileId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_Fax_FaxId",
                        column: x => x.FaxId,
                        principalTable: "Fax",
                        principalColumn: "FaxId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_Mobile_MobileId",
                        column: x => x.MobileId,
                        principalTable: "Mobile",
                        principalColumn: "MobileId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Employee_ZipCode_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCode",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(maxLength: 50, nullable: true),
                    Street = table.Column<string>(maxLength: 50, nullable: true),
                    ZipCodeId = table.Column<long>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    MailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Company_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Company_ZipCode_ZipCodeId",
                        column: x => x.ZipCodeId,
                        principalTable: "ZipCode",
                        principalColumn: "ZipCodeId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocumentId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DocumentData = table.Column<byte[]>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Document_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    FunctionId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Priority = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.FunctionId);
                    table.ForeignKey(
                        name: "FK_Function_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Printer",
                columns: table => new
                {
                    PrinterId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 20, nullable: true),
                    ServiceTag = table.Column<string>(maxLength: 20, nullable: true),
                    ServiceNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Network = table.Column<string>(maxLength: 50, nullable: true),
                    NetworkIpAddress = table.Column<string>(maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Replace = table.Column<bool>(nullable: false),
                    Resources = table.Column<string>(nullable: true),
                    PaperSize = table.Column<int>(nullable: true),
                    Color = table.Column<bool>(nullable: false),
                    DeviceNameId = table.Column<long>(nullable: true),
                    DeviceTypeId = table.Column<long>(nullable: true),
                    EmployeeId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    ManufacturerId = table.Column<long>(nullable: true),
                    InventoryId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printer", x => x.PrinterId);
                    table.ForeignKey(
                        name: "FK_Printer_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_DeviceName_DeviceNameId",
                        column: x => x.DeviceNameId,
                        principalTable: "DeviceName",
                        principalColumn: "DeviceNameId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "DeviceTypeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Printer_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SystemData",
                columns: table => new
                {
                    SystemDataId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Local = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemData", x => x.SystemDataId);
                    table.ForeignKey(
                        name: "FK_SystemData_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SystemAccount",
                columns: table => new
                {
                    SystemAccountId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(maxLength: 25, nullable: false),
                    SystemDataId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAccount", x => x.SystemAccountId);
                    table.ForeignKey(
                        name: "FK_SystemAccount_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_SystemAccount_SystemData_SystemDataId",
                        column: x => x.SystemDataId,
                        principalTable: "SystemData",
                        principalColumn: "SystemDataId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    SoftwareId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Version = table.Column<string>(maxLength: 25, nullable: true),
                    Revision = table.Column<string>(maxLength: 25, nullable: true),
                    Fix = table.Column<string>(maxLength: 25, nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    ComputerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.SoftwareId);
                }
            );

            migrationBuilder.CreateTable(
                name: "Computer",
                columns: table => new
                {
                    ComputerId = table
                        .Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 20, nullable: true),
                    ServiceTag = table.Column<string>(maxLength: 20, nullable: true),
                    ServiceNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Memory = table.Column<long>(nullable: true),
                    Network = table.Column<string>(maxLength: 50, nullable: true),
                    NetworkIpAddress = table.Column<string>(maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Replace = table.Column<bool>(nullable: false),
                    DeviceNameId = table.Column<long>(nullable: true),
                    DeviceTypeId = table.Column<long>(nullable: true),
                    PlaceId = table.Column<long>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    ManufacturerId = table.Column<long>(nullable: true),
                    InventoryId = table.Column<long>(nullable: true),
                    ProcessorId = table.Column<long>(nullable: true),
                    OSSoftwareId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computer", x => x.ComputerId);
                    table.ForeignKey(
                        name: "FK_Computer_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_DeviceName_DeviceNameId",
                        column: x => x.DeviceNameId,
                        principalTable: "DeviceName",
                        principalColumn: "DeviceNameId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_DeviceType_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceType",
                        principalColumn: "DeviceTypeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "InventoryId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Software_OSSoftwareId",
                        column: x => x.OSSoftwareId,
                        principalTable: "Software",
                        principalColumn: "SoftwareId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Place_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Place",
                        principalColumn: "PlaceId",
                        onDelete: ReferentialAction.Restrict
                    );
                    table.ForeignKey(
                        name: "FK_Computer_Processor_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processor",
                        principalColumn: "ProcessorId",
                        onDelete: ReferentialAction.Restrict
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChipCardDoor_ChipCardId",
                table: "ChipCardDoor",
                column: "ChipCardId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChipCardDoor_ChipCardProfileId",
                table: "ChipCardDoor",
                column: "ChipCardProfileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChipCardDoor_DepartmentId",
                table: "ChipCardDoor",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChipCardDoor_PlaceId",
                table: "ChipCardDoor",
                column: "PlaceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_ChipCardProfile_ChipCardId",
                table: "ChipCardProfile",
                column: "ChipCardId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Company_EmployeeId",
                table: "Company",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Company_ZipCodeId",
                table: "Company",
                column: "ZipCodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_DepartmentId",
                table: "Computer",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_DeviceNameId",
                table: "Computer",
                column: "DeviceNameId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_DeviceTypeId",
                table: "Computer",
                column: "DeviceTypeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_EmployeeId",
                table: "Computer",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_InventoryId",
                table: "Computer",
                column: "InventoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ManufacturerId",
                table: "Computer",
                column: "ManufacturerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_OSSoftwareId",
                table: "Computer",
                column: "OSSoftwareId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_PlaceId",
                table: "Computer",
                column: "PlaceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Computer_ProcessorId",
                table: "Computer",
                column: "ProcessorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Document_EmployeeId",
                table: "Document",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ChipCardDoorId",
                table: "Employee",
                column: "ChipCardDoorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ChipCardId",
                table: "Employee",
                column: "ChipCardId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ChipCardProfileId",
                table: "Employee",
                column: "ChipCardProfileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_FaxId",
                table: "Employee",
                column: "FaxId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobTitleId",
                table: "Employee",
                column: "JobTitleId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MobileId",
                table: "Employee",
                column: "MobileId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PhoneId",
                table: "Employee",
                column: "PhoneId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ZipCodeId",
                table: "Employee",
                column: "ZipCodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Fax_DepartmentId",
                table: "Fax",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Fax_DeviceNameId",
                table: "Fax",
                column: "DeviceNameId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Fax_DeviceTypeId",
                table: "Fax",
                column: "DeviceTypeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Fax_InventoryId",
                table: "Fax",
                column: "InventoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Fax_ManufacturerId",
                table: "Fax",
                column: "ManufacturerId"
            );

            migrationBuilder.CreateIndex(name: "IX_Fax_PlaceId", table: "Fax", column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Function_EmployeeId",
                table: "Function",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturer_ZipCodeId",
                table: "Manufacturer",
                column: "ZipCodeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_DepartmentId",
                table: "Mobile",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_DeviceNameId",
                table: "Mobile",
                column: "DeviceNameId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_DeviceTypeId",
                table: "Mobile",
                column: "DeviceTypeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_InventoryId",
                table: "Mobile",
                column: "InventoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_ManufacturerId",
                table: "Mobile",
                column: "ManufacturerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_PlaceId",
                table: "Mobile",
                column: "PlaceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_DepartmentId",
                table: "Phone",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_DeviceNameId",
                table: "Phone",
                column: "DeviceNameId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_DeviceTypeId",
                table: "Phone",
                column: "DeviceTypeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_InventoryId",
                table: "Phone",
                column: "InventoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_ManufacturerId",
                table: "Phone",
                column: "ManufacturerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PlaceId",
                table: "Phone",
                column: "PlaceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_DepartmentId",
                table: "Printer",
                column: "DepartmentId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_DeviceNameId",
                table: "Printer",
                column: "DeviceNameId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_DeviceTypeId",
                table: "Printer",
                column: "DeviceTypeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_EmployeeId",
                table: "Printer",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_InventoryId",
                table: "Printer",
                column: "InventoryId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_ManufacturerId",
                table: "Printer",
                column: "ManufacturerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Printer_PlaceId",
                table: "Printer",
                column: "PlaceId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Software_ComputerId",
                table: "Software",
                column: "ComputerId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccount_EmployeeId",
                table: "SystemAccount",
                column: "EmployeeId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SystemAccount_SystemDataId",
                table: "SystemAccount",
                column: "SystemDataId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SystemData_CompanyId",
                table: "SystemData",
                column: "CompanyId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Software_Computer_ComputerId",
                table: "Software",
                column: "ComputerId",
                principalTable: "Computer",
                principalColumn: "ComputerId",
                onDelete: ReferentialAction.Restrict
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChipCardDoor_ChipCard_ChipCardId",
                table: "ChipCardDoor"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ChipCardProfile_ChipCard_ChipCardId",
                table: "ChipCardProfile"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_ChipCard_ChipCardId",
                table: "Employee"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ChipCardDoor_ChipCardProfile_ChipCardProfileId",
                table: "ChipCardDoor"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_ChipCardProfile_ChipCardProfileId",
                table: "Employee"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ChipCardDoor_Department_DepartmentId",
                table: "ChipCardDoor"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Department_DepartmentId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee"
            );

            migrationBuilder.DropForeignKey(name: "FK_Fax_Department_DepartmentId", table: "Fax");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobile_Department_DepartmentId",
                table: "Mobile"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Department_DepartmentId",
                table: "Phone"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_ChipCardDoor_Place_PlaceId",
                table: "ChipCardDoor"
            );

            migrationBuilder.DropForeignKey(name: "FK_Computer_Place_PlaceId", table: "Computer");

            migrationBuilder.DropForeignKey(name: "FK_Fax_Place_PlaceId", table: "Fax");

            migrationBuilder.DropForeignKey(name: "FK_Mobile_Place_PlaceId", table: "Mobile");

            migrationBuilder.DropForeignKey(name: "FK_Phone_Place_PlaceId", table: "Phone");

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Employee_EmployeeId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Manufacturer_ZipCode_ZipCodeId",
                table: "Manufacturer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_DeviceName_DeviceNameId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_DeviceType_DeviceTypeId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Inventory_InventoryId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Manufacturer_ManufacturerId",
                table: "Computer"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Software_OSSoftwareId",
                table: "Computer"
            );

            migrationBuilder.DropTable(name: "CityName");

            migrationBuilder.DropTable(name: "Document");

            migrationBuilder.DropTable(name: "Function");

            migrationBuilder.DropTable(name: "Printer");

            migrationBuilder.DropTable(name: "SystemAccount");

            migrationBuilder.DropTable(name: "SystemData");

            migrationBuilder.DropTable(name: "Company");

            migrationBuilder.DropTable(name: "ChipCard");

            migrationBuilder.DropTable(name: "ChipCardProfile");

            migrationBuilder.DropTable(name: "Department");

            migrationBuilder.DropTable(name: "Place");

            migrationBuilder.DropTable(name: "Employee");

            migrationBuilder.DropTable(name: "ChipCardDoor");

            migrationBuilder.DropTable(name: "Fax");

            migrationBuilder.DropTable(name: "JobTitle");

            migrationBuilder.DropTable(name: "Mobile");

            migrationBuilder.DropTable(name: "Phone");

            migrationBuilder.DropTable(name: "ZipCode");

            migrationBuilder.DropTable(name: "DeviceName");

            migrationBuilder.DropTable(name: "DeviceType");

            migrationBuilder.DropTable(name: "Inventory");

            migrationBuilder.DropTable(name: "Manufacturer");

            migrationBuilder.DropTable(name: "Software");

            migrationBuilder.DropTable(name: "Computer");

            migrationBuilder.DropTable(name: "Processor");
        }
    }
}
