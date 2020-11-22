using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGreatSite.Migrations
{
    public partial class Orders1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1F4C8722-7530-493E-895A-C0661F518337",
                column: "ConcurrencyStamp",
                value: "8f435939-08f9-4886-9eeb-e32507168b23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9AC5FF00-78D8-42A5-AABD-D8C810061803",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e16a7839-b954-496f-ae41-8eeb1e4395b8", "AQAAAAEAACcQAAAAEM1AmkK3ad3Q8fFDmHPFpbjSzCKBpaUlR+qwfE/1H45sjhEwWLaxjJjRdqYAtnzxdg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29085303-5753-455f-80e6-b2ae58d2911a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4af95bf3-8ad7-4443-b7b0-da84309d80de"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a8f5a04b-138b-42b6-9169-ec7f2f40aa52"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bb60e28d-3251-4119-a931-8c7908127b74"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc221c70-2c5b-44e7-bf31-19dc12dfe23f"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("c6d70167-628e-44eb-83c1-a00be290f6d9"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("eadc257c-1dfe-47c4-99a9-d90cf6a3e22a"),
                column: "DateAdded",
                value: new DateTime(2020, 5, 23, 11, 15, 55, 84, DateTimeKind.Utc).AddTicks(3737));
        }
    }
}
