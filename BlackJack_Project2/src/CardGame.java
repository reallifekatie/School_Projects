import java.util.*;

public abstract class CardGame {

    // four new constants declared and initialized to be the string equivalent of the constant's name
    final String SPADES = "Spades";
    final String HEARTS = "Hearts";
    final String DIAMONDS = "Diamonds";
    final String CLUBS = "Clubs";

    final String[] suits = {SPADES, HEARTS, DIAMONDS, CLUBS};

    // four new constants declared and initialized to be the int value of each face card
    final int ACE_NUM = 0;
    final int JACK_NUM = 10;
    final int QUEEN_NUM = 11;
    final int KING_NUM = 12;

    // four new constants declared and initialized to the string equivalent of each constant's name
    final String ACE_STR = "Ace";
    final String JACK_STR = "Jack";
    final String QUEEN_STR = "Queen";
    final String KING_STR = "King";

    // four new constants declared and initialized to the int score value of each face card
    final int ACE_SCORE = 11;
    final int JACK_SCORE = 10;
    final int QUEEN_SCORE = 10;
    final int KING_SCORE = 10;

    private Map<Integer, String> rankMap = new HashMap<>();
    private Map<String, Integer> scoreMap = new HashMap<>();

    // three private int variables declared; one initialized
    private int numberOfCardsInDeck;
    private int cardsInSuit;
    private int nextCard = 0;

    private final ArrayList<Card> deck = new ArrayList<>();

    public Map<Integer, String> getRankMap() {
        return Collections.unmodifiableMap(rankMap);
    }

    // declaration of public getter for numberOfCardsInDeck; returning that variable's value
    public int getNumberOfCardsInDeck() {
        return numberOfCardsInDeck;
    }
    // declaration of public getter for cardsInSuite; returning that variable's value
    public int getCardsInSuit() {
        return cardsInSuit;
    }
    // declaration of public getter for nextCard; returning that variable's value
    public int getNextCard() {
        return nextCard;
    }

    public List<Card> getDeck() { return Collections.unmodifiableList(deck); }

    private void setRankMap(Map<Integer, String> rankMap) {
        this.rankMap = rankMap;
    }
    private void setScoreMap(Map<String, Integer> scoreMap) {
        this.scoreMap = scoreMap;
    }

    // creation of private setters for numberOfCardsInDeck, cardsInSuit, and nextCard
    // each setter sets it's value
    private void setNumberOfCardsInDeck(int c) {
        this.numberOfCardsInDeck = c;
    }
    private void setCardsInSuit(int s) {
        this.cardsInSuit = s;
    }
    private void setNextCard(int n) {
        this.nextCard = n;
    }

    // creation of private method to setDeck
    // for loop iterates over the number of cards in the deck
    private void setDeck() {
        int cardsInDeck = getNumberOfCardsInDeck();
        deck.clear();
        for (int i = 0; i < cardsInDeck; i++) {
            deck.add(new Card(i));
        }
    }

    // creation of dealCard method
    // declaration and initialization of nextCardIndex variable and assign to it the getNextCard method
    // declaration and initialization of nextCard variable of Card datatype
        // assigned to it is the get method on getDeck method as reference; the nextCardIndex is passed as argument
    // addCard2Hand method is called on reference variable p; passing nextCard variable as argument
    // call to setNextCard setter; passing the pre-increment variable of nextCardIndex as arugment
    public void dealCard(Player p) {
        int nextCardIndex = getNextCard();
        Card nextCard = getDeck().get(nextCardIndex);
        p.addCard2Hand(nextCard);
        setNextCard(++nextCardIndex);
    }

    public void shuffleDeck() {

        // declaration of local variable cardsInDeck of int datatype
            // assigned to it is the getter for numberOfCardsInDeck
        int cardsInDeck = getNumberOfCardsInDeck();
        int index;
        Card temp;
        // for loop iterates over the cardsInDeck variable and assigns them to deck reference variable using set method
        for (int i = 0; i < cardsInDeck; i++) {
            index = (int)(Math.random() * cardsInDeck);
            temp = deck.get(i);
            deck.set(i, deck.get(index));
            deck.set(index, temp);
        }

    }

