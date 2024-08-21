using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] GameObject[] treePrefabs;
    [SerializeField] Transform canvas;

    public static TreeManager instance;

    private Tree currentTree;
    private int currentTreeIndex;
    void Awake()
    {
        instance = this;
        currentTreeIndex = -1;
        SpawnTree();
    }
    public void SpawnTree()
    {
        currentTreeIndex++;
        if(currentTreeIndex < treePrefabs.Length)
        {
            GameObject treeToSpawn = treePrefabs[currentTreeIndex];
            GameObject obj = Instantiate(treeToSpawn, canvas);
            currentTree = obj.GetComponent<Tree>();
        }
    }
    public void ReplaceTree(GameObject tree)
    {
        Destroy(tree);
        SpawnTree();
    }
}
