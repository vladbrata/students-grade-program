public class Clasa
{
    public string? Name;
    public int NumberOfStudents;
    public List <Student> StudentList = new List<Student>();

    public Clasa(string? name)
    {
        this.Name = name;
    }
   
    public void PrintStudents()
    {
        foreach (var student in StudentList) Console.WriteLine(student.Name);
    }

    public void AddStudent(Student student)
    {
        StudentList.Add(student);
    }
}