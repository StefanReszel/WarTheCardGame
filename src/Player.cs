namespace WarTheCardGame;

public class Player
{
    public int wins;
    public Card card;
    public string name;
    
    public Player(string name)
    {
        this.name = name;
        wins = 0;
        card = null;
    }
}