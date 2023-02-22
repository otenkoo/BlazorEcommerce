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
                    Title = "Super Smash Brothers: Melee",
                    Description = "Nintendo GameCube platform fighting game.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/75/Super_Smash_Bros_Melee_box_art.png",
                    Price = 9.99m
                },
                new Product
                {
                Id = 2,
                Title = "MegaMan Legends",
                Description = "First 3D open world RPG-style MegaMan Game on PS1 and N64",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Rockman_DASH_re-release_cover_art.jpg",
                Price = 8.99m
                },
                new Product
                {
                Id = 3,
                Title = "Boktai: The Sun Is in Your Hand!",
                Description = "Top-down JRPG where Solar Boy Django takes on Immortal Vampires",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f0/Boktai_cover_art.jpg",
                Price = 7.99m
                }
              );
        }

        public DbSet<Product> Products { get; set; }
    }
}
