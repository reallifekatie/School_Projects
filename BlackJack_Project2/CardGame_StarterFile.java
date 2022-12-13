//
// Look for comments that are prefaced by the following character sequence: //***
// These comments will be your INSTRUCTIONS concerning the code that you need to write.
//
// NOTE ABOUT INSTRUCTIONS: variable names and method names referenced in the instructions
//    are placed in quotes for emphasis only. When using variable names and methods in your
//    code, you will not place them in quotes.
//
// Please remove all INSTRUCTION COMMENTS before submitting your
//    project to Moodle.
//
// ALL code that you are instructed to write MUST BE COMMENTED by you.
// Commenting your code is a significant part of your grade on this assignment.
//

import java.util.*;

public abstract class CardGame {

    //***
    //*** 1) Create four String constants per the following:
    //***    a) Constant name "SPADES" equal to string "Spades".
    //***    b) Constant name "HEARTS" equal to string "Hearts".
    //***    c) Constant name "DIAMONDS" equal to string "Diamonds".
    //***    d) Constant name "CLUBS" equal to string "Clubs".
    //***

    final String[] suits = {SPADES, HEARTS, DIAMONDS, CLUBS};

    //***
    //*** 2) Create four int constants per the following:
    //***    a) Constant name "ACE_NUM" equal to zero.
    //***    b) Constant name "JACK_NUM" equal to ten.
    //***    c) Constant name "QUEEN_NUM" equal to eleven.
    //***    d) Constant name "KING_NUM" equal to twelve.
    //*** 3) Create four String constants per the following:
    //***    a) Constant name "ACE_STR" equal to string "Ace".
    //***    b) Constant name "JACK_STR" equal to string "Jack".
    //***    c) Constant name "QUEEN_STR" equal to string "Queen".
    //***    d) Constant name "KING_STR" equal to string "King".
    //*** 4) Create four int constants per the following:
    //***    a) Constant name "ACE_SCORE" equal to eleven.
    //***    b) Constant name "JACK_SCORE" equal to ten.
    //***    c) Constant name "QUEEN_SCORE" equal to ten.
    //***    d) Constant name "KING_SCORE" equal to ten.
    //***

    private Map<Integer, String> rankMap = new HashMap<>();
    private Map<String, Integer> scoreMap = new HashMap<>();

    //***
    //*** 5) Create three private properties per the following:
    //***    a) First property is of datatype int and named "numberOfCardsInDeck".
    //***    b) Second property is of datatype int and named "cardsInSuit".
    //***    c) Third property is of datatype int and named "nextCard".
    //***       A) Assign the value of zero to "nextCard".
    //***

    private final ArrayList<Card> deck = new ArrayList<>();

    public Map<Integer, String> getRankMap() {
        return Collections.unmodifiableMap(rankMap);
    }

    //***
    //*** 6) Create a public getter for each of these three properties "numberOfCardsInDeck",
    //***    "cardsInSuit" and "nextCard" that just returns the property.
    //***    (Standard getter methods)
    //***

    public List<Card> getDeck() { return Collections.unmodifiableList(deck); }

    private void setRankMap(Map<Integer, String> rankMap) {
        this.rankMap = rankMap;
    }
    private void setScoreMap(Map<String, Integer> scoreMap) {
        this.scoreMap = scoreMap;
    }


    //***
    //*** 7) Create a private setter for each of these three properties "numberOfCardsInDeck",
    //***    "cardsInSuit" and "nextCard" that assigns the parameter variable to the property
    //***    and returns no value.
    //***    (Standard setter methods)
    //*** 8) Create a private method named "setDeck" that takes no arguments
    //***    and returns no value.
    //***    a) The method body consists of the following lines of code:
    //***       A) Declare a local variable of datatype int named "cardsInDeck".
    //***          1) Invoke the method "getNumberOfCardsInDeck" and assign its
    //***             return value to variable "cardsInDeck".
    //***       C) Invoke the method "clear" on property "deck".
    //***       D) Write a for-loop that iterates variable "cardsInDeck" times
    //***          [HINT: the for-loop's control variable needs to start at zero.]
    //***          and executes the following line of code:
    //***          1) Invoke the "add" method on property "deck" passing the
    //***             following as the one argument:
    //***             a) A new "Card" instance; passing the for-loop's control
    //***                variable to the "Card" constructor.
    //*** 9) From Project 1, modify the following method "dealCard" below as follows:
    //***    a) Declare a local variable of datatype int named "nextCardIndex".
    //***       A) Invoke the method "getNextCard" and assign its
    //***          return value to variable "nextCardIndex".
    //***    b) Declare a local variable of datatype "Card" named "nextCard" and
    //***       assign the following value to it:
    //***       A) Using the method invocation "getDeck()" as a reference
    //***          variable, invoke the method "get" passing the variable
    //***          "nextCardIndex" as the one argument.
    //***    c) From Project 1, modify this line of code:
    //***          p.addCard2Hand(new Card(1));
    //***       to pass the variable "nextCard" to method "addCard2Hand" instead.
    //***    d) Invoke method "setNextCard" passing the "prefix increment"
    //***       (also known as "preincrement") of variable "nextCardIndex" as the
    //***       one argument.
    //***

