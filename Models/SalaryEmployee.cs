namespace InterfaceDiner.Models
{
    abstract class SalaryEmployee : Employee
    {
        public float SalaryRate { get; set; }

        //NOTE: Base is the constructor of the base (parent) class
        public SalaryEmployee(string name, float rate) : base(name)
        {
            SalaryRate = rate;
        }

    }
}