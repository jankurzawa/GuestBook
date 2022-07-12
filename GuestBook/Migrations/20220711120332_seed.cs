using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBook.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreateTime", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("3209c06d-747b-4d3e-9663-5a7c26e0bffb"), "I was here1", new DateTime(2022, 7, 11, 14, 3, 32, 453, DateTimeKind.Local).AddTicks(9782), "mariusz@gmail.com", "Mariusz" },
                    { new Guid("d7fc5e3e-853c-43c7-9f91-d24b6d1b2e1a"), "I was here2", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3694), "mariusz@gmail.com", "Marian" },
                    { new Guid("272a48c6-da96-4715-a89b-5a2cd7251724"), "I was here3", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3762), "mariusz@gmail.com", "Maria" },
                    { new Guid("0f4e265c-47ac-49f7-b7ba-9ccc1619fcd7"), "I was here4", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3769), "mariusz@gmail.com", "Mateusz" },
                    { new Guid("29fa8852-881d-4892-9152-2a1ec8428ebd"), "I was here5", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3773), "mariusz@gmail.com", "Michal" },
                    { new Guid("214fd015-b098-4dce-8e9e-1cb33e0f940a"), "I was here6", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3780), "mariusz@gmail.com", "Milosz" },
                    { new Guid("4e596f77-21ea-4244-9083-9a7d4a633864"), "I was here7", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3784), "mariusz@gmail.com", "Marzena" },
                    { new Guid("aa202224-9bb2-4ac5-a76c-905215b03b96"), "I was here8", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3795), "mariusz@gmail.com", "Milena" },
                    { new Guid("f6bf0515-a5e1-4b6a-998d-0a9c09bec526"), "I was here9", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3799), "mariusz@gmail.com", "Marlena" },
                    { new Guid("f34896e3-925c-45e8-9ea8-524121876081"), "I was here10", new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3804), "mariusz@gmail.com", "Marek" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0f4e265c-47ac-49f7-b7ba-9ccc1619fcd7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("214fd015-b098-4dce-8e9e-1cb33e0f940a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("272a48c6-da96-4715-a89b-5a2cd7251724"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("29fa8852-881d-4892-9152-2a1ec8428ebd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("3209c06d-747b-4d3e-9663-5a7c26e0bffb"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("4e596f77-21ea-4244-9083-9a7d4a633864"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("aa202224-9bb2-4ac5-a76c-905215b03b96"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d7fc5e3e-853c-43c7-9f91-d24b6d1b2e1a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f34896e3-925c-45e8-9ea8-524121876081"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f6bf0515-a5e1-4b6a-998d-0a9c09bec526"));
        }
    }
}
