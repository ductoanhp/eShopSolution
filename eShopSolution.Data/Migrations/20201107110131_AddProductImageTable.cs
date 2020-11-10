using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 6, 12, 13, 47, 870, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 6, 12, 13, 47, 870, DateTimeKind.Local).AddTicks(2713),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c7b7f047-2124-4771-873d-c8d33045a83c"),
                column: "ConcurrencyStamp",
                value: "8d2801b2-140e-4e07-958c-82ec9f96a6a5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a655ba0f-20c9-43e9-8549-105496800d43"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b333e653-99f6-4a5b-b8b4-40d5ab2d90d5", "AQAAAAEAACcQAAAAED5Nbe+ETxH6Js1w+rk45bYth2IuF89kis+5k9gjH7wtx7rzKlIwIN5JX4u8/oO50A==" });

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
    }
}
