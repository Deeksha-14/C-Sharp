namespace emp
{
    public class Employee
    {
        public int empNo;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public string contactNumber { get; set; }

        public Employee()
        {

        }

        public Employee(int empno, string fname, string lname, string em, string cNum)
        {
            this.empNo = empno;
            this.firstName = fname;
            this.lastName = lname;
            this.email = em;
            this.contactNumber = cNum;

        }

        public override string ToString()
        {

            return this.empNo + " " + this.firstName + " " + this.lastName + " " + this.email + " " + this.contactNumber;
            // return string.Format("{0},{1},{2},{3},{4}", this.empNo, this.firstName, this.lastName, this.email, this.contactNumber);
        }


    }



}