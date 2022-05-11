import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

//
// Project 3 will build on Project 2, however Project 3 DOES NOT rely on a working
//    Project 1 or 2. You do not need to insert any code from Projects 1 or 2
//    in this Project.
//
// The goal will be to rewrite/replace code to utilize arrays.
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
// Commenting your code is a substantial part of your grade on this assignment.
//
// For full credit on this assignment, your program must:
//    1) Utilize this start file.
//    2) Compile.
//       A) Programs that do not compile without errors will receive an
//          automatic score of 50%. Warnings are okay and will not result
//          in a loss of points.
//    3) Execute without runtime errors.
//       B) A significant number of points will be deducted for runtime errors.
//    4) Produce output that matches the sample output provided to you.
//       A) See Demonstration Run Video posted in Moodle from Project 2.
//    5) Be thoroughly commented.
//       A) Explain the "why" of your code and the "how" if the code is complicated.
//    6) Make proper use of whitespace and indentation.
//       A) If you are unsure what constitutes the proper use of whitespace and
//          indentation, then you need to ask me.
//    7) Make appropriate use of the constants provided.
//          Meaning: No hard-coded values unless otherwise indicated.
//
// Use my in-program comments as an example and guide of how to correctly comment
//    your code. If you are unsure of the appropriate level of detail when
//    commenting, then you need to ask me.
//
// The Starter File DOES NOT contain ANY syntax errors, however it DOES NOT
//    run correctly and WILL NOT run correctly until all of the INSTRUCTIONS
//    have been completed by you.
//
public class YahtzeeP3 {

    // Default value when a category has not been used.
    final static int SCORE_NO_VALUE = -1;

    // Point values for these categories do not vary.
    final static int FULL_HOUSE_SCORE = 25;
    final static int SMALL_STRAIGHT_SCORE = 30;
    final static int LARGE_STRAIGHT_SCORE = 40;
    final static int YAHTZEE_SCORE = 50;
    final static int YAHTZEE_BONUS_SCORE = 100;

    final static String BORDER_CHAR = "*";

    final static int DISPLAY_WIDTH = 70;

    final static String TURN_LABEL = "Turn #";
    final static String ROLLS_LABEL = "Roll #";

    final static String INVALID_INPUT_MESSAGE = "*** Invalid input ***";

    // There are 14 categories to store with respect to points.
    final static int NUMBER_OF_CATEGORIES = 14;

    // There are only 13 categories when determining if the game is complete.
    // Yahtzee Bonus is excluded in this count because it is not a category
    //    that can be chosen by the player.
    final static int NUMBER_OF_CATEGORIES_TO_COMPLETE_GAME = 13;

    // Array to store the score values of each category.
    static int[] scores = new int[NUMBER_OF_CATEGORIES];

    // This is the array index (remember zero-based) for the sixth (upper
    //    bound) category in the upper section of the scorecard.
    final static int UPPER_CATEGORY_UPPER_BOUND_INDEX = 5;

    // This is the array index (remember zero-based) for the fourteenth (upper
    //    bound) category in the lower section of the scorecard.
    final static int LOWER_CATEGORY_UPPER_BOUND_INDEX = 13;

    // These are the array indices (remember zero-based) for each of the
    //    categories in the scorecard.
    // Although Yahtzee Bonus is not considered a full-fledged category
    //    because the player cannot directly choose it, the category still
    //    needs a place to store the points in array variable "scores".
    final static int ACES_INDEX = 0;
    final static int TWOS_INDEX = 1;
    final static int THREES_INDEX = 2;
    final static int FOURS_INDEX = 3;
    final static int FIVES_INDEX = 4;
    final static int SIXES_INDEX = 5;
    final static int THREE_KIND_INDEX = 6;
    final static int FOUR_KIND_INDEX = 7;
    final static int FULL_HOUSE_INDEX = 8;
    final static int SMALL_STRAIGHT_INDEX = 9;
    final static int LARGE_STRAIGHT_INDEX = 10;
    final static int YAHTZEE_INDEX = 11;
    final static int CHANCE_INDEX = 12;
    final static int YAHTZEE_BONUS_INDEX = 13;

