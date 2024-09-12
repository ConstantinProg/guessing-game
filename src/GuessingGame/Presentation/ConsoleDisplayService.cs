using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;
using GuessingGame.Presentation.ConsoleUI;

namespace GuessingGame.Presentation;

internal class ConsoleDisplayService : IDisplayService
{
    private readonly ConfigurationView _configurationView = new();
    private readonly GuessingView _guessingView = new();

    public void StartUp()
    {
        Console.Title = GameMessages.TITLE;
        Console.WriteLine(GameMessages.WELCOME);
    }

    public IConfigurationOptions ShowConfigurationOptions(IConfigurationOptions options)
    {
        _configurationView.ShowConfigurationOptions(options);
        if (_configurationView.ShowCustomizationDialog())
            return _configurationView.CreateNewConfigurationOptions();
        return options;
    }

    public GuessNumber ShowGuessing(GuessingAttemptNumber guessingAttemptNumber, IConfigurationOptions options)
    {
        return _guessingView.ShowGuessing(guessingAttemptNumber, options);
    }

    public void ShowGuessingClue(bool isGreaterThenSecretNumber)
    {
        _guessingView.ShowGuessingClue(isGreaterThenSecretNumber);
    }

    public void ShowGameResult(bool isPlayerWin)
    {
        _guessingView.ShowGameResult(isPlayerWin);
    }
}
