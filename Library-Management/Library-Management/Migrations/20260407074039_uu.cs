using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_Management.Migrations
{
    /// <inheritdoc />
    public partial class uu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    memberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.memberId);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    borrowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    borrowdate = table.Column<DateOnly>(type: "date", nullable: false),
                    returndate = table.Column<DateOnly>(type: "date", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false),
                    memberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.borrowId);
                    table.ForeignKey(
                        name: "FK_Borrows_Books_bookId",
                        column: x => x.bookId,
                        principalTable: "Books",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_Members_memberId",
                        column: x => x.memberId,
                        principalTable: "Members",
                        principalColumn: "memberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_bookId",
                table: "Borrows",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_memberId",
                table: "Borrows",
                column: "memberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
