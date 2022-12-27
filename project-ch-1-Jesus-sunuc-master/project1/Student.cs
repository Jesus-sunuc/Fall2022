namespace Chapter1;

public class Student: Person
{
    public int numberOfCredits;
    public int totalGradePointsEarned;

    public Student(string inputName, string inputId)
    {
        name = inputName;
        ID = int.Parse(inputId);
    }

    public string GetName() => name;
    public int GetID() => ID;
    public bool AreStudentsEqual(Student StudentA, Student StudentB) => StudentA.ID == StudentB.ID;
    public void SetCredits(string value) => numberOfCredits = int.Parse(value);
    public int GetCredits() => numberOfCredits;
    public void SetGradePoints(string value) => totalGradePointsEarned = int.Parse(value);
    public int GetGradePoints() => totalGradePointsEarned;
    public double GetGPA()
    {
        double GPA = ((double) totalGradePointsEarned / (double) numberOfCredits);

        return GPA;
    }
}




