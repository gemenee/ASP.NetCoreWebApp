using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGreatSite.Migrations
{
    public partial class orderIdBindNeverDisable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "10f34895-5b9c-43d7-9600-afe538923da2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84876218-4638-46c8-99b5-6492f38d83f9", "AQAAAAEAACcQAAAAENnomQp19xzHbcwmGDzd+bSBFIxS6c2Ww5lYynUV0K0ie4evqrCeyJ1knDhwIhjigQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 8, 9, 0, 38, 915, DateTimeKind.Utc).AddTicks(6767));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "27e4ac33-1514-4f60-8da4-2ea313e99edb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7339787-f333-4bde-9707-0da5478b0ed8", "AQAAAAEAACcQAAAAECQvOSa7HmBjiUMT2+F+k4L7pSQLIPO95OIHBn/Sit+vXi8EfrKptDmZj9DEaAs66A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 8, 6, 6, 6, 47, 543, DateTimeKind.Utc).AddTicks(6795));
        }
    }
}
