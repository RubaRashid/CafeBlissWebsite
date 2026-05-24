using CafeBliss.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeBliss.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            var menus = new List<Menu>
        {
            new Menu {
                Id=1,
                Name="Espresso",
                Description="Strong coffee shot",
                ImageUrl="/Images/Drinks/Espresso.jpg",
                Price=400,
                Category = "Cofe"
            },
            new Menu {
                Id=2,
                Name="Cappuccino",
                Description="Milk foam coffee",
                ImageUrl="/Images/Drinks/Caramel-Cappucino.jpg",
                Price=450,
                Category = "Cofe"
            },
            new Menu {
                Id=3,
                Name="Latte",
                Description="Creamy milk coffee",
                ImageUrl="/Images/Drinks/Latte.jpg",
                Price=600,
                Category = "Cofe"
            },
            new Menu { Id=4,
                Name="Mocha",
                Description="Chocolate coffee",
                ImageUrl="/Images/Drinks/Mocha.jpg",
                Price=500,
                Category = "Cofe"
            },
            new Menu {
                Id = 5,
                Name = "Flat White",
                Description = "Velvety espresso milk",
                ImageUrl = "/Images/Drinks/Flat_White.jpg",
                Price = 650,
                Category = "Cofe"
            },
            new Menu {
                Id = 6,
                Name = "Americano",
                Description = "Bold black coffee",
                ImageUrl = "/Images/Drinks/Americano.jpg",
                Price = 500,
                Category = "Cofe"
            },

            new Menu {
                Id = 7,
                Name = "Classic Cortado",
                Description = "Smooth textured espresso",
                ImageUrl = "/Images/Drinks/Classic_Cortado.jpg",
                Price = 650,
                Category = "Cofe"
            },
            new Menu {
                Id = 8,
                Name = "Mocha Cortado",
                Description = "Chocolate creamy espresso",
                ImageUrl = "/Images/Drinks/Mocha_Cortado.jpg",
                Price = 700,
                Category = "Cofe"
            },

            new Menu {
                Id = 9,
                Name = "Salted Caramel Cappuccino",
                Description = "Sweet salted cappuccino",
                ImageUrl = "/Images/Drinks/SaltedCaramelCappuccino.png",
                Price = 750,
                Category = "Cofe"
            },

            new Menu {
                Id = 10,
                Name = "Macchiato",
                Description = "Mild foamy espresso",
                ImageUrl = "/Images/Drinks/machiatto.jpg",
                Price = 600,
                Category = "Cofe"
            },

            new Menu {
                Id = 11,
                Name = "Ristretto",
                Description = "Bold intense espresso",
                ImageUrl = "/Images/Drinks/ristretto.jpg",
                Price = 500,
                Category = "Cofe"
            },

            new Menu {
                Id = 12,
                Name = "White Hot Chocolate",
                Description = "Creamy white chocolate",
                ImageUrl = "/Images/Drinks/WhiteHotChocolate.png",
                Price = 700,
                Category = "Cofe"
            },

            new Menu {
                Id = 13,
                Name = "Hot Chocolate",
                Description = "Rich milky chocolate",
                ImageUrl = "/Images/Drinks/HotChocolate.jpg",
                Price = 650,
                Category = "Cofe"
            },

            new Menu {
                Id = 14,
                Name = "Extra Creamy Hot Chocolate",
                Description = "Creamy chocolate delight",
                ImageUrl = "/Images/Drinks/Extra-Creamy-Hot-Choc.jpg",
                Price = 750,
                Category = "Cofe"
            },

            new Menu {
                Id = 15,
                Name = "Caramel Cappuccino",
                Description = "Creamy caramel coffee",
                ImageUrl = "/Images/Drinks/Caramel-Cappucino.jpg",
                Price = 750,
                Category = "Cofe"
            },

            new Menu {
                Id = 16,
                Name = "Salted Caramel Latte",
                Description = "Sweet caramel latte",
                ImageUrl = "/Images/Drinks/Salted-Caramel-Latte.png",
                Price = 800,
                Category = "Cofe"
            },

            new Menu {
                Id = 17,
                Name = "Karak Tea with Milk",
                Description = "Strong creamy tea",
                ImageUrl = "/Images/Drinks/Karak-Chai.jpg",
                Price = 350,
                Category = "Tea"
},

new Menu {
    Id = 18,
    Name = "Black Tea",
    Description = "Classic strong tea",
    ImageUrl = "/Images/Drinks/Black-Tea.jpg",
    Price = 300,
    Category = "Tea"
},

new Menu {
    Id = 19,
    Name = "Cardamom Tea with Milk",
    Description = "Cardamom milk tea",
    ImageUrl = "/Images/Drinks/Cardamom-Tea-with-Milk.jpg",
    Price = 400,
    Category = "Tea"
},

new Menu {
    Id = 20,
    Name = "Green Tea",
    Description = "Light herbal tea",
    ImageUrl = "/Images/Drinks/Green-Tea.jpg",
    Price = 350,
    Category = "Tea"
},

new Menu {
    Id = 21,
    Name = "Mango n Cream Frappe",
    Description = "Creamy mango frappe",
    ImageUrl = "/Images/Drinks/Mango-Frappe-01.jpg",
    Price = 850,
    Category = "Frappe"
},

new Menu {
    Id = 22,
    Name = "Strawberry Cream",
    Description = "Creamy strawberry drink",
    ImageUrl = "/Images/Drinks/Strawberry-Cream-Frappe.jpg",
    Price = 800,
    Category = "Frappe"
},

new Menu {
    Id = 22,
    Name = "Caramel Crunch",
    Description = "Crunchy caramel frappe",
    ImageUrl = "/Images/Drinks/CaramelCrunch.jpg",
    Price = 850,
    Category = "Frappe"
},

new Menu {
    Id = 23,
    Name = "Salted Caramel Frappe",
    Description = "Salted caramel blend",
    ImageUrl = "/Images/Drinks/SaltedCaramelFrappe.png",
    Price = 900,
    Category = "Frappe"
},

new Menu {
    Id = 24,
    Name = "Coffee Cream",
    Description = "Creamy iced coffee",
    ImageUrl = "/Images/Drinks/CoffeeCream.jpg",
    Price = 850,
    Category = "Frappe"
},

new Menu {
    Id = 25,
    Name = "Chocolate Fudge",
    Description = "Rich chocolate frappe",
    ImageUrl = "/Images/Drinks/Chocolate-Fudge.jpg",
    Price = 900,
    Category = "Frappe"
},

new Menu {
    Id = 26,
    Name = "Iced Latte",
    Description = "Chilled creamy latte",
    ImageUrl = "/Images/Drinks/Iced-Latte.jpg",
    Price = 700,
    Category = "Frappe"
},

new Menu {
    Id = 27,
    Name = "Iced Americano",
    Description = "Refreshing black coffee",
    ImageUrl = "/Images/Drinks/Iced_Americano.jpg",
    Price = 650,
    Category = "Frappe"
},

new Menu {
    Id = 28,
    Name = "Iced Flat White",
    Description = "Cold creamy espresso",
    ImageUrl = "/Images/Drinks/Iced_Flat_White.jpg",
    Price = 750,
    Category = "Frappe"
},

new Menu {
    Id = 29,
    Name = "Signature Iced Chocolate",
    ImageUrl = "/Images/Drinks/Signature-Iced-Chocolate.jpg",
    Price = 800,
    Category = "Frappe"
},

new Menu {
    Id = 33,
    Name = "Iced Mocha",
    Description = "Cold chocolate coffee",
    ImageUrl = "/Images/Drinks/Iced-Mocha.jpg",
    Price = 850,
    Category = "Frappe"
},

new Menu {
    Id = 30,
    Name = "Iced Caramel Cappuccino",
    Description = "Cold caramel cappuccino",
    ImageUrl = "/Images/Drinks/Iced-Caramel-Cappuccino.jpg",
    Price = 900,
    Category = "Frappe"
},

        new Menu {
    Id = 31,
    Name = "Dark Chocolate Cake",
    Description = "Rich chocolate cake",
    ImageUrl = "/Images/Snacks/Dark-Chocolate-Cake.jpg",
    Price = 950,
    Category = "Snacks"
},

new Menu {
    Id = 32,
    Name = "Caramelized Mushroom & Onion Danish",
    Description = "Flaky mushroom pastry",
    ImageUrl = "/Images/Snacks/Caramalized-Mushroom-_-Onion-Danish.jpg",
    Price = 850,
    Category = "Snacks"
},

new Menu {
    Id = 33,
    Name = "Scrambled Egg Croissant Sandwich",
    Description = "Egg croissant sandwich",
    ImageUrl = "/Images/Snacks/Scrambled-Egg-Sandwich.jpg",
    Price = 900,
    Category = "Snacks"
},

new Menu {
    Id = 34,
    Name = "Blondy Pastry Brownie",
    Description = "Dense chocolate brownie",
    ImageUrl = "/Images/Snacks/Blonde-Pastry-_Brownie_.jpg",
    Price = 750,
    Category = "Snacks"
},

new Menu {
    Id = 35,
    Name = "Black Forest Roll Cake",
    Description = "Cherry cream cake",
    ImageUrl = "/Images/Snacks/Black-Forest-Roll-Cake.jpg",
    Price = 950,
    Category = "Snacks"
},

new Menu {
    Id = 36,
    Name = "Toffee Cheesecake",
    Description = "Creamy toffee cheesecake",
    ImageUrl = "/Images/Snacks/Toffee-Cheese-cake.jpg",
    Price = 1100,
    Category = "Snacks"
},

new Menu {
    Id = 37,
    Name = "Almond Raspberry Slice",
    Description = "Almond raspberry pastry",
    ImageUrl = "/Images/Snacks/Almond-Raspberry-Slice.jpg",
    Price = 850,
    Category = "Snacks"
},

new Menu {
    Id = 38,
    Name = "Banana Bread Loaf",
    Description = "Moist banana loaf",
    ImageUrl = "/Images/Snacks/Banana-Bread-Loaf.jpg",
    Price = 700,
    Category = "Snacks"
},

new Menu {
    Id = 39,
    Name = "Blueberry Bread Loaf",
    Description = "Soft blueberry loaf",
    ImageUrl = "/Images/Snacks/Blueberry-Bread-Loaf.jpg",
    Price = 750,
    Category = "Snacks"
},

new Menu {
    Id = 40,
    Name = "Egg Salad Sandwich in Bran Bread",
    Description = "Egg salad sandwich",
    ImageUrl = "/Images/Snacks/Egg-Salad-Sandwich.jpg",
    Price = 850,
    Category = "Snacks"
},

new Menu {
    Id = 41,
    Name = "Classic Plain Croissant",
    Description = "Buttery flaky croissant",
    ImageUrl = "/Images/Snacks/Classic_plain_croissant1.jpg",
    Price = 600,
    Category = "Snacks"
},

new Menu {
    Id = 42,
    Name = "Chocolate Croissant",
    Description = "Chocolate filled croissant",
    ImageUrl = "/Images/Snacks/CHocolate-Crossiant.jpg",
    Price = 700,
    Category = "Snacks"
},
        };


            
            ViewBag.Message = "Menu Cards ";
            return View(menus);
        }
    }
}
