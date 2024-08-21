using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _treePrefabs;
    [SerializeField] private Transform _canvas;

    public static TreeManager Instance;

    private int _currentTreeIndex;

    private void Awake()
    {
        Instance = this;
        _currentTreeIndex = -1;
        SpawnTree();
    }

    public void ReplaceTree(GameObject tree)
    {
        Destroy(tree);
        SpawnTree();
    }

    private void SpawnTree()
    {
        _currentTreeIndex++;
        if(_currentTreeIndex < _treePrefabs.Length)
        {
            GameObject treeToSpawn = _treePrefabs[_currentTreeIndex];
            Instantiate(treeToSpawn, _canvas);
        }
    }
}