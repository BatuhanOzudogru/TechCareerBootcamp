using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task4.Migrations
{
    public partial class createJoinManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderWebUser",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    WebUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderWebUser", x => new { x.OrderId, x.WebUserId });
                    table.ForeignKey(
                        name: "FK_OrderWebUser_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderWebUser_WebUsers_WebUserId",
                        column: x => x.WebUserId,
                        principalTable: "WebUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderWebUser_WebUserId",
                table: "OrderWebUser",
                column: "WebUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderWebUser");
        }
    }
}
