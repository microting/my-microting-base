﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Microting.MyMicrotingBase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    DomainName = table.Column<string>(nullable: true),
                    ServiceEmail = table.Column<string>(nullable: true),
                    NumberOfLicenses = table.Column<int>(nullable: false),
                    NumberOfLicensesUsed = table.Column<int>(nullable: false),
                    UpToDateStatus = table.Column<string>(nullable: true),
                    NextUpgrade = table.Column<DateTime>(nullable: false),
                    InstanceStatus = table.Column<string>(nullable: true),
                    InstanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    DomainName = table.Column<string>(nullable: true),
                    ServiceEmail = table.Column<string>(nullable: true),
                    NumberOfLicenses = table.Column<int>(nullable: false),
                    NumberOfLicensesUsed = table.Column<int>(nullable: false),
                    UpToDateStatus = table.Column<string>(nullable: true),
                    NextUpgrade = table.Column<DateTime>(nullable: false),
                    InstanceStatus = table.Column<string>(nullable: true),
                    InstanceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PluginConfigurationValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginConfigurationValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PluginConfigurationValueVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginConfigurationValueVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PluginPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    PermissionName = table.Column<string>(nullable: true),
                    ClaimName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PluginGroupPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginGroupPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PluginGroupPermissions_PluginPermissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PluginPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PluginGroupPermissionVersions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    WorkflowState = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    UpdatedByUserId = table.Column<int>(nullable: false),
                    Version = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    PluginGroupPermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PluginGroupPermissionVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PluginGroupPermissionVersions_PluginPermissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PluginPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PluginGroupPermissionVersions_PluginGroupPermissions_PluginG~",
                        column: x => x.PluginGroupPermissionId,
                        principalTable: "PluginGroupPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PluginGroupPermissions_PermissionId",
                table: "PluginGroupPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PluginGroupPermissionVersions_PermissionId",
                table: "PluginGroupPermissionVersions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PluginGroupPermissionVersions_PluginGroupPermissionId",
                table: "PluginGroupPermissionVersions",
                column: "PluginGroupPermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "OrganizationVersions");

            migrationBuilder.DropTable(
                name: "PluginConfigurationValues");

            migrationBuilder.DropTable(
                name: "PluginConfigurationValueVersions");

            migrationBuilder.DropTable(
                name: "PluginGroupPermissionVersions");

            migrationBuilder.DropTable(
                name: "PluginGroupPermissions");

            migrationBuilder.DropTable(
                name: "PluginPermissions");
        }
    }
}
