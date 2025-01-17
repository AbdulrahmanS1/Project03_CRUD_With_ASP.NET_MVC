﻿// <auto-generated />
using System;
using Compound.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Compound.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612223204_CreatingTables")]
    partial class CreatingTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Compound.Models.EventModel", b =>
                {
                    b.Property<int>("Event_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Event_Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Event_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Event_Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Compound.Models.ServiceModel", b =>
                {
                    b.Property<int>("Service_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Service_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("Service_Id");

                    b.HasIndex("StaffId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.Property<int>("Staff_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Staff_AtWork")
                        .HasColumnType("bit");

                    b.Property<string>("Staff_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Staff_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Staff_Id");

                    b.HasIndex("UserId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.HasIndex("VillaId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Compound.Models.VilladModel", b =>
                {
                    b.Property<int>("Villa_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Villa_Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Villa_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Villa_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Villa_Number")
                        .HasColumnType("int");

                    b.HasKey("Villa_Id");

                    b.ToTable("Villa");
                });

            modelBuilder.Entity("Compound.Models.EventModel", b =>
                {
                    b.HasOne("Compound.Models.StaffModel", "Staff")
                        .WithMany("Events")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Compound.Models.ServiceModel", b =>
                {
                    b.HasOne("Compound.Models.StaffModel", "Staff")
                        .WithMany("Services")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.HasOne("Compound.Models.UserModel", "User")
                        .WithMany("Staff")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.HasOne("Compound.Models.VilladModel", "Villa")
                        .WithMany("User")
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("Compound.Models.StaffModel", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Compound.Models.UserModel", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Compound.Models.VilladModel", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
