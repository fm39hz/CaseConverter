namespace CaseConverter;

public static class MainProgram
{
	public const string TestString = "MyFreakingAwsomeMethod";
	public static void Main()
	{
		Console.WriteLine(TestString);
		var _snakeCase = CaseConverter.PascalToSnake(TestString);
		Console.WriteLine(_snakeCase);
		var _pascalCase = CaseConverter.SnakeToPascal(_snakeCase);
		Console.WriteLine(_pascalCase);
	}
}