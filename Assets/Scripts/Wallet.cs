using System;

public class Wallet
{
    public event Action<int> OnMoneyChangedEvent;

    public static Wallet Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Wallet();
            return _instance;
        }
    }

    private static Wallet _instance;
    private int _money;

    public void AddMoney(int amount)
    {
        _money += amount;
        OnMoneyChangedEvent?.Invoke(_money);
    }

    public void SpentMoney(object sender, int price)
    {
        if (IsEnoughMoney(price))
        {
            _money -= price;
            OnMoneyChangedEvent?.Invoke(_money);
        } 
    }
    public bool IsEnoughMoney(int price) => price <= _money;
}
