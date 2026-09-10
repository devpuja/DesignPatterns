using Singleton;

var config1 = AppConfiguration.Instance;
var config2 = AppConfiguration.Instance;

Console.WriteLine(ReferenceEquals(config1, config2));