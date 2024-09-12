using System.Net.Sockets;

namespace GuessingGame.Presentation.ConsoleUI;

internal class GameMessages
{
    public const string TITLE = "Guessing Game";
    public const string WELCOME = "Welcome to guessing game!";
    public const string CURRENT_OPTIONS_TITLE = "Current game options:";
    public const string MINIMUM_VALUE_OPTION = "Minimum value of the secret number: ";
    public const string MAXIMUM_VALUE_OPTION = "Maximum value of the secret number: ";
    public const string ATTEMPTS_NUMBER_OPTION = "Number of attempts to guess the secret number: ";
    public const string CHANGE_CONFIGURATION = "If you want to change the game options, press the O key.";
    public const string INPUT_MINIMUM_VALUE_OPTION = "Please input minimum value of the secret number.";
    public const string INPUT_MAXIMUM_VALUE_OPTION = "Please input maximum value of the secret number.";
    public const string INPUT_ATTEMPTS_NUMBER_OPTION = "Please input number of attempts to guess the secret number.";
    public const string INPUT_GUESS = "Please input your guess.";
    public const string INPUT_NUMBER_ERROR = "Please type a number!";
    public const string ATTEMPTS_LEFT_NUMBER = "Attempts left: .";
    public const string SECRET_NUMBER_IS_LESS_THEN_GUESS_NUMBER = "Too big!";
    public const string SECRET_NUMBER_IS_GREATER_THEN_GUESS_NUMBER = "Too small!";
    public const string PLAYER_IS_WIN = "Congratulations! You guessed the number!";
    public const string PLAYER_IS_LOST = "You lost! You'll do better next time!";
}
