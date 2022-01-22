using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppMvc.Migrations
{
    public partial class fixedBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "subscriptionTypes",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "subscriptionTypes",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "subscriptions",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "subscriptions",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Addresses",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Addresses",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(28)",
                oldMaxLength: 28,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "subscriptionTypes",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "subscriptionTypes",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "subscriptions",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "subscriptions",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdateUser",
                table: "Addresses",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Addresses",
                type: "nvarchar(28)",
                maxLength: 28,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);
        }
    }
}
