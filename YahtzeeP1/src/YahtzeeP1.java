import java.util.Random;
import java.util.Scanner;

public class YahtzeeP1 {

    // Default value when a category has not been used.
    final static int SCORE_NO_VALUE = -1;

    // Variables to store the score value of each category.
    static int aces = SCORE_NO_VALUE;
    static int twos = SCORE_NO_VALUE;
    static int threes = SCORE_NO_VALUE;
    static int fours = SCORE_NO_VALUE;
    static int fives = SCORE_NO_VALUE;
    static int sixes = SCORE_NO_VALUE;

    static int threeKind = SCORE_NO_VALUE;
    static int fourKind = SCORE_NO_VALUE;
    static int fullHouse = SCORE_NO_VALUE;
    static int smallStraight = SCORE_NO_VALUE;
    static int largeStraight = SCORE_NO_VALUE;
    static int yahtzee = SCORE_NO_VALUE;
    static int chance = SCORE_NO_VALUE;

    // The number of Bonus Yahtzees are stored instead of the
    //    actual score value.
    static int yahtzeeBonusCount = SCORE_NO_VALUE;

    final static int YAHTZEE_SCORE = 50;
    final static int YAHTZEE_BONUS_SCORE = 100;

    final static String BORDER_CHAR = "*";

    final static String INVALID_INPUT_MESSAGE = "*** Invalid input ***";

    final static int NUMBER_OF_CATEGORIES = 13;

    // Used to store the value of each die face.
    static int die1;
    static int die2;
    static int die3;
    static int die4;
    static int die5;

    // Declare and initialize the trackers for number of turns and number of
    //    rolls per turn.
    static int turnCount = 0;
    static int numberOfRolls = 0;

