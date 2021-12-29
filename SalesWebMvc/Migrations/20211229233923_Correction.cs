using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecords_Seller_SellerId",
                table: "SalesRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecords",
                table: "SalesRecords");

            migrationBuilder.RenameTable(
                name: "SalesRecords",
                newName: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartamentId",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecords_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalesRecords");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecords",
                newName: "IX_SalesRecords_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecords",
                table: "SalesRecords",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecords_Seller_SellerId",
                table: "SalesRecords",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Departament_DepartamentId",
                table: "Seller",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
