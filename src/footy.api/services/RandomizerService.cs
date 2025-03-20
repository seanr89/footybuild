
public class RandomizerService
{
    private readonly Random _random = new();
    public RandomizerService()
    {
        
    }

    public GameEvent CreateRandomPlayerGroups(List<Player> players, int teamCount = 2)
    {
        players = players.OrderBy(x => _random.Next()).ToList();
        var chunked = players.Chunk(players.Count / teamCount).ToList();
        var defaultTeams = new List<Team>();
        for(int i = 0; i < teamCount; i++)
        {
            defaultTeams.Add(new Team($"Team {i + 1}", chunked[i].ToList()));
        }

        return new GameEvent
        {
            Name = "Random Player Groups",
            Description = "Randomly generated player groups",
            Location = "Online",
            AllPlayers = players,
            Teams = defaultTeams
        };
    }
}