    public static void main(String[] args) {

        // This constant stores the number of different values on the dice faces.
        // The random number generator produces a number between 0.0 and 1.0 but
        //    not including 1.0
        // This constant is used with the random number generator to place the
        //    random numbers into the range of 1-6.
        final int MAX_NUMBER_ON_DIE = 6;

        // This constant is the maximum number of rolls of the dice that a player
        //    receives during each turn.
        // It is used to ensure that the player does not exceed the maximum number
        //    of rolls and in display messaging.
        final int MAX_NUMBER_ROLLS = 3;

        final String WELCOME_MESSAGE = "Welcome to YAHTZEE";

        final String PRESS_ENTER_MESSAGE = "Press the Enter key to continue: ";

        final String REROLL_MESSAGE_1 = "Enter: S for ScoreCard; D for Dice; X to Exit";
        final String REROLL_MESSAGE_2 = "Or: A series of numbers to re-roll dice as follows:";
        final String REROLL_MESSAGE_3 = "\t\tYou may re-roll any of the dice by entering " +
                "the die #s without spaces.";
        final String REROLL_MESSAGE_4 = "\t\tFor example, to re-roll dice #1, #3 & #4, " +
                "enter 134 or enter 0 for none.";
        final String REROLL_MESSAGE_5 = "You have %d roll(s) left this turn.";
        final String REROLL_MESSAGE_6 = "Which of the dice would you like to roll again? ";

        final String CATEGORY_MESSAGE_1 = "Enter: 1-" + NUMBER_OF_CATEGORIES +
                " for category; S for ScoreCard; D for Dice; X to Exit";
        final String CATEGORY_MESSAGE_2 = "Which category would you like to choose? ";

        // Variable turnOver is used as the loop control variable for the
        //    "turn" do-loop.
        // It becomes true under the following conditions:
        //    * The user enters "X" to exit the program.
        //    * The user forgoes remaining rolls of the dice and ends the turn.
        //    * The user consumes the maximum number of rolls of the dice.
        boolean turnOver = false;

        // Variable gameExit is used as the loop control variable to exit the
        //    program when the user enters "X".
        boolean gameExit = false;

        // Variable gameComplete is used as the loop control variable to exit
        //    the program when the user scores all 13 categories on the
        //    scorecard which signifies a complete game.
        boolean gameComplete = false;

        // Variable dice2Reroll collects the users response during a turn.
        // Valid responses are:
        //    * "X" to exit the program.
        //    * "S" to redisplay the current scorecard.
        //    * "D" to redisplay the current numbers on the faces of the five dice.
        //    * "0" to forgo re-rolling of the dice and end the turn.
        //    * Any String of integers using 1-5 non-repeating. Spaces are stripped out.
        //    *     For example: 123 re-rolls dice 1, 2 and 3
        String dice2Reroll;

        // If String dice2Reroll is determined to only contain the numbers between
        //    1-5 non-repeating, then variable die2Reroll is used to pull out
        //    individual characters (1-5) from String dice2Reroll to be used to
        //    re-roll the appropriate dice.
        char die2Reroll;

        // Variable scoreOptionInput collects the user's response as the category to score.
        // Valid responses are:
        //    * "X" to exit the program.
        //    * "S" to redisplay the current scorecard.
        //    * "D" to redisplay the current numbers on the faces of the five dice.
        //    * Any integer from 1-13 represented as a String.
        //    *    This is the scorecard category the user wishes to choose.
        //    *     1  = Aces
        //    *     2  = Twos
        //    *     3  = Threes
        //    *     4  = Fours
        //    *     5  = Fives
        //    *     6  = Sixes
        //    *     7  = Three of a kind
        //    *     8  = Four of a kind
        //    *     9  = Full House
        //    *     10 = Small Straight
        //    *     11 = Large Straight
        //    *     12 = Yahtzee
        //    *     13 = Chance
        String scoreOptionInput;

        // If during the input validation, it is determined that variable
        //    scoreOptionInput contains only numbers, then variable scoreOptionInput
        //    is cast into an int datatype and stored in variable scoreOption.
        //    Variable scoreOption is then tested for validity by being in the range 1-13.
        int scoreOption = 0;

        Scanner input = new Scanner(System.in);

        // Use the current time as a seed for the random number generator.
        long seed = (new java.util.Date()).getTime();
        Random generator = new Random(seed);

        System.out.println();
        System.out.println(WELCOME_MESSAGE);

        // This is the main do-while loop.
        // Execution exits this loop when the game is over; having been ended
        //    by the user entering "X" to exit or the user completing the game
        //    by scoring all categories.
        do {
            System.out.println();
            System.out.print(PRESS_ENTER_MESSAGE);

            // Pause for the enter key.
            input.nextLine();

            // Keep track of the number of turns the player uses.
            turnCount++;

            // Roll the dice the first time.
            die1 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
            die2 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
            die3 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
            die4 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
            die5 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;

            // Set/reset the number of rolls per turn.
            numberOfRolls = 1;

            // Display the values of the dice after rolling.
            displayDice();

            // Set/reset the turn flag variable for the next turn.
            turnOver = false;

            // This is the "turn" loop.
            // Execution exits this loop when the user's turn has ended;
            //    having chosen to forgo re-rolls of the dice by entering
            //    "0" or by consuming the maximum number of rolls of the dice.
            do {
                // Give the user the menu commands and instructions.
                System.out.println();
                System.out.println(REROLL_MESSAGE_1);
                System.out.println();

                System.out.println(REROLL_MESSAGE_2);
                System.out.println(REROLL_MESSAGE_3);
                System.out.println(REROLL_MESSAGE_4);

                System.out.println();
                System.out.printf(REROLL_MESSAGE_5, (MAX_NUMBER_ROLLS - numberOfRolls));
                System.out.println();

                System.out.println();
                System.out.print(REROLL_MESSAGE_6);

                // Collect the user's input response of which command to execute
                //    or of which dice to re-roll.
                dice2Reroll = input.nextLine().trim();

                // switch case to define actions to take based on user-input
                switch (dice2Reroll.toUpperCase()) {
                    // if selection is X, game is over.  time to exit
                    case "X":
                        turnOver = true;
                        gameExit = true;
                        break;
                    // if selection is S, display scoresheet
                    case "S":
                        displayScoreSheet();
                        break;
                    // if selection is D, display the dice results
                    case "D":
                        displayDice();
                        break;
                    // if selection is 0, then user is happy with score of dice; their turn is over
                    case "0":
                        turnOver = true;
                        break;
                    // if user hits Enter key without making a selection, display error message
                    case "":
                        displayErrorMessage();
                        break;
                    // In all other cases, test for a valid String of integers
                    //    representing dice to re-roll.
                    default:
                        // Remove any spaces in the String. Particularly ones
                        //    between characters.
                        // For example: 1 2 3 instead of 123
                        dice2Reroll = dice2Reroll.replace(" ", "");
                        // Save off the contents of variable dice2Reroll to variable
                        //    checkDice2Reroll in order for checkDice2Reroll to be
                        //    modified during the validation process.
                        String checkDice2Reroll = dice2Reroll;

                        // Only allow numbers between 1-5 and no numbers can repeat.
                        // Method replaceFirst finds the first occurrence of the target
                        //    String (first argument) and replaces that occurrence with
                        //    the replacement String (second argument).
                        // The goal is to determine if the String variable checkDice2Reroll
                        //    only contains numbers and those numbers must be only the
                        //    numbers 1, 2, 3, 4, and 5; with the additional constraint
                        //    that no number can be repeated. Therefore, if one occurrence
                        //    of each number 1-5 is removed and anything but spaces is left,
                        //    it is invalid input.
                        checkDice2Reroll = checkDice2Reroll.replaceFirst("1", " ");
                        checkDice2Reroll = checkDice2Reroll.replaceFirst("2", " ");
                        checkDice2Reroll = checkDice2Reroll.replaceFirst("3", " ");
                        checkDice2Reroll = checkDice2Reroll.replaceFirst("4", " ");
                        checkDice2Reroll = checkDice2Reroll.replaceFirst("5", " ");

                        // When checkDice2Reroll is blank, the user entered valid dice to reroll.
                        // Conversely, when checkDice2Reroll is not blank, the user entered
                        //    invalid dice to reroll.
                        if (checkDice2Reroll.isBlank()) {

                            // If execution makes it here, the input is a valid
                            //    set of integers in String format representing
                            //    dice to re-roll.
                            // Iterate for each character in the String variable
                            //    dice2Reroll (each of which is an integer), and
                            //    for each of these characters re-roll that die.
                            for (int i = 0; i < dice2Reroll.length(); i++) {

                                // Substring each character in String variable
                                //    dice2Reroll and store in variable die2Reroll.
                                die2Reroll = dice2Reroll.charAt(i);

                                // Re-roll the appropriate die.
                                switch (die2Reroll) {

                                    // If the character is '1', then re-roll die #1.
                                    case '1':
                                        die1 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                                        break;

                                    // If the character is '2', then re-roll die #2.
                                    case '2':
                                        die2 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                                        break;

                                    // If the character is '3', then re-roll die #3.
                                    case '3':
                                        die3 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                                        break;

                                    // If the character is '4', then re-roll die #4.
                                    case '4':
                                        die4 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                                        break;

                                    // If the character is '5', then re-roll die #5.
                                    case '5':
                                        die5 = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                                        break;
                                }
                            }

                            // This is a valid roll of the dice so count it.
                            numberOfRolls++;

                            // Display the values of the dice after rolling.
                            displayDice();

                            // If this roll of the dice reaches the max threshold
                            //    for number of rolls then end the player's turn
                            //    so that they can choose which category to score.
                            if (numberOfRolls == MAX_NUMBER_ROLLS)
                                turnOver = true;
                        }

                        // The user entered invalid input when prompted for which
                        //    dice to reroll. So display an error message.
                        else {
                            displayErrorMessage();
                        }

                }

            } while (!turnOver);

            // if statement to determine if user is exiting game
            // if user is not exiting game, the scoresheet is displayed
            if (!gameExit) {
                displayScoreSheet();
                boolean isValidEntry;
                boolean categoryPicked;
                boolean continuePrompting;

                // do-while loop to display categories for user selection
                do {
                    isValidEntry = true;
                    categoryPicked = false;

                    // Give the user instructions concerning category selection.
                    System.out.println();
                    System.out.println(CATEGORY_MESSAGE_1);
                    System.out.println();

                    System.out.print(CATEGORY_MESSAGE_2);

                    // Collect the user's input response of which command to execute
                    //    or of which category to score.
                    scoreOptionInput = input.nextLine().trim();

                    // Set/reset the numeric equivalent of variable scoreOptionInput.
                    scoreOption = 0;

                    // switch-case statement to gather the user's input and determine what happens next
                    switch (scoreOptionInput.toUpperCase()) {
                        // if user types an X, the game exits
                        case "X":
                            gameExit = true;
                            break;
                        // if user types an s, the scoresheet is displayed
                        case "S":
                            displayScoreSheet();
                            break;
                        // if user types a D, the results of the dice are displayed
                        case "D":
                            displayDice();
                            break;
                        // if user hits Enter key without entering an option, an error message is displayed
                        case "":
                            displayErrorMessage();
                            break;

                        // In all other cases, test for a valid String of integers
                        //    representing a menu category number.
                        default:

                            // Iterate for each character in the String variable scoreOptionInput (each of which is an
                            //    integer), and for each of these characters, check if it is a digit.
                            for (int x = 0; x < scoreOptionInput.length(); x++) {
                                if (!(Character.isDigit(scoreOptionInput.charAt(x)))) {
                                    isValidEntry = false;
                                    displayErrorMessage();
                                }
                            }

                            // If execution makes it here, the input is a valid set of integers in String format
                            //    potentially representing a valid menu category number.
                            if (isValidEntry) {

                                // Cast variable scoreOptionInput into an int datatype and
                                //    store in variable scoreOption.
                                scoreOption = Integer.parseInt(scoreOptionInput);

                                // Test if the numeric menu category is invalid which is not between 1-13 inclusive.
                                // The valid menu categories are 1-13 inclusive.
                                if (scoreOption < 1 || scoreOption > NUMBER_OF_CATEGORIES) {
                                    isValidEntry = false;
                                    displayErrorMessage();
                                }
                            }

                            // The user entered a valid category to score however the
                            //    category was already used by the player.
                            // Categories can only be used once.
                            if (isValidEntry && isCategoryUsed(scoreOption)) {
                                isValidEntry = false;
                                displayErrorMessage();
                            }

                            // If the user's input passes all checks then calculate
                            //    the new score display the current score sheet and
                            //    determine if the game is over.
                            if (isValidEntry) {
                                categoryPicked = true;
                                calculateTurnScore(scoreOption);
                                displayScoreSheet();
                                gameComplete = isGameOver();
                            }

                    }

                    // This do-while continues to execute when variable continuePrompting is true.
                    // Variable continuePrompting is only true when the two parts are both true.
                    //    1) The first part examines variable gameExit. When gameExit is false, the user did not
                    //       enter "X" to exit the game. Therefore, to continue looping the user must not have
                    //       indicated that they wanted to exit the game.
                    //    2) The second part checks the validity of the user input value and determines if a category
                    //       was picked. If the user input is invalid, the loop continues OR if the user did not pick
                    //       an unused category, the loop continues.
                    continuePrompting = !gameExit && !categoryPicked;

                // added do-while's continuation condition clause
                } while (continuePrompting);

            }

        } while (!gameExit && !gameComplete);

        // Display the current score sheet.
        displayScoreSheet();
    }

