using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuestBook.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreateTime", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("736e92cf-2d33-4e7e-91f3-edb01b284a31"), "I was here1", new DateTime(2022, 7, 13, 9, 4, 23, 171, DateTimeKind.Local).AddTicks(8876), "mariusz@gmail.com", "Mariusz" },
                    { new Guid("440bcfb7-0f60-4a9b-9b50-9b5f405cd7dc"), "I was here2", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9034), "mariusz@gmail.com", "Marian" },
                    { new Guid("0513af24-4872-4bfa-80c9-328d43346ecd"), "I was here3", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9113), "mariusz@gmail.com", "Maria" },
                    { new Guid("28185d09-eb75-475b-a527-5a4b1fe64a64"), "I was here4", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9122), "mariusz@gmail.com", "Mateusz" },
                    { new Guid("e4c01e26-799f-4677-87cb-11dadb7302ff"), "I was here5", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9127), "mariusz@gmail.com", "Michal" },
                    { new Guid("93230c51-44db-439f-ab49-3f4060ea967b"), "I was here6", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9135), "mariusz@gmail.com", "Milosz" },
                    { new Guid("dab67b21-0cb4-4941-914f-787739a7bc9e"), "I was here7", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9141), "mariusz@gmail.com", "Marzena" },
                    { new Guid("dcff7868-a4a7-4040-8af7-da9ae1c9cc86"), "I was here8", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9146), "mariusz@gmail.com", "Milena" },
                    { new Guid("36f3f8d0-18cd-43b7-8c20-dd9c540889cd"), "I was here9", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9163), "mariusz@gmail.com", "Marlena" },
                    { new Guid("66819e43-f281-4ec7-87ea-86ed5cab77b7"), "I was here10", new DateTime(2022, 7, 13, 9, 4, 23, 177, DateTimeKind.Local).AddTicks(9171), "mariusz@gmail.com", "Marek" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
