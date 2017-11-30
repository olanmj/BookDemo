using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BookDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Authors",
            //    columns: table => new
            //    {
            //        AuthorID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Author", x => x.AuthorID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    columns: table => new
            //    {
            //        BookID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        AuthorID = table.Column<int>(type: "int", nullable: false),
            //        Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PubDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Book", x => x.BookID);
            //        table.ForeignKey(
            //            name: "FK_Book_Author_AuthorID",
            //            column: x => x.AuthorID,
            //            principalTable: "Authors",
            //            principalColumn: "AuthorID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Book_AuthorID",
            //    table: "Books",
            //    column: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
