using System;

public class Program {
	public static void Demo() {
		string stringLiteral = "00";
		char characterLiteral = '0';
		int integerLiteral = 0;
		float floatLiteral = 0F;
		double doubleRawLiteral = 0.0;
		double doubleLiteral = 0D;
		decimal decimalLiteral = 0M;
		bool booleanLiteral = false;
		var implicitAssignment = "Hello world!";
	}
	public static void Main() {
		string name = "Bob";
		int messages = 3;
		decimal temperature = 34.4M;
		Console.Write("Hello, ");
		Console.Write(name);
		Console.Write("! You have ");
		Console.Write(messages);
		Console.Write(" messages in your inbox. The temperature is ");
		Console.Write(temperature);
		Console.WriteLine(" celsius.");
	}
}
