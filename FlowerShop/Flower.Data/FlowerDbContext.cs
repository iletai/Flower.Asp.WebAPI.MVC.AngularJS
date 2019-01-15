using Flower.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext() : base("FlowerConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }

        public DbSet<Menu> Menus { set; get; }

        public DbSet<MenuGroup> MenuGroups { set; get; }

        public DbSet<Order> Orders { set; get; }

        public DbSet<OrderDetail> OrderDetails { set; get; }

        public DbSet<Page> Pages { set; get; }

        public DbSet<Post> Posts { set; get; }

        public DbSet<PostCategory> PostCategorys { set; get; }

        public DbSet<PostTag> PostTags { set; get; }

        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategorys { set; get; }

        public DbSet<ProductTag> ProductTags { set; get; }

        public DbSet<Slide> Slides { set; get; }

        public DbSet<SupportOnline> SupportOnlines { set; get; }

        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<VistorStatic> VistorStatics { set; get; }

        public DbSet<Tag> Tags { set; get; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
