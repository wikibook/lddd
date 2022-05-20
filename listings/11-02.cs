public class Player
{
    public Guid Id { get; private set; }
    public int Points { get; private set; }
}

public class ApplyBonus
{
    // ...

    public void Execute(Guid playerId, byte percentage)
    {
        var player = _repository.Load(playerId);
        player.Points *= 1 + percentage/100.0;
        _repository.Save(player);
    }
}