using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addDataGamingRealted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "High-performance laptops for gaming", "Gaming Laptops" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Keyboards, mice, and other accessories", "PC Accessories" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "High refresh rate and high resolution monitors", "Monitors" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "17-inch gaming laptop with RTX 3080", "alienware.jpg", "Alienware x17", 3000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Slim and powerful gaming laptop", "rog.jpg", "ASUS ROG Zephyrus", 2500m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Desktop-class gaming performance", "msi.jpg", "MSI Raider GE76", 2800m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Portable premium gaming laptop", "razer.jpg", "Razer Blade 15", 2700m, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Mechanical gaming keyboard", "keyboard.jpg", "Logitech G Pro X Keyboard", 150m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Lightweight gaming mouse", "mouse.jpg", "Logitech G Pro Wireless Mouse", 130m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Gaming headset with 7.1 surround", "headset.jpg", "HyperX Cloud II", 100m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Control panel for streamers", "streamdeck.jpg", "Elgato Stream Deck", 200m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 3, "360Hz gaming monitor", "rogmonitor.jpg", "ASUS ROG Swift PG259QN", 700m, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 3, "Curved QD-OLED monitor", "alienwaremonitor.jpg", "Dell Alienware AW3423DW", 1300m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Super ultrawide gaming monitor", "odyssey.jpg", "Samsung Odyssey G9", 1500m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "4K UHD nano IPS gaming monitor", "lgmonitor.jpg", "LG UltraGear 27GN950", 800m, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Electronic items", "Electronics" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Various books", "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Apparel and accessories", "Clothing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "High performance laptop", null, "Laptop", 1000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Latest model smartphone", null, "Smartphone", 800m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Noise-cancelling headphones", null, "Headphones", 200m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "10-inch display tablet", null, "Tablet", 400m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 1, "Waterproof smartwatch", null, "Smartwatch", 250m, 18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Fiction novel", null, "Novel A", 20m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Mystery novel", null, "Novel B", 18m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Educational science book", null, "Science Book", 30m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Historical events book", null, "History Book", 25m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { 2, "Famous person biography", null, "Biography", 28m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Cotton t-shirt", null, "T-Shirt", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[] { "Denim jeans", null, "Jeans", 40m, 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 13, 3, "Winter jacket", null, "Jacket", 80m, 25 },
                    { 14, 3, "Comfortable sneakers", null, "Sneakers", 60m, 45 },
                    { 15, 3, "Stylish cap", null, "Cap", 10m, 75 }
                });
        }
    }
}
