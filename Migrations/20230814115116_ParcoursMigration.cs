using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace testswagger.Migrations
{
    public partial class ParcoursMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parcourslist",
                columns: table => new
                {
                    ParcoursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcoursName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcoursDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcourslist", x => x.ParcoursId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcourslist");
        }
    }
}
