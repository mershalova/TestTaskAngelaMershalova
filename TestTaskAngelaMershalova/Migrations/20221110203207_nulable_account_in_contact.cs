using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskAngelaMershalova.Migrations
{
    public partial class nulable_account_in_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Accounts_AccountId",
                schema: "TestTask",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                schema: "TestTask",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Accounts_AccountId",
                schema: "TestTask",
                table: "Contacts",
                column: "AccountId",
                principalSchema: "TestTask",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Accounts_AccountId",
                schema: "TestTask",
                table: "Contacts");

            migrationBuilder.AlterColumn<int>(
                name: "AccountId",
                schema: "TestTask",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Accounts_AccountId",
                schema: "TestTask",
                table: "Contacts",
                column: "AccountId",
                principalSchema: "TestTask",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
