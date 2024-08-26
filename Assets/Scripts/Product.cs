public class Product
{
    public int Price { get; private set; }
    public IBuffing Buff { get; private set; }

    public Product(int price, IBuffing buff)
    {
        Price = price;
        Buff = buff;
    }
}
