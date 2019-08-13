namespace InterfaceDiner.Models
{
    class Owner : Manager
    {
        public void Shutdown()
        {

        }
        public Owner(string name, float rate) : base(name, rate)
        {
        }
    }
}