using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class incertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Electronic items", "Electronics" },
                    { 2, "Various books", "Books" },
                    { 3, "Apparel and accessories", "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "High performance laptop", "Laptop", 1000m, 10 },
                    { 2, 1, "Latest model smartphone", "Smartphone", 800m, 15 },
                    { 3, 1, "Noise-cancelling headphones", "Headphones", 200m, 20 },
                    { 4, 1, "10-inch display tablet", "Tablet", 400m, 12 },
                    { 5, 1, "Waterproof smartwatch", "Smartwatch", 250m, 18 },
                    { 6, 2, "Fiction novel", "Novel A", 20m, 50 },
                    { 7, 2, "Mystery novel", "Novel B", 18m, 40 },
                    { 8, 2, "Educational science book", "Science Book", 30m, 25 },
                    { 9, 2, "Historical events book", "History Book", 25m, 35 },
                    { 10, 2, "Famous person biography", "Biography", 28m, 30 },
                    { 11, 3, "Cotton t-shirt", "T-Shirt", 15m, 100 },
                    { 12, 3, "Denim jeans", "Jeans", 40m, 60 },
                    { 13, 3, "Winter jacket", "Jacket", 80m, 25 },
                    { 14, 3, "Comfortable sneakers", "Sneakers", 60m, 45 },
                    { 15, 3, "Stylish cap", "Cap", 10m, 75 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
