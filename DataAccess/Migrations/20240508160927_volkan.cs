using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class volkan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CustomerId",
                table: "Images",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_EmployeeId",
                table: "Images",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Customers_CustomerId",
                table: "Images",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Employees_EmployeeId",
                table: "Images",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Customers_CustomerId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Employees_EmployeeId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CustomerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_EmployeeId",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
