using System.IO;
string filePath = @"D:\Coding\CSharpProjects\students-grade-program\data-base\students.txt";

StreamReader? sr = new StreamReader(filePath);
var liceu1 = new Clasa("9D");
Student? student = null;
while (sr.Peek() != -1) {
    string?[] data = sr.ReadLine().Split(", ");
    string? studentName = data[0];
    student = new Student(studentName, liceu1);
    liceu1.StudentList.Add(student);
    for (int i = 1; i < data.Length; i++) {
        student.GradeList.Add(new Grade(data[i]));
    }
}
sr.Close();
for (int i = 0; i < liceu1.StudentList.Count; i++) {
    liceu1.StudentList[i].PrintInfo();
    Console.WriteLine();
    Console.WriteLine();
}