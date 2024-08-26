public class LevelUpBuff : IBuffing
{
    public void Buff(Player player)
    {
        player.LevelUp();
    }
}
