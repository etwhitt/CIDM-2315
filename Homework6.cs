namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor professor1 = new Professor("Alice", "Java", 9000);
        Professor professor2 = new Professor("Bob", "Math", 8000);

        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
        double totalGrade = student1.GetGrade() + student2.GetGrade();

        Console.WriteLine($"Professor {professor1.ProfName} teaches {professor1.ClassTeach}, and the salary is: {professor1.GetSalary()}");
        Console.WriteLine($"Professor {professor2.ProfName} teaches {professor2.ClassTeach}, and the salary is: {professor2.GetSalary()}");

        Console.WriteLine($"Student {student1.StudentName} enrolls {student1.ClassEnroll}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.StudentName} enrolls {student2.ClassEnroll}, and the grade is: {student2.GetGrade()}");

        Console.WriteLine($"The salary difference between {professor1.ProfName} and {professor2.ProfName} is: {salaryDifference}");
        Console.WriteLine($"The total grade of {student1.StudentName} and {student2.StudentName} is: {totalGrade}");
    }
}

class Professor
{
    private string profName;
    private string classTeach;
    private double salary;

    public Professor(string profName, string classTeach, double salary)
    {
        this.profName = profName;
        this.classTeach = classTeach;
        this.salary = salary;
    }

    public string ProfName
    {
        get {return profName;}
    }

    public string ClassTeach
    {
        get {return classTeach;}
    }

    public double Salary
    {
        get {return salary;}
        private set {salary = value;}
    }

    public double GetSalary()
    {
        return this.salary;
    }
}

class Student
{
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    public Student(string studentName, string classEnroll, double studentGrade)
    {
        this.studentName = studentName;
        this.classEnroll = classEnroll;
        this.studentGrade = studentGrade;
    }

    public string StudentName
    {
        get {return studentName;}
    }

    public string ClassEnroll
    {
        get {return classEnroll;}
    }

    public double StudentGrade
    {
        get {return studentGrade;}
        private set {studentGrade = value;}
    }

    public double GetGrade()
    {
        return this.studentGrade;
    }
}
