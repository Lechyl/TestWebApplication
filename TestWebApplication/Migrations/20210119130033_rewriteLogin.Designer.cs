﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWebApplication.Data;

namespace TestWebApplication.Migrations
{
    [DbContext(typeof(HelloWorldContext))]
    [Migration("20210119130033_rewriteLogin")]
    partial class rewriteLogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestWebApplication.Data.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MessageBody")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("TestWebApplication.Data.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("TestWebApplication.Data.Message", b =>
                {
                    b.HasOne("TestWebApplication.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
