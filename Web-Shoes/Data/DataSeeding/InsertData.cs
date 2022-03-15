using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //var hasher = new PasswordHasher<AppUsers>();



            //Table Products
            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = 1,
                    pd_Name = "Nike Air Force 1 07",
                    pd_Description = "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1y-bME8oi9DccN-zG_Eo-aChLBs8pwVEI",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1YBpU6fwcCzV18ho__mhCCO0yD8ES-ef7",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1sBANC4Og5eumFJBTVLYGIp2qTBKfwSzh",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1A74yTUs0Lmya24nL5UPG8N6cV7GFhn5a",
                    pd_Rate = 5,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "The radiance lives on in the Nike Air Force 1 '07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "CW2288-111",
                    pd_Color = "White/White",
                    pd_Material = "1",
                    pd_Technologies = "1",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 =true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 =true,
                    pd_Size12 =true,
                    pd_Size12_5= true,
                    pd_Size13_5=true,
                    pd_Size14 = true,
                    pd_Size14_5 =true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"


                },

                new Products()
                {
                    pd_Id = 2,
                    pd_Name = "Nike Air Force 1",
                    pd_Description = "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1aaIG6S0bGnm5uhxHVBXy_BkEDb867O0-",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1Y4gS9zvfZdshJc4YySjz13ZGlMIft4kv",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1AyILI7QsTzqBPE6OvDMZpY7OAtxjkuH8",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1WT_vD4nC_szHPH9LVbl_UztqvXlmqs2e",
                    pd_Rate = 5,
                    pd_MenuFacturer = "2",
                    pd_ShortDescription = "The radiance lives on in the Nike Air Force 1 GORE-TEX, the b-ball OG that puts a fresh spin on what you know best: crisp leather, bold colours and the perfect amount of flash to make you shine.This time it's clad in GORE-TEX technology.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DM6435-222",
                    pd_Color = "Medium Olive/Carbon Green/Sail/Black",
                    pd_Material = "2",
                    pd_Technologies = "2",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 3,
                    pd_Name = "Nike Waffle One Crater",
                    pd_Description = "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1raFVtP42IkQ1t-lPPRFi_E5X4iJ0NW4-",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1kFLigFwBNPiqYhIOs2QRL39nRo0IJYWS",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1KZJQR5jt9rzVOBxfUZRx-tjKoO3dKNDJ",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=10oXph87Rn43M13WNaxJWpL0XS_Mf_JFt",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Bringing the classic BRS athletics style into a modern realm with at least 20% recycled materials by weight, the Nike Waffle One Crater is eye-candy for your feet.The playful speckled look on the midsole is created from Crater Foam, a cushiony material made from Nike Grind rubber and Nike foam materials.And for added depth, the sport-inspired upper includes transparent mesh made from recycled polyester.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DC2650-200",
                    pd_Color = "Cream II/Orange/Black/White",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 4,
                    pd_Name = "Nike Air Max 90 Premium",
                    pd_Description = "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1M0_A-sZfffj7gncHmbj88dHvvqXM1eEa",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1K85ItvCTycDSRX9p1Jbzm7Egg5l6OdRa",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1b5FDJjrsLKAlj7zBVGLoxdp_gaVTFkVE",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1LSQUzknGNiwOIVtHFNmPhGSh8ZE0CFJx",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 Premium stays true to its roots, with the iconic Waffle outsole, stitched overlays and classic TPU accents. Fresh colours give a modern look while Max Air cushioning adds comfort to your journey.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DA1641-201",
                    pd_Color = "Hemp/Sand Drift/Light Orewood Brown/Summit White",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 5,
                    pd_Name = "Nike Air Max 90",
                    pd_Description = "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1ov844eV9xL19atvdLqYtsG6oLz1XPT0g",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1kxFSmfxV3eYg_2ikz2fF0G4UoXPedRJG",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1DxgC1AAKFgDxKSOtBnp_kytP3TlZ-kqr",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1dmp8HCRjPGXUyT3TkkHLZNiP9utabt_S",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Nothing as fly, nothing as comfortable, nothing as proven—the Nike Air Max 90 stays true to its roots with the iconic Waffle sole, stitched overlays and classic TPU accents on the heel and eyestays.A variety of materials on the upper gives a modern look, while Max Air cushioning adds comfort to your journey.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DB0625-200",
                    pd_Color = "Dark Driftwood/Sail/Light Chocolate/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 6,
                    pd_Name = "Nike ACG Air Deschutz +",
                    pd_Description = "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1q5roIlNeK4nQtTmqAqz4wWAC6kI0aGQq",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1ezOB26pX2VmYZC1uVja89pZ4QJty7hXe",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1IiK2AM0M9bKRhSBofRlNSR8ZhseQsUmG",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1rctQk2u8mHcN41-GdWdCfHSeSRvDr1dr",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "From city hikes to canyon trails and long walks on the beach, the Nike ACG Air Deschutz + is built to feel comfortable.It's got a classic '90s look and rugged outdoor-inspired design, with plush padding around the ankle for support.A heavy-duty webbing strap and adjustable hook-and-loop closure keep you focused on the journey ahead.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DC9092-001",
                    pd_Color = "Moon Fossil/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 7,
                    pd_Name = "Nike Air Max 97 SE",
                    pd_Description = "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1BYoyjK2a0qyq6zPdr1enQBluAkifs_4d",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1cITDpeROBtZfWCsBYRj-obyMYR4SZQYX",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1Suli5ByGxovAPGmd_kM6GIenMTy32JPe",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1SkQjussYGb4HIrIIk0URRFY-L0rZjEpI",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Made from at least 20% recycled content by weight, the Nike Air Max 97 SE takes a fresh step towards the future of footwear.The upper features 100% recycled canvas and accents of cork.The embroidered cork graphic on the tongue nods to the plant used in the shoe.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DC3986-300",
                    pd_Color = "Hasta/Thunder Blue/Bucktan/Obsidian",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 8,
                    pd_Name = "Nike Air Max 97",
                    pd_Description = "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1TOlxRiO2y8v05O7ZPDBaPO2OnFPrjIY7",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1-zJ4GbHm0iys-PO3XwWHTOB1LLlMQhaR",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1UUI3tV4jyTpPvv8akrL0jcJXDuIWzjM1",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1AXIRrKM96HazbtzcSxhKY59wFjEm1zVe",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original silver bullet colours, it lets you ride in first-class comfort.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DJ0717-001",
                    pd_Color = "Metallic Silver/Black/White/Persian Violet",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 9,
                    pd_Name = "Nike ACG Air Nasu 2",
                    pd_Description = "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1lbsJAVJkbf-_V6pKzm1CZcAJfIsjjv0o",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1kRRsPNYRT0V5f7LKVRmJp82QMWJVYxeQ",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=15wsxpi791SMVlR2Cn7k6FAbCOgUt3I2U",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1XdL62dPC4dpqNdc-BhHnrkm2Hl6morgo",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Take on the tough terrain of the outdoors.The Nike ACG Air Nasu 2 steps up the durability with Ripstop on the upper and reinforced details to stand up to the rigours of the trail.It has mesh elements up top and a lining within to help keep you on your path with a breathable, supportive feel.A sticky rubber outsole is highlighted with lugs that are designed to help give you traction when navigating wet and rocky surfaces.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DC8296-001",
                    pd_Color = "Grey Fog/Melon Tint/Metallic Silver",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 10,
                    pd_Name = "Nike ACG Mountain Fly Low",
                    pd_Description = "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1Dc-PtwoLK8v4YbJ6YWfuhKJ8KgqTs8tI",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1nm4RlNHYo8JP3KtJvT_bvFqOQ5vEGY2m",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1DcJqtgAnjTxw_zZyvTEsktIcR5pljTk6",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1bjUxZvzpqdlFxn5GrukZilFWpwx5UyvX",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Fast, rugged and just as at home in the city as it is in deserts, canyons and mountains, the Nike ACG Mountain Fly Low is ready for whatever you throw at it.The lightweight Ripstop and synthetic upper is durable and airy, while the easy-to-cinch lacing system adds on-the-go personalisation.The sticky rubber outsole brings crag-inspired traction as the soft Nike React foam sole delivers undisputed comfort whether you're pounding the pavement in the city wilds or leaping rock to rock in Joshua Tree.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DC9045-500",
                    pd_Color = "Light Mulberry/Flash Crimson",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 11,
                    pd_Name = "Nike SB Zoom Blazer Mid Premium",
                    pd_Description = "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1vSAQa_8Evmm1tkOzODtMz4GgWTHH5jq-",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1EERkVDnTn-m3dfv2eUCxIGIKZuENwZIu",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1B6Ae6KBW8vwsPz9K1btBZuSC9OZPn5Hu",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1WS6keGw5BUnYs04Ji-yuVf8_CFdh-mRz",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "Inspired by the community art spaces of Barcelona, the Nike SB Zoom Blazer Mid Premium is made from a collage of materials like suede, leather and canvas.The design is elevated with a multi-coloured Nike embroidery on the heel and a mismatched Swoosh, capped off by a contrasting herringbone sole.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DA8854-001",
                    pd_Color = "Black/Wolf Grey/Cool Grey/White",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 12,
                    pd_Name = "Nike Air Max 2021",
                    pd_Description = "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1UZX6cca2sF8sj5pO70ub8Gf23i1Zp6jO",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=184n1JhhW9eVPiPU01g2LsrQaga75xZoT",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=1vQa7rOZejxU29875pv8ne4fyrxt8WEdH",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1shZnWARtq5SwsibFewT6Km0duAMAkpoZ",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "We could use a lot of superlatives to describe the Nike Air Max 2021.We could tell you that we've incorporated recycled materials to design a sneaker with at least 20% recycled content.Or that the new Air cushioning unit underfoot is our most revolutionary.Perhaps we'd call it the the pinnacle of comfort; waxing poetic about the cored-out foam midsole that gives you the lightest, softest feel.But maybe we just say it's modern meets technical with a splash of heritage DNA.What fun is there in giving away the surprises?",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "DA1925-002",
                    pd_Color = "Ghost/Ashen Slate/Obsidian Mist/Obsidian",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 13,
                    pd_Name = "Nike SB Nyjah Free 2",
                    pd_Description = "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1dzvmQMDzkUdh79Sw2Z0itgm1I12xwkA2",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "BV2078-200",
                    pd_Color = "Beach/Topaz Gold/Bright Crimson/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 14,
                    pd_Name = "Nike SB Nyjah Free 2",
                    pd_Description = "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1sKbuA1SGLb7l947dvLYBnV2Nzj9thvFB",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "The Nike SB Nyjah Free 2 is a sequel worthy of its predecessor. Inspired by the iconic Nike Air Zoom Spiridon, the original rubber design has been updated with mesh panels to help your feet stay cool through your hottest skate sessions.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "BV2078-200",
                    pd_Color = "Beach/Topaz Gold/Bright Crimson/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },

                new Products()
                {
                    pd_Id = 15,
                    pd_Name = "Nike SB Nyjah Free 2",
                    pd_Description = "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=170Vm7Py5XUTDhFLn2tLt0CCBftOKbdFd",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "CU9224-700",
                    pd_Color = "Pollen/Pink Blast/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                },
                new Products()
                {
                    pd_Id = 16,
                    pd_Name = "Nike SB Nyjah Free 2",
                    pd_Description = "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.",
                    pd_Price = 10000,
                    pd_ReducePrice = 500,
                    pd_Img1 = "https://drive.google.com/uc?id=1WlG6_0L1Hz6pXP50zUsaz2IPxZg6kjEi",
                    pd_Img2 = "https://drive.google.com/uc?export=download&id=1xDl63HP0U_CkYQMetWNkVH-3p8aFtTSh",
                    pd_Img3 = "https://drive.google.com/uc?export=download&id=15ZOwySMtoHQ9gL9SgNcyR_VZKMH_C4Nf",
                    pd_Img4 = "https://drive.google.com/uc?export=download&id=1sziE_7UxXlHpSSLbn3ca12o34F0Q25Ya",
                    pd_Rate = 4,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "The first signature shoe from technical phenomenon Shane O'Neill, the Nike SB Shane T is a lightweight shoe that's built to perform. Unique lacing lets you choose between lacing your shoes the traditional way or by running them through durable ghillie loops.",
                    pd_Size = "EU41|EU41.5|EU42|EU43|EU44|EU45|EU46|EU47|EU48",
                    pd_Brand = "Nike",
                    pd_Style = "CU9224-700",
                    pd_Color = "Pollen/Pink Blast/Black",
                    pd_Material = "3",
                    pd_Technologies = "3",
                    pd_Size7 = true,
                    pd_Size7_5 = true,
                    pd_Size8 = true,
                    pd_Size8_5 = true,
                    pd_Size9 = true,
                    pd_Size9_5 = true,
                    pd_Size10 = true,
                    pd_Size10_5 = true,
                    pd_Size11 = true,
                    pd_Size11_5 = true,
                    pd_Size12 = true,
                    pd_Size12_5 = true,
                    pd_Size13_5 = true,
                    pd_Size14 = true,
                    pd_Size14_5 = true,
                    pd_NameImg1 = "1",
                    pd_NameImg2 = "2",
                    pd_NameImg3 = "3",
                    pd_NameImg4 = "4"

                }
                );




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
                    about_Title = "Footwear the leading eCommerce Store around the Globe",
                    about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
                });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "admin"
                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020, 01, 02)

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02)

            });


            //Table AppUser - role 2222222222222222222222222222222222222222222222222222222222222222222
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            builder.Entity<Cart>().HasData(
                new Cart()
                {
                    cart_Id = IdCart1,
                    cart_UserID = IdStaff

                },
                new Cart()
                {
                    cart_Id = IdCart2,
                    cart_UserID = IdAdmin

                });


            //Table Product In Cart

            builder.Entity<ProductInCart>().HasData(
                new ProductInCart()
                {
                     pic_CartId = IdCart2,
                     pic_ProductId =1,
                     pic_amount = 2,
                     pic_size = "7",
                     pic_color = "blue"

                },
                new ProductInCart()
                {
                    pic_CartId = IdCart2,
                    pic_ProductId = 2,
                    pic_amount = 3,
                    pic_size = "7.5",
                    pic_color = "blue"

                },
                new ProductInCart()
                {
                    pic_CartId = IdCart2,
                    pic_ProductId = 3,
                    pic_amount = 1,
                    pic_size = "8",
                    pic_color = "blue"
                });


            //Table Categories





            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "women",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 2,
                    cg_Name = "Man",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            builder.Entity<ContactSystem>().HasData(
                new ContactSystem()
                {
                    Contact_Id = 1,
                    Contact_Address = " 123, An Lac A Ward, Binh Tan District, HCM",
                    Contact_Phone = "0123456789",
                    Contact_Email = "admin@gmail.com",
                    Contact_Website = "https://shoes.com"


                });



            //Table ContactUsers


            builder.Entity<ContactUsers>().HasData(
                new ContactUsers()
                {
                    cu_Id = 1,
                    cu_FirstName = "FirstName",
                    cu_LastName = "LastName",
                    cu_Email = "Email",
                    cu_Subject = "Subject",
                    cu_Description = "Description"
                });


            var ReviewId1 = "EEBA6608-AB75-4E83-909F-604B1A06F16C";

            var ReviewId2 = "9EED8607-D2BB-45EE-AEE3-C59D858A7F97";

            var ReviewId3 = "C2A543C2-B1E2-4DC5-A131-9137E4673FA6";




            //Table Reviews new DateTime(2020, 01, 02)


            builder.Entity<Reviews>().HasData(
                new Reviews()
                {
                    review_id = ReviewId1,
                    review_Comment = "Good1",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId2,
                    review_Comment = "Good2",
                    review_UserId = IdStaff,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                },
                new Reviews()
                {
                    review_id = ReviewId3,
                    review_Comment = "Good3",
                    review_UserId = IdAdmin,
                    review_UploadTime = new DateTime(2020, 01, 02),
                    review_HideStatus = false,
                    review_ReviewType = "Review"

                });

            var SubReviewId1 = Guid.NewGuid().ToString(); 

            var SubReviewId2 = Guid.NewGuid().ToString();

            var SubReviewId3 = Guid.NewGuid().ToString();


            // Table SubReview 

            builder.Entity<SubReview>().HasData(
                new SubReview()
                {
                    subReview_Id = SubReviewId1,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 1",
                    subReview_DateCommnet = new DateTime(2020, 01, 02),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId2,
                    subReview_UserId = IdStaff,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                },
                new SubReview()
                {
                    subReview_Id = SubReviewId3,
                    subReview_UserId = IdAdmin,
                    subReview_Commnet = "subreview 3",
                    subReview_DateCommnet = new DateTime(2020, 01, 03),
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                }
                );

            builder.Entity<SubReviewInReview>().HasData(
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId1
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId1,
                    SRiR_SubReviewId = SubReviewId2
                },
                new SubReviewInReview()
                {
                    SRiR_ReviewId = ReviewId2,
                    SRiR_SubReviewId = SubReviewId3
                }
                );




            //Table Wishlist


            builder.Entity<Wishlists>().HasData(
                new Wishlists()
                {
                    wl_Id = 1,
                    wl_UserId = IdStaff

                });






            //Table ProductInCategories



            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 1
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 2
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 3
                });


            //Table ProductInCategories



            builder.Entity<ProductInWishlist>().HasData(
                new ProductInWishlist()
                {
                    piw_ProductId = 1,
                    piw_WishlistId = 1
                });




            //Table ReviewInproduct



            builder.Entity<ReviewInproduct>().HasData(
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId1,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId2,
                },
                new ReviewInproduct()
                {
                    rip_ProductId = 1,
                    rip_ReviewId = ReviewId3,
                });


            builder.Entity<Coupons>().HasData(
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode ="code10",
                    couponPrice = 10
                },
                new Coupons()
                {
                    couponId = Guid.NewGuid().ToString(),
                    couponCode = "code50",
                    couponPrice = 50
                });



            string billId1 = "D269BF93-A5E2-4C4A-8146-9967DDE80D30";
            string billId2 = "AFD66490-12F5-4EA7-BFF6-425624290D6D";

            //Table Bills

            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = billId1,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2000,
                    bill_ProductIdlist = "1|2|3|4",
                    bill_ProductNamelist = "product 1|product 2| product 3| product 4",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|1",
                    bill_HideStatus = false,
                    bill_WaitForConfirmation = false,
                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered =  false,
                    bill_Cancelled = false
                },

                new Bills()
                {
                    bill_Id = billId2,
                    bill_UserId = IdStaff,
                    bill_PaidTotal = 2100,
                    bill_ProductIdlist = "5|6|7|8",
                    bill_ProductNamelist = "product 5|product 6| product 7| product 8",
                    bill_ProductSizelist = "7|8|9|14",
                    bill_ProductColorlist = "Blue|Red|Black|Green",
                    bill_ProductPricelist = "550|450|350|640",
                    bill_Shipping = 10,
                    bill_Discount = 0,
                    bill_Confirmation = true,
                    bill_DatetimeOrder = DateTime.Now,
                    bill_PaymentMethod = "Check Payment",
                    bill_Note = "",
                    bill_Quantity = "1|1|2|2",
                    bill_WaitForConfirmation = false,
                    bill_HideStatus = false,

                    bill_WaitPickup = false,
                    bill_Delivering = false,
                    bill_Delivered = false,
                    bill_Cancelled = false
                }); ;

            //Table Shiping

            string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            builder.Entity<Shipping>().HasData(
                new Shipping()
                {
                    ship_Id = shipId,
                    ship_Name ="Ship",
                    ship_Price = 5
                });


        }    
                
               
    }   
}
