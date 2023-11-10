using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TimeToBuy.Migrations
{
    /// <inheritdoc />
    public partial class seedproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CurrentPrice", "Description", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 49.99m, "Geralt of Rivia, a lone monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.", "The Witcher 3: Wild Hunt", "Role-playing game" },
                    { 2, 59.99m, "Los Santos: a sprawling sun-soaked metropolis full of self-help gurus, starlets, and fading celebrities, once the envy of the Western world, now struggling to stay afloat in an era of economic uncertainty and cheap reality TV.", "Grand Theft Auto V", "Action-adventure game" },
                    { 3, 59.99m, "America, 1899. The end of the wild west era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee.", "Red Dead Redemption 2", "Adventure game" },
                    { 4, 59.99m, "FIFA 22 brings the game even closer to the real thing with fundamental gameplay advances and a new season of innovation across every mode.", "FIFA 22", "Sports game" },
                    { 5, 26.95m, "Minecraft is a game about placing blocks and going on adventures. Build anything you can imagine with unlimited resources in Creative mode, or go on grand expeditions in Survival across mysterious lands and into the depths of your own worlds.", "Minecraft", "Sandbox game" },
                    { 6, 59.99m, "Call of Duty: Warzone is a free-to-play battle royale video game released on March 10, 2020, for PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, and Microsoft Windows.", "Call Of Duty: Warzone", "Shooter game" },
                    { 7, 59.99m, "Experience survival horror like never before in Resident Evil Village, the eighth major installment in the genre-defining Resident Evil franchise. Set a few years after the horrifying events in the critically acclaimed Resident Evil 7 biohazard, the all-new storyline brings Ethan Winters to a remote snow-capped village filled with a diverse cast of terrifying enemies.", "Resident Evil Village", "Horror game" },
                    { 8, 59.99m, "Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification. You play as V, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality.", "Cyberpunk 2077", "Role-playing game" },
                    { 9, 24.99m, "Battle out of hell in Hades, recipient of more than 50 Game of the Year awards! In this god-like rogue-like dungeon crawler, you'll wield the powers and mythic weapons of Olympus to break free from the clutches of the god of the dead himself, while growing stronger and unraveling more of the story with each unique escape attempt.", "Hades", "Action game" },
                    { 10, 59.99m, "Escape to a deserted island and create your own paradise as you explore, create, and customize in the Animal Crossing: New Horizons game. Your island getaway has a wealth of natural resources that can be used to craft everything from tools to creature comforts.", "Animal Crossing: New Horizons", "Simulation game" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
