using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElectronicRedBook.Migrations
{
    public partial class AddedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    ChildId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChildName = table.Column<string>(nullable: true),
                    ChildSurname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.ChildId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ChildId",
                table: "AspNetUsers",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Children_ChildId",
                table: "AspNetUsers",
                column: "ChildId",
                principalTable: "Children",
                principalColumn: "ChildId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Children_ChildId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ChildId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "AspNetUsers");
        }
    }
}
