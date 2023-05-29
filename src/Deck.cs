using System.Net.Http.Headers;

namespace WarTheCardGame;

public class Deck
{
    public Card[] cards;
    public int outer_card;
    
    public Deck()
    {
        outer_card = 52;
        cards = new Card[52];
        int index = 0;

        for (int i = 2; i < 15; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cards[index] = new Card(i, j);
                index++;
            }
        }
        shuffle_cards();
    }

    public Card get_card()
    {
        outer_card--;
        if (outer_card < 0)
        {
            return null;
        }
        return cards[outer_card];
    }

    private void shuffle_cards()
    {
        Random random = new Random();
        cards = cards.OrderBy(x => random.Next()).ToArray();
    }
}