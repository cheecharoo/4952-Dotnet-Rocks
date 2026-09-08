namespace DotnetLibrary;

public class Student
{
    public int ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? School { get; set; }

    public override string ToString()
    {
        return $"Student ID: {ID}, Name: {FirstName} {LastName}, School: {School}";
    }   
}
