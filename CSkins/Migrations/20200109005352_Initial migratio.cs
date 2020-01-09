using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSkins.Migrations
{
    public partial class Initialmigratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Gun = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    SkinId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Skin_SkinId",
                        column: x => x.SkinId,
                        principalTable: "Skin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Skin",
                columns: new[] { "Id", "Description", "Gun", "ImageUrl", "Name" },
                values: new object[] { 1, "A very rare AWP skin from the Cobblestone Collection case", "AWP", "/images/dragonlore.jpg", "Dragon Lore" });

            migrationBuilder.InsertData(
                table: "Skin",
                columns: new[] { "Id", "Description", "Gun", "ImageUrl", "Name" },
                values: new object[] { 2, "A very rare knife skin. Can be opened in several cases", "Karambit", " /images/marblefade.jpg", "Marble Fade" });

            migrationBuilder.InsertData(
                table: "Skin",
                columns: new[] { "Id", "Description", "Gun", "ImageUrl", "Name" },
                values: new object[] { 3, "A rare AK skin opened from the Spectrum 2 collection", "M4A4", "/images/empress.jpg", "The Empress" });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "SkinId" },
                values: new object[] { 1, "Splendid, I must say. Gracious upon the first sip jolly ole chaps.", 1 });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "SkinId" },
                values: new object[] { 2, "Quite awful in taste and overall quality mate. Do not recommend this one for a night out with the chaps", 2 });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Content", "SkinId" },
                values: new object[] { 3, "Good for a wee bit of a wakeup but not a particular favorite of mine", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Review_SkinId",
                table: "Review",
                column: "SkinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Skin");
        }
    }
}
