namespace WarTheCardGame;

public class Game
{
    private string name1;
    private string name2;
    private Deck deck;
    private Player player_1;
    private Player player_2;
    
    public Game()
    {   
        Console.Write("Imię gracza 1: ");
        name1 = Console.ReadLine();
        Console.Write("Imię gracza 2: ");
        name2 = Console.ReadLine();

        deck = new Deck();
        player_1 = new Player(name1);
        player_2 = new Player(name2);
    }

    public void play_game()
    {
        Console.WriteLine("Zaczynamy rozgrywkę!");

        while (deck.outer_card >= 1)
        {
            Console.WriteLine("Naciśnij \"q\", aby zakończyć lub inny klawisz, aby kontynuować grę.");
            if (Console.ReadKey(false).Key == ConsoleKey.Q)
            {
                break;
            }
            
            player_1.card = deck.get_card();
            player_2.card = deck.get_card();
            drawing_prompt();
            if (player_1.card > player_2.card)
            {
                player_1.wins++;
                win_prompt(player_1.name);
            }
            else
            {
                player_2.wins++;
                win_prompt(player_2.name);
            }
        }
        string winner = this.winner();
        Console.WriteLine("Wojna skończona - wygrał {0}", winner);
    }

    private string winner()
    {
        if (player_1.wins > player_2.wins)
        {
            return player_1.name;
        }
        else if (player_1.wins < player_2.wins)
        {
            return player_2.name;
        }
        else
        {
            return "Jest remis!";
        }
    }

    private void win_prompt(string winner)
    {
        Console.WriteLine("Tę rundę wygrywa {0}", winner);
    }

    private void drawing_prompt()
    {
        Console.WriteLine("{0} wyciągnął {1}", player_1.name, player_1.card);
        Console.WriteLine("{0} wyciągnął {1}", player_2.name, player_2.card);
    }
}