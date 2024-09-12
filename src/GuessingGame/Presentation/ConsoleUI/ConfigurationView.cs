using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Presentation.ConsoleUI;

internal class ConfigurationView
{
    public void ShowConfigurationOptions(IConfigurationOptions options)
    {
        Console.WriteLine(GameMessages.CURRENT_OPTIONS_TITLE);
        Console.WriteLine(GameMessages.MINIMUM_VALUE_OPTION + options.GetMinimumSecretNumberValue());
        Console.WriteLine(GameMessages.MAXIMUM_VALUE_OPTION + options.GetMaximumSecretNumberValue());
        Console.WriteLine(GameMessages.ATTEMPTS_NUMBER_OPTION + options.GetGuessingAttemptNumber());
    }

    public bool ShowCustomizationDialog()
    {
        Console.WriteLine(GameMessages.CHANGE_CONFIGURATION);
        var consoleKeyInfo = Console.ReadKey();
        return consoleKeyInfo.Key == ConsoleKey.O;
    }

    public IConfigurationOptions CreateNewConfigurationOptions()
    {
        var minimumNumber = RequestMinimumNumberFromUser();
        var maximumNumber = RequestMaximumNumberFromUser(minimumNumber);
        var guessingAttemptNumber = RequestGuessingAttemptNumberFromUser();
        var options = new CustomConfigurationOptions(minimumNumber, maximumNumber, guessingAttemptNumber);
        return options;
    }

    private MinimumNumber RequestMinimumNumberFromUser()
    {
        MinimumNumber? minimumNumber = null;
        while (minimumNumber == null)
        {
            Console.WriteLine(GameMessages.INPUT_MINIMUM_VALUE_OPTION);
            string? minimumNumberInput = Console.ReadLine();
            try
            {
                minimumNumber = new MinimumNumber(minimumNumberInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return minimumNumber!;
    }

    private MaximumNumber RequestMaximumNumberFromUser(MinimumNumber minimumNumber)
    {
        MaximumNumber? maximumNumber = null;
        while (maximumNumber == null)
        {
            Console.WriteLine(GameMessages.INPUT_MAXIMUM_VALUE_OPTION);
            string? maximumNumberInput = Console.ReadLine();
            try
            {
                maximumNumber = new MaximumNumber(maximumNumberInput, minimumNumber);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return maximumNumber!;
    }

    private GuessingAttemptNumber RequestGuessingAttemptNumberFromUser()
    {
        GuessingAttemptNumber? guessingAttemptNumber = null;
        while (guessingAttemptNumber == null)
        {
            Console.WriteLine(GameMessages.INPUT_ATTEMPTS_NUMBER_OPTION);
            string? guessingAttemptNumberInput = Console.ReadLine();
            try
            {
                guessingAttemptNumber = new GuessingAttemptNumber(guessingAttemptNumberInput);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return guessingAttemptNumber!;
    }
}
