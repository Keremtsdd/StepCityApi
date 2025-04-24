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
            Brand="Adidas",
            Model="Samba Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0f9d7304a8ca29676f975d2f2e24b6e2.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_3ee3ac5fcc06d33314f3daaed0eac7bb.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_797a715d85a8656c3b29a6b415277677.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_87b22b874025b016341e0b8bbdcc514f.jpeg",
            ShopierLink="https://www.shopier.com/35040267"
        },

          new ShoeFeature
        {
            Id=2,
            Brand="Nike",
            Model="Air Jordan 1 Low Erkek Sneaker",
            Price=1499,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7b1a0e184b746a5337110a4c4cce8595.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_70146cc4f4bc7322450b1aaf7bd1ecec.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_cbe7bda3860a45f5ed858df97651c21e.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_4e0d3862840e22086a0e88a22a0002f4.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35043805"
        },

          new ShoeFeature
        {
            Id=3,
            Brand="New Balance",
            Model="530 Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7f83f3fdaf99de7fa66a1fed69567b77.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1e9472c3f472d7d4b7435b0a6037c8db.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_8a33488cd280f6cad8075156de16e56d.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_dbe023ef23f73014b757380bcfd26d9c.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35047045"
        },

          new ShoeFeature
        {
            Id=4,
            Brand="Nike",
            Model="Air Force 1 Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3da1030c40045a0acc0f1266047c6e69.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_07f082ad35bd4c37857edc9ac36ae2fb.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_ce694557e0b6170ce16dc1a79361b3a5.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_57d4e3de277dde847ea0ab11e064e086.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34587702"
        },

          new ShoeFeature
        {
            Id=5,
            Brand="Nike",
            Model="Dunk Low Panda Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7c80d95212ea1f999a660cf98deb687e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b6568c3eb0d936b0a2102bc00030dd75.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_e781b75e824eb0752cd158cf69d8d514.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8e02821a9d75a4fd86a3f9944d84c6b8.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34589027"
        },

           new ShoeFeature
        {
            Id=6,
            Brand="Nike ",
            Model="Air Force 1 07 Petrol Yeşili Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d75ae8b8a7c5648c7e77416c0a356062.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1a31ad96c9064dd1d31979fc51846569.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_4eda87a3c83ac8dcc7072b834df0fb53.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34616093"
        },

           new ShoeFeature
        {
            Id=7,
            Brand="Adidas",
            Model="Handball Spezial Erkek Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7fd76f0ece7092d6cec9877f6db3d2b0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_00a1d0266e5a3cfb3f26f11d7b8f434d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_8a6f057af44a32810d0138bbe63d81be.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_3a170a189345f973731dbe6e0f60f03f.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34617014"
        },

          new ShoeFeature
        {
            Id=8,
            Brand="Nike",
            Model="Dunk Low Retro Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_b0c4c8378f1bf57d5320b0475abf170b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_7b05dd70d85b15f93a7e5a702fcab6c0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_5a603c8c536e5c2ea2a36ab43051f80f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_353f0b387c16d86659208ab3b44cc20f.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34615869"
        },

             new ShoeFeature
        {
            Id=9,
            Brand="Nike",
            Model="Dunk Low Retro Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_742bfecd510a8661551fd2a6a2691e70.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_259627b93d23f349b39a475eaf4ba3c9.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_259627b93d23f349b39a475eaf4ba3c9.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34615851"
        },

          new ShoeFeature
        {
            Id=10,
            Brand="Nike",
            Model="Dunk Low Retro 'Be True To Your School Collection' Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_fddda475f00c3ed4995fd8b432fcd55a.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_da6c4e6a37e9602f36f72aca0fd1c84f.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_dfa2c354edbba679f0c18bb58fc817cf.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34615590"
        },

            new ShoeFeature
        {
            Id=11,
            Brand="EA7",
            Model="Emporio Armani Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d9f4bba9452f5012dbf898814b3db921.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1fd1ba81e20ad5c3d04b076cae17f3ea.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_83ed41f5f09d9b9e1a8a0c1c760ef11b.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34614574"
        },

        new ShoeFeature
        {
            Id=12,
            Brand="Armani",
            Model="Exchange Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_a5c1c2e2bec34b16c00bf5980f729aa1.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_13eecaba129a7fb4a5f4b0435d7e3119.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_88c5099d2b33d97cf4970fc398632008.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_e2b9250d1a280526ae8e081dd15703a0.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614529"
        },

             new ShoeFeature
        {
            Id=13,
            Brand="EA7",
            Model="Emporio Armani Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f2fef034e92cc3e62faa0f1b90fd6772.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_981b84ca084447a53eafa0d8336f4a7c.jpeg",
            Image3="",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34614443"
        },

             new ShoeFeature
        {
            Id=14,
            Brand="EA7",
            Model="Emporio Armani Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_122e103f44e5ed6f7018fda14e05cba9.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_06a358c2e58fb27970bee1d087cd9c1a.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a63a69cc44a09ba632c654b01a1f90ca.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8e3aa9bf82eaa1a4c2125ea70c37430e.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614402"
        },

         new ShoeFeature
        {
            Id=15,
            Brand="EA7",
            Model="Emporio Armani Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_992c7cc0eadce15081a7e4cbd7065cb6.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e9e5f27d653f88aafe85c919e279d9a6.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_21dfc4a5bd590848163a10ac101c86ae.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_f9e24d2dba58d848a9c9ea0b3bba51b2.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614311"
        },

            new ShoeFeature
        {
            Id=16,
            Brand="EA7",
            Model="Emporio Armani Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2cbcbe649ef7900636a12fd75ea25fdf.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_61205f973c75e618456719153d381847.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_dfe15103af3dbd14505d6540e8703d87.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_97697f6ce49ab6c6346142abfbcfc8ed.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614221"
        },

            new ShoeFeature
        {
            Id=17,
            Brand="Dolce&Gabbana",
            Model="Erkek Sneaker",
            Price=1499,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_6a332c268ccdceca2b69a213540cb5e7.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_820017d3426aed3c59df3e6f81d6a247.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a5c16c55fdc2b6be4adcd0faf2c06da2.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_0e2b16be2f7918184487d0e0973d2cf2.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614067"
        },

             new ShoeFeature
        {
            Id=18,
            Brand="Dolce&Gabbana",
            Model="Erkek Sneaker",
            Price=1499,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0218e4db9d7613013ffa6965abd2ec8d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_2baa76a13405f9b5b3e2fc7706554676.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_7fb8fae2dcbf80399fa1e1f6f278262b.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_161991c17a111d30bbabff148be3a561.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34614017"
        },

            new ShoeFeature
        {
            Id=19,
            Brand="Dolce&Gabbana",
            Model="Erkek Sneaker",
            Price=1499,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_91f337ee404c4d3b7d7d59c5b366b9dd.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_47948df4d0eb4e26b0bf24a0fb85e25e.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1ea5f37dc1c1fd37c80e2c30a41fc194.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_aaa357f13b1f975d3ab596b7139fdf2b.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34613970"
        },

            new ShoeFeature
        {
            Id=20,
            Brand="Alexander McQueen",
            Model="Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4b44f5d740e104f5080846852fd619a0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_de534a194b62d1ab5a2070c1bb71f3ba.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_75d42115ff405c3ac3bf24f92f830a1f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_f699bd88bc161e8752fa82847f92bbdd.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34613391"
        },

             new ShoeFeature
        {
            Id=21,
            Brand="Alexander McQueen",
            Model="Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_14f5584a55bc57cc625d5f865d4b42f6.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9cf6a409f6fa8cda135c54d8e080bf76.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_ee4f1592c8a4589c324bf1d6d3531119.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_09b3d1adfd39f7602b54c387fa160f8c.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34612897"
        },

             new ShoeFeature
        {
            Id=22,
            Brand="Alexander McQueen",
            Model="Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d488c36f33bfebdec12a4626e38bf18b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_26a3eb207ff59f3dcfdcc55605ec462e.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_028e70f15a59a2c167cec8e10d16f1c4.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34612805"
        },

             new ShoeFeature
        {
            Id=23,
            Brand="Alexander McQueen",
            Model="Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_47b247ad65324f8de3d96406107f028e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_09e107f159cff9dded4f3c7c712de75b.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1aa435f28726328ec1e430e3eb2e0d87.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34612604"
        },

            new ShoeFeature
        {
            Id=24,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker Blue Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ea7890416dbf43652784ba85b3ce7ae5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_559de3cb042bdb014b2b8d03e31641d5.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_921b0249a98008e153f5abef62fea038.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_69879131d053b06d4936a6afb0414f5d.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34592283"
        },

             new ShoeFeature
        {
            Id=25,
            Brand="New Balance",
            Model="530 Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7f83f3fdaf99de7fa66a1fed69567b77.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1e9472c3f472d7d4b7435b0a6037c8db.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_8a33488cd280f6cad8075156de16e56d.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_dbe023ef23f73014b757380bcfd26d9c.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35047045"
        },


         new ShoeFeature
        {
            Id=26,
            Brand="Nike",
            Model="Dunk Low Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8cc88fece6708ff173f0b12170735da5.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_7733136b79e02a139ff0d1da4080caf9.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_fd2b566cb5b204b5f07f56405614c50c.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_29d283a5a2e44d21d1e8e07a1ef0fece.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35044639"
        },


         new ShoeFeature
        {
            Id=27,
            Brand="Nike",
            Model="Blazer Low Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_593a04f4b84f664cd245fc6c59639b21.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_19367c64d930230a277a8a26327f3add.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_00a3324e121bba0be916fe807317abb2.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_ed484513dd5be197d421f520aaef61a5.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35044427"
        },

         new ShoeFeature
        {
            Id=28,
            Brand="Nike",
            Model="Nets Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_c4799b13f5137594f7b747db74aa86d4.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_40ec5bb96e3bdea896f85001191266e1.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d1e66566c735afb8b1171cceed6d7675.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a0f050b09cf2a6cc72afc0a844cae8aa.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35044065"
        },


            new ShoeFeature
        {
            Id=29,
            Brand="Adidas",
            Model="Samba Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f7ea6410f78e1280742b65756e4f3dd7.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_19dea27769acf4908fa684994ff34657.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a7be0bcfd5b77999a4141dc83498ad07.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_51dc611d92fcb5e52c6f09ee72bcf859.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35042809"
        },
             new ShoeFeature
        {
            Id=30,
            Brand="Valentino Garavani",
            Model="Erkek Siyah Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_dc264513d004d105a6b66a9b5e10a026.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_55f6e960c6919abc26bae91f28bde426.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_0a6b504538cd8e789a5c02e704d27e31.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34753083"
        },

            new ShoeFeature
        {
            Id=31,
            Brand="Prada",
            Model="Siyah Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0b622aa50614d1b417d13cddb7e48fa9.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_25d5985b0b2182953252bf2dce1f3998.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_3a47898a6725ac764a099fc08f881a18.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34753031"
        },

            new ShoeFeature
        {
            Id=32,
            Brand="Prada",
            Model="Siyah Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0cd3d4f3661f4e4e322838b256b0c208.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_91b7745e1efbfd7676fde171119a366c.jpeg",
            Image3="",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34752992"
        },

             new ShoeFeature
        {
            Id=33,
            Brand="Prada",
            Model="Siyah Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_a1fcb3ea17af20726a32302624642a0a.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_c454f9be1e14d0a022a8a488ddec3fe0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_86d6d426d868bb8b7e917f49fba6d75c.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_9b436d2d5dbbf6656f7464d65b8d72a2.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34752963"
        },

             new ShoeFeature
        {
            Id=34,
            Brand="Off White",
            Model="Siyah Erkek Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_96864f1c626afcae98e5b9b2783f1126.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_7bf0d48645638828b19690a0bf0b3ad0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d32c1d1aa1b099938a1d24f94c7c68dd.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_9f0a9d265dc38845816f4412e1494d58.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34752651"
        },

         new ShoeFeature
        {
            Id=35,
            Brand="Off White",
            Model="Beyaz Erkek Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2106496f7ba50cf85179e78dfe8f5efc.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_bbb36490c8b4b916f53c7e910192a1d8.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_db0c1e6970204e3b16598338bcf1b46c.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34752629"
        },

             new ShoeFeature
        {
            Id=36,
            Brand="Hugo Boss",
            Model="Siyah Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_965997330672a7a6b776e4ee0fcdae0e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_04493a94e0cdb8c49a27bc256cb25ef3.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_da165651ba98e6f0f46a3eee8c3d4d84.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34752460"
        },

             new ShoeFeature
        {
            Id=37,
            Brand="Valentino Garavani",
            Model="Siyah Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_d549ebba90201dcffd87e2106d020fd4.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_add771f3bcbd5d1db09fac7af1da839b.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a999601d67c74d24caa2f1ce972fc273.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_980517943f5e2c0ec5b4a57b0135f29e.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34752378"
        },

            new ShoeFeature
        {
            Id=38,
            Brand="Valentino Garavani",
            Model="Siyah Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_bbe24218042f7aeb43ba1a10b03e684d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_9b4c3da15a9ffff118a067eedcda1e39.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_aac8265a94403f23e99d2047621dbfe7.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_64013827c2174a9dba45ad6bd329174f.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34752344"
        },

             new ShoeFeature
        {
            Id=39,
            Brand="Valentino Garavani",
            Model="Beyaz Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f6b13042bb8489750ef32e9fee30f65b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_4901ce428e8bf253afd7e4378f7738bb.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_4db551850828d05fef40d6cc2fb04cc4.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34752297"
        },

        new ShoeFeature
        {
            Id=40,
            Brand="Alexander McQueen",
            Model="Beyaz Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_73c5e72a384c6e3b69f926b3cbb8184b.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_605bac1f54dcf9a905f5c09ddaa3b53e.jpeg",
            Image3="",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34740064"
        },

          new ShoeFeature
        {
            Id=41,
            Brand="Alexander McQueen",
            Model="Beyaz Erkek Sneaker",
            Price=1699,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_02329bf644484474639a86a3b878cc60.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_0444a489d865b61fda776eb17f36cba6.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6c9504b85b3cbf9a70c166519e37b2e9.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/34739892"
        },

                new ShoeFeature
        {
            Id=42,
            Brand="Nike",
            Model="Dunk Low Cream Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ce7aa164670f26763fde3c75c0b22018.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_706fa1b766aee2723fd14753d19e8bdb.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d0bbd7c90d7ecbca9c10272072163ad0.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_693eae41201ae25040dbb671b731540b.jpeg",
            ShopierLink="https://www.shopier.com/s/product/34661519"
        },

         new ShoeFeature
        {
            Id=43,
            Brand="Nike",
            Model="Air Force Erkek Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_49770efa096493696d4ff0f9ded69526.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ea634a8253bdcd575f566fc3008284b9.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_e254c26b79475cec82d9482b7f01f171.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/35077041"
        },

           new ShoeFeature
        {
            Id=44,
            Brand="Louis Vuitton",
            Model="Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_4bf5cb057a02561ea000b845b998f78a.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_50c84872882416547ededa4fbe7086d0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_10feacf3370f8a14cb8c492fe2e553b0.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_461964e784d7f662f6be5257327fba0d.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076732"
        },



         new ShoeFeature
        {
            Id=45,
            Brand="Louis Vuitton",
            Model="Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_1a51850d335ebb943ee33b1147268238.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ca6cc1527502705b8c4d456f2476315a.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_955bb23379f67327bfd8cc5301b395a9.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/35076705"
        },

                      new ShoeFeature
        {
            Id=46,
            Brand="Lacoste",
            Model="Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_0b035e50c5721b47870ca0396fae0809.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1e3aa5917a23b9568a9345301c38671d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_b3ef76cd7de0d0ca50185effa808da63.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_dd6e36094db836e3a3f41b9718e7ae5b.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076667"
        },

            new ShoeFeature
        {
            Id=47,
            Brand="Lacoste",
            Model="Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_54438ac518dd636fdfd1566a28a291dd.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f99d7b7506274644f548b67ba16e0410.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d11747a975bcff0ac5cda3c75981d45a.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/35076620"
        },

            new ShoeFeature
        {
            Id=48,
            Brand="Lacoste",
            Model="Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7c120e57ccdea4c493279528f0b46698.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_988b4a90d4b939795f9f6a2b9e8a81a7.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_a68490db2e416d017618834eaf1ca511.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_357833c012c12a8609235b65d0bff939.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076549"
        },

            new ShoeFeature
        {
            Id=49,
            Brand="Lacoste",
            Model="Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_bcb58fc7aab2b4fc2c662516c8e962cc.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b063840b5fd02c40210867a35c95c36b.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_bbf24f38bb8b5d300dd3d768607957ec.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_ac1376f06d38d47db15a83732c2b0dee.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076502"
        },

            new ShoeFeature
        {
            Id=50,
            Brand="Lacoste",
            Model="Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_2514500f436cbe9d33a55727ad61e9fe.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_83d79a5f4e04b437e87866053c82ef31.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_cd79aeaff1c1aaa0b8b25a6cd5ca5dff.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_36b782cc61b13e676218756ea92f084f.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076458"
        },

        new ShoeFeature
        {
            Id=51,
            Brand="New Balance",
            Model="530 Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_134033d7cd3bf77e5563584503f3cf85.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_da05abfa1349df1ac97a6546cd0a80f4.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_2fcf0dcb661f57b109545c72c214855f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_cdaf9e41fd2593f220d88e42fa7b3b1c.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076362"
        },

        new ShoeFeature
        {
            Id=52,
            Brand="Nike",
            Model="Air Erkek Sneaker",
            Price=1659,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8dbfc0c39bc5ce7f62c14c0ec04ecdc8.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_25ebf0a422dfb5693b15a2d15baa6d31.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1273d750c4f9a164770d24c30301dcb0.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_ff9f96a6ff2d4eab9ee8d01e0f2b4c65.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076167"
        },
          new ShoeFeature
        {
            Id=53,
            Brand="Prada",
            Model="Beyaz Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_7b5963eaced665dfded1a5ff9e7e1fe3.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_482a8f0f65cfcc9b9f9fcf47998a4111.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_afbd1174f254279953d2688a0f289d78.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_4fdf02ccc6c4abce1971b0a4c5b416a1.jpeg",
            ShopierLink="https://www.shopier.com/s/product/35076274"
        },

         new ShoeFeature
        {
            Id=54,
            Brand="DSQUARED2",
            Model="Siyah Erkek Sneaker",
            Price=1399,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_c71738f55067ecc288d137538a1f36ac.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_7ab630ebfbabb9d1ecfbdb4883bc0e46.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_eaf3c53f6bfc35e362a671f8a2ee817d.jpeg",
            Image4="",
            ShopierLink="https://www.shopier.com/s/product/35076063"
        },

         new ShoeFeature
        {
            Id=55,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker Black Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_aa8d60802306bf41c27bbc58c503e99f.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_463ac9248c54927137678ebdf9f2a9a9.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6eacca4e1ed3ea7e4ab3a59b59dc67fe.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_0937218a22a73012ff0dbc66da62a331.jpeg",
            ShopierLink="https://www.shopier.com/34592216"
        },

         new ShoeFeature
        {
            Id=56,
            Brand="Louis Vuitton",
            Model="Trainer Sneaker Full White Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e7d58d15ecbf67be2df89f03f1470b72.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d1c69409078fe3cafc67de6f88d89ebf.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_997c1892903dd99e6ebff6315d3cbb8f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_d1c69409078fe3cafc67de6f88d89ebf.jpeg",
            ShopierLink="https://www.shopier.com/34592097"
        },

          new ShoeFeature
        {
            Id=57,
            Brand="New Balance",
            Model="530 Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_23c5aa2608e6ce2d00b45018aa5627b3.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_a87aee8b24517dcba650ce0f17568c88.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_2dddcd4a36dec8f59cbdf496a018bcdd.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_ccd566f0661f6711ad504049a5c2108e.jpeg",
            ShopierLink="https://www.shopier.com/34591021"
        },

           new ShoeFeature
        {
            Id=58,
            Brand="New Balance",
            Model="9060 Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_ec4ac6f4256f5063ee3c7a2d361a1562.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_3512db2ebc41144f3044ef4703726a9b.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6bc23409f018465bff8a25b3dbdb6634.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_dd8286f50032b67797233ef49bf39699.jpeg",
            ShopierLink="https://www.shopier.com/34590958"
        },

        new ShoeFeature
        {
            Id=59,
            Brand="New Balance",
            Model="9060 Black Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_b5eef5dfacb211638b09535666598016.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_977d720c6d9637fb75ccd81a6ddefc7b.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_d5c13663d7778fb3c84665db584a253f.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_7a619b7fa35f4e3932f352058761540b.jpeg",
            ShopierLink="https://www.shopier.com/34590622"
        },

        new ShoeFeature
        {
            Id=60,
            Brand="Adidas",
            Model="Campus Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_35a1e7eaa414c73fe3340ba4150d9ba2.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_240be1e9135ae3784958ea86c3ae203f.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6006e4ccdc8a119ef1554fa3d0f83ade.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a1605b1cc2bc83bc984a250fd96a5989.jpeg",
            ShopierLink="https://www.shopier.com/34590256"
        },

         new ShoeFeature
        {
            Id=61,
            Brand="Nike",
            Model="Dunk Low Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f4a8f9191a6f58f3ebebbe97ac22bfc7.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1790f17b9bdae658e19743a410d850d3.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1bdf34c64661e3622db21d31b8b235b8.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_f198608ce8c8dbfff98e084b05ab0796.jpeg",
            ShopierLink="https://www.shopier.com/34590190"
        },

         new ShoeFeature
        {
            Id=62,
            Brand="Nike",
            Model="Dunk Low Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_9118e3628ccea080e7fe991d72f82ec8.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_56879828c50a3509fe04560ad38a4568.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_cd2543e4620c9cee900c6fe9b4b970cb.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_6984475ef8eaed5351f319549e408aaa.jpeg",
            ShopierLink="https://www.shopier.com/34589342"
        },

        new ShoeFeature
        {
            Id=63,
            Brand="Nike",
            Model="Dunk Low Grey Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_fec308abca81b5a48472a20166f1eaf2.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_085f20869b3851f022b2dc90303266a0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_3ae23d4bb1417428c487fc51c97026ff.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8ff935152be075ee98404e9ed605cf04.jpeg",
            ShopierLink="https://www.shopier.com/34589158"
        },

         new ShoeFeature
        {
            Id=64,
            Brand="Nike",
            Model="Dunk Low Triple White Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_c5d53588536e7844201f3d636e6442c4.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_1d7b9f38b2d88900db2ead40444f5823.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_5e1532411d22b2f7f8675a414103d400.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_28638c3768ab84ad723218201891d6c7.jpeg",
            ShopierLink="https://www.shopier.com/34589122"
        },

        new ShoeFeature
        {
            Id=65,
            Brand="Adidas",
            Model="Handball Spezial Erkek Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_e533db1712b85f0ad1fb68ef0f1e997e.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_6d6ca97cd8a62070846261172b56d6f0.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_b94f73af5b00c8d39b06d7e9552ebae5.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_e51a8adc62cba82dcfde64a4059e1d80.jpeg",
            ShopierLink="https://www.shopier.com/34588910"
        },

        new ShoeFeature
        {
            Id=66,
            Brand="Adidas",
            Model="Handball Spezial Erkek Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_133e1e68e16e0dda3a8b1bbcb9237b65.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_a3dcbc512633208c70af04960a409d20.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_b0966fbe75ffe55149c828b9787f7e2a.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_31cd0ff5619990e313ae4d90992809c4.jpeg",
            ShopierLink="https://www.shopier.com/34588650"
        },

        new ShoeFeature
        {
            Id=67,
            Brand="Adidas",
            Model="Handball Spezial Erkek Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_316dfdfc9a20ce370bc29c71d61572af.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_e9ecb851960513aeb8341b1a984d79a7.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6ef6912f6efaa1be2070f062ec941d85.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_9f2140b2a99a638aaa670582991a4681.jpeg",
            ShopierLink="https://www.shopier.com/34588482"
        },

        new ShoeFeature
        {
            Id=68,
            Brand="Adidas",
            Model="Low Erkek Sneaker",
            Price=1199,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_aeb3d3f66a25405cf24e5f1318a8a0cb.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d5e2e63ff54a098df2d14245669660fb.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_e88b883ced65dd15da883f0c7bf77258.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a299074ce0eece1275579c781ac55760.jpeg",
            ShopierLink="https://www.shopier.com/34588198"
        },

        new ShoeFeature
        {
            Id=69,
            Brand="Adidas",
            Model="Superstar II Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_87403acad389420d7b7afc59b8a4fdf0.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_605280e297dacc050f0879ce73d2ea3e.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_99b69bbf42f1b2363f564b8a1ea3ddd2.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a5fb764ccd7d855700801397f1f1077b.jpeg",
            ShopierLink="https://www.shopier.com/34587936"
        },

        new ShoeFeature
        {
            Id=70,
            Brand="Nike",
            Model="Air Force 1 Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8a04d454a2a3ee6b864882f40b741192.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_b626982b7d7599e169b9c9a4ec0ed4ea.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_846b218762b9fb41d73d4677e5b71a8a.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_8d4d8d03e82a4f7399b9d301c88421b9.jpeg",
            ShopierLink="https://www.shopier.com/34587362"
        },

        new ShoeFeature
        {
            Id=71,
            Brand="Nike",
            Model="Air Force 1 Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_43e7136c3bcf5abbe63f3a64a68a2446.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_f629a8cd99467429f5141de830d0e2dd.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_1b11c58253110c3311ebab5d51e2168b.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_483eabb6df0da09cd27984c45d4d3055.jpeg",
            ShopierLink="https://www.shopier.com/34586859"
        },

        new ShoeFeature
        {
            Id=72,
            Brand="Nike",
            Model="Air Force 1 ‘07 Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_3cde6ffb770363ac1902ff778baa7987.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_d4afa7826f2a4986f133b6e0ccaf5834.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_0c5d3cc0877ff55457025b28d21d1404.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_6f7690ad6a89f860593cf040b945d9ef.jpeg",
            ShopierLink="https://www.shopier.com/35050870"
        },

        new ShoeFeature
        {
            Id=73,
            Brand="Puma",
            Model="Park Lifestyle OG Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_8ce10de716847c0d9760589b7a9cd8e2.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_01d7def96f2ca59333fd7fce056f77b2.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c0059d966ded8d3f4aa53c292398abd1.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_0c2c3747f83f6fd56108c76247f537d7.jpeg",
            ShopierLink="https://www.shopier.com/35047778"
        },

        new ShoeFeature
        {
            Id=74,
            Brand="EA7",
            Model="Emporıo Armanı Slasher Erkek Sneaker",
            Price=1599,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_dec4a391d525f5b6ae2dc116f46523ad.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_efa4ee1a8c3c360b10abe14e3ada973a.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_760a1deeb33567a74bcc6dba5eb4f590.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_e41c3154ecfe0fd2970a5713d3592adc.jpeg",
            ShopierLink="https://www.shopier.com/35045821"
        },

        new ShoeFeature
        {
            Id=75,
            Brand="Nike",
            Model="Blazer Low Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_b238587ecdae96e618a5d114bcac513d.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_63c31f81ae11e04c8b8248b5fa0fc419.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_6075dd443a09f157f2dda72898ef42bf.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_bf93ff9f1f5680b6b74ba87a646178aa.jpeg",
            ShopierLink="https://www.shopier.com/35045821"
        },

        new ShoeFeature
        {
            Id=76,
            Brand="Nike",
            Model="Air Force 1 ‘07 Erkek Sneaker",
            Price=1299,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f48494333ddb6b874ac8eac027a71d65.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_ef1930571992c65d8c0226c1022c399d.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_5fdacb98fae4887f5b63cadf36b7d5f6.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_a522072f62ed216504236402e6b566b6.jpeg",
            ShopierLink="https://www.shopier.com/35045374"
        },

        new ShoeFeature
        {
            Id=77,
            Brand="Nike",
            Model="Air Erkek Sneaker",
            Price=1696,
            Title="Bu Sitedeki tüm ürünler ücretsiz kargo ile gönderilir.",
            Cargo="Ücretsiz Kargo",
            Image1="https://cdn.shopier.app/pictures_large/stepcity_f17a46286bfbc2fecf4de082d15f91ac.jpeg",
            Image2="https://cdn.shopier.app/pictures_large/stepcity_c8bb23693c2aef7be43fe913914c6f16.jpeg",
            Image3="https://cdn.shopier.app/pictures_large/stepcity_c0a583431f0f84dd39e46742e05f7c26.jpeg",
            Image4="https://cdn.shopier.app/pictures_large/stepcity_088450646b920b1e6cd9ba4195f7f8dd.jpeg",
            ShopierLink="https://www.shopier.com/35044889"
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