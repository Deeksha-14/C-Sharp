using emp;

namespace salesMan;

public class SalesManager:Employee
{
    public string deptNo{get; set;}

    public SalesManager()
    {

    }

        //public Employee(int empno, string fname, string lname, string em, string cNum)

    public SalesManager(string deptNo, int eno, string fname, string lname, string em, string cNum):base(eno, fname, lname, em, cNum)
    {
        this.deptNo=deptNo;
    }


    public override string ToString()
    {
        return base.ToString+this.deptNo;
    }

}