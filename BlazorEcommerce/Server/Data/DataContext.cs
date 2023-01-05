namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Oprah Winfrey: The Life, Lessons & Rules for Success",
                    Description = "When Oprah Winfrey speaks, the world listens. Health – both emotional and physical," +
            "and general wellness are the topics she often focuses upon. She is completely transparent with her own struggles" +
            "in these areas, allowing herself to be relatable whilst also inspiring change",
                    ImageUrl = "https://m.media-amazon.com/images/I/419htJJ1l5L._SX331_BO1,204,203,200_.jpg",
                    Price = 13.03m
                },
                new Product
                {
                    Id = 2,
                    Title = "What Happened to You : Conversations on Trauma, Resilience, and Healing",
                    Description = "Our earliest experiences shape our lives far down the road, and What Happened to You? provides powerful scientific and emotional insights into the behavioral patterns so many of us struggle to understand.",
                    ImageUrl = "https://m.media-amazon.com/images/I/41o9P29YcqL._SX328_BO1,204,203,200_.jpg",
                    Price = 15.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "When the Body Says No: The Cost of Hidden Stress",
                    Description = "In this accessible and groundbreaking book--filled with the moving stories of real people--medical doctor and bestselling author Gabor Maté shows that emotion and psychological stress play a powerful role in the onset of chronic illness, including breast cancer, prostate cancer, multiple sclerosis and many others, even Alzheimer's disease.",
                    ImageUrl = "https://m.media-amazon.com/images/I/41Nwq227r4L._SX330_BO1,204,203,200_.jpg",
                    Price = 16.99m
                });
        }
        public DbSet<Product> Products { get; set; }
    }
}
