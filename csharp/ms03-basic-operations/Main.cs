using System;

public class Program {
	public static void Demo() {
		double addition = 114D + 514D;
		double subtraction = 1919D - 810D;
		double multiplication = 114D * 514D;
		double division = 1919D / 810D;
		int remainder = 114 % 514;
		// +=, ++, -=, --
		// variable++, ++variable
	}
	public static void Main() {
		int fahrenheit = 94;
		float celsiusUnfiltered = (float) (fahrenheit - 32) / 1.8F;
		Console.WriteLine($"The temperature is {celsiusUnfiltered} Celsius.");
	}
}
