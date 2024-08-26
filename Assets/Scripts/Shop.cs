using System.Collections.Generic;

public class Shop
{
    public static Shop Instance
    {
        get
        {
            if(_instance == null)
                _instance = new Shop();
            return _instance;
        }
    }

    private static Shop _instance;
    private Player _player;
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
