using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PopugJira.Data.Migrations
{
    public partial class Tasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TasksList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    userCreatedId = table.Column<string>(nullable: true),
                    userExecuteId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TasksList_AspNetUsers_userCreatedId",
                        column: x => x.userCreatedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TasksList_AspNetUsers_userExecuteId",
                        column: x => x.userExecuteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TasksList_userCreatedId",
                table: "TasksList",
                column: "userCreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_TasksList_userExecuteId",
                table: "TasksList",
                column: "userExecuteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksList");
        }
    }
}
