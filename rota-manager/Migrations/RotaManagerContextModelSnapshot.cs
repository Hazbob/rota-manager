﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using rota_manager.Data;

#nullable disable

namespace rota_manager.Migrations
{
    [DbContext(typeof(RotaManagerContext))]
    partial class RotaManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("rota_manager.models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GroupId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmployeeId");

                    b.HasIndex("GroupId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("rota_manager.models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("rota_manager.models.Rota", b =>
                {
                    b.Property<int>("RotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RotaId"));

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("WeekOfYear")
                        .HasColumnType("integer");

                    b.HasKey("RotaId");

                    b.HasIndex("GroupId");

                    b.ToTable("Rotas");
                });

            modelBuilder.Entity("rota_manager.models.RotaEntry", b =>
                {
                    b.Property<int>("RotaEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RotaEntryId"));

                    b.Property<int>("DayOfYear")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ParentRotaRotaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("RotaEntryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ParentRotaRotaId");

                    b.ToTable("RotaEntries");
                });

            modelBuilder.Entity("rota_manager.models.RotaHistory", b =>
                {
                    b.Property<int>("RotaHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RotaHistoryId"));

                    b.Property<DateTime>("EditedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int>("RotaId")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RotaHistoryId");

                    b.ToTable("RotaHistories");
                });

            modelBuilder.Entity("rota_manager.models.Employee", b =>
                {
                    b.HasOne("rota_manager.models.Group", null)
                        .WithMany("Employees")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("rota_manager.models.Rota", b =>
                {
                    b.HasOne("rota_manager.models.Group", null)
                        .WithMany("Rotas")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rota_manager.models.RotaEntry", b =>
                {
                    b.HasOne("rota_manager.models.Employee", null)
                        .WithMany("RotaEntries")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rota_manager.models.Rota", "ParentRota")
                        .WithMany("RotaEntries")
                        .HasForeignKey("ParentRotaRotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentRota");
                });

            modelBuilder.Entity("rota_manager.models.Employee", b =>
                {
                    b.Navigation("RotaEntries");
                });

            modelBuilder.Entity("rota_manager.models.Group", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Rotas");
                });

            modelBuilder.Entity("rota_manager.models.Rota", b =>
                {
                    b.Navigation("RotaEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
