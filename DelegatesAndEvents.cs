namespace revision;

public static class DelegatesAndEvents
{
    public static void Run()
    {
        Player p1 = new();
        Achievement achievement1 = new();
        achievement1.Register(p1);
        p1.AddPoints(50);
        p1.AddPoints(60);
        p1.AddPoints(60);
        p1.AddPoints(60);
    }
}


public delegate void PointsReachedHandler(int totalPoints);

file class Player
{
    private int _points;
    
    private bool _hundredPointsReached = false;
    private bool _twoHundredPointsReached = false;
    
    public event PointsReachedHandler? OnHundredPoints;
    public event PointsReachedHandler? OnTwoHundredPoints;

    public void AddPoints(int amount)
    {
        _points += amount;
        if (_points >= 200 && !_twoHundredPointsReached)
        {
            OnTwoHundredPoints?.Invoke(_points);
            _twoHundredPointsReached = true;
        }

        if (_points >= 100 && !_hundredPointsReached)
        {
            OnHundredPoints?.Invoke(_points);
            _hundredPointsReached = true;
        }
        
    }
}

file class Achievement
{
    public void Register(Player player)
    {
        player.OnHundredPoints += Achieved;
        player.OnTwoHundredPoints += Achieved;
    }

    private static void Achieved(int totalPoints)
    {
        Console.WriteLine($"Achievement unlocked at {totalPoints} points!");
    }

}
