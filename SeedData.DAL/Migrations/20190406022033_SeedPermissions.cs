using Microsoft.EntityFrameworkCore.Migrations;

namespace SeedData.DAL.Migrations
{
    public partial class SeedPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "TlkpPermissionId", "Code", "Description" },
                values: new object[,]
                {
                    { 1, "UserCanCreate", "User can create additional user accounts" },
                    { 2, "UserCanRead", "User can view other user accounts" },
                    { 3, "UserCanUpdate", "User can update other user accounts" },
                    { 4, "UserCanDelete", "User can delete other user accounts" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "TlkpPermissionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "TlkpPermissionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "TlkpPermissionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "TlkpPermissionId",
                keyValue: 4);
        }
    }
}
