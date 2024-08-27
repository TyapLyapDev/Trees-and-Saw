using System;
using UnityEngine;

public class TreeFabric : MonoBehaviour
{
    public static TreeFabric Instance;

    public Tree CurrentTree { get => _currentTree; }

    [SerializeField] private GameObject[] _treePrefabs;
    [SerializeField] private Transform _canvas;

    private int _currentTreeIndex;
    private Tree _currentTree;

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
            _currentTree = Instantiate(treeToSpawn, _canvas).gameObject.GetComponent<Tree>();
            SpawnNewTreeEvent.Instance?.Invoke(_currentTree);
        }
    }
}