using ShoppingCartMicroservice.ShoppingCart;

public interface IShoppingCartStore
{
    ShoppingCart Get(int userId);
    void save(ShoppingCart shoppingCart);
}