namespace InterfaceDiner.Models
{
    //NOTE: Abstract prevents the class from being instatiated
    abstract class HourlyEmployee : Employee
    {
        public float HourlyRate { get; set; }



        //NOTE: Base is the constructor of the base (parent) class
        public HourlyEmployee(string name, float rate) : base(name)
        {
            HourlyRate = rate;
        }

    }
}