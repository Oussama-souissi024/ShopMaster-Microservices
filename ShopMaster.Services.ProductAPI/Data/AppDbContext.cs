using Microsoft.EntityFrameworkCore;
using ShopMaster.Services.ProductAPI.Models;

namespace ShopMaster.Services.ProductAPI.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Clavier Mécanique RGB",
                Price = 89.99,
                Description = "Clavier mécanique avec rétroéclairage RGB personnalisable, idéal pour le gaming et la bureautique. Conception robuste et touches programmables.",
                ImageUrl = "https://www.cdiscount.com/pdt2/7/0/4/1/700x700/tra1699540317704/rw/clavier-mecanique-sans-fil-65-bluetooth-5-0-2-4gh.jpg",
                CategoryName = "Périphérique"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Souris Gamer 7 Boutons",
                Price = 49.99,
                Description = "Souris ergonomique avec 7 boutons programmables, capteur haute précision, idéale pour les joueurs professionnels.",
                ImageUrl = "https://www.alarabia.com.tn/19082-large_default/souris-filaire-gamer-spirit-s-pm7-rgb-7-boutons.jpg",
                CategoryName = "Périphérique"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Écran LED Full HD 24\"",
                Price = 159.99,
                Description = "Écran LED de 24 pouces avec résolution Full HD, offrant des couleurs éclatantes et des angles de vision larges pour un usage polyvalent.",
                ImageUrl = "https://mk-media.mytek.tn/media/catalog/product/cache/8be3f98b14227a82112b46963246dfe1/e/c/ecran-samsung-lf24t350fhmxzn-24-full-hd-75hz.jpg",
                CategoryName = "Affichage"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Ordinateur Portable i5",
                Price = 699.99,
                Description = "Ordinateur portable équipé d'un processeur Intel i5, 8 Go de RAM, et un SSD de 256 Go pour une performance optimale dans toutes les tâches.",
                ImageUrl = "https://mtsplus.tn/2607-large_default/pc-portable-asus-i5-11e-gen-8go-512go-ssd-mx330-x515ep-br245t.jpg",
                CategoryName = "Ordinateur"
            });

        }
    }
}
