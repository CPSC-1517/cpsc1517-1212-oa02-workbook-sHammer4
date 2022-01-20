// See https://aka.ms/new-console-template for more information
using OOPDemo02b;
//Allows you to access the static methods in Console class directly
using static System.Console;

Course cpsc1517Course = new Course("CPSC1517", "Intro to App Dev");
//var cpsc1517Course = new Course("CPSC1517", "Intro to App Dev");
//Course cpsc1517Course = new ("CPSC1517", "Intro to App Dev");

cpsc1517Course.LoadFromFile("students.txt");
WriteLine($"CourseNo: {cpsc1517Course.CourseNo}");
WriteLine($"CourseName: {cpsc1517Course.CourseName}");

//Add some students to the course
//cpsc1517Course.AddStudent("Aaron Fong");
//cpsc1517Course.AddStudent("David L, McKinley");
//cpsc1517Course.AddStudent("Hamza Said");
//cpsc1517Course.AddStudent("Haseeb Memon");
//cpsc1517Course.AddStudent("Allaine Peredes");


//Display all the students in the course
foreach(var currentStudent in cpsc1517Course.Students)
{
    WriteLine(currentStudent);
}

//Remove 2 students from the course
cpsc1517Course.RemoveStudent("Hamza Said");
cpsc1517Course.RemoveStudent("Haseeb Memon");

//Display the number of students
WriteLine($"There are now {cpsc1517Course.StudentCount} students.");

