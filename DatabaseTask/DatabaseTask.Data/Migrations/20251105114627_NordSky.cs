
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class NordSky : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pilots",
                columns: table => new
                {
                    PilotID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PilotName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightHours = table.Column<int>(type: "int", nullable: false),
                    LicenseExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilots", x => x.PilotID);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    passengerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    DateOFBooking = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    registrationNumber = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<int>(type: "int", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatCapacity = table.Column<int>(type: "int", nullable: false),
                    PilotsPilotID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlaneID);
                    table.ForeignKey(
                        name: "FK_Planes_Pilots_PilotsPilotID",
                        column: x => x.PilotsPilotID,
                        principalTable: "Pilots",
                        principalColumn: "PilotID");
                });

            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    passengersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketsTicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.passengersID);
                    table.ForeignKey(
                        name: "FK_passengers_Tickets_TicketsTicketID",
                        column: x => x.TicketsTicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID");
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    passengerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlightID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanesPlaneID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TicketsTicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    passengersID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightsID);
                    table.ForeignKey(
                        name: "FK_Flights_Planes_PlanesPlaneID",
                        column: x => x.PlanesPlaneID,
                        principalTable: "Planes",
                        principalColumn: "PlaneID");
                    table.ForeignKey(
                        name: "FK_Flights_Tickets_TicketsTicketID",
                        column: x => x.TicketsTicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID");
                    table.ForeignKey(
                        name: "FK_Flights_passengers_passengersID",
                        column: x => x.passengersID,
                        principalTable: "passengers",
                        principalColumn: "passengersID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_passengersID",
                table: "Flights",
                column: "passengersID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_PlanesPlaneID",
                table: "Flights",
                column: "PlanesPlaneID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_TicketsTicketID",
                table: "Flights",
                column: "TicketsTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_passengers_TicketsTicketID",
                table: "passengers",
                column: "TicketsTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_PilotsPilotID",
                table: "Planes",
                column: "PilotsPilotID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropTable(
                name: "Pilots");

            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
