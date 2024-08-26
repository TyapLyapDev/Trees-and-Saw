public class AddWorkerBuff : IBuffing
{
    public void Buff(Player player)
    {
        player.Sawmill.AddWorker();
    }
}
