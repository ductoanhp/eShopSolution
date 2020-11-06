using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentifyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 6, 12, 13, 47, 870, DateTimeKind.Local).AddTicks(2713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 6, 11, 40, 4, 289, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c7b7f047-2124-4771-873d-c8d33045a83c"), "8d2801b2-140e-4e07-958c-82ec9f96a6a5", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a655ba0f-20c9-43e9-8549-105496800d43"), new Guid("c7b7f047-2124-4771-873d-c8d33045a83c") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a655ba0f-20c9-43e9-8549-105496800d43"), 0, "b333e653-99f6-4a5b-b8b4-40d5ab2d90d5", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenductoan91hp@gmail.com", true, "Toan", "Nguyen Duc", false, null, "nguyenductoan91hp@gmail.com", "admin", "AQAAAAEAACcQAAAAED5Nbe+ETxH6Js1w+rk45bYth2IuF89kis+5k9gjH7wtx7rzKlIwIN5JX4u8/oO50A==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 11, 6, 12, 13, 47, 902, DateTimeKind.Local).AddTicks(2732));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7b7f047-2124-4771-873d-c8d33045a83c"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a655ba0f-20c9-43e9-8549-105496800d43"), new Guid("c7b7f047-2124-4771-873d-c8d33045a83c") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a655ba0f-20c9-43e9-8549-105496800d43"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 6, 11, 40, 4, 289, DateTimeKind.Local).AddTicks(5291),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 6, 12, 13, 47, 870, DateTimeKind.Local).AddTicks(2713));

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
                value: new DateTime(2020, 11, 6, 11, 40, 4, 322, DateTimeKind.Local).AddTicks(5310));
        }
    }
}
