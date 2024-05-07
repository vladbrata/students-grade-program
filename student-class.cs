using System.Threading.Tasks.Dataflow;

public class Student
{
    public string Name;
    public Clasa ClassName;
    public List<Grade> GradeList = new List<Grade>(); 
    public Student (string name, Clasa className)
    {
        this.Name = name;
        this.ClassName = className;
        ClassName.NumberOfStudents++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} este in clasa {ClassName.Name}.");
        Console.Write($"{Name} are notele ");
        PrintGradeList();
    }
    public void PrintGradeList()
    {
        foreach (Grade grade in GradeList) Console.Write(grade.stringGrade + ' ');
    }
    public void AddStudent(Student student)
    {
        ClassName.StudentList.Add(student);
    }
    public void AddGrade(Grade grade)
    {
        GradeList.Add(grade);
    }

}