using System;

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
string currentStudentLetterGrade = "";
int[] studentScores = new int[10];

// Report header
Console.WriteLine("Student\t\tGrade\n");
foreach(string name in studentNames) {
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    // Initializes the rest of the variables
    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    // Score calculations
    foreach(int score in studentScores) {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments) {
            // Adds the exam score to the sum
            sumAssignmentScores += score;
        } else {
            // Adds the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score/10;
        }
    }

        // Final score calculation
        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
        if (currentStudentGrade >= 97) {
            currentStudentLetterGrade = "A+";
        } else if (currentStudentGrade >= 93 && currentStudentGrade <= 96) {
            currentStudentLetterGrade = "A";
        } else if (currentStudentGrade >= 90 && currentStudentGrade <= 93) {
            currentStudentLetterGrade = "A-";
        } else if (currentStudentGrade >= 87 && currentStudentGrade <= 90) {
            currentStudentLetterGrade = "B+";
        } else if (currentStudentGrade >= 83 && currentStudentGrade <= 87) {
            currentStudentLetterGrade = "B";
        }

        Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
    }

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();