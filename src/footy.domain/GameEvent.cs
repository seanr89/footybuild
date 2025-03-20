public class GameEvent{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public List<Player> AllPlayers { get; set; } = [];
    public List<Team> Teams { get; set; } = [];
}