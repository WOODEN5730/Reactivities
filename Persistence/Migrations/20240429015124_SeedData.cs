
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("032e36a7-2959-4939-bffb-153a17d8c11a"), "drinks", "London", new DateTime(2024, 7, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2536), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("0394107e-95b6-4db4-be03-b45c1152d8f8"), "travel", "London", new DateTime(2024, 11, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2551), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("2dcbff29-b09a-4084-a5a7-ef1b31ac8133"), "culture", "London", new DateTime(2024, 5, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2533), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("3f22892a-33fb-4370-86b8-76b9bbdc00ec"), "culture", "Paris", new DateTime(2024, 3, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2530), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("48373c4f-47db-4137-848c-e254674af5d0"), "drinks", "London", new DateTime(2024, 9, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2547), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("60016532-b76f-4b16-8b5a-3f7f05c86df3"), "drinks", "London", new DateTime(2024, 8, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2546), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("6ab7b11f-f386-4863-bd80-4a6b1f948368"), "music", "London", new DateTime(2024, 10, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2549), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("a279b50e-3d78-485a-a7f9-e9b7ba1ab175"), "drinks", "London", new DateTime(2024, 2, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2521), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("a947ed77-c2f7-40cb-bd1f-4ea710d5b4a3"), "music", "London", new DateTime(2024, 6, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2535), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("f057e460-057d-40b4-856b-77b5fccf75f9"), "film", "London", new DateTime(2024, 12, 29, 1, 51, 24, 129, DateTimeKind.Utc).AddTicks(2552), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("032e36a7-2959-4939-bffb-153a17d8c11a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0394107e-95b6-4db4-be03-b45c1152d8f8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2dcbff29-b09a-4084-a5a7-ef1b31ac8133"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3f22892a-33fb-4370-86b8-76b9bbdc00ec"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("48373c4f-47db-4137-848c-e254674af5d0"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("60016532-b76f-4b16-8b5a-3f7f05c86df3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6ab7b11f-f386-4863-bd80-4a6b1f948368"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a279b50e-3d78-485a-a7f9-e9b7ba1ab175"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a947ed77-c2f7-40cb-bd1f-4ea710d5b4a3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f057e460-057d-40b4-856b-77b5fccf75f9"));
        }
    }
}
