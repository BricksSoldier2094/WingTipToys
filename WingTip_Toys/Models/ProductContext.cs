using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WingTip_Toys.Models
{
    public class ProductContext : DbContext
    {

        public ProductContext() : base ("WingTipToys")
        {

        }

        public DbSet<CategoryModel> Categories { get; set; }

        public DbSet<ProductModel> Products { get; set; }

    }
}