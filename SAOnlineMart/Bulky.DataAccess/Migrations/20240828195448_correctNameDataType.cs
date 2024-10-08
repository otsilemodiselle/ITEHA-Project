﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAOnlineMart.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class correctNameDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Introducing “Eternal Echoes” – a mesmerizing creation by Arckerman Artworks Gallery. This captivating painting embodies the spirit and rhythm of African culture through its dynamic composition and organic hues.\r\n\r\nArckerman Artworks Gallery has long been celebrated for its commitment to preserving African artistry. Founded by renowned artist Juma Arckerman in 1985 amidst the bustling streets of Johannesburg, South Africa, this gallery has become a sanctuary for traditional techniques infused with contemporary flair. Juma’s passion for his roots led him to explore various regions across Africa, gathering inspiration from local artisans’ stories woven into their craft.\r\n\r\n“Eternal Echoes” represents Arckerman Artworks’ signature style—a harmonious blend where ancestral whispers meet modern expressionism. Each stroke on this canvas resonates with history’s pulse while echoing forward into today’s artistic landscape.\r\n\r\nInvite your clientele to own more than just art; offer them a timeless narrative captured within “Eternal Echoes”, where every glance reveals another layer in its endless story.", "Eternal Echoes Painting" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Grace of the Plains” by Chokwe Carvings is a stunning statuette that captures the essence of South African artistry and tradition. This exquisite piece, carved by the talented Tebatso Chokwe, depicts a one-legged African lady in a poised and graceful stance, holding a small bowl. The intricate patterns and textures adorning the figure tell a story of resilience and beauty, inspired by the legendary one-legged dancers of Limpopo who balance life’s challenges with poise and strength.\r\n\r\nChokwe Carvings, a renowned workshop nestled in the heart of Johannesburg, has been a beacon of traditional craftsmanship for over four decades. Founded by master artisan Tebatso Chokwe, the workshop draws inspiration from the diverse tribes and landscapes of South Africa. Tebatso’s passion for preserving ancient techniques while infusing contemporary elements is evident in every piece they create.\r\n\r\nThe “Grace of the Plains” statuette is crafted from indigenous wood, embodying the spirit of Ubuntu—interweaving individual craftsmanship with communal culture. The figure’s serene expression and elegant posture reflect the harmonious balance between tradition and modernity. Each curve and etched line is a testament to the meticulous craftsmanship and cultural significance embedded in the piece.\r\n\r\nThis statuette is not just a decorative item; it is a carrier of stories, each line and curve whispering secrets of a land rich in diversity and creativity. Displaying this piece in your space invites not only an aesthetic transformation but also an immersive cultural experience. The “Grace of the Plains” is more than art—it’s a bridge to a world where every creation is infused with meaning and every artifact sings the song of its people.\r\n\r\nBring home this rustic embodiment of South African artisanship and let your space narrate stories that transcend time.", "Grace of the Plains Statuette" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Echoes of the Ancestors” by Ettiene Etchings is a captivating trio of mask face statues that embody the rich cultural heritage of South Africa. Each mask is a testament to the enduring legacy of tribal craftsmanship, meticulously carved from indigenous wood to bring forth the spirit and culture of its origins.\r\n\r\nEttiene Etchings, a renowned workshop nestled in the heart of Johannesburg, has been a beacon of traditional artistry for over four decades. Founded by master craftsman Ettiene Mostert, the workshop draws inspiration from the diverse tribes and landscapes of South Africa. Ettiene’s passion for preserving ancient techniques while infusing contemporary elements is evident in every piece they create.\r\n\r\nThe “Echoes of the Ancestors” collection features three distinct masks, each with its own unique character and story. The first mask stands as a guardian of history, its stern expression etched with patterns that tell tales of ancient wisdom passed down through generations. The second mask, crowned with an elaborate headdress, symbolizes the connection between earth and sky, embodying the vibrant life force that pulses through nature’s creations. The third mask wears a serene countenance, reflecting the harmonious balance between tradition and modernity.\r\n\r\nThese statues are not mere decorative pieces; they are carriers of stories, each line and curve whispering secrets of a land rich in diversity and creativity. Displaying these masks in your space invites not only an aesthetic transformation but also an immersive cultural experience.\r\n\r\nCrafted by skilled artisans who have inherited their techniques from forebears skilled in woodwork and symbolism, these masks resonate with the soulful beats of African drums and the silent strength of ancestral spirits. The “Echoes of the Ancestors” collection is more than art—it’s a bridge to a world where every creation is infused with meaning and every artifact sings the song of its people.\r\n\r\nBring home this rustic embodiment of South African artisanship and let your walls narrate stories that transcend time.", "Echoes of the Ancestors Statues" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Lunar Harmony Necklace” by Nandi Necklaces is a stunning piece that captures the essence of South African artistry and tradition. This beautifully crafted beaded necklace, with its distinctive crescent shape, is a testament to the skilled craftsmanship and rich cultural heritage of the region.\r\n\r\nNandi Necklaces, a renowned atelier based in the vibrant city of Durban, has been creating exquisite jewelry for over three decades. Founded by Nandi Mthembu, the atelier draws inspiration from the diverse landscapes and vibrant cultures of South Africa. Nandi’s passion for preserving traditional beadwork techniques while infusing contemporary elements is evident in every piece they create.\r\n\r\nThe “Lunar Harmony Necklace” features an intricate pattern of beads in warm earth tones, ranging from deep browns to soft creams and vibrant oranges. Each bead is meticulously selected to represent the diverse colors found in the African landscape, from the rich soils of the savannah to the fiery hues of a sunset. The crescent shape of the necklace mirrors the arc of the horizon, symbolizing the harmony between nature and the cosmos.\r\n\r\nThis necklace is more than just an accessory; it’s a piece of wearable art that tells a story of tradition and modernity. The design is inspired by ancient tribal motifs, each symbol carrying a story of its own. The beads are arranged in various sizes and textures, creating a rich tapestry that speaks to the skilled artisanship behind its creation.\r\n\r\nWearing the “Lunar Harmony Necklace” is an invitation to embrace the beauty and resilience of South African culture. Each design element is a tribute to the artisans who have mastered their craft over generations, echoing their connection to nature and community. This necklace is a celebration of heritage, a piece that carries within it the stories and traditions of South Africa.", "Lunar Harmony Necklace" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Supplier" },
                values: new object[] { "Introducing the “Naledi Circle” – a masterpiece of South African artisanship, where each bead tells a story of heritage and craftsmanship. Handcrafted by makers, Brenda Beadwork, this exquisite beaded bracelet draws inspiration from the rich tapestry of South African culture. The “Naledi Circle” is more than just an accessory; it’s a celebration of tradition woven into modern style.\r\n\r\nBrenda Sithole, our esteemed artisan from the heartlands of South Africa, has poured her passion into creating this rustic yet elegant piece. Each bead is meticulously selected to represent the earthy hues of South Africa’s landscapes – from the golden browns reminiscent of the vast savannahs to the soft greys echoing the early morning mists over Table Mountain.\r\n\r\nThe design itself pays homage to ancient techniques passed down through generations. It mirrors the undulating rhythms and patterns found in traditional Zulu beadwork, which often carry meanings related to social status or availability for marriage. In crafting “Naledi Circle,” Brenda has reimagined these motifs for contemporary fashion while retaining their cultural essence.\r\n\r\nWearing this bracelet not only adorns your wrist with beauty but also connects you with stories woven through time – stories of resilience, community, and artistry that continue to thrive in modern-day South Africa.", "Naledi Circle Bracelet", "Brenda Beadwork" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Heart of the Savannah” is a stunning beaded necklace crafted by the talented artisans at Japhthah Jewellers. This exquisite piece embodies the spirit of South African artistry, with each bead meticulously selected to represent the diverse hues found in the vast landscapes, from the golden sunrise over Kruger Park to the deep umbers of its fertile earth.\r\n\r\nThe central heart-shaped charm is a true masterpiece, inspired by traditional Zulu love letters. These intricate patterns convey messages through their designs, with each twist and turn telling tales of enduring bonds and communal unity. The necklace’s multiple strands transition in color from light to dark, symbolizing the journey from dawn to dusk across the African plains.\r\n\r\nJaphthah Jewellers, a family-run business nestled in the heart of Pretoria, has been preserving the rich heritage of South African beadwork for generations. Their artisans are known for their dedication to traditional techniques, passed down through the ages, while infusing each piece with a contemporary flair. The “Heart of the Savannah” is not just jewelry; it’s a wearable story that carries within it centuries-old techniques and the vibrant culture of South Africa.\r\n\r\nAdorn yourself with this unique piece and feel the connection to the land and its people, celebrating the beauty and resilience of African artistry.", "Heart of Savannah Necklace" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Chieftain’s Stooled Water Pot” by E Francis Furnishers is a captivating piece of display furniture that embodies the essence of South African tradition and artistry. This beautifully crafted African pot, resting on a rustic wooden stool, draws inspiration from the traditional drinking pots used by village chiefs, symbolizing leadership and community.\r\n\r\nE Francis Furnishers, a renowned collective based in the heart of Limpopo, has been preserving the art of traditional pottery for generations. Founded by the visionary artisan Emmanuel Francis, the workshop is dedicated to capturing the rich cultural heritage of South Africa. Emmanuel’s passion for his craft is evident in every piece, as he infuses each creation with a deep love for his homeland’s history and traditions.\r\n\r\nThe “Chieftain’s Stooled Water Pot” is crafted from the rich, red earth of the region, known for its fertile soil and abundant natural resources. The intricate patterns and designs etched into the pot’s surface are inspired by ancient tribal motifs, each symbol carrying a story of its own. The geometric shapes and earthy tones reflect the beauty of the South African landscape, from the rolling hills to the vast savannahs.\r\n\r\nThis pot is more than just a decorative item; it is a piece of living history, a tangible connection to the past. The artisans at E Francis Furnishers use traditional techniques passed down through generations, ensuring that each piece is a true work of art. The wooden stool, with its simple yet elegant design, complements the pot perfectly, adding a touch of rustic charm to any space.\r\n\r\nThe “Chieftain’s Stooled Water Pot” is a celebration of South African culture and craftsmanship. Each line and curve tells a story of resilience and beauty, reflecting the spirit of the people who create these masterpieces. Displaying this pot in your home invites not only an aesthetic transformation but also an immersive cultural experience. It is a bridge to a world where every creation is infused with meaning and every artifact sings the song of its people.\r\n\r\nBring home this rustic embodiment of South African artisanship and let your space narrate stories that transcend time.", "Chieftain's Stooled Water Pot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Amphora Collection” by Arthur Artisans is a stunning showcase of South African craftsmanship. This elegant wooden cabinet, adorned with intricate geometric carvings, houses an array of vases that each tell a unique story of tradition and artistry.\r\n\r\nArthur Artisans, led by the talented Arthur Stemmet, has been a cornerstone of Cape Town’s artisanal community for over three decades. Arthur’s passion for preserving the rich cultural heritage of South Africa is evident in every piece he creates. Drawing inspiration from the rolling hills and vibrant flora of the Western Cape, Arthur infuses his work with a deep love for his homeland’s diverse culture and landscape.\r\n\r\nThe “Amphora  Collection” features vases of various shapes, sizes, and designs, each crafted with meticulous attention to detail. The natural color palette, ranging from earthy browns to soft creams, reflects the beauty of the South African landscape. The intricate patterns and textures on the vases pay homage to ancient African pottery techniques passed down through generations.\r\n\r\nThese vases are not just decorative items; they are keepers of history, artfully molded by hands that understand the value of preserving culture in every curve and etching. Displaying this collection in your home invites not only an aesthetic transformation but also an immersive cultural experience.\r\n\r\nThe “Amphora  Collection” is more than just a set of vases—it’s a celebration of South African heritage, a testament to the enduring legacy of traditional craftsmanship, and a bridge to a world where every creation is infused with meaning and every artifact sings the song of its people. Bring home this rustic embodiment of South African artisanship and let your space narrate stories that transcend time.", "Amphora Collection Cabinet" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Heritage Haven” by Makhubela Makers is a testament to the rich cultural tapestry of South Africa. This three-seater couch, adorned with intricate African-inspired fabric, is a blend of modern design and traditional craftsmanship.\r\n\r\nMakhubela Makers, a family-run workshop in Pretoria, has been a beacon of South African artistry for over three decades. Founded by Thabo Makhubela, the workshop draws inspiration from the diverse landscapes and vibrant cultures of the region. Thabo’s passion for preserving traditional techniques while infusing contemporary elements is evident in every piece they create.\r\n\r\nThe “Heritage Haven” couch features a sleek, modern silhouette that beautifully contrasts with the detailed patterns and textures of the fabric. The geometric designs and earthy tones are reminiscent of the vast African plains, capturing the essence of the land and its people. Each stitch is a tribute to the meticulous craftsmanship and cultural significance embedded in the fabric, sourced from local weavers who have honed their skills over generations.\r\n\r\nThis couch is not just a piece of furniture; it’s a narrative woven into existence by skilled hands. It invites you to experience the stories and traditions of South Africa, offering a comfortable and culturally rich addition to any living space. With “Heritage Haven,” you bring home a piece of South African heritage, celebrating the beauty and resilience of its artistry.", "Heritage Haven Couch" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "“Zulu Elegance Ensemble” by Thuso Taylors is a sartorial masterpiece that captures the essence of South African heritage and modern sophistication. This men’s suit, with its intricate patterns and vibrant colors, is a testament to the skilled craftsmanship and cultural richness of the region.\r\n\r\nThuso Taylors, a distinguished atelier based in Johannesburg, has been at the forefront of South African fashion for over two decades. Founded by the visionary designer Thuso Mokoena, the atelier draws inspiration from the diverse cultures and landscapes of South Africa. Thuso’s designs are renowned for their fusion of traditional motifs with contemporary silhouettes, creating pieces that are both timeless and modern.\r\n\r\nThe “Zulu Elegance Ensemble” features a tailored suit with patterns inspired by ancient Zulu art. The geometric shapes and bold colors reflect the vibrant energy of South African culture, from the rhythmic beats of traditional music to the dynamic movements of Zulu dance. The suit’s earthy tones, accented by pops of color, evoke the natural beauty of the African landscape, from the golden savannahs to the lush valleys.\r\n\r\nThis suit is more than just attire; it is a celebration of South African artistry brought to life through fashion. Each stitch tells a story of tradition and innovation, as local artisans meticulously weave cultural narratives into the fabric. The suit’s design pays homage to the rich history of the Zulu people, while also embracing the modern gentleman’s need for style and substance.\r\n\r\nWearing the “Zulu Elegance Ensemble” is an invitation to embrace the beauty and resilience of South African culture. Each design element is a tribute to the artisans who have mastered their craft over generations, echoing their connection to nature and community. This suit is a statement piece that carries within it the stories and traditions of South Africa, making every occasion a celebration of heritage and elegance.", "Zulu Elegance Ensemble" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "\"Little Safari Dream Dress” by Emma Embroiders is a delightful blend of tradition and whimsy, perfect for the young adventurer. This charming children’s dress features intricate embroidery that tells a story of South African heritage and craftsmanship.\r\n\r\nEmma Embroiders, a beloved atelier based in the vibrant city of Durban, has been creating beautiful, handcrafted garments for over two decades. Founded by Emma Ndlovu, the atelier is renowned for its dedication to preserving traditional embroidery techniques while infusing each piece with contemporary flair. Emma’s passion for her craft is evident in every stitch, as she draws inspiration from the rich cultural tapestry of South Africa.\r\n\r\nThe “Little Safari Dream Dress” is adorned with vibrant patterns and traditional African motifs, each symbol carrying a story of its own. The geometric shapes and earthy tones are reminiscent of the diverse landscapes and wildlife of the African plains. The dress is made from high-quality, comfortable fabric, ensuring that your little one can explore the world in style and comfort.\r\n\r\nThis dress is more than just clothing; it’s a piece of wearable art that celebrates the beauty and resilience of South African culture. Each design element is a tribute to the artisans who have mastered their craft over generations, echoing their connection to nature and community. The “Little Safari Dream Dress” invites your child to embark on a journey of discovery, wrapped in the stories and traditions of South Africa.", "Little Safari Dream Dress" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "“Sunset Serenade Gown” by Felicia Fashioners is a vibrant celebration of South African elegance and tradition. This full-length, strapless dress features a voluminous skirt adorned with intricate patterns in shades of red, yellow, gold, and brown, reminiscent of the breathtaking hues of an African sunset.\r\n\r\nFelicia Fashioners, a boutique atelier based in the heart of Cape Town, has been a beacon of South African haute couture for over two decades. Founded by the visionary designer Felicia Maseko, the atelier draws inspiration from the rich cultural heritage and diverse landscapes of South Africa. Felicia’s designs are renowned for their fusion of traditional motifs with contemporary silhouettes, creating pieces that are both timeless and modern.\r\n\r\nThe “Sunset Serenade Gown” is a testament to this unique blend. The geometric and organic shapes in the fabric are inspired by ancient tribal art, each symbol carrying a story of its own. The bold colors reflect the vibrant energy of local markets and the natural beauty of the African plains. The gown’s voluminous skirt and strapless bodice create a silhouette that is both dramatic and elegant, perfect for making a statement at any event.\r\n\r\nThis gown is not just a piece of clothing; it’s a work of art that embodies the spirit of South Africa. Each stitch is a tribute to the artisans who have mastered their craft over generations, echoing their connection to nature and community. Wearing the “Sunset Serenade Gown” is an invitation to embrace the rich tapestry of South African culture and style, making every occasion a celebration of heritage and beauty.", "Sunset Serenade Gown" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Paiting of African woman.", "Painting" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sculpture of African woman.", "Ornament" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A trio of African style mask statues.", "Masks" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Crescent shaped necklace.", "Necklace" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Supplier" },
                values: new object[] { "Ornate beaded bracelet.", "Bracelet", "Barend Beadwork" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Beaded necklace with intricate charm.", "Charmed Necklace" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Wooden stool with African pot atop.", "Stool and Vase" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Cabinet with bespoke pottery on display.", "Showcase" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sleek couch with African style fabric.", "Couch" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "", "Suit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "African style gown for girls.", "Gown" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Bespoke cascading Africa dress.", "Dress" });
        }
    }
}
