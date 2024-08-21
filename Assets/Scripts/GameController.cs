using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    private int money;

    public static GameController instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void TreeClicked()
    //{
    //    money++;
    //    moneyText.SetText(money.ToString());
    //}
    public void AddMoney(int amount)
    {
        money += amount;
        moneyText.SetText(money.ToString());
    }
    public void PayMoney(int amount)
    {
        money -= amount;
        moneyText.SetText(money.ToString());
    }
}
