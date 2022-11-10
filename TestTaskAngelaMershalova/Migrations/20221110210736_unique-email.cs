using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestTaskAngelaMershalova.Migrations
{
    public partial class uniqueemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Email",
                schema: "TestTask",
                table: "Contacts",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_Email",
                schema: "TestTask",
                table: "Contacts");
        }
    }
}
