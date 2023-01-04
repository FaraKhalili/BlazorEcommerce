using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class Productseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "When Oprah Winfrey speaks, the world listens. Health – both emotional and physical,and general wellness are the topics she often focuses upon. She is completely transparent with her own strugglesin these areas, allowing herself to be relatable whilst also inspiring change", "https://m.media-amazon.com/images/I/419htJJ1l5L._SX331_BO1,204,203,200_.jpg", 13.03m, "Oprah Winfrey: The Life, Lessons & Rules for Success" },
                    { 2, "Our earliest experiences shape our lives far down the road, and What Happened to You? provides powerful scientific and emotional insights into the behavioral patterns so many of us struggle to understand.", "https://m.media-amazon.com/images/I/41o9P29YcqL._SX328_BO1,204,203,200_.jpg", 15.99m, "What Happened to You : Conversations on Trauma, Resilience, and Healing" },
                    { 3, "In this accessible and groundbreaking book--filled with the moving stories of real people--medical doctor and bestselling author Gabor Maté shows that emotion and psychological stress play a powerful role in the onset of chronic illness, including breast cancer, prostate cancer, multiple sclerosis and many others, even Alzheimer's disease.", "https://m.media-amazon.com/images/I/41Nwq227r4L._SX330_BO1,204,203,200_.jpg", 16.99m, "When the Body Says No: The Cost of Hidden Stress" }
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
        }
    }
}
