namespace InterfaceDiner.Models
{
    public class Punch
    {
        public bool In { get; set; }
        public int Time { get; set; }

        public Punch(bool clockIn, int time)
        {
            In = clockIn;
            Time = time;
        }
    }
}