    public static void displayDice() {

        final String DIE_1_LABEL = "Die #1 = ";
        final String DIE_2_LABEL = "Die #2 = ";
        final String DIE_3_LABEL = "Die #3 = ";
        final String DIE_4_LABEL = "Die #4 = ";
        final String DIE_5_LABEL = "Die #5 = ";

        System.out.println();

        System.out.print(DIE_1_LABEL);
        System.out.println(" (" + (die1) + ")");

        System.out.print(DIE_2_LABEL);
        System.out.println(" (" + (die2) + ")");

        System.out.print(DIE_3_LABEL);
        System.out.println(" (" + (die3) + ")");

        System.out.print(DIE_4_LABEL);
        System.out.println(" (" + (die4) + ")");

        System.out.print(DIE_5_LABEL);
        System.out.println(" (" + (die5) + ")");

        System.out.println();
    }

    public static void displayScoreSheet() {

        final String ACES_LABEL = "Aces";
        final String TWOS_LABEL = "Twos";
        final String THREES_LABEL = "Threes";
        final String FOURS_LABEL = "Fours";
        final String FIVES_LABEL = "Fives";
        final String SIXES_LABEL = "Sixes";

        final String THREE_KIND_LABEL = "3 of a kind";
        final String FOUR_KIND_LABEL = "4 of a kind";
        final String FULL_HOUSE_LABEL = "Full House";
        final String SMALL_STRAIGHT_LABEL = "Sm. Straight";
        final String LARGE_STRAIGHT_LABEL = "Lg. Straight";
        final String YAHTZEE_LABEL = "YAHTZEE";
        final String CHANCE_LABEL = "Chance";
        final String YAHTZEE_BONUS_LABEL = "YAHTZEE BONUS";

        // If the player achieves a score of 63 or greater in the upper section,
        //    then a bonus is awarded.
        final int BONUS_THRESHOLD = 63;

        // This is the upper section bonus.
        final int BONUS_SCORE = 35;

        final String UPPER_SECTION_LABEL = "UPPER SECTION";
        final String LOWER_SECTION_LABEL = "LOWER SECTION";
        final String UPPER_SECTION_SUBTOTAL_LABEL = "TOTAL SCORE";
        final String UPPER_SECTION_BONUS_LABEL = "BONUS if >= 63";
        final String UPPER_SECTION_TOTAL_LABEL = "TOTAL of Upper Section";
        final String LOWER_SECTION_TOTAL_LABEL = "TOTAL of Lower Section";
        final String GRAND_TOTAL_LABEL = "GRAND TOTAL";

        final String OPTION_SUFFIX_ONE_DIGIT = ")  ";
        final String OPTION_SUFFIX_TWO_DIGIT = ") ";

        final String FIRST_OPTION_LABEL = "1";
        final String SECOND_OPTION_LABEL = "2";
        final String THIRD_OPTION_LABEL = "3";
        final String FOURTH_OPTION_LABEL = "4";
        final String FIFTH_OPTION_LABEL = "5";
        final String SIXTH_OPTION_LABEL = "6";
        final String SEVENTH_OPTION_LABEL = "7";
        final String EIGHTH_OPTION_LABEL = "8";
        final String NINTH_OPTION_LABEL = "9";
        final String TENTH_OPTION_LABEL = "10";
        final String ELEVENTH_OPTION_LABEL = "11";
        final String TWELFTH_OPTION_LABEL = "12";
        final String THIRTEENTH_OPTION_LABEL = "13";

        final String EQUALS_LABEL = " = ";

        // declared two new variables
        // each variable is assigned a method call
        int upperScoreTotal;
        upperScoreTotal = calculateUpperScore();
        int lowerScoreTotal;
        lowerScoreTotal = calculateLowerScore();

        System.out.println();
        System.out.println(UPPER_SECTION_LABEL);

        // Option 1 = Aces
        if (aces == SCORE_NO_VALUE)
            System.out.println(FIRST_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + ACES_LABEL);
        else
            System.out.println(FIRST_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + ACES_LABEL + EQUALS_LABEL + aces);

        if (twos == SCORE_NO_VALUE)
            System.out.println(SECOND_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + TWOS_LABEL);
        else
            System.out.println(SECOND_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + TWOS_LABEL + EQUALS_LABEL + twos);

        if (threes == SCORE_NO_VALUE)
            System.out.println(THIRD_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + THREES_LABEL);
        else
            System.out.println(THIRD_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + THREES_LABEL + EQUALS_LABEL + threes);

        if (fours == SCORE_NO_VALUE)
            System.out.println(FOURTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FOURS_LABEL);
        else
            System.out.println(FOURTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FOURS_LABEL + EQUALS_LABEL + fours);

        if (fives == SCORE_NO_VALUE)
            System.out.println(FIFTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FIVES_LABEL);
        else
            System.out.println(FIFTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FIVES_LABEL + EQUALS_LABEL + fives);

        if (sixes == SCORE_NO_VALUE)
            System.out.println(SIXTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + SIXES_LABEL);
        else
            System.out.println(SIXTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + SIXES_LABEL + EQUALS_LABEL + sixes);

        // Upper section score subtotal
        if (upperScoreTotal > 0)
            System.out.println(UPPER_SECTION_SUBTOTAL_LABEL + EQUALS_LABEL + upperScoreTotal);
        else
            System.out.println(UPPER_SECTION_SUBTOTAL_LABEL);

        // Upper section score bonus
        if (upperScoreTotal >= BONUS_THRESHOLD)
            System.out.println(UPPER_SECTION_BONUS_LABEL + EQUALS_LABEL + BONUS_SCORE);
        else
            System.out.println(UPPER_SECTION_BONUS_LABEL);

        // Upper section score total
        if (upperScoreTotal > 0)
            if (upperScoreTotal >= BONUS_THRESHOLD)
                System.out.println(UPPER_SECTION_TOTAL_LABEL + EQUALS_LABEL + (upperScoreTotal + BONUS_SCORE));
            else
                System.out.println(UPPER_SECTION_TOTAL_LABEL + EQUALS_LABEL + upperScoreTotal);
        else
            System.out.println(UPPER_SECTION_TOTAL_LABEL);

        System.out.println();
        System.out.println(LOWER_SECTION_LABEL);

        // scoring for hands with a three of a kind
        if (threeKind == SCORE_NO_VALUE)
            System.out.println(SEVENTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + THREE_KIND_LABEL);
        else
            System.out.println(SEVENTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + THREE_KIND_LABEL + EQUALS_LABEL + threeKind);

        // scoring for hands with four of a kind
        if (fourKind == SCORE_NO_VALUE)
            System.out.println(EIGHTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FOUR_KIND_LABEL);
        else
            System.out.println(EIGHTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FOUR_KIND_LABEL + EQUALS_LABEL + fourKind);

        // scoring for hands with a full house
        if (fullHouse == SCORE_NO_VALUE)
            System.out.println(NINTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FULL_HOUSE_LABEL);
        else
            System.out.println(NINTH_OPTION_LABEL + OPTION_SUFFIX_ONE_DIGIT + FULL_HOUSE_LABEL + EQUALS_LABEL + fullHouse);

        // scoring for hands with a small straight
        if (smallStraight == SCORE_NO_VALUE)
            System.out.println(TENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + SMALL_STRAIGHT_LABEL);
        else
            System.out.println(TENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + SMALL_STRAIGHT_LABEL + EQUALS_LABEL + smallStraight);

        // scoring for hands with a large straight
        if (largeStraight == SCORE_NO_VALUE)
            System.out.println(ELEVENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + LARGE_STRAIGHT_LABEL);
        else
            System.out.println(ELEVENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + LARGE_STRAIGHT_LABEL + EQUALS_LABEL + largeStraight);

        // scoring for hands with yahtzee (5 of a kind)
        if (yahtzee == SCORE_NO_VALUE)
            System.out.println(TWELFTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + YAHTZEE_LABEL);
        else
            System.out.println(TWELFTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + YAHTZEE_LABEL + EQUALS_LABEL + yahtzee);

        // scoring for chance hands
        if (chance == SCORE_NO_VALUE)
            System.out.println(THIRTEENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + CHANCE_LABEL);
        else
            System.out.println(THIRTEENTH_OPTION_LABEL + OPTION_SUFFIX_TWO_DIGIT + CHANCE_LABEL + EQUALS_LABEL + chance);

        // Yahtzee bonus for multiple Yahtzees
        if (yahtzeeBonusCount == SCORE_NO_VALUE)
            System.out.println(YAHTZEE_BONUS_LABEL);
        else
            System.out.println(YAHTZEE_BONUS_LABEL + EQUALS_LABEL + (yahtzeeBonusCount * YAHTZEE_BONUS_SCORE));

        // Lower section score total
        if (lowerScoreTotal > 0)
            System.out.println(LOWER_SECTION_TOTAL_LABEL + EQUALS_LABEL + lowerScoreTotal);
        else
            System.out.println(LOWER_SECTION_TOTAL_LABEL);

        // Upper section score total
        if (upperScoreTotal > 0)
            if (upperScoreTotal >= BONUS_THRESHOLD)
                System.out.println(UPPER_SECTION_TOTAL_LABEL + EQUALS_LABEL + (upperScoreTotal + BONUS_SCORE));
            else
                System.out.println(UPPER_SECTION_TOTAL_LABEL + EQUALS_LABEL + upperScoreTotal);
        else
            System.out.println(UPPER_SECTION_TOTAL_LABEL);

        // Grand total
        if (upperScoreTotal + lowerScoreTotal > 0)
            if (upperScoreTotal >= BONUS_THRESHOLD)
                System.out.println(GRAND_TOTAL_LABEL + EQUALS_LABEL + (upperScoreTotal + lowerScoreTotal + BONUS_SCORE));
            else
                System.out.println(GRAND_TOTAL_LABEL + EQUALS_LABEL + (upperScoreTotal + lowerScoreTotal));
        else
            System.out.println(GRAND_TOTAL_LABEL);

        System.out.println();
    }