    public void dealCard(Player p) {
        p.addCard2Hand(new Card(1));
    }

    public void shuffleDeck() {

        //***
        //*** 10) Declare a local variable of datatype int named "cardsInDeck".
        //***     a) Invoke the method "getNumberOfCardsInDeck" and assign its
        //***        return value to variable "cardsInDeck".
        //*** 11) Declare a local variable of datatype int named "index".
        //*** 12) Declare a local variable of datatype "Card" named "temp".
        //*** 13) Write a for-loop that iterates variable "cardsInDeck" times
        //***     [HINT: The for-loop's control variable needs to start at zero]
        //***           and executes the following four lines of code:
        //***     a) Invoke the "random" method on Class "Math" and multiply it
        //***        by variable "cardsInDeck". Wrap this in parentheses.
        //***     b) Cast the value from the previous Step to datatype int.
        //***     c) Assign the value from the previous two Steps to variable "index".
        //***     NOTE: Steps a, b, & c are together just one line of code.
        //***     d) Assign the following to variable "temp":
        //***        A) Invoke the "get" method on property "deck" passing the
        //***           for-loop's control variable as the one argument.
        //***        B) Invoke the "set" method on property "deck" passing the
        //***           for-loop's control variable as the first argument, and
        //***           passing the following as the second argument:
        //***           1) Invoke the "get" method on property "deck" passing the
        //***              variable "index" as the one argument .
        //***        C) Invoke the "set" method on property "deck" passing the
        //***           variable "index" as the first argument, and passing the
        //***           variable "temp" as the second argument.
        //***

    }

    public CardGame(int numCards) {

        //***
        //*** 14) Invoke method "setNumberOfCardsInDeck" passing the parameter
        //***     variable "numCards" as the one argument.
        //*** 15) Invoke method "setCardsInSuit" passing the following expression
        //***     as the one argument:
        //***     a) Parameter variable "numCards" divided by the length of array "suits".
        //***        NOTE: DO NOT hard-code the length of array "suits" in the expression.
        //***        HINT: Refer to Chapter 7 section 7.2.3 to obtain an array's size.
        //***

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

        //***
        //*** 16) Invoke the method "setDeck".
        //***

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

            //***
            //*** 17) Declare a local variable of datatype int named "rankNum" and
            //***     assign the following expression to it:
            //***     a) Parameter variable "cardNum" modulus property "cardsInSuit".
            //***        HINT: You can directly reference property "cardsInSuit" here
            //***              because it is visible from this inner class.
            //***

            if (rankMap.containsKey(rankNum))
                setRank(rankMap.get(rankNum));
            else
                setRank(String.valueOf(rankNum + 1));

            //***
            //*** 18) Invoke method "setSuit" passing as the one argument the array
            //***     "suits" which is indexed using the following expression:
            //***     a) Parameter variable "cardNum" divided by property "cardsInSuit".
            //***        HINT: You can directly reference property "cardsInSuit" here
            //***              because it is visible from this inner class.
            //***

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

        //***
        //*** 19) Create a public method named "getCard" that takes one argument
        //***     and returns a value of datatype "Card".
        //***     a) The one argument is of datatype int and named "cardIndex".
        //***     b) Write a return statement that returns the following expression:
        //***        A) Invoke the "get" method on property "hand" passing the variable
        //***           "cardIndex" as the one argument.
        //*** 20) Create a public method named "addCard2Hand" that takes one argument
        //***     and returns no value.
        //***     a) The one argument is of datatype "Card" and named "c".
        //***     b) The method body consists of the following lines of code:
        //***        A) Invoke the "add" method on property "hand" passing the variable
        //***           "c" as the one argument.
        //***        B) Invoke method "setCurrentScore" passing the following expression
        //***           as the one argument:
        //***           1) Invoke the method "getCurrentScore" plus (+) invoke the method
        //***              "getScore" on parameter variable "c".
        //*** 21) Create a public method named "displayFormattedHand" that takes no
        //***     arguments and returns no value.
        //***     a) The method body consists of the following for-loop:
        //***     b) Write a for-loop that iterates the size of array "hand" times
        //***          [HINT: the for-loop's control variable needs to start at zero.]
        //***          and executes the following line of code:
        //***        A) Send the following Steps to the Console using a println statement.
        //***        B) Invoke the "get" method on property "hand" passing the for-loop's
        //***           control variable as the one argument.
        //***        C) Using the code from the previous Step (B) as the reference variable,
        //***           invoke method "toString".
        //***        NOTE: Steps A, B, & C are together just one line of code.
        //*** 22) Create a public no-arg constructor for class "Player".
        //***     a) The method body consists of four lines of code as follows:
        //***        A) Declare a variable of datatype Scanner named "input", and
        //***           assign a new Scanner instance from the console to it.
        //***        B) Display the following message to the console; keeping the
        //***           cursor on the same line as the message.
        //***               "Please enter your name: "
        //***        C) Declare a local variable of datatype String named "playerName".
        //***        D) Invoke the "nextLine" on the variable "input" and assign the
        //***           return value to variable "playerName".
        //***        E) Invoke the "setName" method passing the variable "playerName"
        //***           as the one argument.
        //***

        public Player(String name) {
            setName(name);
        }
    }

    public abstract void determineOutcome(Player p, Player d);
}