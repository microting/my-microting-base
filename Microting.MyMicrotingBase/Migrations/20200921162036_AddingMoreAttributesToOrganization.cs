using Microsoft.EntityFrameworkCore.Migrations;

namespace Microting.MyMicrotingBase.Migrations
{
    public partial class AddingMoreAttributesToOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PluginGroupPermissionVersions_PluginPermissions_PermissionId",
                table: "PluginGroupPermissionVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_PluginGroupPermissionVersions_PluginGroupPermissions_PluginG~",
                table: "PluginGroupPermissionVersions");

            migrationBuilder.DropIndex(
                name: "IX_PluginGroupPermissionVersions_PermissionId",
                table: "PluginGroupPermissionVersions");

            migrationBuilder.DropIndex(
                name: "IX_PluginGroupPermissionVersions_PluginGroupPermissionId",
                table: "PluginGroupPermissionVersions");

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "OrganizationVersions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentOverdue",
                table: "OrganizationVersions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "OrganizationVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "OrganizationVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNo",
                table: "Organizations",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PaymentOverdue",
                table: "Organizations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Organizations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Organizations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "OrganizationVersions");

            migrationBuilder.DropColumn(
                name: "PaymentOverdue",
                table: "OrganizationVersions");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "OrganizationVersions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrganizationVersions");

            migrationBuilder.DropColumn(
                name: "CustomerNo",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "PaymentOverdue",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Organizations");

            migrationBuilder.CreateIndex(
                name: "IX_PluginGroupPermissionVersions_PermissionId",
                table: "PluginGroupPermissionVersions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PluginGroupPermissionVersions_PluginGroupPermissionId",
                table: "PluginGroupPermissionVersions",
                column: "PluginGroupPermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PluginGroupPermissionVersions_PluginPermissions_PermissionId",
                table: "PluginGroupPermissionVersions",
                column: "PermissionId",
                principalTable: "PluginPermissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PluginGroupPermissionVersions_PluginGroupPermissions_PluginG~",
                table: "PluginGroupPermissionVersions",
                column: "PluginGroupPermissionId",
                principalTable: "PluginGroupPermissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
