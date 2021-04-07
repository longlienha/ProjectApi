using Microsoft.EntityFrameworkCore.Migrations;

namespace project_v2.Migrations
{
    public partial class InitWebDB_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Product_Store_ID",
                table: "Product",
                column: "StoreID",
                principalTable: "Store",
                principalColumn: "StoreID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Store_ID",
                table: "Product");
        }
    }
}
