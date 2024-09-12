using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Presentation.ConsoleUI;

internal class GuessingView
{
    public GuessNumber ShowGuessing(GuessingAttemptNumber guessingAttemptNumber, IConfigurationOptions options)
    {
        Console.WriteLine(GameMessages.ATTEMPTS_LEFT_NUMBER + guessingAttemptNumber);
        return RequestGuessNumberFromUser(options.GetMinimumSecretNumberValue(), options.GetMaximumSecretNumberValue());
    }

    public void ShowGuessingClue(bool isGreaterThenSecretNumber)
    {
        if (isGreaterThenSecretNumber)
            Console.WriteLine(GameMessages.SECRET_NUMBER_IS_LESS_THEN_GUESS_NUMBER);
        else
            Console.WriteLine(GameMessages.SECRET_NUMBER_IS_GREATER_THEN_GUESS_NUMBER);
    }

    public void ShowGameResult(bool isPlayerWin)
    {
        if (isPlayerWin)
            Console.WriteLine(GameMessages.PLAYER_IS_WIN);
        else
            Console.WriteLine(GameMessages.PLAYER_IS_LOST);
    }

    private GuessNumber RequestGuessNumberFromUser(MinimumNumber minimumNumber, MaximumNumber maximumNumber)
    {
        GuessNumber? guessNumber = null;
        while (guessNumber == null)
        {
            Console.WriteLine(GameMessages.INPUT_GUESS);
            string? guessNumberInput = Console.ReadLine();
            try
            {
                guessNumber = new GuessNumber(guessNumberInput, minimumNumber, maximumNumber);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return guessNumber!;
    }
}
