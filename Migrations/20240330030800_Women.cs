using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeTrove.Migrations
{
    /// <inheritdoc />
    public partial class Women : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Women",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   newprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   oldprice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   image = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Women", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Women");
        }
    }
}
