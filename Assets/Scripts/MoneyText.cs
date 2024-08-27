using TMPro;
using UnityEngine;

public class MoneyText : MonoBehaviour
{
    private TextMeshProUGUI _moneyText;

    void Awake()
    {
        _moneyText = GetComponent<TextMeshProUGUI>();
        Wallet.Instance.OnMoneyChangedEvent += OnMoneyChanged;
    }

    private void OnMoneyChanged(int money)
    {
        _moneyText.SetText(money.ToString());

    }
}
