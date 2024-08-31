using SAOnlineMart.Models;
using Humanizer;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.Drawing.Drawing2D;
using System.Formats.Tar;
using System.IO.Pipelines;

namespace SAOnlineMart.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Handcrafted Jewelry", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Locally-Produced Clothing", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Art and Home Decor", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Furniture and Homeware", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Gourmet Food and Snacks", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Health and Wellness Products", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Bespoke Accessories", DisplayOrder = 7 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Eternal Echoes Painting",
                    Supplier = "Arckerman Artworks",
                    Description = "Introducing <strong>“Eternal Echoes”</strong> – a mesmerizing creation by Arckerman Artworks Gallery. " +
                                    "This captivating painting embodies the spirit and rhythm of African culture through its" +
                                    " dynamic composition and organic hues.<br/><br/>Arckerman Artworks Gallery has long been celebrated" +
                                    " for its commitment to preserving African artistry. Founded by renowned artist Juma Arckerman in " +
                                    "1985 amidst the bustling streets of Johannesburg, South Africa, this gallery has become a sanctuary " +
                                    "for traditional techniques infused with contemporary flair. Juma’s passion for his roots led him to " +
                                    "explore various regions across Africa, gathering inspiration from local artisans’ stories woven into " +
                                    "their craft.<br/><br/><strong>“Eternal Echoes”</strong> represents Arckerman Artworks’ signature style—a harmonious blend " +
                                    "where ancestral whispers meet modern expressionism. Each stroke on this canvas resonates with history’s" +
                                    " pulse while echoing forward into today’s artistic landscape.<br/><br/>Invite your clientele to own more " +
                                    "than just art; offer them a timeless narrative captured within <strong>“Eternal Echoes”</strong>, where every glance reveals " +
                                    "another layer in its endless story.",

                    Barcode = "827349",
                    ListPrice = 1999,
                    CategoryId = 3,
                    ImageUrl = "\\images\\product\\aba2fdab-8868-4514-a6aa-2252177adeaa.jfif"
                },

                new Product
                {
                    Id = 2,
                    Name = "Grace of the Plains Statuette",
                    Supplier = "Chokwe Carvings",
                    Description = "<strong>“Grace of the Plains”</strong> by Chokwe Carvings is a stunning statuette that captures the essence of South" +
                                "African artistry and tradition. This exquisite piece, carved by the talented Tebatso Chokwe, depicts a one-legged" +
                                "African lady in a poised and graceful stance, holding a small bowl. The intricate patterns and textures adorning " +
                                "the figure tell a story of resilience and beauty, inspired by the legendary one-legged dancers of Limpopo who balance" +
                                " life’s challenges with poise and strength.<br/><br/>Chokwe Carvings, a renowned workshop nestled in the heart of Johannesburg," +
                                " has been a beacon of traditional craftsmanship for over four decades. Founded by master artisan Tebatso Chokwe, the workshop" +
                                " draws inspiration from the diverse tribes and landscapes of South Africa. Tebatso’s passion for preserving ancient techniques" +
                                " while infusing contemporary elements is evident in every piece they create.<br/><br/>The <strong>“Grace of the Plains”</strong> statuette is" +
                                " crafted from indigenous wood, embodying the spirit of Ubuntu—interweaving individual craftsmanship with communal culture." +
                                " The figure’s serene expression and elegant posture reflect the harmonious balance between tradition and modernity. Each" +
                                " curve and etched line is a testament to the meticulous craftsmanship and cultural significance embedded in the piece.<br/><br/>This" +
                                " statuette is not just a decorative item; it is a carrier of stories, each line and curve whispering secrets of a land rich " +
                                "in diversity and creativity. Displaying this piece in your space invites not only an aesthetic transformation but also an " +
                                "immersive cultural experience. The <strong>“Grace of the Plains”</strong> is more than art—it’s a bridge to a world where every creation is" +
                                " infused with meaning and every artifact sings the song of its people.<br/><br/>Bring home this rustic embodiment of South African" +
                                " artisanship and let your space narrate stories that transcend time.",
                    Barcode = "193674",
                    ListPrice = 849,
                    CategoryId = 3,
                    ImageUrl = "\\images\\product\\5f6ed848-1200-4fde-8e6b-04fbd659233d.jfif"
                },

                new Product
                {
                    Id = 3,
                    Name = "Echoes of the Ancestors Statues",
                    Supplier = "Ettiene Etchings",
                    Description = "<strong>“Echoes of the Ancestors”</strong> by Ettiene Etchings is a captivating trio of mask " +
                                "face statues that embody the rich cultural heritage of South Africa. Each mask is a testament" +
                                " to the enduring legacy of tribal craftsmanship, meticulously carved from indigenous wood to" +
                                " bring forth the spirit and culture of its origins.<br/><br/>Ettiene Etchings, a renowned " +
                                "workshop nestled in the heart of Johannesburg, has been a beacon of traditional artistry for" +
                                " over four decades. Founded by master craftsman Ettiene Mostert, the workshop draws inspiration" +
                                " from the diverse tribes and landscapes of South Africa. Ettiene’s passion for preserving ancient" +
                                " techniques while infusing contemporary elements is evident in every piece they create.<br/><br/>The" +
                                " <strong>“Echoes of the Ancestors”</strong> collection features three distinct masks, each with its own unique " +
                                "character and story. The first mask stands as a guardian of history, its stern expression etched " +
                                "with patterns that tell tales of ancient wisdom passed down through generations. The second mask, " +
                                "crowned with an elaborate headdress, symbolizes the connection between earth and sky, embodying the" +
                                " vibrant life force that pulses through nature’s creations. The third mask wears a serene countenance," +
                                " reflecting the harmonious balance between tradition and modernity.<br/><br/>These statues are not mere" +
                                " decorative pieces; they are carriers of stories, each line and curve whispering secrets of a land rich" +
                                " in diversity and creativity. Displaying these masks in your space invites not only an aesthetic" +
                                " transformation but also an immersive cultural experience.<br/><br/>Crafted by skilled artisans who" +
                                " have inherited their techniques from forebears skilled in woodwork and symbolism, these masks " +
                                "resonate with the soulful beats of African drums and the silent strength of ancestral spirits. " +
                                "The <strong>“Echoes of the Ancestors”</strong> collection is more than art—it’s a bridge to a world where every " +
                                "creation is infused with meaning and every artifact sings the song of its people.<br/><br/>Bring" +
                                " home this rustic embodiment of South African artisanship and let your walls narrate stories that transcend time.",
                    Barcode = "582913",
                    ListPrice = 2500,
                    CategoryId = 3,
                    ImageUrl = "\\images\\product\\943ccaa4-0fcb-4dc9-b2f6-677c57a93a3d.jfif"
                },

                new Product
                {
                    Id = 4,
                    Name = "Lunar Harmony Necklace",
                    Supplier = "Nandi Necklaces",
                    Description = "<strong>“Lunar Harmony Necklace”</strong> by Nandi Necklaces is a " +
                                "stunning piece that captures the essence of South African artistry " +
                                "and tradition. This beautifully crafted beaded necklace, with its " +
                                "distinctive crescent shape, is a testament to the skilled craftsmanship " +
                                "and rich cultural heritage of the region.<br/><br/>Nandi Necklaces, a" +
                                " renowned atelier based in the vibrant city of Durban, has been creating" +
                                " exquisite jewelry for over three decades. Founded by Nandi Mthembu, the " +
                                "atelier draws inspiration from the diverse landscapes and vibrant cultures " +
                                "of South Africa. Nandi’s passion for preserving traditional beadwork techniques" +
                                " while infusing contemporary elements is evident in every piece they" +
                                " create.<br/><br/>The <strong>“Lunar Harmony Necklace”</strong> features an intricate pattern" +
                                " of beads in warm earth tones, ranging from deep browns to soft creams and " +
                                "vibrant oranges. Each bead is meticulously selected to represent the diverse " +
                                "colors found in the African landscape, from the rich soils of the savannah to " +
                                "the fiery hues of a sunset. The crescent shape of the necklace mirrors the arc " +
                                "of the horizon, symbolizing the harmony between nature and the cosmos.<br/><br/>This" +
                                " necklace is more than just an accessory; it’s a piece of wearable art that tells " +
                                "a story of tradition and modernity. The design is inspired by ancient tribal motifs," +
                                " each symbol carrying a story of its own. The beads are arranged in various sizes and" +
                                " textures, creating a rich tapestry that speaks to the skilled artisanship behind its " +
                                "creation.<br/><br/>Wearing the <strong>“Lunar Harmony Necklace”</strong> is an invitation to embrace the beauty" +
                                " and resilience of South African culture. Each design element is a tribute to the artisans" +
                                " who have mastered their craft over generations, echoing their connection to nature and " +
                                "community. This necklace is a celebration of heritage, a piece that carries within it the" +
                                " stories and traditions of South Africa.",
                    Barcode = "746025",
                    ListPrice = 475,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\ea0ec1ea-661e-4549-83ab-ca22c65377d4.jfif"
                },

                new Product
                {
                    Id = 5,
                    Name = "Naledi Circle Bracelet",
                    Supplier = "Brenda Beadwork",
                    Description = "Introducing the <strong>“Naledi Circle”</strong> – a masterpiece of South African artisanship, where" +
                                " each bead tells a story of heritage and craftsmanship. Handcrafted by makers, Brenda Beadwork, this" +
                                " exquisite beaded bracelet draws inspiration from the rich tapestry of South African culture. The" +
                                " <strong>“Naledi Circle”</strong> is more than just an accessory; it’s a celebration of tradition woven into modern " +
                                "style.<br/><br/>Brenda Sithole, our esteemed artisan from the heartlands of South Africa, has poured " +
                                "her passion into creating this rustic yet elegant piece. Each bead is meticulously selected to represent" +
                                " the earthy hues of South Africa’s landscapes – from the golden browns reminiscent of the vast savannahs" +
                                " to the soft greys echoing the early morning mists over Table Mountain.<br/><br/>The design itself pays " +
                                "homage to ancient techniques passed down through generations. It mirrors the undulating rhythms and" +
                                " patterns found in traditional Zulu beadwork, which often carry meanings related to social status or " +
                                "availability for marriage. In crafting <strong>“Naledi Circle”</strong>, Brenda has reimagined these motifs for contemporary " +
                                "fashion while retaining their cultural essence.<br/><br/>Wearing this bracelet not only adorns your wrist " +
                                "with beauty but also connects you with stories woven through time – stories of resilience, community, " +
                                "and artistry that continue to thrive in modern-day South Africa.",
                    Barcode = "238964",
                    ListPrice = 399,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\2e1984e3-5be4-48f2-8cda-ae8be8f301e3.jfif"
                },

                new Product
                {
                    Id = 6,
                    Name = "Heart of Savannah Necklace",
                    Supplier = "Japhthah Jewellers",
                    Description = "“<strong> Heart of the Savannah </strong>” is a stunning beaded necklace crafted by the talented" +
                                " artisans at Japhthah Jewellers.This exquisite piece embodies the spirit of South African artistry," +
                                " with each bead meticulously selected to represent the diverse hues found in the vast landscapes," +
                                " from the golden sunrise over Kruger Park to the deep umbers of its fertile earth.<br><br>" +
                                " The central <strong>heart-shaped charm</strong> is a true masterpiece, inspired by traditional Zulu love letters. These intricate" +
                                " patterns convey messages through their designs, with each twist and turn telling tales of enduring" +
                                " bonds and communal unity. The necklace’s multiple strands transition in color from light to dark, " +
                                "symbolizing the journey from dawn to dusk across the African plains.<br><br>" +
                                " Japhthah Jewellers, a family-run business nestled in the heart of Pretoria, has been preserving the rich heritage of South" +
                                " African beadwork for generations. Their artisans are known for their dedication to traditional" +
                                " techniques, passed down through the ages, while infusing each piece with a contemporary flair. " +
                                "The <strong>“Heart of the Savannah”</strong> is not just jewelry; it’s a wearable story that carries within it" +
                                " centuries-old techniques and the vibrant culture of South Africa.<br><br>" +
                                " Adorn yourself with this unique piece and feel the connection to the land and its people, celebrating the beauty" +
                                " and resilience of African artistry.",
                    Barcode = "901758",
                    ListPrice = 819,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\892bde25-a8a9-4cd2-b800-45bd7cfb06c7.jfif"
                },

                new Product
                {
                    Id = 7,
                    Name = "Chieftain's Stooled Water Pot",
                    Supplier = "Francis Furnishers",
                    Description = "“<strong> Chieftain’s Stooled Water Pot </strong>” by E Francis Furnishers is a captivating piece of display" +
                                " furniture that embodies the essence of South African tradition and artistry.This beautifully crafted African pot, " +
                                "resting on a rustic wooden stool,draws inspiration from the traditional drinking pots used" +
                                " by village chiefs, symbolizing leadership and community.<br><br>" +
                                " E Francis Furnishers, a renowned collective based in the heart of Limpopo, has been preserving the art of traditional" +
                                " pottery for generations. Founded by the visionary artisan Emmanuel Francis, the workshop is dedicated to capturing the" +
                                " rich cultural heritage of South Africa. Emmanuel’s passion for his craft is evident in every piece, as he infuses each creation with a" +
                                " deep love for his homeland’s history and traditions.<br><br>" +
                                " The <strong>“Chieftain’s Stooled Water Pot”</strong> is crafted from the rich, red earth of the region, known for " +
                                "its fertile soil and abundant natural resources. The intricate patterns and designs etched into the pot’s surface are" +
                                " inspired by ancient tribal motifs, each symbol carrying a story of its own. The geometric shapes and earthy tones" +
                                " reflect the beauty of the South African landscape, from the rolling hills to the vast savannahs.<br><br>" +
                                " This pot is more than just a decorative item; it is a piece of living history, a tangible connection to" +
                                " the past. The artisans at E Francis Furnishers use traditional techniques passed down through generations," +
                                " ensuring that each piece is a true work of art. The wooden stool, with its simple yet elegant design, complements" +
                                " the pot perfectly, adding a touch of rustic charm to any space.<br><br>" +
                                " The <strong>“Chieftain’s Stooled Water Pot”</strong> is a celebration of South African culture and craftsmanship." +
                                " Each line and curve tells a story of resilience and beauty, reflecting the spirit of the people who create these " +
                                "masterpieces. Displaying this pot in your home invites not only an" +
                                " aesthetic transformation but also an immersive cultural experience. It is a bridge to a world where every creation" +
                                " is infused with meaning and every artifact sings the song of its people.<br><br>" +
                                " Bring home this rustic embodiment of South African artisanship and let your space narrate stories that transcend time.",
                    Barcode = "364217",
                    ListPrice = 1000,
                    CategoryId = 4,
                    ImageUrl = "\\images\\product\\16b1009c-dfae-4ab0-b6e1-ac9d7be5bd57.jfif"
                },

                new Product
                {
                    Id = 8,
                    Name = "Amphora Collection Cabinet",
                    Supplier = "Author Artisans",
                    Description = "“<strong> Amphora Collection </strong>” by Arthur Artisans is a stunning showcase of South African craftsmanship." +
                                "This elegant wooden cabinet, adorned with intricate geometric carvings, houses an array of vases that each tell a unique story of " +
                                "tradition and artistry.<br><br> Arthur Artisans, led by the talented Arthur Stemmet, has been a cornerstone of Cape Town’s artisanal" +
                                " community for over three decades. Arthur’s passion for preserving the rich cultural heritage of South Africa is evident in every piece" +
                                " he creates. Drawing inspiration from the rolling hills and vibrant flora of the Western Cape, Arthur infuses his work with a" +
                                " deep love for his homeland’s diverse culture and landscape.<br><br> The <strong>“Amphora Collection”</strong> features vases of" +
                                " various shapes, sizes, and designs, each crafted with meticulous attention to detail. The natural color palette, ranging from" +
                                " earthy browns to soft creams, reflects the beauty of the South African landscape. The intricate patterns and textures on the vases pay" +
                                " homage to ancient African pottery techniques passed down through generations.<br><br> These vases are not just decorative items; they " +
                                "are keepers of history, artfully molded by hands that understand the value of preserving culture in every curve and etching. Displaying" +
                                " this collection in your home invites not only an aesthetic transformation but also an immersive cultural experience.<br><br>" +
                                " The <strong>“Amphora Collection”</strong> is more than just a set of vases—it’s a celebration of South African heritage, a testament" +
                                " to the enduring legacy of traditional craftsmanship, and a bridge to a world where every creation is infused with meaning and every" +
                                " artifact sings the song of its people. Bring home this rustic embodiment of South African artisanship and let your space narrate" +
                                " stories that transcend time."
            ,
                    Barcode = "512480",
                    ListPrice = 4899,
                    CategoryId = 4,
                    ImageUrl = "\\images\\product\\e7ec96e4-9e3f-451a-8fc5-06b1b4ef0c53.jfif"
                },

                new Product
                {
                    Id = 9,
                    Name = "Heritage Haven Couch",
                    Supplier = "Makhubela Makers",
                    Description = "“<strong> Heritage Haven </strong>” by Makhubela Makers is a testament to the rich cultural tapestry of " +
                                    "South Africa.This three - seater couch, adorned with intricate African - inspired fabric, is a blend of modern design and" +
                                    " traditional craftsmanship.<br><br> Makhubela Makers, a family-run workshop in Pretoria, has been a beacon of South African" +
                                    " artistry for over three decades. Founded by Thabo Makhubela, the workshop draws inspiration from the diverse landscapes and" +
                                    " vibrant cultures of the region. Thabo’s passion for preserving traditional techniques while infusing contemporary elements" +
                                    " is evident in every piece they create.<br><br> The <strong>“Heritage Haven”</strong> couch features a sleek, modern silhouette" +
                                    " that beautifully contrasts with the detailed patterns and textures of the fabric. The geometric designs and earthy tones are" +
                                    " reminiscent of the vast African plains, capturing the essence of the land and its people. Each stitch is a tribute to the" +
                                    " meticulous craftsmanship and cultural significance embedded in the fabric, sourced from local weavers who have honed their" +
                                    " skills over generations.<br><br> This couch is not just a piece of furniture; it’s a narrative woven into existence by skilled" +
                                    " hands. It invites you to experience the stories and traditions of South Africa, offering a comfortable and culturally rich" +
                                    " addition to any living space. With <strong>“Heritage Haven”</strong>, you bring home a piece of South African heritage," +
                                    " celebrating the beauty and resilience of its artistry.",
                    Barcode = "679341",
                    ListPrice = 3500,
                    CategoryId = 4,
                    ImageUrl = "\\images\\product\\09447715-1462-43f4-b56b-44cc19592c60.jfif"
                },

                new Product
                {
                    Id = 10,
                    Name = "Zulu Elegance Ensemble",
                    Supplier = "Thuso Taylors",
                    Description = "“<strong> Zulu Elegance Ensemble </strong>” by Thuso Taylors is a sartorial masterpiece that captures" +
                                " the essence of South African heritage and modern sophistication. This men’s suit," +
                                " with its intricate patterns and vibrant colors, is a testament to the skilled" +
                                " craftsmanship and cultural richness of the region.<br><br>" +
                                "Thuso Taylors, a distinguished atelier based in Johannesburg, has been at the forefront of South African fashion" +
                                " for over two decades. Founded by the visionary designer Thuso Mokoena, the atelier" +
                                " draws inspiration from the diverse cultures and landscapes of South Africa. Thuso’s designs are renowned for their fusion of traditional motifs with" +
                                " contemporary silhouettes, creating pieces that are both timeless and modern.<br><br>" +
                                " The <strong>“Zulu Elegance Ensemble”</strong> features a tailored suit with patterns inspired by ancient" +
                                " Zulu art. The geometric shapes and bold colors reflect the vibrant energy of South" +
                                " African culture, from the rhythmic beats of traditional music to the dynamic movements" +
                                " of Zulu dance. The suit’s earthy tones, accented by pops of color, evoke the" +
                                " natural beauty of the African landscape, from the golden savannahs to the" +
                                " lush valleys.<br><br>" +
                                " This suit is more than just attire; it is a celebration of South African artistry brought to life through fashion. Each stitch tells" +
                                " a story of tradition and innovation, as local artisans meticulously weave cultural" +
                                " narratives into the fabric. The suit’s design pays homage to the rich history" +
                                " of the Zulu people, while also embracing the modern gentleman’s need for style" +
                                " and substance.<br><br>" +
                                " Wearing the <strong>“Zulu Elegance Ensemble”</strong> is an invitation to embrace the beauty and resilience of South African culture. Each design element" +
                                " is a tribute to the artisans who have mastered their craft over generations, " +
                                "echoing their connection to nature and community. This suit is a statement piece" +
                                " that carries within it the stories and traditions of South Africa, making every" +
                                " occasion a celebration of heritage and elegance.",
                    Barcode = "453829",
                    ListPrice = 2250,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\a60ea39c-e9fa-4e92-84a3-6e20387e8a62.webp"
                },

                new Product
                {
                    Id = 11,
                    Name = "Little Safari Dream Dress",
                    Supplier = "Emma Embroiders",
                    Description = "“<strong> Little Safari Dream Dress </strong>” by Emma Embroiders is a delightful blend of tradition and whimsy," +
                                " perfect for the young adventurer. This charming children’s dress features intricate" +
                                " embroidery that tells a story of South African heritage and craftsmanship.<br><br>" +
                                "Emma Embroiders, a beloved atelier based in the vibrant city of Durban, has been creating" +
                                " beautiful, handcrafted garments for over two decades. Founded by Emma Ndlovu, the atelier is renowned for its dedication to preserving traditional embroidery techniques" +
                                " while infusing each piece with contemporary flair. Emma’s passion for her craft is evident" +
                                " in every stitch, as she draws inspiration from the rich cultural tapestry of South Africa.<br><br>" +
                                " The <strong>“Little Safari Dream Dress”</strong> is adorned with vibrant patterns and traditional" +
                                " African motifs, each symbol carrying a story of its own. The geometric shapes and earthy tones are reminiscent of the diverse landscapes and wildlife of the African plains. The" +
                                " dress is made from high-quality, comfortable fabric, ensuring that your little one can" +
                                " explore the world in style and comfort.<br><br>" +
                                " This dress is more than just clothing; it’s a piece of wearable art that celebrates the beauty and resilience of South African" +
                                " culture. Each design element is a tribute to the artisans who have mastered their craft" +
                                " over generations, echoing their connection to nature and community. The <strong>“Little Safari Dream Dress”</strong> invites your child to embark on a journey of discovery, wrapped in the" +
                                " stories and traditions of South Africa.",
                    Barcode = "720496",
                    ListPrice = 1600,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\95bf05bf-f30d-49ed-b159-943fd719afcf.webp"
                },

                new Product
                {
                    Id = 12,
                    Name = "Sunset Serenade Gown",
                    Supplier = "Felicia Fashioners",
                    Description = "“<strong> Sunset Serenade Gown </strong>” by Felicia Fashioners is a vibrant celebration of South African" +
                                " elegance and tradition. This full-length, strapless dress features a voluminous skirt adorned with" +
                                " intricate patterns in shades of red, yellow, gold, and brown, reminiscent of the breathtaking hues" +
                                " of an African sunset.<br><br>" +
                                "Felicia Fashioners, a boutique atelier based in the heart of Cape Town, has been a beacon of South African haute couture for over two decades. Founded by the visionary" +
                                " designer Felicia Maseko, the atelier draws inspiration from the rich cultural heritage and diverse" +
                                " landscapes of South Africa. Felicia’s designs are renowned for their fusion of traditional motifs" +
                                " with contemporary silhouettes, creating pieces that are both timeless and modern.<br><br>" +
                                " The <strong>“Sunset Serenade Gown”</strong> is a testament to this unique blend. The geometric and organic shapes in the fabric" +
                                " are inspired by ancient tribal art, each symbol carrying a story of its own. The bold colors reflect" +
                                " the vibrant energy of local markets and the natural beauty of the African plains. The gown’s" +
                                " voluminous skirt and strapless bodice create a silhouette that is both dramatic and elegant," +
                                " perfect for making a statement at any event.<br><br>" +
                                " This gown is not just a piece of clothing; it’s a work of art that embodies the spirit of South Africa. Each stitch is a tribute to the" +
                                " artisans who have mastered their craft over generations, echoing their connection to nature and" +
                                " community. Wearing the <strong>“Sunset Serenade Gown”</strong> is an invitation to embrace the rich tapestry of South" +
                                " African culture and style, making every occasion a celebration of heritage and beauty.",
                    Barcode = "185237",
                    ListPrice = 2900,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\fae71570-fb05-4ade-975a-aaf37e0c5064.webp"
                }
            );
        }
    }
}
