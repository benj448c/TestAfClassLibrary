using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTesting
{
    public class Person
    {
        private string _name;
        private string _address;

        /// <summary>
        /// Name of the student must be more than 2 characters
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 2) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        /// <summary>
        /// Address of the student can't be null
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                _address = value ?? throw new ArgumentNullException("Address", "Cannot be null");
            }
        }

        public Gender Gender { get; set; }
    }

    /// <summary>
    /// enum that only allows male or female
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
    }
}
