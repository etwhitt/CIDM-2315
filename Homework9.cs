namespace Homework9;

public class Program
{
    static void Main(string[] args)
    {
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        double averageGPA = gradebook.Values.Average();

        Console.WriteLine($"The average GPA is: {averageGPA:F2}");

        foreach (Student student in Student.studentList)
        {
            string name = student.GetName();
            if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}


class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public string GetName()
    {
        return studentName;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}
