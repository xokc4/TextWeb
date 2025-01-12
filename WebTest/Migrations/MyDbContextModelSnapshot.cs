﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTest.Models.BD;

#nullable disable

namespace WebTest.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTest.Models.BD.ColumnElementPar", b =>
                {
                    b.Property<int>("IdColumn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdColumn"));

                    b.Property<string>("ContentColumn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOneColumn")
                        .HasColumnType("int");

                    b.Property<int>("IdOnlyString")
                        .HasColumnType("int");

                    b.Property<string>("NameColumn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdColumn");

                    b.ToTable("ColumnElements");
                });

            modelBuilder.Entity("WebTest.Models.BD.Element", b =>
                {
                    b.Property<int>("IdElement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdElement"));

                    b.Property<int>("IdOne")
                        .HasColumnType("int");

                    b.Property<int>("IdOnlystring")
                        .HasColumnType("int");

                    b.Property<int>("IndexProduct")
                        .HasColumnType("int");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdElement");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("WebTest.Models.BD.Pricelist", b =>
                {
                    b.Property<int>("IdPriceList")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPriceList"));

                    b.Property<int>("IdOnlystring")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPriceList");

                    b.ToTable("Pricelists");
                });
#pragma warning restore 612, 618
        }
    }
}
