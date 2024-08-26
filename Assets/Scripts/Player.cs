using UnityEngine;

public class Player
{
    public Sawmill Sawmill;

    public static Player Instance { 
        get
        {
            if(Instance == null)
                _instance = new Player();
            return _instance;
        } 
    }
    public float HitDamage { get; private set; }
    public int Level { get; private set; }

    private static Player _instance;

    private void Awake()
    {
        Sawmill = Sawmill.Instance;
    }

    public void AddDamage(float value) => HitDamage += value;

    public void MultiplyDamage(float value) => HitDamage *= value;

    public void LevelUp()
    {
        Level++;
        ///TODO
    }
}