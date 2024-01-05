using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Migrations
{
    public partial class addRoomsIdClientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Clients_RoomsId",
                table: "ClientRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Rooms_RoomsId1",
                table: "ClientRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom");

            migrationBuilder.DropIndex(
                name: "IX_ClientRoom_RoomsId1",
                table: "ClientRoom");

            migrationBuilder.RenameColumn(
                name: "RoomsId",
                table: "Clients",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "RoomsId1",
                table: "ClientRoom",
                newName: "ClientsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom",
                columns: new[] { "ClientsId", "RoomsId" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientRoom_RoomsId",
                table: "ClientRoom",
                column: "RoomsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Clients_ClientsId",
                table: "ClientRoom",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Rooms_RoomsId",
                table: "ClientRoom",
                column: "RoomsId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Clients_ClientsId",
                table: "ClientRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Rooms_RoomsId",
                table: "ClientRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom");

            migrationBuilder.DropIndex(
                name: "IX_ClientRoom_RoomsId",
                table: "ClientRoom");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Clients",
                newName: "RoomsId");

            migrationBuilder.RenameColumn(
                name: "ClientsId",
                table: "ClientRoom",
                newName: "RoomsId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom",
                columns: new[] { "RoomsId", "RoomsId1" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientRoom_RoomsId1",
                table: "ClientRoom",
                column: "RoomsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Clients_RoomsId",
                table: "ClientRoom",
                column: "RoomsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Rooms_RoomsId1",
                table: "ClientRoom",
                column: "RoomsId1",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
