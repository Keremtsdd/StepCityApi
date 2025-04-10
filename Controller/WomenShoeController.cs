using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]

public class WomenShoeController : ControllerBase
{

    public static List<ShoeFeature> Shoe = new List<ShoeFeature>
    {

        new ShoeFeature
        {
            Id=1,
            Brand="Adidas",
            Model="Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2f7b86b31d65fb3588a316ce119ae8c5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8661258088af0f0e47552b8c8a3f5210.jpeg"
        },

         new ShoeFeature
        {
            Id=2,
            Brand="Adidas",
            Model="Superstar Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_bdaca18c2dfc4cdbd3825150a75c1f98.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d2d75666e44221059e6bc94dc38d7d13.jpeg"
        },

        new ShoeFeature
        {
            Id=3,
            Brand="Adidas",
            Model="Superstar Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ac5c9d5724b74f728bce4d01b7208a7a.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f8567e29e5b5f801531635c43f05339d.jpeg"
        },

        new ShoeFeature
        {
            Id=4,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3f16521959da067d4a6afec888335066.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d54332d76cb35ac09680cb8256aeb8e4.jpeg"
        },

        new ShoeFeature
        {
            Id=5,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ae85f0f1844d4dd55d095bfafec7a2d6.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4c98f7f44d4cf98bebb93f30efb1cb27.jpeg"
        },

         new ShoeFeature
        {
            Id=6,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ec674505b8fad0fde234d091f2163802.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_654bf48efec17b20d12750faa5d12156.jpeg"
        },

          new ShoeFeature
        {
            Id=7,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_38a26ea6d1a57071672e96422b4fdfd5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e0455a7d5a324e6cf2dfa9699f6df9ca.jpeg"
        },

           new ShoeFeature
        {
            Id=8,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d9a41723f133b8b1f6192044467b1df8.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_933d801383d519d04c33477010c51e43.jpeg"
        },

           new ShoeFeature
        {
            Id=9,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3b16703a6eb7d2eacb0b91b947096a9d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_24ca43bc8d9726e770e21b1e0bb1152b.jpeg"
        },

          new ShoeFeature
        {
            Id=10,
            Brand="Adidas",
            Model="Handball Spezial Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_03cf6a42106dec4864cd64589bb6c887.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2ae1e70e54a96ea1b37f05bb7273c9d4.jpeg"
        },

          new ShoeFeature
        {
            Id=11,
            Brand="Adidas",
            Model="Samba Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_07747e9ca315b88675044d3dd778cf3c.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_7e879c7cf99a76c5fed368b49955c6a2.jpeg"
        },

          new ShoeFeature
        {
            Id=12,
            Brand="Adidas",
            Model=" Samba Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_51009cbe389f0f335afb1517ff16647f.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_250c4a7e8210959790f0720f5dacfb92.jpeg"
        },

          new ShoeFeature
        {
            Id=13,
            Brand="Adidas",
            Model="Samba Sneaker",
            Price=800,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4f7ae4c7b0cb07dfb4c1045a69f36d1d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1c3e04c5b90a26c6555a477e47e8e313.jpeg"
        },

          new ShoeFeature
        {
            Id=14,
            Brand="Nike",
            Model="Air Force 1 Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_fc6edf3ffe83febf73dd8568c366d554.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_deff52667a5203ddf357d34d6850eb7c.jpeg"
        },

         new ShoeFeature
        {
            Id=15,
            Brand="Nike",
            Model="Air Force 1 Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2c8e4f039d0f367355a178abe78e0778.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9ff8d07a09be213f005acbe0f8bb6ac4.jpeg"
        },

        new ShoeFeature
        {
            Id=16,
            Brand="Nike",
            Model="Air Force 1 Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_819749fb213df2e0b1cb2f648cb21fcd.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f82a95a47c835ee4ee9b5bde00324b3e.jpeg"
        },

          new ShoeFeature
        {
            Id=17,
            Brand="Nike",
            Model="Air Force 1 Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8815e77584893833fb969bb4e28cde34.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_59b18b7b09e43f7d77586c4e72abb21e.jpeg"
        },

          new ShoeFeature
        {
            Id=18,
            Brand="Nike",
            Model="Air Jordan 1 Low Sneaker",
            Price=1300,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_aabe117e54eda547b665e49582f64635.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fc2fde7f0c2b9607913a49f1b4879cdb.jpeg"
        },

           new ShoeFeature
        {
            Id=19,
            Brand="Nike",
            Model="Air Force 1 Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_48deda9eaea33b222b533c6429d5ccbb.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8ae9bac1b80db2a5d5b4753989e4e12b.jpeg"
        },

           new ShoeFeature
        {
            Id=20,
            Brand="Nike",
            Model="Dunk Low Retro Panda Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_5e4c835d281eea82a2add0cd3d59c178.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_bc80928ba4d2bd1c615ee8dfe846c732.jpeg"
        },

           new ShoeFeature
        {
            Id=21,
            Brand="Nike",
            Model="Dunk Low Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4ac8227e03e5ccdaa4151520c276ccca.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9743ba9ef114456110a14a439130a586.jpeg"
        },

         new ShoeFeature
        {
            Id=22,
            Brand="Golden Goose",
            Model="Super-Star",
            Price=2000,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4f8a57539cd02d6309d7d21c36ee54ce.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e1f83864497c9182e57df4cbc0916ab9.jpeg"
        },

        new ShoeFeature
        {
            Id=23,
            Brand="Golden Goose",
            Model="Super-Star",
            Price=2000,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e0d5757eff003dc27f99bf40dfe57a68.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_6a81f753af2401847ee8407951ce4013.jpeg"
        },

         new ShoeFeature
        {
            Id=24,
            Brand="Lacoste",
            Model="Sneaker",
            Price=1200,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_55be3d205c91777dee79deff4e274e9b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ea2bb2ffd54bcdca2887f71e8e630654.jpeg"
        },

        new ShoeFeature
        {
            Id=25,
            Brand="Lacoste",
            Model="Sneaker",
            Price=1200,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_72daead3cf57565314cb2a336843fad4.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f1cdf9b2eeb37813d5cd33844e7dc48c.jpeg"
        },

    };

    [HttpGet]
    public IActionResult GetAllShoes()
    {
        return Ok(Shoe);
    }

    [HttpGet("{id}")]
    public IActionResult GetShoeById(int id)
    {
        var shoe = Shoe.FirstOrDefault(x => x.Id == id);
        if (shoe == null)
        {
            return NotFound(new { message = $"Id'si {id} olan ayakkabı bulunamadı." });
        }
        return Ok(shoe);
    }

}
