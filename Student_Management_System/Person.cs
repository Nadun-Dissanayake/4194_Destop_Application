using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Management_System
{
    public class Person : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateofBirth { get; set; }
        public string Image { get; set; }
        public double GPA { get; set; }

        public string ImageURL 
        { 
            get
            {
                return $"/Images/{Image}.png";
            } 
        }

        public Person(string firstName, string lastName, string dateofBirth, string image, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
            Image = image;
            GPA = gpa;
        }
        public Person()
        {

        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
