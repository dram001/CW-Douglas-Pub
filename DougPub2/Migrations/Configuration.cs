namespace DougPub2.Migrations
{
    using System.Linq;
    using System.Security.Claims;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin;
    using Microsoft.Owin.Security;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using System.Web;
    using System.Data.Entity.Migrations;
    using DougPub2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DougPub2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DougPub2.Models.ApplicationDbContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var user = new ApplicationUser { UserName = "admin@gmail.com" };
            var guestUser = new ApplicationUser { UserName = "guest@guest.com" };

            userManager.Create(user, "Admin@123"); //strong password!#@$!
            userManager.Create(guestUser, "Guest@1"); //strong password!#@$!

            roleManager.Create(new IdentityRole { Name = "Admin" });
            userManager.AddToRole(user.Id, "Admin");

            context.Catagories.AddOrUpdate(
                  c => c.Name,
                  new Catagorie { Name = "Snacks" },
                  new Catagorie { Name = "Main Courses" },
                  new Catagorie { Name = "Desserts" },
                  new Catagorie { Name = "Drinks" },
                  new Catagorie { Name = "Drinks (Non-Alcoholic)" }
                );

            context.Items.AddOrUpdate(
                 X => X.Name,
                 new Item { CatagorieId = 1, Name = "Pork Scratchings", Price = 60, ItemPictureUrl = "/Content/img/pork-scratchings.jpg", InternalImage = null, Description = "Pork rind rendered to a crisp and seasoned with salt" },
                 new Item { CatagorieId = 1, Name = "Scotch Eggs", Price = 65, ItemPictureUrl = "/Content/img/scotch-egg.jpg", InternalImage = null, Description = "The true classic British delicacies!" },
                 new Item { CatagorieId = 1, Name = "Soup", Price = 40, ItemPictureUrl = "/Content/img/soup.jpg", InternalImage = null, Description = "Soup with crusty bread and butter" },
                 new Item { CatagorieId = 1, Name = "Pate and Toast", Price = 70, ItemPictureUrl = "/Content/img/pate-on-toast.jpg", InternalImage = null, Description = "Diced livers on toast, cooked with garlic and herbs" },
                 new Item { CatagorieId = 1, Name = "Potted Shrimp", Price = 70, ItemPictureUrl = "/Content/img/potted-shrimps.jpg", InternalImage = null, Description = "Brown shrimp cooked and then set in butter, flavoured with nutmeg" },
                 new Item { CatagorieId = 1, Name = "Whitebait", Price = 80, ItemPictureUrl = "/Content/img/whitebait.jpg", InternalImage = null, Description = "Small and delicate baby fishes!" },

                 new Item { CatagorieId = 2, Name = "All Day Breakfast", Price = 168, ItemPictureUrl = "/Content/img/all-day-breakfast.jpg", InternalImage = null, Description = "The Full Breakfast is available all day" },
                 new Item { CatagorieId = 2, Name = "Fish and Chips", Price = 162, ItemPictureUrl = "/Content/img/fish-and-chips-2.jpg", InternalImage = null, Description = "A famous British food served with malt vinegar, lemon juice and tartare sauce" },
                 new Item { CatagorieId = 2, Name = "Scampi and Chips", Price = 140, ItemPictureUrl = "/Content/img/scampi-chips.jpg", InternalImage = null, Description = "Alternative to fish and chips. Also served with salt and vinegar and tartare sauce" },
                 new Item { CatagorieId = 2, Name = "Bangers and Mash", Price = 145, ItemPictureUrl = "/Content/img/bangers-and-mash-1.jpg", InternalImage = null, Description = "Sausages and mashed potatoes, served with gravy" },
                 new Item { CatagorieId = 2, Name = "Pork Belly", Price = 166, ItemPictureUrl = "/Content/img/pork-belly-and-mash.jpg", InternalImage = null, Description = "Pork belly served with creamy mashed potatoes, vegetables and apple sauce" },
                 new Item { CatagorieId = 2, Name = "Pie and Mash", Price = 122, ItemPictureUrl = "/Content/img/pie-mash.jpg", InternalImage = null, Description = "A pie with mashed potatoes, vegetables and gravy" },
                 new Item { CatagorieId = 2, Name = "Liver and Bacon", Price = 150, ItemPictureUrl = "/Content/img/liver-bacon.jpg", InternalImage = null, Description = "Served with mashed potatoes, fried onions and vegetables" },
                 new Item { CatagorieId = 2, Name = "Burger and Chips", Price = 142, ItemPictureUrl = "/Content/img/burger-and-chips.jpg", InternalImage = null, Description = "A British beef patty combined with cheese, bacon, lettuce and tomato, all within a toasted brioche bun" },
                 new Item { CatagorieId = 2, Name = "Steak and Chips", Price = 252, ItemPictureUrl = "/Content/img/steak-and-chips-british-dinners.jpg", InternalImage = null, Description = "Rump, sirloin or ribeye, a nice juicy steak with chips, grilled mushrooms, tomatoes and peas" },
                 
                 new Item { CatagorieId = 3, Name = "Ice Cream Sundae", Price = 89, ItemPictureUrl = "/Content/img/ice-cream-sundae-pub-dessert.jpg", InternalImage = null, Description = "Scoops of ice cream are combined with sauce and toppings like chocolate pieces, nuts, cream, fruit and marshmallows" },
                 new Item { CatagorieId = 3, Name = "Sticky Toffee Pudding", Price = 72, ItemPictureUrl = "/Content/img/sticky-toffee-pudding.jpg", InternalImage = null, Description = "A sponge cake oozing with toffee sauce" },
                 new Item { CatagorieId = 3, Name = "Apple Crumble", Price = 66, ItemPictureUrl = "/Content/img/apple-crumble.jpg", InternalImage = null, Description = "A nice chunky apple pieces spiced with cinnamon and covered with a crisp yet crumbly topping and custard" },
                 new Item { CatagorieId = 3, Name = "Chocolate Fudge Cake", Price = 76, ItemPictureUrl = "/Content/img/chocolate-fudge-cake.jpg", InternalImage = null, Description = "Similar to the sticky toffee pudding, but oozes chocolate instead" },
                 new Item { CatagorieId = 3, Name = "Cheese Board", Price = 92, ItemPictureUrl = "/Content/img/cheese-board.jpg", InternalImage = null, Description = "A variety of cheeses to try along with crackers, chutney and fruit" },

                 new Item { CatagorieId = 4, Name = "GUINNESS STOUT", Price = 88, ItemPictureUrl = "/Content/img/guinness-stout.jpg", InternalImage = null, Description = "A dark Irish dry stout" },
                 new Item { CatagorieId = 4, Name = "O'HARA'S IRISH RED", Price = 88, ItemPictureUrl = "/Content/img/O'HARA'S-IRISH-RED.jpg", InternalImage = null, Description = "A Irish Red Ale style beer" },
                 new Item { CatagorieId = 4, Name = "MAGNERS APPLE CIDER", Price = 79, ItemPictureUrl = "/Content/img/MAGNERS-APPLE-CIDER.jpg", InternalImage = null, Description = "A Premium Irish Cider crafted with the finest blend of 17 Apple Varieties" },
                 new Item { CatagorieId = 4, Name = "ABSOLUT VODKA", Price = 84, ItemPictureUrl = "/Content/img/ABSOLUT-VODKA.jpg", InternalImage = null, Description = "A Swedish vodka made exclusively from natural ingredients" },
                 new Item { CatagorieId = 4, Name = "MOJITOS", Price = 116, ItemPictureUrl = "/Content/img/MOJITOS.jpg", InternalImage = null, Description = "Light Rum, Sweet n Sour & Mint" },
                 new Item { CatagorieId = 4, Name = "BLACK RUSSIAN", Price = 104, ItemPictureUrl = "/Content/img/BLACK-RUSSIAN.jpg", InternalImage = null, Description = "Ketel One & Kahlua" },
                 new Item { CatagorieId = 4, Name = "SLOW COMFORTABLE SCREW", Price = 104, ItemPictureUrl = "/Content/img/SLOW-COMFORTABLE-SCREW.jpg", InternalImage = null, Description = "Southern Comfort, Sloe Gin, vodka & OJ." },
                 
                 new Item { CatagorieId = 5, Name = "FRUIT PUNCH", Price = 78, ItemPictureUrl = "/Content/img/FRUIT-PUNCH.jpg", InternalImage = null, Description = "Fresh OJ, Grapefruit & Pineapple" },
                 new Item { CatagorieId = 5, Name = "SHIRLEY TEMPLE", Price = 78, ItemPictureUrl = "/Content/img/SHIRLEY-TEMPLE.jpg", InternalImage = null, Description = "Berry Juice & Sprite" },
                 new Item { CatagorieId = 5, Name = "COKE/ GINGER ALE/ TONIC WATER", Price = 45, ItemPictureUrl = "/Content/img/coke.jpg", InternalImage = null, Description = "Soft drink" }
               );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
