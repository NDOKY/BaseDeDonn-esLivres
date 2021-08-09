using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseDeDonnéesLivres.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LivreDesire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    anneePublication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    auteur = table.Column<string>(type: "nvarchar(max)", nullable: true), 
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivreDesire", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivreDesire");
        }
    }
}
