using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortGen.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Abouts_AboutId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Skills",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Experiences",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "Experiences",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Abouts_AboutId",
                table: "Experiences",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Abouts_AboutId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "OrderNo",
                table: "Experiences");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Skills",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Experiences",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Abouts_AboutId",
                table: "Experiences",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id");
        }
    }
}
