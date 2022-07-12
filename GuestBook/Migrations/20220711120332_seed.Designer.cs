﻿// <auto-generated />
using System;
using GuestBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuestBook.Migrations
{
    [DbContext(typeof(GuestBookContext))]
    [Migration("20220711120332_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuestBook.Models.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3209c06d-747b-4d3e-9663-5a7c26e0bffb"),
                            Content = "I was here1",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 453, DateTimeKind.Local).AddTicks(9782),
                            Email = "mariusz@gmail.com",
                            Name = "Mariusz"
                        },
                        new
                        {
                            Id = new Guid("d7fc5e3e-853c-43c7-9f91-d24b6d1b2e1a"),
                            Content = "I was here2",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3694),
                            Email = "mariusz@gmail.com",
                            Name = "Marian"
                        },
                        new
                        {
                            Id = new Guid("272a48c6-da96-4715-a89b-5a2cd7251724"),
                            Content = "I was here3",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3762),
                            Email = "mariusz@gmail.com",
                            Name = "Maria"
                        },
                        new
                        {
                            Id = new Guid("0f4e265c-47ac-49f7-b7ba-9ccc1619fcd7"),
                            Content = "I was here4",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3769),
                            Email = "mariusz@gmail.com",
                            Name = "Mateusz"
                        },
                        new
                        {
                            Id = new Guid("29fa8852-881d-4892-9152-2a1ec8428ebd"),
                            Content = "I was here5",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3773),
                            Email = "mariusz@gmail.com",
                            Name = "Michal"
                        },
                        new
                        {
                            Id = new Guid("214fd015-b098-4dce-8e9e-1cb33e0f940a"),
                            Content = "I was here6",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3780),
                            Email = "mariusz@gmail.com",
                            Name = "Milosz"
                        },
                        new
                        {
                            Id = new Guid("4e596f77-21ea-4244-9083-9a7d4a633864"),
                            Content = "I was here7",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3784),
                            Email = "mariusz@gmail.com",
                            Name = "Marzena"
                        },
                        new
                        {
                            Id = new Guid("aa202224-9bb2-4ac5-a76c-905215b03b96"),
                            Content = "I was here8",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3795),
                            Email = "mariusz@gmail.com",
                            Name = "Milena"
                        },
                        new
                        {
                            Id = new Guid("f6bf0515-a5e1-4b6a-998d-0a9c09bec526"),
                            Content = "I was here9",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3799),
                            Email = "mariusz@gmail.com",
                            Name = "Marlena"
                        },
                        new
                        {
                            Id = new Guid("f34896e3-925c-45e8-9ea8-524121876081"),
                            Content = "I was here10",
                            CreateTime = new DateTime(2022, 7, 11, 14, 3, 32, 458, DateTimeKind.Local).AddTicks(3804),
                            Email = "mariusz@gmail.com",
                            Name = "Marek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
