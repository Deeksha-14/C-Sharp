using inherit;

namespace stud;
//give its namespace too


public class Student : Person
{

    private string prn;
    private string course;
    private DateTime registrationNumb;


    //public
    public Student()
    {
        count++;
    }
    //string firstName, string lastName, string contactNumber, string email

    //public // datetime regnum
    public Student(string prn, string course, DateTime registrationNumb, string fName, string lName, DateTime bDate, string contactNumber, string email) : base(fName, lName, bDate, contactNumber, email)
    {
        this.prn = prn;
        this.course = course;
        this.registrationNumb = registrationNumb;
        count++;
    }


    //public cause we want to access it outside or scope doesnt matter here.??
    public static int count;

    //getCount g is capital
    public static int GetCount()
    {
        return count;//this is not valid in the static property
    }


    public override string ToString()
    {
        return base.ToString() + string.Format("{0},{1},{2}", this.prn, this.course, this.registrationNumb);
    }

}