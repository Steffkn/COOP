namespace E_Shop.Data
{
    using Models;
    using System.Data.Entity;

    public interface IEShopDbContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Product> Products { get; set; }
        IDbSet<Category> Categories { get; set; }
        IDbSet<ShoppingCart> ShoppingCarts { get; set; }

        int SaveChanges();
    }
}
