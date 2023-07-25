using prof;
using stud;
using drawing;

//string prn, string course, DateTime registrationNumb, string firstName, string lastName, string contactNumber, string email
DateTime regNum = new DateTime(2023, 03, 03);
DateTime bDate = new DateTime(2023, 04, 04);
Student s1 = new Student("abc123", "pgdac", regNum, "pooja", "upadhyay", bDate, "834898", "p@forget.com");
Console.WriteLine(s1);

Point startPoint1 = new Point(5, 10);
Point endPoint1 = new Point(15,20); 

Point point=new Point(2,4);  
