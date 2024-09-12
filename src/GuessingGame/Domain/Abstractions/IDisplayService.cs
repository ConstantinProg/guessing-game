using GuessingGame.Domain.Numbers;

namespace GuessingGame.Domain.Abstractions;

internal interface IDisplayService
{
    void StartUp();
    IConfigurationOptions ShowConfigurationOptions(IConfigurationOptions configuration);
    GuessNumber ShowGuessing(GuessingAttemptNumber guessingAttemptNumber, IConfigurationOptions options);
    void ShowGuessingClue(bool isGreaterThenSecretNumber);
    void ShowGameResult(bool isPlayerWin);
}