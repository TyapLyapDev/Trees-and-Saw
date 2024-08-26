using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarFill;
    [SerializeField] TreeFabric _treeFabric;

    private Tree _currentTree;

    private void Awake()
    {
        _treeFabric.OnNewTreeEvent += InitializeCurrentTree;
    }
    public void InitializeCurrentTree(object sender, Tree tree)
    {
        _currentTree = tree;
        _currentTree.OnTreeHpChangedEvent += OnTreeHpChanged;
    }
    private void OnTreeHpChanged(object sender, float curHp, float totalHp)
    {
        _healthBarFill.fillAmount = (float) curHp / totalHp;
    }
}
