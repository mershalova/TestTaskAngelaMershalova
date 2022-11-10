using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskAngelaMershalova.Migrations
{
    public partial class nullable_acount_incedent_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Incedents_IncedentId",
                schema: "TestTask",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "IncedentId",
                schema: "TestTask",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Incedents_IncedentId",
                schema: "TestTask",
                table: "Accounts",
                column: "IncedentId",
                principalSchema: "TestTask",
                principalTable: "Incedents",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Incedents_IncedentId",
                schema: "TestTask",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "IncedentId",
                schema: "TestTask",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Incedents_IncedentId",
                schema: "TestTask",
                table: "Accounts",
                column: "IncedentId",
                principalSchema: "TestTask",
                principalTable: "Incedents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
