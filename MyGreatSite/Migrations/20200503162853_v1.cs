using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGreatSite.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("29085303-5753-455f-80e6-b2ae58d2911a"), "PageAbout", new DateTime(2020, 5, 3, 16, 28, 52, 678, DateTimeKind.Utc).AddTicks(234), null, null, null, null, "Содержание заполняется администратором", "Обо мне", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "b9291e72-fe27-412b-8406-09eeac063095");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "718c10f9-977d-4909-a4f1-70fe362e351f", "AQAAAAEAACcQAAAAEICQ5cUdBBetoCVBUVAvuBMbzO4XqR6BPHBY4KqSM8tDzroJMUAgb9Mj/Nx8eBiHig==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 16, 52, 42, 851, DateTimeKind.Utc).AddTicks(5691));
        }
    }
}
