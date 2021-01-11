using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SPR.Data.Migrations
{
    public partial class SPR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirTreatment",
                columns: table => new
                {
                    airtreatmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    treatmentname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirTreatment", x => x.airtreatmentid);
                });

            migrationBuilder.CreateTable(
                name: "AssignedRoles",
                columns: table => new
                {
                    assignedrolesid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    assignto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedRoles", x => x.assignedrolesid);
                });

            migrationBuilder.CreateTable(
                name: "BoughtoutInstrument",
                columns: table => new
                {
                    boughtoutid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    boughtoutname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoughtoutInstrument", x => x.boughtoutid);
                });

            migrationBuilder.CreateTable(
                name: "BusinessDivision",
                columns: table => new
                {
                    divisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OilfreeId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    divisionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lrbuId = table.Column<int>(type: "int", nullable: false),
                    rotaryId = table.Column<int>(type: "int", nullable: false),
                    smallairId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDivision", x => x.divisionId);
                });

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    channelid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    channelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.channelid);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    competitionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    competitionname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.competitionid);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    facilityid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facilityname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.facilityid);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    industryid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    industrytype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.industryid);
                });

            migrationBuilder.CreateTable(
                name: "LRBU",
                columns: table => new
                {
                    lrbuid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lrbuname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LRBU", x => x.lrbuid);
                });

            migrationBuilder.CreateTable(
                name: "OilFree",
                columns: table => new
                {
                    oilfreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oilfreename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilFree", x => x.oilfreeId);
                });

            migrationBuilder.CreateTable(
                name: "PricingStatus",
                columns: table => new
                {
                    statusid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingStatus", x => x.statusid);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    regionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regiontype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.regionid);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    confirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    emailid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emplooyeeid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    forcechangepassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleID = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.RegistrationID);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rolename = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleid);
                });

            migrationBuilder.CreateTable(
                name: "Rotary",
                columns: table => new
                {
                    rotaryid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rotary_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotary", x => x.rotaryid);
                });

            migrationBuilder.CreateTable(
                name: "Smallair",
                columns: table => new
                {
                    smallairid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    smallairname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smallair", x => x.smallairid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirTreatment");

            migrationBuilder.DropTable(
                name: "AssignedRoles");

            migrationBuilder.DropTable(
                name: "BoughtoutInstrument");

            migrationBuilder.DropTable(
                name: "BusinessDivision");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "LRBU");

            migrationBuilder.DropTable(
                name: "OilFree");

            migrationBuilder.DropTable(
                name: "PricingStatus");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "Rotary");

            migrationBuilder.DropTable(
                name: "Smallair");
        }
    }
}