    // This method is called after the user enters a valid category to score.
    public static void calculateTurnScore(int scoreOption) {
        switch (scoreOption) {
            // scoring case for aces
            case 1:
                aces = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for twos
            case 2:
                twos = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for threes
            case 3:
                threes = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for fours
            case 4:
                fours = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for fives
            case 5:
                fives = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for sixes
            case 6:
                sixes = calculateUpperSectionCategory(scoreOption);
                break;
            // scoring case for three of a kind
            // calls method to calculate
            case 7:
                threeKind = calculateThreeOfKind();
                break;
            // scoring case for four of a kind
            // calls method to calculate
            case 8:
                fourKind = calculateFourOfKind();
                break;
            // scoring case for full house
            // calls method to calculate
            case 9:
                fullHouse = calculateFullHouse();
                break;
            // scoring case for small straight
            // calls method to calculate
            case 10:
                smallStraight = calculateSmallStraight();
                break;
            // scoring case for large straight
            // calls method to calculate
            case 11:
                largeStraight = calculateLargeStraight();
                break;
            // scoring case for yahtzee
            // declared and initialize variable and assigned as call method
            case 12:
                int checkYahtzee = calculateYahtzee();
                if (yahtzee == SCORE_NO_VALUE)
                    yahtzee = checkYahtzee;
                else if (yahtzee == YAHTZEE_SCORE && checkYahtzee == YAHTZEE_SCORE)
                    if (yahtzeeBonusCount == SCORE_NO_VALUE)
                        yahtzeeBonusCount = 1;
                    else
                        yahtzeeBonusCount++;
                break;
            case 13:
                chance = calculateChance();
                break;
        }

    }
    // new method created to calculate the upper section category scores
    public static int calculateUpperSectionCategory(int dieNumber) {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        System.out.println("In method calculateUpperSectionCategory");
                return score;
    }

