﻿// <auto-generated />
using EntityFrameworkCodeFirst.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCodeFirst.Repository.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200716020851_AddTable")]
    partial class AddTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkCodeFirst.Entity.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ProductId = 1,
                            UserId = 2
                        },
                        new
                        {
                            OrderId = 2,
                            ProductId = 2,
                            UserId = 2
                        },
                        new
                        {
                            OrderId = 3,
                            ProductId = 3,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductNum")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "烤鸭",
                            ProductNum = 30
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "火腿",
                            ProductNum = 40
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "啤酒",
                            ProductNum = 50
                        });
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserName = "张三"
                        },
                        new
                        {
                            UserId = 2,
                            UserName = "李四"
                        },
                        new
                        {
                            UserId = 3,
                            UserName = "麻五"
                        });
                });

            modelBuilder.Entity("EntityFrameworkCodeFirst.Entity.Order", b =>
                {
                    b.HasOne("EntityFrameworkCodeFirst.Entity.Product", "Product")
                        .WithOne("Order")
                        .HasForeignKey("EntityFrameworkCodeFirst.Entity.Order", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCodeFirst.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
