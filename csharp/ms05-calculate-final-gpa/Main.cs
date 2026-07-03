using System;

public class Program {
	public static void Main() {
		// student
		string studentName = "Sophia Johnson";
		// course name
		string course1Name = "English 101";
		string course2Name = "Algebra 101";
		string course3Name = "Biology 101";
		string course4Name = "Computer Science I";
		string course5Name = "Psychology 101";
		// course credit
		int course1Credit = 3;
		int course2Credit = 3;
		int course3Credit = 4;
		int course4Credit = 4;
		int course5Credit = 3;
		// grade
		int gradeA = 4;
		int gradeB = 3;
		// course grade
		int course1Grade = gradeA;
		int course2Grade = gradeB;
		int course3Grade = gradeB;
		int course4Grade = gradeB;
		int course5Grade = gradeA;
		// credit hours
		int totalCreditHours = 0;
		totalCreditHours += course1Credit;
		totalCreditHours += course2Credit;
		totalCreditHours += course3Credit;
		totalCreditHours += course4Credit;
		totalCreditHours += course5Credit;
		// grade points
		int totalGradePoints = 0;
		totalGradePoints += course1Credit * course1Grade;
		totalGradePoints += course2Credit * course2Grade;
		totalGradePoints += course3Credit * course3Grade;
		totalGradePoints += course4Credit * course4Grade;
		totalGradePoints += course5Credit * course5Grade;
		// output
		decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;
		int leadingDigit = (int) gradePointAverage;
		int firstDigit = (int) (gradePointAverage * 10) % 10;
		int secondDigit = (int) (gradePointAverage * 100 ) % 10;
		Console.WriteLine($"Student: {studentName}\n");
		Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
		Console.WriteLine($"{course1Name}\t\t{course1Grade}\t\t{course1Credit}");
		Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
		Console.WriteLine($"{course3Name}\t\t{course3Grade}\t\t{course3Credit}");
		Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
		Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");
		Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
	}
}
