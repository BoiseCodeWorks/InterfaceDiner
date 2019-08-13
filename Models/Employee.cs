using System;
using System.Collections.Generic;

namespace InterfaceDiner.Models
{
    abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Punch> TimeCard { get; set; }
        public bool ClockedIn { get; set; }

        public void PunchClock(int time)
        {
            //NOTE: Toggles the bool
            ClockedIn = !ClockedIn;
            TimeCard.Add(new Punch(ClockedIn, time));
        }

        public Employee(string name)
        {
            Id = new Guid().ToString();
            TimeCard = new List<Punch>();
        }
    }
}