namespace inherit; //can be capital and small

public class Person
{

    private string fName;
    private string lName;
    private readonly DateTime birthDate;
    private string contactNumber;
    private string email;

    public Person()
    {

    }
    //getter setter not applied in person
    //class definition consists of - 
    public Person(string firstName, string lastName, DateTime bDate, string contactNumber, string email)
    {
        this.fName = firstName;
        this.lName = lastName;
        this.birthDate = bDate;
        this.contactNumber = contactNumber;
        this.email = email;

    }
    //getter setter return type string
    public string FName
    {
        get { return this.fName; }
        set { this.fName = value; }
    }

    public override string ToString()
    {

        //string data = base.ToString();
        // return data + string.Format("{0},{1},{2},{3}", this.firstName, this.lastName, this.contactNumber, this.email);
        return string.Format("{0},{1},{2},{3}", this.fName, this.lName, this.contactNumber, this.email);


    }

}