    public CardGame(int numCards) {

        // invoked method setNumberOfCardsInDeck and passed numCards as argument
        // invoked method setCardsInSuit and passed into it the number of cards divided by the length of suits array
        setNumberOfCardsInDeck(numCards);
        setCardsInSuit(numCards / suits.length);

        Map<Integer, String> rankMap = new HashMap<>();
        rankMap.put(ACE_NUM, ACE_STR);
        rankMap.put(JACK_NUM, JACK_STR);
        rankMap.put(QUEEN_NUM, QUEEN_STR);
        rankMap.put(KING_NUM, KING_STR);

        this.setRankMap(rankMap);

        Map<String, Integer> scoreMap = new HashMap<>();
        scoreMap.put(ACE_STR, ACE_SCORE);
        scoreMap.put(JACK_STR, JACK_SCORE);
        scoreMap.put(QUEEN_STR, QUEEN_SCORE);
        scoreMap.put(KING_STR, KING_SCORE);

        this.setScoreMap(scoreMap);

        // invoked setDeck method
        setDeck();

    }

    public class Card {
        private String rank;
        private String suit;
        private int score;

        public String getRank() {
            return rank;
        }
        public String getSuit() {
            return suit;
        }
        public int getScore() {
            return score;
        }

        private void setRank(String rank) {
            this.rank = rank;
        }
        private void setSuit(String suit) {
            this.suit = suit;
        }
        private void setScore(int score) {
            this.score = score;
        }

        public Card(int cardNum) {

            // declaration and initialization of rankNum variable of int datatype
                // assigned to rankNum is the remainder of the number of cards divided by the number of cards in a suit
            int rankNum = cardNum % cardsInSuit;

            if (rankMap.containsKey(rankNum))
                setRank(rankMap.get(rankNum));
            else
                setRank(String.valueOf(rankNum + 1));

            // invoked the setSuit method and passed as it's argument the suits array
                // the index of the suits array is the card number divided by the cardsInSuit variable
            setSuit(suits[cardNum / cardsInSuit]);

            if (scoreMap.containsKey(getRank()))
                setScore(scoreMap.get(getRank()));
            else
                setScore(rankNum + 1);
        }

        @Override
        public String toString() {
            return "\t" + rank + " of " + suit;
        }
    }

    public static class Player {
        private String name;
        private int currentScore;
        private final ArrayList<Card> hand = new ArrayList<>();

        public String getName() {
            return name;
        }
        public int getCurrentScore() {
            return currentScore;
        }
        public List<Card> getHand() {
            return Collections.unmodifiableList(hand);
        }

        private void setName(String name) {
            this.name = name;
        }
        private void setCurrentScore(int currentScore) {
            this.currentScore = currentScore;
        }

        // declaration of getCard public method
            // int datatype of cardIndex is passed as argument
        // this method return value is the get method call on reference variable hand, passing the cardIndex as argument
        public Card getCard(int cardIndex) {
            return hand.get(cardIndex);
        }
        // declaration of addCard2Hand public method
        // this method invokes the add method on hand reference variable, passing as argument the variable declared in method
        // the setCurrentScore method is called which adds the current score to the new score
        public void addCard2Hand(Card c) {
            hand.add(c);
            setCurrentScore(getCurrentScore() + c.getScore());
        }
        // creation of public method displayFormattedHand
        // for loop iterates over the size of hand and outputs to console as a string
        public void displayFormattedHand() {
            for (int i = 0; i < hand.size(); i++) {
                System.out.println(hand.get(i).toString());
            }
        }

        // creation of public no-arg constructor for Player class
        // new scanner object created to contain the user's input
        // the playerName variable is declared as a string and initialized to the user's input
        // setName method is called and the user's input is passed as argument
        public Player() {
            Scanner input = new Scanner(System.in);
            System.out.println("Please enter your name: ");
            String playerName = input.nextLine();
            setName(playerName);
        }

        public Player(String name) {
            setName(name);
        }
    }

    public abstract void determineOutcome(Player p, Player d);
}