using E_Shop.Data.Repositories;
using E_Shop.Models;

namespace E_Shop.Data
{
    public interface IEShopData
    {
        IRepository<User> Users { get; }
        IRepository<Product> Products { get; }
        IRepository<Category> Categories { get; }
        IRepository<ShoppingCart> ShoppingCarts { get; }

        int SaveChanges();
    }
}
