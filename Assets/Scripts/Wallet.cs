using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;

    public static Wallet Instance;

    private int _money;
    private void Awake()
    {
        Instance = this;
    }
    public void AddMoney(int amount)
    {
        _money += amount;
        _moneyText.SetText(_money.ToString());
    }
    public void SpentMoney(int price)
    {
        if(_money>=price)
        _money -= price;
        _moneyText.SetText(_money.ToString());
    }

}