    // new method created to calculate the score for hands with three of a kind
    public static int calculateThreeOfKind() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isThreeKind = false;
        System.out.println("In method calculateThreeOfKind");
        return score;
    }

    // new method created to calculate the score for hands with four of a kind
    public static int calculateFourOfKind() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isFourKind = false;
        System.out.println("In method calculateFourOfKind");
        return score;
    }

    // new method created to calculate the score for hands with full house
    public static int calculateFullHouse() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isFullHouse = false;
        System.out.println("In method calculateFullHouse");
        return score;
    }

    // new method created to calculate the score for hands with a small straight
    public static int calculateSmallStraight() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isSmallStraight = false;
        System.out.println("In method calculateSmallStraight");
        return score;
    }

    // new method created to calculate the score for hands with a large straight
    public static int calculateLargeStraight() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isLargeStraight = false;
        System.out.println("In method calculateLargeStraight");
        return score;
    }

    // new method created to calculate the score for hands with yahtzee (5 of a kind)
    public static int calculateYahtzee() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        boolean isYahtzee = false;
        System.out.println("In method calculateYahtzee");
        return score;
    }

    // new method created to calculate the score for hands with chance
    public static int calculateChance() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        System.out.println("In method calculateChance");
        return score;
    }

    // new method created to calculate the score for hands in the upper score category
    public static int calculateUpperScore() {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        int score = 0;
        System.out.println("In method calculateUpperScore");
        return score;
    }

    // new method created to calculate the score for hands in the lower score category
    public static int calculateLowerScore() {
        int score = 0;
        System.out.println("In method calculateLowerScore");
        return score;
    }

    // new boolean method created
    public static boolean isCategoryUsed(int scoreOption) {
        // declared new variable and initialized it to zero
        // this method call will print a statement and return that zero score
        boolean used = false;
        System.out.println("In method isCategoryUsed");
        return used;
    }

    // new boolean method created for actions taken when isGameOver method is called
    public static boolean isGameOver() {
        boolean gameOver = false;
        if (aces != SCORE_NO_VALUE && twos != SCORE_NO_VALUE && threes != SCORE_NO_VALUE && fours != SCORE_NO_VALUE &&
                fives != SCORE_NO_VALUE && sixes != SCORE_NO_VALUE && threeKind != SCORE_NO_VALUE && fourKind != SCORE_NO_VALUE &&
                fullHouse != SCORE_NO_VALUE && smallStraight != SCORE_NO_VALUE && largeStraight != SCORE_NO_VALUE && yahtzee
                != SCORE_NO_VALUE && chance != SCORE_NO_VALUE )
            gameOver = true;
        return gameOver;
    }

    // This method Displays a generic error message.
    public static void displayErrorMessage() {
        System.out.println();

        // Constant BORDER_CHAR is the character used to create noticeable
        //    message separator.
        // BORDER_CHAR is repeated (using the repeat method) the length of
        //    the error message in order to create a border that matches the
        //    length of the message.
        System.out.println(BORDER_CHAR.repeat(INVALID_INPUT_MESSAGE.length()));
        System.out.println(INVALID_INPUT_MESSAGE);
        System.out.println(BORDER_CHAR.repeat(INVALID_INPUT_MESSAGE.length()));
    }
}