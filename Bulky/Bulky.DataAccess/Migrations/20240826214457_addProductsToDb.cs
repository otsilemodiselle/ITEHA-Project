using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "ListPrice", "Name", "Supplier" },
                values: new object[,]
                {
                    { 1, "827349", "Paiting of African woman.", 1999.0, "Painting", "Arckerman Artworks" },
                    { 2, "193674", "Sculpture of African woman.", 849.0, "Ornament", "Chokwe Carvings" },
                    { 3, "582913", "A trio of African style mask statues.", 2500.0, "Masks", "Ettiene Etchings" },
                    { 4, "746025", "Crescent shaped necklace.", 475.0, "Necklace", "Nandi Necklaces" },
                    { 5, "238964", "Ornate beaded bracelet.", 399.0, "Bracelet", "Barend Beadwork" },
                    { 6, "901758", "Beaded necklace with intricate charm.", 819.0, "Charmed Necklace", "Japhthah Jewellers" },
                    { 7, "364217", "Wooden stool with African pot atop.", 1000.0, "Stool and Vase", "Francis Furnishers" },
                    { 8, "512480", "Cabinet with bespoke pottery on display.", 4899.0, "Showcase", "Author Artisans" },
                    { 9, "679341", "Sleek couch with African style fabric.", 3500.0, "Couch", "Makhubela Makers" },
                    { 10, "453829", "African style blazer and pants suit.", 2250.0, "Suit", "Thuso Taylors" },
                    { 11, "720496", "African style gown for girls.", 1600.0, "Gown", "Emma Embroiders" },
                    { 12, "185237", "Bespoke cascading Africa dress.", 2900.0, "Dress", "Felicia Fashioners" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
