using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookDemo.Migrations
{
    public partial class datetoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PubDate",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PubDate",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
