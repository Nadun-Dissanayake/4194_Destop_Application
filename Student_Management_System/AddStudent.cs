using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Student_Management_System
{
    public partial class AddStudent : ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa = 0;

        [ObservableProperty]
        public BitmapImage selectedImage;

        [ObservableProperty]
        public String image;

        [ObservableProperty]
        public ObservableCollection<Person> people;


        public AddStudent()
        {

        }

        public AddStudent(Person s1)
        {
            firstname = s1.FirstName;
            lastname = s1.LastName;
            gpa = s1.GPA;
            dateofbirth = s1.DateofBirth;
        }
        public Action CloseAction { get; internal set; }
        public Person S1 { get; private set; }

        [RelayCommand]
        public void Submit()
        {
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (S1 == null)
            {

                S1 = new Person()
                {
                    FirstName = firstname,

                    LastName = lastname,

                    DateofBirth = dateofbirth,

                    Image = image,

                    GPA = gpa

                };
            }
            else
            {
                S1.FirstName = firstname;

                S1.LastName = lastname;

                S1.GPA = gpa;

                S1.Image = image;

                S1.DateofBirth = dateofbirth;
            }

            if (S1.FirstName != null)
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();



        }
    }
}
