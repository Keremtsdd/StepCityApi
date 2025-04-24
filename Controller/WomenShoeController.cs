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
            Brand="Nike",
            Model="Dunk Low Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_b0b4201e7fb1ec60dbb4d30999391635.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_625c74016989ee1722b72e0dc7f9394d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_920077e15ab7f940dd8d33af063524a8.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_ca0012580573f8dc18a89a79c8ed2e04.jpeg",
            ShopierLink="https://www.shopier.com/35045427"
        },
        new ShoeFeature
        {
            Id=2,
            Brand="Adidas",
            Model="X Wales Bonner Kadın Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_eefda3716dcaf44d2b88133364cc86b9.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_395a54dd30ec37d9c83fdfc259971376.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_7765b443b6648c32a6818557d6d2fc59.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_009e7fbe3cc1bac1f3c5df0df030b72b.jpeg",
            ShopierLink="https://www.shopier.com/35038777"
        },
        new ShoeFeature
        {
            Id=3,
            Brand="Puma",
            Model="Speedcat OG Kadın Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4f336db6680688b18a9f922cb4195021.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_078a13a32d2f05053bf1fa4116cc90bf.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c2fe653f28428de74f10eb87900e84dc.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_7d6f3efb8916a3231da3a856fc40ef9e.jpeg",
            ShopierLink="https://www.shopier.com/35047088"
        },
        new ShoeFeature
        {
            Id=4,
            Brand="New Balance",
            Model="9060 Kadın Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ba3047550391c3459f14815bdb9e6c4d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ec0ce0427f30ec61d8c3d8072239f046.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_684860b9fd55966e2bf15aec22db6df4.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_3ee2c5cb17292868f753f24fe39adcf8.jpeg",
            ShopierLink="https://www.shopier.com/35046957"
        },
        new ShoeFeature
        {
            Id=5,
            Brand="Lacoste",
            Model="Kadın Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3f2480e2953591371bddbf88a8238d65.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_83ccc3615e1aeedc5437d7ce78df1967.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_b3218f7b085fe9b50b67beda9e8df12e.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_294bfcb3c61b8ea96f8a2786925fe9b8.jpeg",
            ShopierLink="https://www.shopier.com/34618113"
        },
        new ShoeFeature
        {
            Id=6,
            Brand="Lacoste",
            Model="Kadın Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4389e41053e72f366258ac4cdf73116e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_c986fbc1c9a584fb82607b7b98f3e289.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_025692770e475ff2d595de5119203c98.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_b0530f5a2593e22271994a15dcc05d54.jpeg",
            ShopierLink="https://www.shopier.com/34618079"
        },
        new ShoeFeature
        {
            Id=7,
            Brand="Adidas",
            Model="Kadın Sneaker",
            Price=1850,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_c5ca9e1d4adf1ef0d3afa021a18d71a8.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_01c27efd626d5229c204682c69793434.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_9e24b1527cd8948fd32cd7e1683bd067.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_bf8ca74a8bd8f94e2de01e95cf3e4dad.jpeg",
            ShopierLink="https://www.shopier.com/34617707"
        },
        new ShoeFeature
        {
            Id=8,
            Brand="Adidas",
            Model="Superstar Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_874f97bf12b5d8cf04b461fb54ac4e0f.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d865312829fb9e90570ae3c29c4f8f76.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_fda2673e147ca786d0caee1ac55dd1f9.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34617600"
        },
        new ShoeFeature
        {
            Id=9,
            Brand="Adidas",
            Model="Superstar Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_eae60da1e6ac53d68340c149f0543257.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_c7a5e6e47f775a01105c20a76997f790.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c5904403b37d8a83cde7b7bdbc157d3a.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34617587"
        },
        new ShoeFeature
        {
            Id=10,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_86825092b61d9aa95d73752683360065.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1db2bd882c9e4eb380fac62bbf501afc.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_2eba7752350d5ac4050165544498114e.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_69a1f87818cc475684b7ccc9da5b5fbb.jpeg",
            ShopierLink="https://www.shopier.com/34617554"
        },
        new ShoeFeature
        {
            Id=11,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_a62080b40b135ac643e616d1cde782c6.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2d6fdeef1b667588a76f9de7f11887ad.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c495a2ad4ac4f4a2c72055ccd11a3a6d.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_006e745085121c74070b0b22ee34db6c.jpeg",
            ShopierLink="https://www.shopier.com/34617539"
        },
        new ShoeFeature
        {
            Id=12,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_428d88ec4361a4845fb41300b28284f5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1d701cd863902add31339eac3dd0c12c.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_ec707467df5a5dc50f866fde88956fab.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34617501"
        },
        new ShoeFeature
        {
            Id=13,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d4baf425e46ee2d99d2292f212ef8f71.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fd85465fd07c9742e69c9f0627a8323f.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_128f235af7211b7f1ff1fe83652bf335.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_74602afa425f437c6a27d6e4685217f0.jpeg",
            ShopierLink="https://www.shopier.com/34617066"
        },
        new ShoeFeature
        {
            Id=14,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_1e3c2e73b23d74bfb981319bdc9cdb25.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_bc54274b74470ca34e6309449ea518d3.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c1d777d4b6b2597f4d2497fe69d4aa20.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_459aaef43a9b5906e63d4dc3cf84bec5.jpeg",
            ShopierLink="https://www.shopier.com/34616981"
        },
        new ShoeFeature
        {
            Id=15,
            Brand="Adidas",
            Model="Handball Spezial Kadın Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e042b913ff6babc52382141156f098f0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_6623b54c8ea79bd803a392428b753a79.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_5936079d2fb46777841c0f5b6894094e.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_b112b85c2a87e5e9ceb5a7207ed80059.jpeg",
            ShopierLink="https://www.shopier.com/34616950"
        },
        new ShoeFeature
        {
            Id=16,
            Brand="Adidas",
            Model="Samba Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f71f774148de7e38deef34eb2757b66a.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fc120a86e62ba702cab6398a1468981d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_b864a9bbb03e92096fef10e3bf1e7fb3.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_86bb357f6f3840cbfc76b9c7b04f719d.jpeg",
            ShopierLink="https://www.shopier.com/34616832"
        },
        new ShoeFeature
        {
            Id=17,
            Brand="Adidas",
            Model="Samba Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_92cffc28e58d7997a7b3c1f076ce41ed.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d44820c7ed01843f318a5cefa6dd738f.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_3a2eb235cf9a0aa9dd9a9308d4eafb13.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_d9c5bba22d44cd8c19a4cb01d1c4e430.jpeg",
            ShopierLink="https://www.shopier.com/34616802"
        },
        new ShoeFeature
        {
            Id=18,
            Brand="Adidas",
            Model="Samba Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_efd585f99f09462d1784f7249b8e9d43.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_400066e5c1faac1c733504b62925e551.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_7ef3a51b55a63832d5bce5b925dc401f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8d3f2379c837e556e5bc7c2550883196.jpeg",
            ShopierLink="https://www.shopier.com/34616775"
        },
        new ShoeFeature
        {
            Id=19,
            Brand="Nike",
            Model="Air Force 1 Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_71dd7f8ada4977c5b34532a87ab0ec3d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ef72fb552e37cbd0e22f2e06f890776d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a4433c7bac0878fe6e4339cc5de385f9.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a9d4a0c70d81f313e45bcf3fa14bd937.jpeg",
            ShopierLink="https://www.shopier.com/34616663"
        },
        new ShoeFeature
        {
            Id=20,
            Brand="Nike",
            Model="Air Force 1 Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_5cca6d5101d7c702b9b02460a167b192.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fb18e1aa4f334b69fa97c281f326da94.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1c60ce60b6074468f921212d7f6e59e2.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34616526"
        },
        new ShoeFeature
        {
            Id=21,
            Brand="Nike",
            Model="Air Force 1 Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_12e4fa93b5e5a84adcadbde4e1da5cba.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_544efda70f3f153abe205a7ebcd43b0d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_9fa407458ab09cd5efad4fbfc272b653.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_b3cd38add128f82e8eed398d7a70adb5.jpeg",
            ShopierLink="https://www.shopier.com/34616506"
        },
        new ShoeFeature
        {
            Id=22,
            Brand="Nike",
            Model="Air Force 1 Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_52105e464a732ea8610e5d71fe96a0ee.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d62f5e4c0ed1c812688bde43b9308566.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_5712e8e2bb319a93a88a5ef31602959b.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34616279"
        },
        new ShoeFeature
        {
            Id=23,
            Brand="Nike",
            Model="Air Jordan 1 Low Kadın Sneaker",
            Price=1499,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_27c7639afd03f2bae880c0ba908395c1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_22475951909726a19831293eb24229d1.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_ef82c48133cc7d0ededb2dac42f564d6.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_5c011621f9acc1231b38d6094cd2e722.jpeg",
            ShopierLink="https://www.shopier.com/34616256"
        },
        new ShoeFeature
        {
            Id=24,
            Brand="Nike",
            Model="Air Force 1 Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_9bf5856a2efffcb556a71652e71cf135.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_a15ccb50570b9d5b38d65fd2b78e1dbe.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_913d0b95edf308dd6fab176772fabbf4.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/34616191"
        },
        new ShoeFeature
        {
            Id=25,
            Brand="New Balance",
            Model="530 Kadın Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7f83f3fdaf99de7fa66a1fed69567b77.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1e9472c3f472d7d4b7435b0a6037c8db.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_8a33488cd280f6cad8075156de16e56d.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_dbe023ef23f73014b757380bcfd26d9c.jpeg",
            ShopierLink="https://www.shopier.com/35047045"
        },
        new ShoeFeature
        {
            Id=26,
            Brand="New Balance",
            Model="9060 Kadın Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ba3047550391c3459f14815bdb9e6c4d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_75620461ce3fdee1b575a0d7c2ab1da6.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_684860b9fd55966e2bf15aec22db6df4.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_3ee2c5cb17292868f753f24fe39adcf8.jpeg",
            ShopierLink="https://www.shopier.com/35046957"
        },
        new ShoeFeature
        {
            Id=27,
            Brand="Nike",
            Model="Dunk Low Panda Kadın Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7c80d95212ea1f999a660cf98deb687e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b6568c3eb0d936b0a2102bc00030dd75.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_e781b75e824eb0752cd158cf69d8d514.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8e02821a9d75a4fd86a3f9944d84c6b8.jpeg",
            ShopierLink="https://www.shopier.com/34589027"
        },
        new ShoeFeature
        {
            Id=28,
            Brand="Golden Goose",
            Model="Super-Star Kadın Sneaker",
            Price=1999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_53a959185721d06e905fb765818a7dd0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_fa07fb2e97dceadce06adfd9253f4f55.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d78527cc45527eb7a903bccbce8a9ae1.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a994e41eb6137c0f40be40b19b25f930.jpeg",
            ShopierLink="https://www.shopier.com/34615367"
        },
        new ShoeFeature
        {
            Id=29,
            Brand="Golden Goose",
            Model="Super-Star Kadın Sneaker",
            Price=1999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3abd6832354bc141ce2789cda3436ac1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4e19e8b18d45fa3658673ca67da96b9e.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_94baccfa2709a1ed7c64498658175629.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_32c9c9427a92b7789057b9ba399f0551.jpeg",
            ShopierLink="https://www.shopier.com/34615290"
        },
        new ShoeFeature
        {
            Id=30,
            Brand="Golden Goose",
            Model="Super-Star Kadın Sneaker",
            Price=1999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e056ff60afd46e327dae9a79338becac.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2e732b0ca6a98020ecbcf9d4e26a5745.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_e1f4b60bd2efa24e2ffb6a8d065f6b69.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_7c365c10ce07d78b077bee1f659695ad.jpeg",
            ShopierLink="https://www.shopier.com/35077566"
        },
         new ShoeFeature
        {
            Id=31,
            Brand="Golden Goose",
            Model="Super-Star Kadın Sneaker",
            Price=1999,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_962bc9523bd322a16703f7d693400e84.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e2b8fa02fd70b834ed42f149d03ad6d4.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_acf4f7b25b9d5e3254bf419d4c23007b.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_7197e38f8025d72c66eb0877fa0be5bf.jpeg",
            ShopierLink="https://www.shopier.com/35077511"
        },
         new ShoeFeature
        {
            Id=32,
            Brand="Christian Dior",
            Model="Kadın Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_55ef3b9a370ce6ad5c9ceaa5cd369e46.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f41ae95504bf411466425508c0282175.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_dc6ffc434ab3aaff1b38ba7452aa9432.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_172f6ebf63912a20d0cfa629e953b5fc.jpeg",
            ShopierLink="https://www.shopier.com/35077640"
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

    [HttpPost]
    public IActionResult AddShoe([FromBody] ShoeFeature newShoe)
    {
        if (newShoe == null)
        {
            return BadRequest(new { message = "Geçersiz ayakkabı verisi." });
        }

        if (string.IsNullOrEmpty(newShoe.Brand))
        {
            return BadRequest(new { message = "Marka alanı boş olamaz." });
        }

        if (string.IsNullOrEmpty(newShoe.Model))
        {
            return BadRequest(new { message = "Model alanı boş olamaz." });
        }

        if (newShoe.Price <= 0)
        {
            return BadRequest(new { message = "Fiyat sıfırdan büyük olmalıdır." });
        }

        if (string.IsNullOrEmpty(newShoe.Title))
        {
            return BadRequest(new { message = "Başlık alanı boş olamaz." });
        }

        if (string.IsNullOrEmpty(newShoe.Cargo))
        {
            return BadRequest(new { message = "Kargo durumu boş olamaz." });
        }

        if (string.IsNullOrEmpty(newShoe.Image1) || string.IsNullOrEmpty(newShoe.Image2) || string.IsNullOrEmpty(newShoe.Image3) || string.IsNullOrEmpty(newShoe.Image4))
        {
            return BadRequest(new { message = "Tüm görsel alanları boş olamaz." });
        }

        if (string.IsNullOrEmpty(newShoe.ShopierLink))
        {
            return BadRequest(new { message = "Shopier linki boş olamaz." });
        }

        var newId = Shoe.Max(x => x.Id) + 1;
        newShoe.Id = newId;


        Shoe.Add(newShoe);
        return CreatedAtAction(nameof(GetShoeById), new { id = newShoe.Id }, newShoe);
    }


    [HttpPut("{id}")]
    public IActionResult UpdateShoe(int id, [FromBody] ShoeFeature updatedShoe)
    {
        var shoe = Shoe.FirstOrDefault(x => x.Id == id);
        if (shoe == null)
        {
            return NotFound(new { message = $"Id'si {id} olan ayakkabı bulunamadı." });
        }

        if (!string.IsNullOrEmpty(updatedShoe.Brand)) shoe.Brand = updatedShoe.Brand;
        if (!string.IsNullOrEmpty(updatedShoe.Model)) shoe.Model = updatedShoe.Model;
        if (updatedShoe.Price > 0) shoe.Price = updatedShoe.Price;
        if (!string.IsNullOrEmpty(updatedShoe.Image1)) shoe.Image1 = updatedShoe.Image1;
        if (!string.IsNullOrEmpty(updatedShoe.Image2)) shoe.Image2 = updatedShoe.Image2;
        if (!string.IsNullOrEmpty(updatedShoe.Image3)) shoe.Image3 = updatedShoe.Image3;
        if (!string.IsNullOrEmpty(updatedShoe.Image4)) shoe.Image4 = updatedShoe.Image4;
        if (!string.IsNullOrEmpty(updatedShoe.ShopierLink)) shoe.ShopierLink = updatedShoe.ShopierLink;

        return Ok(shoe);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteShoe(int id)
    {
        var shoe = Shoe.FirstOrDefault(x => x.Id == id);
        if (shoe == null)
        {
            return NotFound(new { message = $"Id'si {id} olan ayakkabı bulunamadı." });
        }

        Shoe.Remove(shoe);
        return NoContent();
    }

}
