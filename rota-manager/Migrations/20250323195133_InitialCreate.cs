﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace rota_manager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    InternalEmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.InternalEmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GroupName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "RotaHistories",
                columns: table => new
                {
                    RotaHistoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RotaId = table.Column<int>(type: "integer", nullable: false),
                    EditedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotaHistories", x => x.RotaHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Rotas",
                columns: table => new
                {
                    RotaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeekOfYear = table.Column<int>(type: "integer", nullable: false),
                    GroupId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotas", x => x.RotaId);
                    table.ForeignKey(
                        name: "FK_Rotas_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RotaEntries",
                columns: table => new
                {
                    RotaEntryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DayOfYear = table.Column<int>(type: "integer", nullable: false),
                    ParentRotaRotaId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeInternalEmployeeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RotaEntries", x => x.RotaEntryId);
                    table.ForeignKey(
                        name: "FK_RotaEntries_Employee_EmployeeInternalEmployeeId",
                        column: x => x.EmployeeInternalEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "InternalEmployeeId");
                    table.ForeignKey(
                        name: "FK_RotaEntries_Rotas_ParentRotaRotaId",
                        column: x => x.ParentRotaRotaId,
                        principalTable: "Rotas",
                        principalColumn: "RotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RotaEntries_EmployeeInternalEmployeeId",
                table: "RotaEntries",
                column: "EmployeeInternalEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RotaEntries_ParentRotaRotaId",
                table: "RotaEntries",
                column: "ParentRotaRotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rotas_GroupId",
                table: "Rotas",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RotaEntries");

            migrationBuilder.DropTable(
                name: "RotaHistories");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Rotas");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
