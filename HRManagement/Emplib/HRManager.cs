using emp;

namespace HR;

public class HrManager : Employee
{

    public string deptNo { get; set; }

    public HrManager()
    {

    }


    //public Employee(int empno, string fname, string lname, string em, string cNum)

    public HrManager(string deptNo, int empno, string fname, string lname, string em, string cNum) : base(empno, fname, lname, em, cNum)
    {
        this.deptNo = deptNo;

    }


    public override string ToString()
    {
        return base.ToString + this.deptNo;


    }

}