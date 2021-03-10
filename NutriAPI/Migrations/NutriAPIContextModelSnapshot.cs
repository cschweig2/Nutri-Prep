﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriAPI.Models;

namespace NutriAPI.Migrations
{
    [DbContext(typeof(NutriAPIContext))]
    partial class NutriAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NutriAPI.Models.Supplement", b =>
                {
                    b.Property<int>("SupplementId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contraindications")
                        .IsRequired();

                    b.Property<string>("Dosing")
                        .IsRequired();

                    b.Property<string>("Maladies")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("SupplementId");

                    b.ToTable("Supplements");

                    b.HasData(
                        new
                        {
                            SupplementId = 1,
                            Contraindications = "Milk Thistle may lower blood sugar levels in people with type 2 diabetes. Those with allergies to plants in the same family as Milk Thistle (ragweed, marigold, etc.) may experience a reaction.",
                            Dosing = "According to research, the therapeutic threshold may be around 225mg per day.",
                            Maladies = "Liver Health, Skin Health, Blood Sugar Support, Detox Support",
                            Name = "Milk Thistle",
                            Type = "Herb"
                        },
                        new
                        {
                            SupplementId = 2,
                            Contraindications = "Preformed Vitamin A (as opposed to provitamin A as beta-carotene, which is water-soluble) is fat-soluble, which means that it can accumulate in the body and cause potential toxicity. If you are concerned about this, consult a physician about what dose is right for you.",
                            Dosing = "Consult this webpage to find your appropriate dosing: https://ods.od.nih.gov/factsheets/VitaminA-HealthProfessional/. Keep in mind that Vitamin A is stored in the body long-term, and therefore accumulates. For optimal health, ",
                            Maladies = "Skin Health, Immune System Support, Eye Health, Antioxidant Support",
                            Name = "Vitamin A",
                            Type = "Vitamin"
                        },
                        new
                        {
                            SupplementId = 3,
                            Contraindications = "High doses taken long-term (over a 20-month period) may lead to: hypoglycemia, weakness, shakiness, excessive sweating, or muscular dystrophy. This should also not be taken alongside blood-sugar-lowering medications unless prescribed by your doctor.",
                            Dosing = "According to Dr. Axe, a general recommended gymnema sylvestre dosage is a 100-milligram capsule, taken up to four times daily. It’s best to start with one capsule and gradually increase your dose, paying attention to any adverse effects.",
                            Maladies = "Blood Sugar Support",
                            Name = "Gymnema Sylvestre",
                            Type = "Herb"
                        },
                        new
                        {
                            SupplementId = 4,
                            Contraindications = "Research suggests that toxicity does not occur until you have reached above 80 ng/mL AND blood calcium levels increase. Vitamin D can be taken with any other vitamin or herb.",
                            Dosing = "Dosing can range from 500IU to upwards of 25,000IU. This will depend on your current Vitamin D status. A doctor can order a blood test to find this out. Optimal Vitamin D levels in the body are 40-65 ng/mL.",
                            Maladies = "Bone Health, Immune System Support, Hormone Balance",
                            Name = "Vitamin D",
                            Type = "Vitamin"
                        },
                        new
                        {
                            SupplementId = 5,
                            Contraindications = "Dandelion can interact with certain drugs by affecting how the drug is absorbed into the bloodstream, metabolized by the liver, or cleared from the body via the kidneys. Consult your physician before use if you are currently taking prescription medications.",
                            Dosing = "European Commission and the British Herbal Pharmacopoeia recommend 2-8 grams of dandelion root daily safe. For fresh root extracts, 1-2 tablespoons daily. For dried extract, .75 to 1 gram daily.",
                            Maladies = "Detox Support, Liver Health",
                            Name = "Dandelion Root",
                            Type = "Herb"
                        },
                        new
                        {
                            SupplementId = 6,
                            Contraindications = "Some bentonite clay products contain trace amounts of heavy metals and may not be suitable for pregnant women and children. Do not take in large quantities, this could cause harmful disruption of normal digestion and the absorption of nutrients.",
                            Dosing = "Generally, 1/2 to 1 tsp per day is well tolerated. Always use products according to their instructions.",
                            Maladies = "Detox Support, Digestive Health",
                            Name = "Bentonite Clay",
                            Type = "Herb"
                        },
                        new
                        {
                            SupplementId = 7,
                            Contraindications = "Consult your physician before use if you have a diagnosed digestive issue such as IBS, IBD, Crohns Disease, etc.",
                            Dosing = "No established dose. Use as directed on the supplement bottle. Generally taken before each meal to stimulate digestion.",
                            Maladies = "Digestive Health",
                            Name = "Bitters",
                            Type = "Herb"
                        },
                        new
                        {
                            SupplementId = 8,
                            Contraindications = "None established.",
                            Dosing = "No established dose. Use as directed on the supplement bottle. It's important to note that the body produces HMB naturally, but additional supplementation may benefit body-building efforts.",
                            Maladies = "Athletic Performance",
                            Name = "Hydroxymethylbutyrate (HMB)",
                            Type = "Miscellanous Nutrient"
                        },
                        new
                        {
                            SupplementId = 9,
                            Contraindications = "Consult your physician before use if you are currently on any blood pressure medications.",
                            Dosing = "No established dose. Use as directed on the supplement bottle.",
                            Maladies = "Athletic Performance, Heart Health",
                            Name = "Beet Root Powder",
                            Type = "Herb"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
