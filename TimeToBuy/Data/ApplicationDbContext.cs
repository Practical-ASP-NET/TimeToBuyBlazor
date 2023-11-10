using Microsoft.EntityFrameworkCore;

namespace TimeToBuy.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Product { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        var products = new List<Product>()
        {
            new() { Id = 1, Name = "The Witcher 3: Wild Hunt", ShortDescription = "Role-playing game", Description = "Geralt of Rivia, a lone monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.", CurrentPrice = 49.99M },
            new() { Id = 2, Name = "Grand Theft Auto V", ShortDescription = "Action-adventure game", Description = "Los Santos: a sprawling sun-soaked metropolis full of self-help gurus, starlets, and fading celebrities, once the envy of the Western world, now struggling to stay afloat in an era of economic uncertainty and cheap reality TV.", CurrentPrice = 59.99M },
            new() { Id = 3, Name = "Red Dead Redemption 2", ShortDescription = "Adventure game", Description = "America, 1899. The end of the wild west era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee.", CurrentPrice = 59.99M },
            new() { Id = 4, Name = "FIFA 22", ShortDescription = "Sports game", Description = "FIFA 22 brings the game even closer to the real thing with fundamental gameplay advances and a new season of innovation across every mode.", CurrentPrice = 59.99M },
            new() { Id = 5, Name = "Minecraft", ShortDescription = "Sandbox game", Description = "Minecraft is a game about placing blocks and going on adventures. Build anything you can imagine with unlimited resources in Creative mode, or go on grand expeditions in Survival across mysterious lands and into the depths of your own worlds.", CurrentPrice = 26.95M },
            new() { Id = 6, Name = "Call Of Duty: Warzone", ShortDescription = "Shooter game", Description = "Call of Duty: Warzone is a free-to-play battle royale video game released on March 10, 2020, for PlayStation 4, PlayStation 5, Xbox One, Xbox Series X/S, and Microsoft Windows.", CurrentPrice = 59.99M },
            new() { Id = 7, Name = "Resident Evil Village", ShortDescription = "Horror game", Description = "Experience survival horror like never before in Resident Evil Village, the eighth major installment in the genre-defining Resident Evil franchise. Set a few years after the horrifying events in the critically acclaimed Resident Evil 7 biohazard, the all-new storyline brings Ethan Winters to a remote snow-capped village filled with a diverse cast of terrifying enemies.", CurrentPrice = 59.99M },
            new() { Id = 8, Name = "Cyberpunk 2077", ShortDescription = "Role-playing game", Description = "Cyberpunk 2077 is an open-world, action-adventure story set in Night City, a megalopolis obsessed with power, glamour and body modification. You play as V, a mercenary outlaw going after a one-of-a-kind implant that is the key to immortality.", CurrentPrice = 59.99M },
            new() { Id = 9, Name = "Hades", ShortDescription = "Action game", Description = "Battle out of hell in Hades, recipient of more than 50 Game of the Year awards! In this god-like rogue-like dungeon crawler, you'll wield the powers and mythic weapons of Olympus to break free from the clutches of the god of the dead himself, while growing stronger and unraveling more of the story with each unique escape attempt.", CurrentPrice = 24.99M },
            new() { Id = 10, Name = "Animal Crossing: New Horizons", ShortDescription = "Simulation game", Description = "Escape to a deserted island and create your own paradise as you explore, create, and customize in the Animal Crossing: New Horizons game. Your island getaway has a wealth of natural resources that can be used to craft everything from tools to creature comforts.", CurrentPrice = 59.99M }
        };

        modelBuilder.Entity<Product>().HasData(products);
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public decimal CurrentPrice { get; set; }
}