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
//***
//*** INSTRUCTIONS FOR CODE FOR YOU TO WRITE
//***

public abstract class CardGame {
    public void dealCard(Player p) {
        p.addCard2Hand(new Card(1));
    }
    public void shuffleDeck() {
    }
    public CardGame(int numCards) {
    }
    public abstract void determineOutcome(Player p, Player d) {
    }
    public class Card {
        private String rank;
        private String suit;
        private int score;

        public getRank() {
            return rank;
        }
        public getSuit() {
            return suit;
        }
        public getScore() {
            return score;
        }
        private void setRank(String r) {
            this.rank = r;
        }
        private void setSuit(String s) {
            this.suit = s;
        }
        private void setScore(int c) {
            this.score = c;
        }
        public Card(int numCards) {
        }
    }

}

//*** 1) Define a public abstract class named "CardGame".
//*** 2) Inside class "CardGame", include the following:
//***
//***    1) Create a public method named "dealCard" that takes one
//***       argument and returns no value.
//***       a) The one argument is of datatype "Player" and named "p".
//***       b) Add the following one line of code to this method:
//***             p.addCard2Hand(new Card(1));
//***    2) Create a public method named "shuffleDeck" that takes no
//***       arguments and returns no value.
//***       a) The method contains no code.
//***    3) Create a public one-arg constructor for class "CardGame".
//***       a) The one argument is of datatype int and named "numCards".
//***       b) The method contains no code.
//***    4) Create a public abstract method named "determineOutcome" that
//***       takes two arguments and returns no value.
//***       a) The first argument is of datatype "Player" and named "p".
//***       b) The second argument is of datatype "Player" and named "d".
//***
//***    5) Create a public inner class named "Card". Inner class means that
//***       it is nested inside class "CardGame".
//***    6) Inside class "Card", include the following:
//***       1) Create three private properties per the following:
//***          a) First property is of datatype String and named "rank".
//***          b) Second property is of datatype String and named "suit".
//***          c) Third property is of datatype int and named "score".
//***       2) Create a public getter for each of these three properties that
//***          just returns the property.
//***       3) Create a private setter for each of these three properties that
//***          assigns the parameter variable to the property and returns no value.
//***          (Standard setter method)
//***       4) Create a public one-arg constructor for class "Card".
//***          a) The one argument is of datatype int and named "numCards".
//***          b) The method contains no code.
//***       5) Override the toString method (using the Override annotation).
//***          a) Add the following one line of code to this method:
//***                return "\t" + rank + " of " + suit;
//***
//***    7) Create a public static inner class named "Player". Inner class
//***       means that it is nested inside class "CardGame".
//***    8) Inside class "Player", include the following:
//***
//***       1) Create two private properties per the following:
//***          a) First property is of datatype String and named "name".
//***          b) Second property is of datatype int and named "currentScore".
//***       2) Create a public getter for each of these two properties that
//***          just returns the property.
//***       3) Create a private setter for each of these two properties that
//***          assigns the parameter variable to the property and returns no value.
//***          (Standard setter method)
//***       4) Create a public method named "getCard" that takes one
//***          argument and returns a String.
//***          a) The one argument is of datatype int and named "cardIndex".
//***          b) Add the following one line of code to this method:
//***                return "";
//***       5) Create a public method named "addCard2Hand" that takes one
//***          argument and returns no value.
//***          a) The one argument is of datatype "Card" and named "c".
//***          b) Add the following one line of code to this method:
//***                setCurrentScore(22);
//***       6) Create a public method named "displayFormattedHand" that
//***          takes no arguments and returns no value.
//***          a) The method contains no code.
//***       7) Create a public no-arg constructor for class "Player".
//***          a) The method contains no code.
//***       8) Create a public one-arg constructor for class "Player".
//***          a) The one argument is of datatype String and named "name".
//***          b) Add the following one line of code to this method:
//***                setName(name);
//***