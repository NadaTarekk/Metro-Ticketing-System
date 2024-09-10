using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metro_Ticketing_System.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HasTransition = table.Column<bool>(type: "INTEGER", nullable: false),
                    TransionToStationId = table.Column<int>(type: "INTEGER", nullable: true),
                    LineId = table.Column<int>(type: "INTEGER", nullable: false),
                    Postion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Lines_LineId",
                        column: x => x.LineId,
                        principalTable: "Lines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stations_Stations_TransionToStationId",
                        column: x => x.TransionToStationId,
                        principalTable: "Stations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Line1" });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Line2" });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 1, false, 1, "Helwan", 1, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 2, false, 1, "Ain Helwan", 2, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 3, false, 1, "Helwan University", 3, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 4, false, 1, "Wadi Hof", 4, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 5, false, 1, "Hadayek Helwan", 5, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 6, false, 1, "El Maasara", 6, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 7, false, 1, "Tora El Asmant", 7, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 8, false, 1, "Kozzika", 8, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 9, false, 1, "Tora El Balad", 9, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 10, false, 1, "Sakanat El Maadi", 10, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 11, false, 1, "Maadi", 11, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 12, false, 1, "Hadayek El Maadi", 12, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 13, false, 1, "Dar El Salam", 13, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 14, false, 1, "El Zahraa", 14, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 15, false, 1, "Mar Girgis", 15, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 16, false, 1, "El Malek El Saleh", 16, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 17, false, 1, "Al Sayeda Zeinab", 17, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 18, false, 1, "Saad Zaghloul", 18, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 19, false, 1, "Sadat", 19, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 20, false, 1, "Nasser", 20, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 21, false, 1, "Orabi", 21, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 22, false, 1, "Al Shohadaa", 22, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 23, false, 1, "Ghamra", 23, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 24, false, 1, "El Demerdash", 24, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 25, false, 1, "Manshiet El Sadr", 25, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 26, false, 1, "Kobri El Qobba", 26, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 27, false, 1, "Hammamat El Qobba", 27, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 28, false, 1, "Saray El Qobba", 28, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 29, false, 1, "Hadayeq El Zaitoun", 29, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 30, false, 1, "Helmeyet El Zaitoun", 30, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 31, false, 1, "El Matareyya", 31, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 32, false, 1, "Ain Shams", 32, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 33, false, 1, "Ezbet El Nakhl", 33, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 34, false, 1, "El Marg", 34, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 35, false, 1, "New El Marg", 35, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 36, false, 2, "Shubra Al Khaimah", 1, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 37, false, 2, "Koliet El-Zeraa", 2, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 38, false, 2, "Mezallat", 3, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 39, false, 2, "Khalafawy", 4, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 40, false, 2, "St. Teresa", 5, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 41, false, 2, "Rod El-Farag", 6, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 42, false, 2, "Masarra", 7, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 43, false, 2, "Al Shohadaa", 8, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 44, false, 2, "Attaba", 9, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 45, false, 2, "Mohamed Naguib", 10, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 46, false, 2, "Sadat", 11, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 47, false, 2, "Opera", 12, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 48, false, 2, "Dokki", 13, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 49, false, 2, "El Bohoth", 14, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 50, false, 2, "Cairo University", 15, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 51, false, 2, "Faisal", 16, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 52, false, 2, "Giza", 17, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 53, false, 2, "Omm El-Masryeen", 18, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 54, false, 2, "Sakiat Mekky", 19, null });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "HasTransition", "LineId", "Name", "Postion", "TransionToStationId" },
                values: new object[] { 55, false, 2, "El Monib", 20, null });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_LineId",
                table: "Stations",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_TransionToStationId",
                table: "Stations",
                column: "TransionToStationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Lines");
        }
    }
}