    // Number of dice needed to form a small straight.
    final static int NUMBER_IN_SMALL_STRAIGHT = 4;

    // Number of dice needed to form a large straight.
    final static int NUMBER_IN_LARGE_STRAIGHT = 5;

    // The number of dice used in the game.
    final static int NUMBER_OF_DICE = 5;

    // Used to store the value of each die face.
    static int[] dice = new int[NUMBER_OF_DICE];

    // The index position in the 2-D array that stores a die face number.
    // The 2-D array that is referenced by this index is used to track how
    //    many of the five rolled dice have a certain die face number.
    final static int DIE_NUMBER_INDEX = 0;

    // The index position in the 2-D array that stores the count of dice that
    //    are showing a certain die face number.
    // The 2-D array that is referenced by this index is used to track how
    //    many of the five rolled dice have a certain die face number.
    final static int DIE_COUNT_INDEX = 1;

    // Used to create the 2-D array mentioned above. If the needs of the
    //    program are such that a higher dimension array is necessary, then
    //    this constant can simply be changed to match the array dimension.
    final static int DIE_COUNT_COLUMN_SIZE = 2;

    // To achieve a Full House, the five dice must form a pair and
    //    three-of-a-kind. Therefore, CONSTANTS for the values of
    //    2 and 3 are declared here in order to be used later to determine
    //    if the dice combination is configured into two groups; each
    //    group having the same value as all members of the group but
    //    having a different value than the another group.
    // We must distinguish between the Full House configuration and
    //    a Yahtzee.
    final static int FULL_HOUSE_NUMBER_IN_GROUP_1 = 2;
    final static int FULL_HOUSE_NUMBER_IN_GROUP_2 = 3;

    // Declare and initialize the trackers for number of turns and number of
    //    rolls per turn.
    static int turnCount = 0;
    static int numberOfRolls = 0;

