namespace CaseConverter;

public static class MainProgram
{
	public static void Main()
	{
		const string pascalCase = "MyFreakingAwsomeMethod";
		Console.WriteLine(pascalCase);
		var _snakeCase = PascalCaseToSnakeCase(pascalCase);
		Console.WriteLine(_snakeCase);
	}

	public static string PascalCaseToSnakeCase(string pascalCase)
	{
		return pascalCase.Aggregate("", (current, character) => current + (character == char.ToUpper(character)? "_" + char.ToLower(character) : character)).Remove(0, 1);
	}
}