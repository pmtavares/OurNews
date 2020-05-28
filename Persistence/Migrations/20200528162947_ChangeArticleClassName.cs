using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeArticleClassName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurNews");

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Content = table.Column<string>(maxLength: 2000, nullable: false),
                    MainContent = table.Column<string>(maxLength: 5000, nullable: false),
                    MainPhoto = table.Column<string>(nullable: true),
                    SecundaryPhoto = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.CreateTable(
                name: "OurNews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Content = table.Column<string>(maxLength: 2000, nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    MainContent = table.Column<string>(maxLength: 5000, nullable: false),
                    MainPhoto = table.Column<string>(nullable: true),
                    SecundaryPhoto = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(maxLength: 80, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurNews", x => x.Id);
                });
        }
    }
}
