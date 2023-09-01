namespace CaseConverter;

public static class CaseConverter
{
	public static string PascalToSnake(string pascalCase)
	{
		if (!CaseAnalyzer.PascalAnalysis(pascalCase))
		{
			throw new ArgumentException("String is not in Pascal Case");
		}
		return pascalCase.Aggregate("", (current, character) => current + (character == char.ToUpper(character)? "_" + char.ToLower(character) : character)).Remove(0, 1);
	}

	public static string SnakeToPascal(string snakeCase)
	{
		if (!CaseAnalyzer.SnakeAnalysis(snakeCase))
		{
			throw new ArgumentException("String is not written in Snake Case");
		}
		var _pascalCase = "";
		for (var _i = 0; _i < snakeCase.Length; _i++)
		{
			var _isPrefix = _i > 0 && snakeCase[_i - 1] == '_';
			switch (_isPrefix)
			{
				case true:
					_pascalCase = _pascalCase.Remove(_pascalCase.Length - 1, 1);
					_pascalCase += char.ToUpper(snakeCase[_i]);
					break;
				case false:
					_pascalCase += snakeCase[_i];
					break;
			}
		}
		return char.ToUpper(snakeCase[0]) + _pascalCase.Remove(0, 1);
	}
}