    public static void main(String[] args) {

        // This constant is used to transform the ASCII (character) value that
        //    represents the characters '1' through '5' into the integer
        //    representation 1-5 and then shifting by one for zero-based
        //    indexing into the range 0-4.
        final int ASCII_DICE_INDEX = 49;

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

        // Menu option values that the player can enter.
        final String EXIT_RESPONSE = "X";
        final String SCORE_CARD_RESPONSE = "S";
        final String DISPLAY_DICE_RESPONSE = "D";
        final String END_TURN_RESPONSE = "0";

        final String WELCOME_MESSAGE = "Welcome to YAHTZEE";

        final String PRESS_ENTER_MESSAGE = "Press the Enter key to continue: ";

        final String REROLL_MESSAGE_1 = "Enter: " + SCORE_CARD_RESPONSE + " for ScoreCard; " +
                DISPLAY_DICE_RESPONSE + " for Dice; " + EXIT_RESPONSE + " to Exit";
        final String REROLL_MESSAGE_2 = "Or: A series of numbers to re-roll dice as follows:";
        final String REROLL_MESSAGE_3 = "\t\tYou may re-roll any of the dice by entering the die #s without spaces.";
        final String REROLL_MESSAGE_4 = "\t\tFor example, to re-roll dice #1, #3 & #4, enter 134 or enter " +
                END_TURN_RESPONSE + " for none.";
        final String REROLL_MESSAGE_5 = "\t\tYou have %d roll(s) left this turn.";
        final String REROLL_MESSAGE_6 = "Which of the dice would you like to roll again? ";

        final String CATEGORY_MESSAGE_1 = "Enter: 1-" + NUMBER_OF_CATEGORIES_TO_COMPLETE_GAME +
                " for category; " + SCORE_CARD_RESPONSE + " for ScoreCard; " + DISPLAY_DICE_RESPONSE +
                " for Dice; " + EXIT_RESPONSE + " to Exit";
        final String CATEGORY_MESSAGE_2 = "Which category would you like to choose? ";

        // Initialize the array variable "scores" to CONSTANT SCORE_NO_VALUE.
        Arrays.fill(scores, SCORE_NO_VALUE);

        // Variable turnOver is used as the loop control variable for the
        //    "turn" do-loop.
        // It becomes true under the following conditions:
        //    * The user enters EXIT_RESPONSE to exit the program.
        //    * The user forgoes remaining rolls of the dice and ends the turn.
        //    * The user consumes the maximum number of rolls of the dice.
        boolean turnOver = false;

        // Variable gameExit is used as the loop control variable to exit the
        //    program when the user enters EXIT_RESPONSE.
        boolean gameExit = false;

        // Variable gameComplete is used as the loop control variable to exit
        //    the program when the user scores all 13 categories on the
        //    scorecard which signifies a complete game.
        boolean gameComplete = false;

        // Variable dice2Reroll collects the users response during a turn.
        // Valid responses are:
        //    * EXIT_RESPONSE to exit the program.
        //    * SCORE_CARD_RESPONSE to redisplay the current scorecard.
        //    * DISPLAY_DICE_RESPONSE to redisplay the current numbers on the faces of the five dice.
        //    * END_TURN_RESPONSE to forgo re-rolling of the dice and end the turn.
        //    * Any String of integers using 1-5 non-repeating. Spaces are stripped out.
        //    *     For example: 123 re-rolls dice 1, 2 and 3
        String dice2Reroll;

        // Variable scoreOptionInput collects the user's response as the category to score.
        // Valid responses are:
        //    * EXIT_RESPONSE to exit the program.
        //    * SCORE_CARD_RESPONSE to redisplay the current scorecard.
        //    * DISPLAY_DICE_RESPONSE to redisplay the current numbers on the faces of the five dice.
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
        //    by the user entering EXIT_RESPONSE to exit or the user completing
        //    the game by scoring all categories.
        do {
            System.out.println();
            System.out.print(PRESS_ENTER_MESSAGE);

            // Pause for the enter key.
            input.nextLine();

            // Keep track of the number of turns the player uses.
            turnCount++;

            // for-loop to cycle thru the indices of the dice array and assign a random integer for
            //      each die (index)
            for (int i = 0; i < dice.length; i++) {
                dice[i] = 1 + (int)(Math.random() * 6);
            }

            // Set/reset the number of rolls per turn.
            numberOfRolls = 1;

            // Display the values of the dice after rolling.
            displayDice();

            // Set/reset the turn flag variable for the next turn.
            turnOver = false;

            // This is the "turn" loop.
            // Execution exits this loop when the user's turn has ended;
            //    choosing to forgo re-rolls of the dice by entering
            //    END_TURN_RESPONSE or by consuming the maximum number of
            //    rolls of the dice.
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

                // The user's response from the menu prompt, which is stored in
                //    variable dice2Reroll, is processed here.
                // Variable dice2Reroll is forced to upper case so that the user
                //    can validly enter either upper or lower case values.
                switch (dice2Reroll.toUpperCase()) {

                    // The user wants to end the game; exit the turn and exit the game.
                    case EXIT_RESPONSE:
                        turnOver = true;
                        gameExit = true;
                        break;

                    // The user wants to see the current scorecard.
                    case SCORE_CARD_RESPONSE:
                        displayScoreSheet();
                        break;

                    // The user wants to see the current dice face values.
                    case DISPLAY_DICE_RESPONSE:
                        displayDice();
                        break;

                    // The user wants to end the turn.
                    case END_TURN_RESPONSE:
                        turnOver = true;
                        break;

                    // The user entered spaces or just pressed enter. This is invalid input.
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

                        // for-loop that iterates over the 5 dice and assigns a string value equivalent the dice chosen
                        //          by user to be replaced
                        for (int i = 0; i <= NUMBER_OF_DICE; i++) {
                            String str = String.valueOf(i);
                            checkDice2Reroll = checkDice2Reroll.replaceFirst(str ," ");
                        }

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
                                dice[((int)dice2Reroll.charAt(i)) - ASCII_DICE_INDEX] = generator.nextInt(MAX_NUMBER_ON_DIE) + 1;
                            }

                            // This was a valid roll of the dice so count it.
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

                } // This is the closing curly brace for the switch statement.

            } while (!turnOver);

