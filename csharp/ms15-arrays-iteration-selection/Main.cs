using System;

public class Program {
	public static void Main() {
		// initialize variables - graded assignments
		int examAssignments = 5;
		string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

		// define scores
		int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
		int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
		int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
		int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
		int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
		int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
		int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
		int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

		Console.WriteLine("Student\t\tGrade\n");

		foreach (string studentName in studentNames) {
			int[] studentScores = new int[5];
			string studentGrade = "";

			if (studentName == "Sophia") {
				studentScores = sophiaScores;
			} else if (studentName == "Andrew") {
				studentScores = andrewScores;
			} else if (studentName == "Emma") {
				studentScores = emmaScores;
			} else if (studentName == "Logan") {
				studentScores = loganScores;
			} else if (studentName == "Becky") {
				studentScores = beckyScores;
			} else if (studentName == "Chris") {
				studentScores = chrisScores;
			} else if (studentName == "Eric") {
				studentScores = ericScores;
			} else if (studentName == "Gregor") {
				studentScores = gregorScores;
			} else {
				break;
			}

			int studentSum = 0;
			int assignmentCount = 0;
			foreach (int score in studentScores) {
				assignmentCount ++;
				if (assignmentCount <= examAssignments) {
					studentSum += score;
				} else {
					studentSum += score / 10;
				}
			}

			decimal studentScore = (decimal) studentSum / examAssignments;

			if (studentScore >= 97) {
				studentGrade = "A+";
			} else if (studentScore >= 93) {
				studentGrade = "A";
			} else if (studentScore >= 90) {
				studentGrade = "A-";
			} else if (studentScore >= 87) {
				studentGrade = "B+";
			} else if (studentScore >= 83) {
				studentGrade = "B";
			} else if (studentScore >= 80) {
				studentGrade = "B-";
			} else if (studentScore >= 77) {
				studentGrade = "C+";
			} else if (studentScore >= 73) {
				studentGrade = "C";
			} else if (studentScore >= 70) {
				studentGrade = "C-";
			} else if (studentScore >= 67) {
				studentGrade = "D+";
			} else if (studentScore >= 63) {
				studentGrade = "D";
			} else if (studentScore >= 60) {
				studentGrade = "D-";
			} else {
				studentGrade = "F";
			}
			Console.WriteLine($"{studentName}:\t\t{studentScore}\t{studentGrade}");
		}

		Console.WriteLine("Press the Enter key to continue");
		Console.ReadLine();
	}
}
