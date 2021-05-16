using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureShopDatabaseImplement.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_FurnitureId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComponents_Components_ComponentId",
                table: "ProductComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComponents_Products_FurnitureId",
                table: "ProductComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductComponents",
                table: "ProductComponents");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Furnitures");

            migrationBuilder.RenameTable(
                name: "ProductComponents",
                newName: "FurnitureComponents");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComponents_FurnitureId",
                table: "FurnitureComponents",
                newName: "IX_FurnitureComponents_FurnitureId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComponents_ComponentId",
                table: "FurnitureComponents",
                newName: "IX_FurnitureComponents_ComponentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FurnitureComponents",
                table: "FurnitureComponents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureComponents_Components_ComponentId",
                table: "FurnitureComponents",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FurnitureComponents_Furnitures_FurnitureId",
                table: "FurnitureComponents",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Furnitures_FurnitureId",
                table: "Orders",
                column: "FurnitureId",
                principalTable: "Furnitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureComponents_Components_ComponentId",
                table: "FurnitureComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_FurnitureComponents_Furnitures_FurnitureId",
                table: "FurnitureComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Furnitures_FurnitureId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Furnitures",
                table: "Furnitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FurnitureComponents",
                table: "FurnitureComponents");

            migrationBuilder.RenameTable(
                name: "Furnitures",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "FurnitureComponents",
                newName: "ProductComponents");

            migrationBuilder.RenameIndex(
                name: "IX_FurnitureComponents_FurnitureId",
                table: "ProductComponents",
                newName: "IX_ProductComponents_FurnitureId");

            migrationBuilder.RenameIndex(
                name: "IX_FurnitureComponents_ComponentId",
                table: "ProductComponents",
                newName: "IX_ProductComponents_ComponentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductComponents",
                table: "ProductComponents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_FurnitureId",
                table: "Orders",
                column: "FurnitureId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComponents_Components_ComponentId",
                table: "ProductComponents",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComponents_Products_FurnitureId",
                table: "ProductComponents",
                column: "FurnitureId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