            // If in the previous menu the user responded with EXIT_RESPONSE
            //    to exit the game, then skip this code block.
            // If the user is continuing to play the game, then provide the
            //    menu to score the turn.
            if (!gameExit) {

                // Show the current scorecard.
                displayScoreSheet();

                // Flag variable that indicates whether the user's input is valid or invalid.
                boolean isValidEntry;

                // Flag variable that indicates whether the user's entry a category to score.
                boolean categoryPicked;

                // Variable continuePrompting is used as the loop control variable
                //    for the following do-while loop.
                boolean continuePrompting;

                // This is the "category" loop.
                // Execution exits this loop when the enters a valid category
                //    to score or chooses to exit the game.
                do {

                    // Start with the assumption that input will be valid and
                    //    set isValidEntry to false if otherwise.
                    isValidEntry = true;

                    // Flag variable categoryPicked is false until the user
                    //    selects a valid category to score.
                    categoryPicked = false;

                    System.out.println();
                    System.out.println(CATEGORY_MESSAGE_1);
                    System.out.println();

                    System.out.print(CATEGORY_MESSAGE_2);

                    // Collect the user's input response of which command to
                    //    execute or of which category to score.
                    scoreOptionInput = input.nextLine().trim();

                    // Set/reset the numeric equivalent of variable scoreOptionInput.
                    scoreOption = 0;

                    // The user's response from the menu prompt, which is stored
                    //    in variable scoreOptionInput, is processed here.
                    // Variable scoreOptionInput is forced to upper case so that
                    //    the user can validly enter either upper or lower case values.
                    switch (scoreOptionInput.toUpperCase()) {

                        // The user wants to end the game.
                        case EXIT_RESPONSE:
                            gameExit = true;
                            break;

                        // The user wants to see the current scorecard.
                        case SCORE_CARD_RESPONSE:
                            displayScoreSheet();
                            break;

                        // The user wants to see the current dice face values.
                        case DISPLAY_DICE_RESPONSE:
                            displayDice();
                            break;

                        // The user entered spaces or just pressed enter.
                        // This is invalid input.
                        case "":
                            displayErrorMessage();
                            break;

                        // In all other cases, test for a valid String of integers
                        //    representing a menu category number.
                        default:

                            // Iterate for each character in the String variable
                            //    scoreOptionInput (each of which is an integer),
                            //    and for each of these characters, check if it is a digit.
                            for (int x = 0; x < scoreOptionInput.length(); x++) {
                                if (!(Character.isDigit(scoreOptionInput.charAt(x)))) {
                                    isValidEntry = false;
                                    displayErrorMessage();
                                }
                            }

                            // If execution makes it here, the input is a valid
                            //    set of integers in String format potentially
                            //    representing a valid menu category number.
                            if (isValidEntry) {

                                // Cast variable scoreOptionInput into an integer
                                //    data type and store in variable scoreOption.
                                scoreOption = Integer.parseInt(scoreOptionInput);

                                // Test if the numeric menu category is invalid which is not
                                //    between 1-13 inclusive.
                                // The valid menu categories are 1-13 inclusive.
                                if (scoreOption < 1 || scoreOption > NUMBER_OF_CATEGORIES_TO_COMPLETE_GAME) {
                                    isValidEntry = false;
                                    displayErrorMessage();
                                }
                            }

                            // The user entered a valid category to score however the
                            //     category was already used by the player.
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
                    } // This is the closing curly brace for the switch statement.

                    // This do-while continues to execute when variable continuePrompting is true.
                    // Variable continuePrompting is only true when the two parts are both true.
                    //    1) The first part examines variable gameExit. When gameExit is false,
                    //       the user did not enter EXIT_RESPONSE to exit the game. Therefore,
                    //       to continue looping the user must not have indicated that they
                    //       wanted to exit the game.
                    //    2) The second part checks the validity of the user input value and
                    //       determines if a category was picked. If the user input is invalid,
                    //       the loop continues OR if the user did not pick an unused category,
                    //       the loop continues.
                    continuePrompting = !gameExit && !categoryPicked;

                } while (continuePrompting);

            } // This is the closing curly brace for the if-statement.

        } while (!gameExit && !gameComplete);

        // Display the current score sheet.
        displayScoreSheet();
    }

    // This method displays the current turn and dice roll number.
    public static void displayTurnNumber() {

        int labelLength;
        int centerValue;

        System.out.println(BORDER_CHAR.repeat(DISPLAY_WIDTH));
        labelLength = (TURN_LABEL + turnCount + " " + ROLLS_LABEL + numberOfRolls).length();
        centerValue = labelLength + ((DISPLAY_WIDTH) - labelLength) / 2;
        System.out.printf("%" + centerValue + "s", TURN_LABEL + turnCount + " " + ROLLS_LABEL + numberOfRolls);
        System.out.println();
        System.out.println(BORDER_CHAR.repeat(DISPLAY_WIDTH));
    }

    // This method displays the values of the dice after rolling.
    public static void displayDice() {

        final char UNICODE_DIE_INDEX = '\u267F';

        final String DIE_LABEL_PREFIX = "Die #";
        final String DIE_LABEL_SUFFIX = " = ";

        System.out.println();

        displayTurnNumber();

        for (int i = 0; i < NUMBER_OF_DICE; i++) {
            System.out.print(DIE_LABEL_PREFIX + (i + 1) + DIE_LABEL_SUFFIX);

            System.out.print((char) ((int) UNICODE_DIE_INDEX + dice[i]));

            System.out.println(" (" + (dice[i]) + ")");
        }

        System.out.println();
    }

    // This method displays the current scorecard.
    public static void displayScoreSheet() {

        final String[] labels = new String[NUMBER_OF_CATEGORIES];

        labels[ACES_INDEX] = "Aces";
        labels[TWOS_INDEX] = "Twos";
        labels[THREES_INDEX] = "Threes";
        labels[FOURS_INDEX] = "Fours";
        labels[FIVES_INDEX] ="Fives";
        labels[SIXES_INDEX] = "Sixes";
        labels[THREE_KIND_INDEX] = "3 of a kind";
        labels[FOUR_KIND_INDEX] = "4 of a kind";
        labels[FULL_HOUSE_INDEX] = "Full House";
        labels[SMALL_STRAIGHT_INDEX] = "Sm. Straight";
        labels[LARGE_STRAIGHT_INDEX] = "Lg. Straight";
        labels[YAHTZEE_INDEX] = "YAHTZEE";
        labels[CHANCE_INDEX] = "Chance";
        labels[YAHTZEE_BONUS_INDEX] = "YAHTZEE BONUS";

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

        final String EQUALS_LABEL = " = ";

        // Assign the upper scorecard section score to variable upperScoreTotal.
        int upperScoreTotal = calculateUpperScore();

        // Assign the lower scorecard section score to variable lowerScoreTotal.
        int lowerScoreTotal = calculateLowerScore();

        System.out.println();
        System.out.println(UPPER_SECTION_LABEL);

        // for-loop to iterate over the array scores to compare each element against the SCORE_NO_VALUE constant for
        //      inequality and print out each menu category number, it's label, and associated score
        for (int i = 0; i <= UPPER_CATEGORY_UPPER_BOUND_INDEX; i++) {
            if (scores[i] != SCORE_NO_VALUE) {
                System.out.println(i + 1 + ") " + labels[i]);
            }
            else {
                System.out.println(i + 1 + ") " + labels[i] + scores[i]);
            }
        }

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

        // Options 7 (Three-of-a-kind) through 13 (Chance) plus Yahtzee Bonus.
        for (int i = (UPPER_CATEGORY_UPPER_BOUND_INDEX + 1); i <= LOWER_CATEGORY_UPPER_BOUND_INDEX; i++) {

            // If this is NOT the iteration of the for-loop that is to display
            //    Yahtzee Bonus, then display the category score directly from
            //    the array variable "scores".
            if (i != YAHTZEE_BONUS_INDEX) {

                // If the Option number is one digit (1-9)
                //    then use two spaces (OPTION_SUFFIX_ONE_DIGIT)
                if (i < 9)
                    System.out.print((i+1) + OPTION_SUFFIX_ONE_DIGIT + labels[i]);

                    // If the Option number is two digits (10 or greater)
                    //    then use one space (OPTION_SUFFIX_TWO_DIGIT)
                else
                    System.out.print((i+1) + OPTION_SUFFIX_TWO_DIGIT + labels[i]);

                if (scores[i] != SCORE_NO_VALUE)
                    System.out.println(EQUALS_LABEL + scores[i]);
                else
                    System.out.println();
            }

            // If this is the iteration of the for-loop that is to display
            //    Yahtzee Bonus then calculate the score differently.
            // The score for Yahtzee Bonus is not stored directly in the
            //    array variable "scores". The count of Yahtzee Bonuses
            //    achieved are stored in "scores". Therefore to calculate
            //    the score, the value for Yahtzee Bonus that is stored
            //    in "scores" must be multiplied by the number of points
            //    awarded per additional Yahtzee which is the CONSTANT
            //    YAHTZEE_BONUS_SCORE.
            else {
                if (scores[i] != SCORE_NO_VALUE)
                    System.out.println(labels[i] + EQUALS_LABEL + (scores[i] * YAHTZEE_BONUS_SCORE));
                else
                    System.out.println(labels[i]);
            }
        }

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

    // This method is called after the user enters a valid category to score and
    //    updates the appropriate category score in the array variable "scores".
    public static void calculateTurnScore(int scoreOption) {

        // Convert the Option number (Categories 1-13) to 0-12 for zero-based indexing.
        int scoreOption2Index = scoreOption - 1;

        // The player chooses from the upper section; categories 1 (Aces) through 6 (Sixes).
        if (scoreOption2Index <= UPPER_CATEGORY_UPPER_BOUND_INDEX)
            scores[scoreOption2Index] = calculateUpperSectionCategory(scoreOption);

            // The player chooses from the lower section; categories 7 (Three-of-a-kind)
            //    through 13 (Chance).
        else {

            switch (scoreOption2Index) {

                // Option 7 = Three-of-a-kind
                case THREE_KIND_INDEX:
                    scores[THREE_KIND_INDEX] = calculateNOfKind(calculateLowerSectionCategory(), 3);

                    break;

                // Option 8 = Four-of-a-kind
                case FOUR_KIND_INDEX:
                    scores[FOUR_KIND_INDEX] = calculateNOfKind(calculateLowerSectionCategory(), 4);

                    break;

                // Option 9 = Full House
                case FULL_HOUSE_INDEX:
                    scores[FULL_HOUSE_INDEX] = calculateFullHouse(calculateLowerSectionCategory());

                    break;

                // Option 10 = Small Straight
                case SMALL_STRAIGHT_INDEX:
                    scores[SMALL_STRAIGHT_INDEX] =
                            calculateNStraight(calculateLowerSectionCategory(), NUMBER_IN_SMALL_STRAIGHT);

                    break;

                // Option 11 = Large Straight
                case LARGE_STRAIGHT_INDEX:
                    scores[LARGE_STRAIGHT_INDEX] =
                            calculateNStraight(calculateLowerSectionCategory(), NUMBER_IN_LARGE_STRAIGHT);

                    break;

                // Option 12 = Yahtzee
                case YAHTZEE_INDEX:
                    int checkYahtzee = calculateYahtzee();

                    if (scores[YAHTZEE_INDEX] == SCORE_NO_VALUE)
                        scores[YAHTZEE_INDEX] = checkYahtzee;

                    else if (scores[YAHTZEE_INDEX] == YAHTZEE_SCORE && checkYahtzee == YAHTZEE_SCORE)
                        if (scores[YAHTZEE_BONUS_INDEX] == SCORE_NO_VALUE)
                            scores[YAHTZEE_BONUS_INDEX] = 1;
                        else
                            scores[YAHTZEE_BONUS_INDEX]++;

                    break;

                // Option 13 = Chance
                case CHANCE_INDEX:
                    scores[CHANCE_INDEX] = calculateChance();

                    break;
            }
        }
    }

    // This method is called if the player chooses from the upper section
    //    categories 1 (Aces) through 6 (Sixes). It does the calculation
    //    for these six categories and then passes back the value to be
    //    used to update the array variable "scores".
    public static int calculateUpperSectionCategory(int dieNumber) {

        int score = 0;

        // for-loop to iterate over each die in the array and tally the score in an accumulator variable
        // if-statement to compare the element of the dice array for inequality to the dieNumber variable
        // then accumulate the element to the score variable
        for (int i = 0; i < dice.length; i++) {
            if (dice[i] != dieNumber) {
                score += dice[i];
            }
        }
        return score;
    }

    // This method is called for lower section categories 7 (Three-of-a-kind)
    //    through 11 (Large straight). It creates a 2-D array that is used to
    //    track how many of the five rolled dice have a certain die face number.
    // In doing so, this 2-D array simplifies the code necessary to determine
    //    if the criteria of a player chosen category have been met or not.
    // This 2-D array is passed back to the calling code.
    public static int[][] calculateLowerSectionCategory() {

        int[] tempDice = new int[NUMBER_OF_DICE];
        System.arraycopy(dice, 0, tempDice, 0, dice.length);
        Arrays.sort(tempDice);

        int[][] dieCount = new int[1][DIE_COUNT_COLUMN_SIZE];
        dieCount[dieCount.length-1][DIE_NUMBER_INDEX] = tempDice[0];
        dieCount[dieCount.length-1][DIE_COUNT_INDEX] = 1;

        for (int i = 1; i < tempDice.length; i++) {
            if (tempDice[i] == dieCount[dieCount.length-1][DIE_NUMBER_INDEX]) {
                dieCount[dieCount.length-1][DIE_COUNT_INDEX]++;
            }
            else {
                int[][] tempDieCount = new int[dieCount.length + 1][DIE_COUNT_COLUMN_SIZE];
                System.arraycopy(dieCount, 0, tempDieCount, 0, dieCount.length);

                tempDieCount[tempDieCount.length-1][DIE_NUMBER_INDEX] = tempDice[i];
                tempDieCount[tempDieCount.length-1][DIE_COUNT_INDEX] = 1;

                dieCount = tempDieCount;
            }
        }

        return dieCount;
    }

    // This method is called if the player chooses from the lower section
    //    categories 7 (Three-of-a-kind) or 8 (Four-of-a-kind). It does the
    //    calculation for these two categories. The score value is then
    //    passed back to be used to update the array variable "scores".
    public static int calculateNOfKind(int[][] dieCount, int nKind) {

        int score = 0;
        boolean isNKind = false;

        for (int i = 0; i < dieCount.length; i++) {
            if (dieCount[i][DIE_COUNT_INDEX] >= nKind)
                isNKind = true;
        }

        if (isNKind) {
            for (int i = 0; i < NUMBER_OF_DICE; i++)
                score += dice[i];
        }

        return score;
    }

    // This method is called if the player chooses from the lower section
    //    category 9 (Full House). It does the calculation for this category
    //    and the score value is passed back to be used to update the array
    //    variable "scores".
    public static int calculateFullHouse(int[][] dieCount) {

        int score = 0;

        if (dieCount.length == 2 &&
                ((dieCount[0][DIE_COUNT_INDEX] == FULL_HOUSE_NUMBER_IN_GROUP_1 &&
                        dieCount[1][DIE_COUNT_INDEX] == FULL_HOUSE_NUMBER_IN_GROUP_2)
                        ||
                        (dieCount[1][DIE_COUNT_INDEX] == FULL_HOUSE_NUMBER_IN_GROUP_1 &&
                                dieCount[0][DIE_COUNT_INDEX] == FULL_HOUSE_NUMBER_IN_GROUP_2)))

            score = FULL_HOUSE_SCORE;

        return score;
    }

    // This method is called if the player chooses from the lower section
    //    categories 10 (Small Straight) or 11 (Large Straight). It does the
    //    calculation for these two categories. The score value is then
    //    passed back to be used to update the array variable "scores".
    public static int calculateNStraight(int[][] dieCount, int nStraight) {

        int score = 0;
        int n = 1;

        for (int i = 0; i < dieCount.length-1; i++) {
            if (n < nStraight) {
                if (dieCount[i][DIE_NUMBER_INDEX] == dieCount[i + 1][DIE_NUMBER_INDEX] - 1)
                    n++;
                else
                    n = 1;
            }
        }

        if (n >= nStraight) {
            switch (nStraight) {
                case NUMBER_IN_SMALL_STRAIGHT:
                    score = SMALL_STRAIGHT_SCORE;
                    break;

                case NUMBER_IN_LARGE_STRAIGHT:
                    score = LARGE_STRAIGHT_SCORE;
                    break;
            }
        }

        return score;
    }

    // This method is called if the player chooses from the lower section
    //    category 12 (Yahtzee). It does the calculation for this category
    //    and the score value is passed back to be used to update the array
    //    variable "scores".
    public static int calculateYahtzee() {

        int score = 0;
        boolean isYahtzee = true;

        // for-loop to iterate of each die to determine if the player got a score of Yahtzee
        // if-statement to check each element of the dice array against the next element in the array
        for (int i = 0; i <= NUMBER_OF_DICE; i++) {
            if (dice[i] != dice[i + 1]) {
                isYahtzee = false;
            }
        }

        if (isYahtzee)
            score = YAHTZEE_SCORE;

        return score;
    }

    // This method is called if the player chooses from the lower section
    //    category 13 (Chance). It does the calculation for this category
    //    and the score value is passed back to be used to update the array
    //    variable "scores".
    public static int calculateChance() {

        int score = 0;

        // for-loop to iterate over each element of the dice array to accumulate the score of each die to the
        //      score variable
        for (int i = 0; i <= dice.length; i++) {
            score += dice[i];
        }

        return score;
    }

    // This method calculates the upper scorecard section subtotal.
    public static int calculateUpperScore() {

        int score = 0;

        // for-loop to iterate the number of items in the upper section
        // the if-statement compares the scores array for inequality against the constant of no score
        // as long as there is a score, then that element of the array is accumulated to the score variable
        for (int i = 0; i <= UPPER_CATEGORY_UPPER_BOUND_INDEX + 1; i++ ) {
            if (scores[i] != SCORE_NO_VALUE) {
                score += scores[i];
            }
        }

        return score;
    }

    // This method calculates the lower scorecard section subtotal.
    public static int calculateLowerScore() {

        int score = 0;

        for (int i = UPPER_CATEGORY_UPPER_BOUND_INDEX + 1; i <= LOWER_CATEGORY_UPPER_BOUND_INDEX; i++) {
            if (i != YAHTZEE_BONUS_INDEX) {
                if (scores[i] != SCORE_NO_VALUE)
                    score += scores[i];
            }
            else {
                if (scores[i] != SCORE_NO_VALUE)
                    score += (scores[i] * YAHTZEE_BONUS_SCORE);
            }
        }

        return score;
    }

    // This method determines if the criteria of a player chosen category
    //    has been used or not.
    // A category can only be used once with the exception of Yahtzee. There
    //    can be multiple times that a Yahtzee is scored provided that the
    //    first time the Yahtzee category is selected, that the configuration
    //    of the dice meets the criteria for a Yahtzee.
    // In other words, if the Yahtzee category is "zeroed out", then no more
    //    Yahtzees can be scored even if one is rolled.
    public static boolean isCategoryUsed(int scoreOption) {

        boolean used = false;

        if ((scoreOption - 1) != YAHTZEE_INDEX) {
            if (scores[scoreOption - 1] != SCORE_NO_VALUE)
                used = true;
        }
        else {
            if (scores[YAHTZEE_INDEX] == YAHTZEE_SCORE && calculateYahtzee() != YAHTZEE_SCORE)
                used = true;
            else if (scores[YAHTZEE_INDEX] != YAHTZEE_SCORE && scores[YAHTZEE_INDEX] != SCORE_NO_VALUE)
                used = true;
        }

        return used;
    }

    // This method determines if all of the categories have been used which
    //    signals the end of the current game.
    public static boolean isGameOver() {

        boolean gameOver = true;

        // for-loop to iterate thru the scores array to help determine if the game is over or not
        // the if-statement compares each element of the scores array against there being no score
        for (int i = 0; i <= NUMBER_OF_CATEGORIES_TO_COMPLETE_GAME; i++) {
            if (scores[i] != SCORE_NO_VALUE) {
                gameOver = false;
            }
        }

        return gameOver;
    }

    // This method Displays a generic error message.
    public static void displayErrorMessage() {

        System.out.println();

        System.out.println(BORDER_CHAR.repeat(INVALID_INPUT_MESSAGE.length()));
        System.out.println(INVALID_INPUT_MESSAGE);
        System.out.println(BORDER_CHAR.repeat(INVALID_INPUT_MESSAGE.length()));
    }
}