using System;
using UnityEngine;

public class Sawmill : MonoBehaviour
{
    public Worker[] Workers = new Worker[10];
    public static Sawmill Instance;

    private int _workersCount;
    private void Awake()
    {
        Instance = this;
    }
    public void AddWorker()
    {
        if (_workersCount == 10)
            throw new InvalidOperationException(" оличество работник не может быть больше 10ю");
        Workers[_workersCount++] = new Worker();
    }
}
public class Worker
{
    public int Level { get; private set; } = 1;
    public void LevelUp() => Level++;
}
