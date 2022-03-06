using Microsoft.EntityFrameworkCore.Migrations;

namespace kitchen_express.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Product",
                newName: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Product",
                newName: "ProjectId");
        }
    }
}
