using Microsoft.EntityFrameworkCore.Migrations;

namespace Microting.MyMicrotingBase.Migrations
{
    public partial class AddingNameToOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrganizationVersions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Organizations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrganizationVersions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Organizations");
        }
    }
}
