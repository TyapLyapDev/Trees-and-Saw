using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyText;
    
    public static GameController Instance;

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

    private void PayMoney(int amount)
    {
        _money -= amount;
        _moneyText.SetText(_money.ToString());
    }
}