using SingletonPatternApp;

Logger logger = Logger.getInstance();

logger.LogDebug("hello I am debugging");
logger.LogInformation("hello I am info");
logger.LogWarning("hello I am a warning");
logger.LogError("hello I am an error");

logger.setLogLevel(LogLevel.ERROR);

Console.WriteLine("Error level");
Console.WriteLine("-----------------------------------");
logger.LogDebug("hello I am debugging");
logger.LogInformation("hello I am info");
logger.LogWarning("hello I am a warning");
logger.LogError("hello I am an error");

Logger loggerB = Logger.getInstance(); // same instance is returned

loggerB.LogDebug("hello I am debugging");
loggerB.LogInformation("hello I am info");
loggerB.LogWarning("hello I am a warning");
loggerB.LogError("hello I am an error");