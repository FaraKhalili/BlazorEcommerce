﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "When Oprah Winfrey speaks, the world listens. Health – both emotional and physical,and general wellness are the topics she often focuses upon. She is completely transparent with her own strugglesin these areas, allowing herself to be relatable whilst also inspiring change",
                            ImageUrl = "https://m.media-amazon.com/images/I/419htJJ1l5L._SX331_BO1,204,203,200_.jpg",
                            Price = 13.03m,
                            Title = "Oprah Winfrey: The Life, Lessons & Rules for Success"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Our earliest experiences shape our lives far down the road, and What Happened to You? provides powerful scientific and emotional insights into the behavioral patterns so many of us struggle to understand.",
                            ImageUrl = "https://m.media-amazon.com/images/I/41o9P29YcqL._SX328_BO1,204,203,200_.jpg",
                            Price = 15.99m,
                            Title = "What Happened to You : Conversations on Trauma, Resilience, and Healing"
                        },
                        new
                        {
                            Id = 3,
                            Description = "In this accessible and groundbreaking book--filled with the moving stories of real people--medical doctor and bestselling author Gabor Maté shows that emotion and psychological stress play a powerful role in the onset of chronic illness, including breast cancer, prostate cancer, multiple sclerosis and many others, even Alzheimer's disease.",
                            ImageUrl = "https://m.media-amazon.com/images/I/41Nwq227r4L._SX330_BO1,204,203,200_.jpg",
                            Price = 16.99m,
                            Title = "When the Body Says No: The Cost of Hidden Stress"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
