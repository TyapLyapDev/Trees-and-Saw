using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    [SerializeField] private Image _healthBarFill;
    [SerializeField] private int _totalHp;
    [SerializeField] private string _description;

    private int _hp;

    void Start()
    {
        _hp = _totalHp;
    }

    private void OnClick()
    {
        Hit();
    }

    private void Hit()
    {
        _hp--;
        _healthBarFill.fillAmount = (float)_hp / _totalHp;

        if (_hp <= 0)
        {
            CutDown(); 
        }
    }

    private void CutDown()
    {
        Wallet.Instance.AddMoney(_totalHp);
        TreeFabric.Instance.ReplaceTree(gameObject);
    }
}