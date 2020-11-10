using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7b7f047-2124-4771-873d-c8d33045a83c"),
                column: "ConcurrencyStamp",
                value: "6586788f-92bf-4f93-ac7a-75f3579ced5b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a655ba0f-20c9-43e9-8549-105496800d43"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ece010f7-430d-400c-89ed-ab0da0e3d878", "AQAAAAEAACcQAAAAEE2vXjUIc0QCKwiGI5zYjKgmSHJ79cHeFi4WZzB+m4bWAcu7nA++csnS+52UxcMpnw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 11, 9, 0, 25, 58, 236, DateTimeKind.Local).AddTicks(5196));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7b7f047-2124-4771-873d-c8d33045a83c"),
                column: "ConcurrencyStamp",
                value: "11134296-25e3-400b-ae0b-ed315e47ba76");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a655ba0f-20c9-43e9-8549-105496800d43"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18cf5c19-6bf7-4886-96a0-0b135d551e7d", "AQAAAAEAACcQAAAAENn8gdphibruMHrJaqZP/5W2Wer/spriiPwcZQg+NQfNQxbUN18emL2RUagpLbZ6Hg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 11, 7, 18, 1, 30, 34, DateTimeKind.Local).AddTicks(47));
        }
    }
}
