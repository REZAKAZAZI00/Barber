using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barber.Migrations
{
    /// <inheritdoc />
    public partial class migbarbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentPerson_People_PersonId",
                table: "EquipmentPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDrinks_People_PersonId",
                table: "FoodDrinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_People_PersonId",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonId",
                table: "Orders",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentPerson_Person_PersonId",
                table: "EquipmentPerson",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDrinks_Person_PersonId",
                table: "FoodDrinks",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Person_PersonId",
                table: "Orders",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Person_PersonId",
                table: "Payments",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentPerson_Person_PersonId",
                table: "EquipmentPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDrinks_Person_PersonId",
                table: "FoodDrinks");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Person_PersonId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Person_PersonId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PersonId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentPerson_People_PersonId",
                table: "EquipmentPerson",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDrinks_People_PersonId",
                table: "FoodDrinks",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_People_PersonId",
                table: "Payments",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "PersonId");
        }
    }
}
