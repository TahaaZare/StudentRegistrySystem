using Project;

Console.Write("Enter the number of students: ");
int studentCount;
while (!int.TryParse(Console.ReadLine(), out studentCount) || studentCount <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive number.");
}

List<Student> students = new List<Student>();

for (int i = 1; i <= studentCount; i++)
{
    Console.WriteLine($"Enter details for student {i}:");

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Age: ");
    int age;
    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
    {
        Console.WriteLine("Invalid age. Please enter a positive number.");
    }

    Console.Write("Student ID: ");
    string studentId = Console.ReadLine();

    students.Add(new Student(name, age, studentId));
}

Console.WriteLine("\nStudent Details:");
foreach (var student in students)
{
    student.PrintDetails();
}