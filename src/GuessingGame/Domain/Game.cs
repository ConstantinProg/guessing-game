using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Domain;

internal class Game
{
    private IConfigurationSource _configurationSource;
    private IDisplayService _displayService;

    public Game(IConfigurationSource configurationSource, IDisplayService displayService)
    {
        _configurationSource = configurationSource;
        _displayService = displayService;
    }

    public void Run()
    {
        _displayService.StartUp();
        var options = _configurationSource.GetConfigurationOptions();
        options = _displayService.ShowConfigurationOptions(options);
        _configurationSource.SaveConfigurationOptions(options);
        var attemptsLeftNumber = options.GetGuessingAttemptNumber();
        var secretNumber = new SecretNumberGenarator(options).GenerateSecretNumber();
        while (attemptsLeftNumber.IsGreaterThenZero)
        {
            var guessNumber = _displayService.ShowGuessing(attemptsLeftNumber, options);
            if (secretNumber.IsEquals(guessNumber))
                break;
            else
                _displayService.ShowGuessingClue(isGreaterThenSecretNumber: guessNumber.IsGreaterThen(secretNumber));
            attemptsLeftNumber.ReduceByOneAttempt();
        }
        _displayService.ShowGameResult(isPlayerWin: attemptsLeftNumber.IsGreaterThenZero);
    }
}
