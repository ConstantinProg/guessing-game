using GuessingGame.Configuration;
using GuessingGame.Presentation;
using GuessingGame.Domain;

var game = new Game(FileConfigurationSource.Default, new ConsoleDisplayService());
game.Run();
