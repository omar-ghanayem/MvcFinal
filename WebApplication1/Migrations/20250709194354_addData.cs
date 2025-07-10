using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "High-performance laptops for gaming on the go.", "https://images.unsplash.com/photo-1603791440384-56cd371ee9a7", "Gaming Laptops" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Essential accessories to enhance your gaming experience.", "https://images.unsplash.com/photo-1606813909357-6c06b3d06670", "Gaming Accessories" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "High-end parts to build or upgrade your gaming PC.", "https://images.unsplash.com/photo-1622445240093-5c583afad7df", "PC Components" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Ultra-thin, powerful gaming laptop with RTX graphics.", "https://images.unsplash.com/photo-1610465291908-9680af5dc5c3", "Alienware x15", 2500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Compact gaming powerhouse with AMD Ryzen.", "https://images.unsplash.com/photo-1603791440384-56cd371ee9a7", "ASUS ROG Zephyrus G14", 1800m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Desktop-level performance in a portable chassis.", "https://images.unsplash.com/photo-1610484826969-6bfb495c7e7e", "MSI GE76 Raider", 2200m, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sleek design with powerful GPU for high FPS gaming.", "https://images.unsplash.com/photo-1609942531744-6aa46f8cc8f6", "Razer Blade 15", 2400m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Affordable yet powerful laptop for serious gamers.", "https://images.unsplash.com/photo-1622445240093-5c583afad7df", "Lenovo Legion 5 Pro", 1600m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Pro-level gaming headset with Blue VO!CE technology.", "https://images.unsplash.com/photo-1593642532973-d31b6557fa68", "Logitech G Pro X Headset", 130m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Mechanical keyboard with customizable RGB and macro keys.", "https://images.unsplash.com/photo-1587202372775-989305e9b13f", "Corsair K95 RGB Keyboard", 200m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Ergonomic, ultra-fast gaming mouse.", "https://images.unsplash.com/photo-1579546928687-c5f301b01016", "Razer DeathAdder V2 Mouse", 70m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Large surface mouse pad for precise movements.", "https://images.unsplash.com/photo-1620332324517-917e03be63f4", "SteelSeries QcK Mouse Pad", 30m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Customizable control pad for streamers and content creators.", "https://images.unsplash.com/photo-1622445240093-5c583afad7df", "Elgato Stream Deck", 150m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Ultimate graphics card for 4K and high-FPS gaming.", "https://images.unsplash.com/photo-1625603614538-b3a9d66b3cb1", "NVIDIA RTX 4090 GPU", 1600m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Top-tier processor for gaming and multitasking.", "https://images.unsplash.com/photo-1587206661871-8700cf32d296", "Intel Core i9-13900K CPU", 600m, 12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "High-speed DDR5 RAM for ultra-smooth gameplay.", "https://images.unsplash.com/photo-1611703376240-27f9f05ba6f6", "Corsair Vengeance 32GB RAM", 250m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Ultra-fast storage for quick loading and system performance.", "https://images.unsplash.com/photo-1616628182440-9fdf52e55b93", "Samsung 980 Pro 2TB SSD", 230m, 15 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Premium liquid cooling with customizable LCD display.", "https://images.unsplash.com/photo-1633081815765-1422eaa16c0b", "NZXT Kraken Z73 Liquid Cooler", 280m, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Electronic items", null, "Electronics" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Various books", null, "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Apparel and accessories", null, "Clothing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "High performance laptop", null, "Laptop", 1000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Latest model smartphone", null, "Smartphone", 800m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Noise-cancelling headphones", null, "Headphones", 200m, 20 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "10-inch display tablet", null, "Tablet", 400m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Waterproof smartwatch", null, "Smartwatch", 250m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Fiction novel", null, "Novel A", 20m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Mystery novel", null, "Novel B", 18m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Educational science book", null, "Science Book", 30m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Historical events book", null, "History Book", 25m, 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Famous person biography", null, "Biography", 28m, 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Cotton t-shirt", null, "T-Shirt", 15m, 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Denim jeans", null, "Jeans", 40m, 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Winter jacket", null, "Jacket", 80m, 25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Comfortable sneakers", null, "Sneakers", 60m, 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { "Stylish cap", null, "Cap", 10m, 75 });
        }
    }
}
