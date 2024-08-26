using System;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    public event Action<object, float, float> OnTreeHpChangedEvent;

    [SerializeField] private int _totalHp;
    [SerializeField] private string _description;
    [SerializeField] private int _award;
    [SerializeField] private int _level;
    private int _hp;

    void Start()
    {
        _hp = _totalHp;
    }

    private void Hit()
    {
        _hp--;
        OnTreeHpChangedEvent?.Invoke(this, _hp, _totalHp);
        if (_hp <= 0)
        {
            CutDown(); 
        }
    }

    private void CutDown()
    {
        Wallet.Instance.AddMoney(this, _totalHp);
        TreeFabric.Instance.ReplaceTree(gameObject);
    }
}