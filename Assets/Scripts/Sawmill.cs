using System;
using UnityEngine;

public class Sawmill : MonoBehaviour
{
    const int MAX_WORKERS = 10;
    public Worker[] Workers = new Worker[MAX_WORKERS];
    public static Sawmill Instance;

    private int _workersCount;

    private void Awake()
    {
        Instance = this;
    }

    public void AddWorker()
    {
        if (_workersCount == MAX_WORKERS)
            throw new InvalidOperationException("You can't add more than 10 workers!");
        Workers[_workersCount++] = new Worker();
    }
}
