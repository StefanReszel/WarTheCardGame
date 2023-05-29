using System.Net.Mail;

namespace WarTheCardGame;

public class Card
{
    private string[] suits = { "pik", "kier", "karo", "trefl" };
    private string[] values =
        { null, null, "2", "3", "4", "5", "6", "7", "8", "9", "10", "waleta", "damę", "króla", "asa" };

    public int value;
    public int suit;

    public Card(int value, int suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public static bool operator < (Card first_card, Card second_card)
    {
        if (first_card.value < second_card.value)
        {
            return true;
        }
        if (first_card.value == second_card.value)
        {
            if (first_card.suit < second_card.suit)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator >(Card first_card, Card second_card)
    {
        if (first_card.value > second_card.value)
        {
            return true;
        }
        if (first_card.value == second_card.value)
        {
            if (first_card.suit > second_card.suit)
            {
                return true;
            }
        }
        return false;
    }

    public override string ToString()
    {
        return this.values[this.value] + " " + this.suits[this.suit];
    }
}