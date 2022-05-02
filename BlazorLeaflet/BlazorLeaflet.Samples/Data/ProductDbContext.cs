using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLeaflet.Samples.Data
{
    public class ProductDbContext : DbContext
    {
        #region Contructor
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Product> Product { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Product> GetProducts()
        {
            return new List<Product>
    {
       
    };
        }
        #endregion
    }
}
