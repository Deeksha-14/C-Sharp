namespace prof;

public partial class Profile
{
    private string firstName;
    private string lastName;
    private string email;
    private string aadharNumber;
    private string contNumb;

    public override string ToString()
    {
        return string.Format("{0},{1},{2},{3}", this.firstName, this.lastName, this.email, this.qualification, this.company);


    }



}