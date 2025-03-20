

public class Team
{
    public string Name { get; set; }
    public List<Player> Players { get; set; } = new List<Player>();
    public Team(string name, List<Player> players)
    {
        Name = name;
        Players = players;
    }
}