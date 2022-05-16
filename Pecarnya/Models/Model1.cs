using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pecarnya.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptWares> ReceiptWares { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Wares> Wares { get; set; }
        public virtual DbSet<WaresIngredients> WaresIngredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>()
                .HasMany(e => e.Wares)
                .WithOptional(e => e.Ingredients)
                .HasForeignKey(e => e.IngredientId);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptWares)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Receipt)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wares>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Wares>()
                .HasMany(e => e.ReceiptWares)
                .WithRequired(e => e.Wares)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wares>()
                .HasMany(e => e.WaresIngredients)
                .WithRequired(e => e.Wares)
                .WillCascadeOnDelete(false);
        }
    }
}
