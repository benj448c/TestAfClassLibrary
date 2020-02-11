using System;

namespace StudentTesting
{
    public class Student : Person
    {
        private int _semester;

        /// <summary>
        /// Semester of the student can't be less than 1 and more than 8
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if (1 >= value || value >= 8) throw new ArgumentOutOfRangeException("Semester", "must be more than 1 and less than 8");
                _semester = value; 

            }
        }
    }


}
