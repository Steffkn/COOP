using E_Shop.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace E_Shop.Data
{
    public class EShopDbContext : IdentityDbContext<User>
    {
        public EShopDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public IDbSet<User> Users { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<ShoppingCart> ShoppingCarts { get; set; }

        public static EShopDbContext Create()
        {
            return new EShopDbContext();
        }
    }
}
