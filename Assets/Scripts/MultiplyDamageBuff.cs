public class MultiplyDamageBuff : IBuffing
{
    public float Value { get; set; }

    public MultiplyDamageBuff(float value)
    {
        this.Value = value;
    }

    public void Buff(Player player)
    {
        player.MultiplyDamage(Value);
    }
}
