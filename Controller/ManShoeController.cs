using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ManShoeController : ControllerBase
{
    public static List<ShoeFeature> Shoe = new List<ShoeFeature>
    {

         new ShoeFeature
        {
            Id=1,
            Brand="Nike",
            Model="Dunk Low Panda",
            Price=1099,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_5e4c835d281eea82a2add0cd3d59c178.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_6bef218a4f4a85b9e404fdb4e8abdfd2.jpeg"
        },

          new ShoeFeature
        {
            Id=2,
            Brand="Nike",
            Model="Dunk Low GS",
            Price=1099,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_654b45978d8b512e03c6291ff838e2e8.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_908ea60657c1879953eb5e01fba1082a.jpeg"
        },

          new ShoeFeature
        {
            Id=3,
            Brand="Nike",
            Model="Air Force 1 07 Sneaker",
            Price=1200,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_003b0423eb1b5f75f9fe596fdb907659.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8b2ce04cb3630a57276752e373a5f371.jpeg"
        },

          new ShoeFeature
        {
            Id=4,
            Brand="Nike",
            Model="Dunk Low Retro Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_712fb5dc077e5d2a327a1e988d559843.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b79f33df7a770603e9018183dd359023.jpeg"
        },

          new ShoeFeature
        {
            Id=5,
            Brand="Nike",
            Model="Dunk Low Retro 'Be True To Your School Collection' Sneaker",
            Price=900,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7f02081d0fdbb140103afebd4449fa2f.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_c5f2ad79bc2fa89d9cd71de6db5427ea.jpeg"
        },

           new ShoeFeature
        {
            Id=6,
            Brand="EA7",
            Model="Emporio Armani Sneaker",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_638ad73592961cd52b5dcec2c77cd53f.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_638ad73592961cd52b5dcec2c77cd53f.jpeg"
        },

           new ShoeFeature
        {
            Id=7,
            Brand="EA7",
            Model="Armani Exchange",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_28aceca4e508bc8326db58cd3c9803d4.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_0886842612e28fd8d349a1f8636269e8.jpeg"
        },

          new ShoeFeature
        {
            Id=8,
            Brand="EA7",
            Model="Emporio Armani Sneaker",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0a8446a7a978054304d866ef39cf4340.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f50431c28910e4833396b068fa134b74.jpeg"
        },

          new ShoeFeature
        {
            Id=9,
            Brand="EA7",
            Model="Emporio Armani Sneaker",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_b6aebfc1a20edb7de9af9ba35f339984.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_5b7bda03772fbb4097595833fbe616f7.jpeg"
        },

           new ShoeFeature
        {
            Id=10,
            Brand="EA7",
            Model="Emporio Armani Sneaker",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_5f7f211631b52e7c85344a7d852e7d6c.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4aa138e74de427ff0d679823ad11f17a.jpeg"
        },

            new ShoeFeature
        {
            Id=11,
            Brand="EA7",
            Model="Emporio Armani Sneaker",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_24496fe35c860a87c30a738837e2355e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8d562176243f5dd83bdb2a3682a4fc61.jpeg"
        },

             new ShoeFeature
        {
            Id=12,
            Brand="Dolce & Gabbana",
            Model="",
            Price=1650,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f720a2167bd62eda740b65be4c803283.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ffc6ef294400ece95a44188a1eec9136.jpeg"
        },

             new ShoeFeature
        {
            Id=13,
            Brand="Dolce & Gabbana",
            Model="",
            Price=1650,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_61d2ea03b169a348977e3b319b1ff03b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_61d2ea03b169a348977e3b319b1ff03b.jpeg"
        },

             new ShoeFeature
        {
            Id=14,
            Brand="Alexander McQuuen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_a46fc331f0af9b1ac313b5e272045091.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8ddc02b6168f93dc6a4e4a2e0646c062.jpeg"
        },

         new ShoeFeature
        {
            Id=15,
            Brand="Alexander McQuuen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_028972f36f04a740a152660928aadcdc.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_444a110a7cbf6c4e804da2d821bf32d1.jpeg"
        },

            new ShoeFeature
        {
            Id=16,
            Brand="Alexander McQuuen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3da2ab9b6bc1c616c8ecb5d90895c9aa.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fc65fe0d3715589d9037dd7719c7b87f.jpeg"
        },

            new ShoeFeature
        {
            Id=17,
            Brand="Alexander McQuuen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7e998ecd7ff2619922eb4185ccf43234.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b1e2d5f72c459405428749a108a278c1.jpeg"
        },

             new ShoeFeature
        {
            Id=18,
            Brand="Alexander McQuuen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e3aea3570ec1e8779ff05f7776582790.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_80689698df3b6052b55f5c30a18f767d.jpeg"
        },

            new ShoeFeature
        {
            Id=19,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker Blue",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_68293dfa66b69bd2e2d9f383d6481857.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2f7956510683a03903da5fcfd56ee385.jpeg"
        },

            new ShoeFeature
        {
            Id=20,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker Black",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3ff72c1d35991981ba64878c590bbbe1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2a124bc04c4cfba2c3d351803ccff655.jpeg"
        },

             new ShoeFeature
        {
            Id=21,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker White",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_faab1684323d68484f1756d09dd43949.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1ad47545f0dc70ad3adf489600fd965d.jpeg"
        },

             new ShoeFeature
        {
            Id=22,
            Brand="New Balance",
            Model="530",
            Price=1250,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8828819cc5d097ac2c5b6ca8c6d69588.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_478e7ca40026e6f85c9abefed55e235e.jpeg"
        },

             new ShoeFeature
        {
            Id=23,
            Brand="New Balance",
            Model="9060",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8253b7cf8b77048a0b853f52575eee5b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4d7bef75a36debc0a4468e93a526c8b1.jpeg"
        },

              new ShoeFeature
        {
            Id=24,
            Brand="New Balance",
            Model="9060",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_07cab845a4133f300612c9ba31c17745.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ecdc4ee854263c860ee44ecb060478e3.jpeg"
        },

             new ShoeFeature
        {
            Id=25,
            Brand="Nike",
            Model="Dunk Low",
            Price=1099,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_df69f0e61f7c5cde877e878b6a036e82.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_505b7f76997b0abb873ec53c74d878f7.jpeg"
        },



                     new ShoeFeature
        {
            Id=26,
            Brand="Adidas",
            Model="Handball Spezial",
            Price=999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_eb248bcc1c47ba54b291d4bf2e01b222.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8bc23725523cca7f2ec7b621bcf9ae22.jpeg"
        },


                          new ShoeFeature
        {
            Id=27,
            Brand="Adidas",
            Model="Superstar II",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_9eea2fc4a2249839caa432bb653bd8ea.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fdb7b9c50bee44080e7a0087951beb8c.jpeg"
        },

                           new ShoeFeature
        {
            Id=28,
            Brand="Nike",
            Model="Air Force 1",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_705cd66013a771a2f44f55fcde664740.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b2a3fe44ce81995adbfe89ecd63c5d0a.jpeg"
        },


                             new ShoeFeature
        {
            Id=29,
            Brand="Valentino Garavani",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_5768896eff5ead235dc456a1bd3729f1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e68d378fc515c0d65061973174893a8d.jpeg"
        },
             new ShoeFeature
        {
            Id=30,
            Brand="Prada",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ea2ac659c52e2a877455ab7b93d4b6b1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_0fce96e3922cd33394d925a22cf7f85e.jpeg"
        },

            new ShoeFeature
        {
            Id=31,
            Brand="Prada",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e046a8a1d205dfffdb480661f91062f0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_3065f095cb096afc65e4761e67bb790c.jpeg"
        },

            new ShoeFeature
        {
            Id=32,
            Brand="Prada",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_350fb4edd6ee4069cdba0f789f6f9836.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_3389ad0bd2097146af9bff9c35e54768.jpeg"
        },

             new ShoeFeature
        {
            Id=33,
            Brand="Off White",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_861b7acc1d364b41649ec5fec655df1d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_34ae75f9c6b6dc16ecd54447040719dd.jpeg"
        },

             new ShoeFeature
        {
            Id=34,
            Brand="Off White",
            Model="Beyaz Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_fb56995b6dd6cc0e6e9cbb533a97884b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9f7257cca16c6d818960a0a5aaa636b8.jpeg"
        },

         new ShoeFeature
        {
            Id=35,
            Brand="Hugo Boss",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_22a0b8da10ab1bf258329f95de592ee3.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_6d7876889d9d4b8e5cea5ac66c3df1d8.jpeg"
        },

             new ShoeFeature
        {
            Id=36,
            Brand="Valentino Garavani",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2f0d1a26d1286abb191ed0e225d109b2.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_78f6ca878cbe163c37f2095a4b390ec9.jpeg"
        },

             new ShoeFeature
        {
            Id=37,
            Brand="Valentino Garavani",
            Model="Siyah Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4433f9344a9d58064e3bea79c2eec447.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_69447b0a3213153c4e26cf74cbe0bb79.jpeg"
        },

            new ShoeFeature
        {
            Id=38,
            Brand="Valentino Garavani",
            Model="Beyaz Sneaker",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_879be02271a428959969ef6a4a73445b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_859ddda85d67e665d76c65e0543f1721.jpeg"
        },

             new ShoeFeature
        {
            Id=39,
            Brand="Alexander McQueen",
            Model="",
            Price=1700,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3b21ac053d1655e8905e66b5e59aab35.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9f6818a93f327b41dc4d34e0bde40506.jpeg"
        },

        new ShoeFeature
        {
            Id=40,
            Brand="Nike",
            Model="Dunk Low Cream",
            Price=999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_deac38f1192f69e1f9b0a040b2354bd5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ab77f17e16adf7f480a7f7b8a0c9bbed.jpeg"
        },

          new ShoeFeature
        {
            Id=41,
            Brand="Nike",
            Model="Air Force 1 Kiraz",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d5e21b305f7a26fc04f94c1eec15f4f9.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_865e4a259c9845212418a2f33360c1a1.jpeg"
        },

                new ShoeFeature
        {
            Id=42,
            Brand="New Balance",
            Model="9060 Black",
            Price=1500,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_6258664462103542dc97a87cc3767c0c.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_8631defb19cd62054e3f4f7a442cea3f.jpeg"
        },

         new ShoeFeature
        {
            Id=43,
            Brand="Nike",
            Model="Dunk Green",
            Price=1099,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_c0eea0d28e7fd1314a8f9b5b96422b6a.jpeg",
            Image2="https://cdn-images.farfetch-contents.com/21/24/32/55/21243255_51158281_1000.jpg"
        },

           new ShoeFeature
        {
            Id=44,
            Brand="Adidas",
            Model="Campus",
            Price=999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_1ce55f9c87c82c015de3b21a133bed42.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f547924c9f467da53c7545ef9144dd89.jpeg"
        },



                   new ShoeFeature
        {
            Id=45,
            Brand="Nike",
            Model="Dunk Low Triple White",
            Price=1099,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_fef5fc10c92d67afbf55722c5e378fa6.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_27e5a0ac3f6599ab78908a4420118832.jpeg"
        },

                      new ShoeFeature
        {
            Id=46,
            Brand="Adidas",
            Model="Handball Spezial",
            Price=999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_67f85e84ac8cdea73b779fc6e7f0deb5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2466279e15bfb326acdd83fa813dbf5f.jpeg"
        },

                             new ShoeFeature
        {
            Id=47,
            Brand="Nike",
            Model="Air Force 1",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8532772283a63747331ce34d262c7ced.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4fe0542f1eca417000b430e797f49184.jpeg"
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