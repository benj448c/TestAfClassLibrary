using System;

namespace StudentTesting
{
    internal class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value >= 0) throw new ArgumentOutOfRangeException("Salary", "Value must be more than 0");
                _salary = value;
            } 
        }
    }
}