using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGreatSite.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "37c19d13-97aa-46fb-a55f-b7e61cc6bc93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96f14d39-a4af-4617-b19b-2fcf4b670352", "AQAAAAEAACcQAAAAELUhER1dRXKu7HHBtlQ8Vmj2mc0n2odwvIE8GilNrHa8MImkpf8OxpObK039SaNx3w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 5, 12, 23, 21, 935, DateTimeKind.Utc).AddTicks(9087));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "d4c6fdf8-35d2-4c1a-8cab-c140c951bd22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf8fe514-a6b7-409f-9923-f35828c5148e", "AQAAAAEAACcQAAAAEBt5N7u5ZLFWW0UooSzHqDSDNf0bMixwBpglIhTy5L1P2QtBsunLNbz0odzQAYd0QQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 677, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 677, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(42));
        }
    }
}
