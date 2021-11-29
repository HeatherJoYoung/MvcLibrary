using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcLibrary.Migrations
{
    public partial class LibraryItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "LibraryItems");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LibraryItems",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublicationDate",
                table: "LibraryItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Pages",
                table: "LibraryItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Actor",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BandName",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSoloArtist",
                table: "LibraryItems",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Studio",
                table: "LibraryItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryItems",
                table: "LibraryItems",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryItems",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Actor",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "BandName",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "IsSoloArtist",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "LibraryItems");

            migrationBuilder.DropColumn(
                name: "Studio",
                table: "LibraryItems");

            migrationBuilder.RenameTable(
                name: "LibraryItems",
                newName: "Book");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Book",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublicationDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pages",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");
        }
    }
}
