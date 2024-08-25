using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    [SerializeField] private Image _healthBarFill;
    [SerializeField] private int _totalHp;

    private int _hp;

    void Start()
    {
        _hp = _totalHp;
    }

    private void OnMouseDown()
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
        GameController.Instance.AddMoney(_totalHp);
        TreeManager.Instance.ReplaceTree(gameObject);
    }
}