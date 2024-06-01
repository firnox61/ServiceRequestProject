using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRequests_Customers_CustomerId",
                table: "OrderRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderRequests_Employees_EmployeeId",
                table: "OrderRequests");

            migrationBuilder.DropIndex(
                name: "IX_OrderRequests_CustomerId",
                table: "OrderRequests");

            migrationBuilder.DropIndex(
                name: "IX_OrderRequests_EmployeeId",
                table: "OrderRequests");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "OrderRequests");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "OrderRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "OrderRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "OrderRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequests_CustomerId",
                table: "OrderRequests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRequests_EmployeeId",
                table: "OrderRequests",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRequests_Customers_CustomerId",
                table: "OrderRequests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRequests_Employees_EmployeeId",
                table: "OrderRequests",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
