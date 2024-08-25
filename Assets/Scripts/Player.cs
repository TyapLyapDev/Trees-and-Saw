using UnityEngine;

public class Player : MonoBehaviour
{
    public Sawmill Sawmill;
    public static Player Instance;
    public float HitDamage { get; private set; }
    public int Level { get; private set; }

    private void Awake()
    {
        Instance = this;
        Sawmill = Sawmill.Instance;
    }
    public void AddDamage(float value) => HitDamage += value;
    public void MultiplyDamage(float value) => HitDamage *= value;
    public void LevelUp()
    {
        Level++;
        ///Что даёт?
    }
}