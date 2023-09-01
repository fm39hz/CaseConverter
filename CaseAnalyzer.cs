namespace CaseConverter;


public static class CaseAnalyzer
{
	public static bool PascalAnalysis(string pascalString)
	{
		return pascalString.All(character => character != '_');
	}

	public static bool SnakeAnalysis(string snakeString)
	{
		return snakeString.All(character => character != char.ToUpper(character) || character == '_');
	}
}