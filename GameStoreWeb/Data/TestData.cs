using GameStoreWeb.Models;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace GameStoreWeb.Data {
    public class TestData {
        public async static Task Load(AppDbContext AppDbContext) {
            await AppDbContext.Database.MigrateAsync();

            if (await AppDbContext.Products.AnyAsync()) {
                return;
            }

            //Genre
            var Action = new Genre()
            { Name = "Action" };

            var Survival = new Genre()
            { Name = "Survival" };

            var Adventure = new Genre()
            { Name = "Adventure" };

            var Sandbox = new Genre()
            { Name = "Sandbox" };

            var Hack_And_Slash = new Genre()
            { Name = "Hack-And-Slash" };

            var Social = new Genre()
            { Name = "Social" };

            var Role_Playing = new Genre()
            { Name = "Role-Playing" };

            var Simulation = new Genre()
            { Name = "Simulation" };

            var Horror = new Genre()
            { Name = "Horror" };

            //Products
            var Conan_Exiles = new Product()
            {
                Title = "Conan Exiles",
                Description = "Conan Exiles is an open-world survival game set in the brutal world of Conan the Barbarian. Players must survive in a harsh and unforgiving environment while building and defending their own settlements, battling fierce monsters, and exploring the vast and dangerous landscape. The game also features a deep crafting system, allowing players to create weapons, armor, and other tools to aid in their survival.",
                Price = 39.99M,
                Genre = Survival,
            };

            var Grand_Theft_Auto_V = new Product()
            {
                Title = "Grand Theft Auto V",
                Description = "A popular open-world game that follows the lives of three criminals as they navigate through the city of Los Santos.",
                Price = 29.99M,
                Genre = Action,
            };

            var Minecraft = new Product()
            {
                Title = "Minecraft",
                Description = "A sandbox game where players can build and explore their own virtual world using blocks.",
                Price = 26.95M,
                Genre = Sandbox,
            };

            var Among_Us = new Product()
            {
                Title = "Among Us",
                Description = "A multiplayer game where players work together to complete tasks on a spaceship, while trying to identify and vote off any impostors.",
                Price = 5.00M,
                Genre = Social,
            };

            var Stardew_Valley = new Product()
            {
                Title = "Stardew Valley",
                Description = "A farming simulation game where players can build and manage their own farm, raise animals, and interact with the community.",
                Price = 14.99M,
                Genre = Simulation,
            };

            var Resident_Evil_Village = new Product()
            {
                Title = "Resident Evil Village",
                Description = "A survival horror game where players must survive and escape from a mysterious village.",
                Price = 59.99M,
                Genre = Horror,
            };

            var Red_Dead_Redemption_2 = new Product()
            {
                Title = "Red Dead Redemption 2",
                Description = "A Western action-adventure game where players take on the role of outlaw Arthur Morgan and his gang as they navigate through the Wild West.",
                Price = 59.99M,
                Genre = Adventure,
            };

            var Dark_Souls_III = new Product()
            {
                Title = "Dark Souls III",
                Description = "A challenging action role-playing game that takes place in a dark and mysterious world.",
                Price = 59.99M,
                Genre = Action,
            };

            var Diablo_III = new Product()
            {
                Title = "Diablo III",
                Description = "A dungeon-crawling game where players can choose from a variety of characters to battle demons and monsters in a dark fantasy world.",
                Price = 19.99M,
                Genre = Hack_And_Slash,
            };

            var Cyberpunk_2077 = new Product()
            {
                Title = "Cyberpunk 2077",
                Description = "A futuristic open-world game where players take on the role of a mercenary in Night City, a city of high-tech and low-life.",
                Price = 59.99M,
                Genre = Role_Playing,
            };

            await AppDbContext.Products.AddRangeAsync(new Product[]
            { Conan_Exiles, Grand_Theft_Auto_V, Minecraft, Among_Us, Stardew_Valley, Resident_Evil_Village, Red_Dead_Redemption_2,
            Dark_Souls_III, Diablo_III, Cyberpunk_2077});

            await AppDbContext.Genres.AddRangeAsync(new Genre[]
            {Action, Survival, Adventure, Sandbox, Hack_And_Slash, Social, Role_Playing, Simulation, Horror});

            await AppDbContext.SaveChangesAsync();



        }
    }
}
