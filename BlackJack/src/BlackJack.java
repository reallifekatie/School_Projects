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

        // new variable with datatype BlackJackPlayer and is assigned to equal new variable cast to datatype BlackJackPlayer
        BlackJackPlayer bjp = (BlackJackPlayer) p;

        // new variable of int datatype
        // assigned to variable bjp invoking getNumberHits method
        int hits = bjp.getNumberHits();
        // invoked method setNumberHits on reference variable bjp
            // passing the pre-incremented value of hits variable
        bjp.setNumberHits(++hits);

    }

    public void determineOutcome(Player p, Player d) {

        // creation of 2 reference variables for player and dealer
        // each reference variable is of BlackJackPlayer data type and is equal to a cast version of BlackJackPlayer
        BlackJackPlayer bjp = (BlackJackPlayer) p;
        BlackJackPlayer bjd = (BlackJackPlayer) d;

        // if statement to invoke the isBust method as the boolean condition
        // if player is bust, the setWinner method declares the Dealer as the winner
        // if dealer is bust, the setWinner method declares the Player as the winner
        // if player's score is higher, setWinner method declares Player the winner
        // if dealer's score is higher, setWinner method declares Dealer the winner
        // otherwise, the game is declared a tie
        if (bjp.isBust()) {
            setWinner(Winner.DEALER);
        } else if (bjd.isBust()) {
            setWinner(Winner.PLAYER);
        } else if (bjd.getCurrentScore() > bjp.getCurrentScore()) {
            setWinner(Winner.DEALER);
        } else if (bjp.getCurrentScore() > bjd.getCurrentScore()) {
            setWinner(Winner.PLAYER);
        } else {
            setWinner(Winner.TIE);
        }

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

            // if statement invokes getCurrentScore method and checks to see if it is greater than the Bust Score constant
            // if true, true is assigned to but variable, which is then passed as argument to setBust method
            if (getCurrentScore() > BUST_SCORE) {
                bust = true;
                setBust(bust);
            }

            return bust;
        }

        public BlackJackPlayer(){

        }

        public BlackJackPlayer(String name) {
            super(name);
        }
    }
}