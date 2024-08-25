using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Player _player;

    private List<Product> _products = new();

    void Awake()
    {
        _player = Player.Instance;
        _products = new() {
        new Product(100, new AddDamageBuff(1)),
        new Product(150, new MultiplyDamageBuff(1.05f)),
        new Product(300, new LevelUpBuff()),
        new Product(350, new AddWorkerBuff())
        };
    }
}
public class Product
{
    public int Price { get; private set; }
    public IBuffing Buff { get; private set; }
    public Product(int price, IBuffing buff)
    {
        this.Price = price;
        this.Buff = buff;
    }
}
public interface IBuffing
{
    public void Buff(Player player);
}
public class AddDamageBuff : IBuffing
{
    public float Value { get; set; }
    public AddDamageBuff(float value)
    {
        this.Value = value;
    }
    public void Buff(Player player)
    {
        player.AddDamage(Value);
    }
}
public class MultiplyDamageBuff : IBuffing
{
    public float Value { get; set; }
    public MultiplyDamageBuff(float value)
    {
        this.Value = value;
    }
    public void Buff(Player player)
    {
        player.MultiplyDamage(Value);
    }
}
public class LevelUpBuff : IBuffing
{
    public void Buff(Player player)
    {
        player.LevelUp();
    }
}
public class AddWorkerBuff : IBuffing
{
    public void Buff(Player player)
    {
        player.Sawmill.AddWorker();
    }
}
