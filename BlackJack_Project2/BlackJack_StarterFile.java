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

public class BlackJack extends CardGame {

    final String DEALER_NAME = "Dealer";
    final int DEALER_HIT_STAY_THRESHOLD = 16;

    private final BlackJackPlayer player = new BlackJackPlayer();
    private final BlackJackPlayer dealer = new BlackJackPlayer(DEALER_NAME);

    enum Winner {DEALER, PLAYER, TIE}
    private Winner winner;

    public BlackJackPlayer getPlayer() {
        return player;
    }
    public BlackJackPlayer getDealer() {
        return dealer;
    }
    public BlackJack.Winner getWinner() {
        return winner;
    }

    private void setWinner(Winner winner) {
        this.winner = winner;
    }

    public void dealCardWithHit(Player p) {
        dealCard(p);

        //***
        //*** 1) Create a reference variable of datatype
        //***    "BlackJackPlayer" and named "bjp".
        //*** 2) Cast parameter variable "p" to datatype "BlackJackPlayer"
        //***    and assign it to variable "bjp".
        //***    NOTE: Steps 1 & 2 are together just one line of code.
        //*** 3) Declare a local variable of datatype int named "hits" and
        //***    assign the following value to it:
        //***    a) Using the reference variable "bjp", invoke the
        //***       method "getNumberHits".
        //*** 4) Invoke method "setNumberHits" on reference variable "bjp"
        //***    passing the "prefix increment" (also known as "preincrement")
        //***    of variable "hits" as the one argument.
        //***

    }

    public void determineOutcome(Player p, Player d) {

        //***
        //*** 5) Create a reference variable of datatype
        //***    "BlackJackPlayer" and named "bjp".
        //*** 6) Cast parameter variable "p" to datatype "BlackJackPlayer"
        //***    and assign it to variable "bjp".
        //***    NOTE: Steps 5 & 6 are together just one line of code.
        //*** 7) Create a reference variable of datatype
        //***    "BlackJackPlayer" and named "bjd".
        //*** 8) Cast parameter variable "d" to datatype "BlackJackPlayer"
        //***    and assign it to variable "bjd".
        //***    NOTE: Steps 7 & 8 are together just one line of code.
        //*** 9) Write an if-else-if structure as follows:
        //***    a) Write an if-statement invoking the "isBust" method
        //***       on reference variable "bjp" (this is the BlackJack Player)
        //***       as the boolean condition.
        //***    b) Execute the following line of code if the boolean
        //***       condition in Step 9a evaluates to true:
        //***       A) Invoke the method "setWinner" passing the enum constant
        //***          "Winner.DEALER" as the one argument.
        //***    c) Write an else-if statement associated with Step 9a invoking
        //***       the "isBust" method on reference variable "bjd"
        //***       (this is the BlackJack Dealer) as the boolean condition.
        //***    d) Execute the following line of code if the boolean
        //***       condition in Step 9c evaluates to true:
        //***       A) Invoke the method "setWinner" passing the enum constant
        //***          "Winner.PLAYER" as the one argument.
        //***    e) Write an else-if statement associated with Step 9c using the
        //***       following code as the boolean condition:
        //***       A) Invoke method "getCurrentScore" on reference variable "bjd"
        //***          (BlackJack Dealer) and compare for greater-than to the
        //***          invocation of method "getCurrentScore" on reference variable
        //***          "bjp" (BlackJack Player).
        //***    f) Execute the following line of code if the boolean
        //***       condition in Step 9e evaluates to true:
        //***       A) Invoke the method "setWinner" passing the enum constant
        //***          "Winner.DEALER" as the one argument.
        //***    g) Write an else-if statement associated with Step 9e using the
        //***       following code as the boolean condition:
        //***       A) Invoke method "getCurrentScore" on reference variable "bjp"
        //***          (BlackJack Player) and compare for greater-than to the
        //***          invocation of method "getCurrentScore" on reference variable
        //***          "bjd" (BlackJack Dealer).
        //***    h) Execute the following line of code if the boolean
        //***       condition in Step 9g evaluates to true:
        //***       A) Invoke the method "setWinner" passing the enum constant
        //***          "Winner.PLAYER" as the one argument.
        //***    i) Write an else statement associated with Step 9g.
        //***    j) Execute the following line of code for Step 9i:
        //***       A) Invoke the method "setWinner" passing the enum constant
        //***          "Winner.TIE" as the one argument.
        //***

    }

    public BlackJack(int numCards) {
        super(numCards);
   }

    public static class BlackJackPlayer extends Player {
        final int BUST_SCORE = 21;

        private int numberHits;
        private boolean bust;

        public int getNumberHits() {
            return numberHits;
        }
        public boolean isBust() {
            return bust;
        }

        private void setNumberHits(int numberHits) {
            this.numberHits = numberHits;
        }
        private void setBust(boolean bust) {
            this.bust = bust;
        }

        public boolean checkBust() {
            boolean bust = false;

            //***
            //*** 10) Write an if-statement invoking the "getCurrentScore" method
            //***     and compare for greater-than to the "Bust Score" constant.
            //*** 11) Execute the following block of code if the boolean condition
            //***     evaluates to true:
            //***     a) Assign the value of true to local boolean variable "bust".
            //***     b) Invoke the method "setBust" passing the variable "bust"
            //***        as the one argument.
            //***

            return bust;
        }

        public BlackJackPlayer(){

        }

        public BlackJackPlayer(String name) {
            super(name);
        }
    }
}