using Microsoft.EntityFrameworkCore.Migrations;

namespace project_v2.Migrations
{
    public partial class InitWebDB_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StoreID",
                table: "Store",
                newName: "StoreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StoreID",
                table: "Store",
                newName: "StoreID");
        }
    }
}
