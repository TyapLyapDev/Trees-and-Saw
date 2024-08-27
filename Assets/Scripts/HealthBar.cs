using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthBarFill;

    private Tree _currentTree;

    private void Awake()
    {
        SpawnNewTreeEvent.Instance.AddListener(InitializeCurrentTree);
    }
    public void InitializeCurrentTree(Tree tree)
    {
        _currentTree = tree;
        _currentTree.OnTreeHpChangedEvent += OnTreeHpChanged;
    }
    private void OnTreeHpChanged(object sender, float curHp, float totalHp)
    {
        _healthBarFill.fillAmount = (float) curHp / totalHp;
    }
}
