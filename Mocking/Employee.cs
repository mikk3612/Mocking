using System;

namespace Mocking
{
    internal class Employee
    {
        public Employee()
        {
        }

        public int Id { get; set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }

        internal double CalculateWeeklySalary(int hours, int wage)
        {
            throw new NotImplementedException();
        }
    }
}