﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Lab1.Entities;

namespace Lab1.Migrations
{
    [DbContext(typeof(Lab1DbContext))]
    [Migration("20161026125326_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab1.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Ownership");

                    b.Property<int>("Workers");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Lab1.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyID");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("ShopID");

                    b.HasKey("Id");

                    b.HasIndex("CompanyID");

                    b.HasIndex("ShopID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Lab1.Entities.ContractItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("ContractId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractItems");
                });

            modelBuilder.Entity("Lab1.Entities.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Culture");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Farm");
                });

            modelBuilder.Entity("Lab1.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Area");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Culture");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Field");
                });

            modelBuilder.Entity("Lab1.Entities.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Lab1.Entities.Contract", b =>
                {
                    b.HasOne("Lab1.Entities.Company", "Company")
                        .WithMany("Contracts")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab1.Entities.Shop", "Shop")
                        .WithMany("Contracts")
                        .HasForeignKey("ShopID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lab1.Entities.ContractItem", b =>
                {
                    b.HasOne("Lab1.Entities.Contract")
                        .WithMany("ContractItems")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lab1.Entities.Farm", b =>
                {
                    b.HasOne("Lab1.Entities.Company")
                        .WithMany("Farms")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Lab1.Entities.Field", b =>
                {
                    b.HasOne("Lab1.Entities.Company")
                        .WithMany("Fields")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
