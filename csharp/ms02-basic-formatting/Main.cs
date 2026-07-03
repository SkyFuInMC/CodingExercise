using System;

public class Program {
	public static void Demo() {
		string escapedStringLiteral = "Hello\tworld!\n";
		string moreEscapedStringLiteral = "\\\"";
		string verbatimStringLiteral = @"verbatim string\";
		string unicodeStringLiteral = "";
		string interpolatedString = $"This is a {verbatimStringLiteral}.";
	}
	public static void Main() {
		string projectDirectory = @"c:\Exercise";
		string projectOutputFile = "data.txt";
		string projectName = "ACME";
		string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
		string projectPathENUS = $"{projectDirectory}\\{projectName}\\{projectOutputFile}";
		Console.WriteLine($"View English output:\n  {projectPathENUS}\n");
		string projectPathRURU = $"{projectDirectory}\\{projectName}\\ru-RU\\{projectOutputFile}";
		Console.WriteLine($"{russianMessage}:\n  {projectPathRURU}");
	}
}
