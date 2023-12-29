var person = new Person("");
person.Name = Console.ReadLine(); 

var student = new Student(Console.ReadLine());

var teacher = new Teacher(Console.ReadLine());

System.Console.WriteLine(student.Study());
System.Console.WriteLine(teacher.Explain());

public class Person
{
    public string Name { get; set; }
    public string ToString()
    {
        return $"{Name}";
    }
    public Person(string a)
    {

    }
}
public class Student : Person
{
    public string Study()
    {
        return $"The student is studying";
    }
    public Student(string a) : base (a)
    {
    }
}
public class Teacher : Person
{
    public string Explain()
    {
        return $"The teacher is explaining";
    }
    public Teacher(string a) : base (a)
    {
    }
}