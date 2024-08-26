public class AddDamageBuff : IBuffing
{
    public float Value { get; set; }

    public AddDamageBuff(float value)
    {
        this.Value = value;
    }

    public void Buff(Player player)
    {
        player.AddDamage(Value);
    }
}
