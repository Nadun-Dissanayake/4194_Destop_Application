using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Student_Management_System
{
    public partial class MainWindowMV : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Person> person;

        [ObservableProperty]
        int index = -1;

        [ObservableProperty]
        public Person p1 = null;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string dateofbirth;


        private string image;

        [ObservableProperty]
        public double gpa = 0;




        [RelayCommand]
        public void AddPerson()
        {

            var Adding = new AddStudent();
            NewStudentWindow newStudentWindow = new NewStudentWindow(Adding);
            newStudentWindow.ShowDialog();
            if (firstname == null)
            {
                person.Add(Adding.S1);
            }
            
            
        }




        [RelayCommand]
        public void DeletePerson()
        {
            if (index == -1)
                MessageBox.Show("Selecte an Item");
            else
            {
                person.RemoveAt(index);
                MessageBox.Show("Successfull");
            }
        }
        [RelayCommand]
        public void EdditPerson()
        {
            if (p1 == null)
                MessageBox.Show("Please selecte an item");
            else
            {
                var Editing = new AddStudent(p1);
                NewStudentWindow newStudentWindow = new NewStudentWindow(Editing);
                newStudentWindow.ShowDialog();

                index = person.IndexOf(p1);
                person.RemoveAt(index);
                person.Add(Editing.S1);
            }

        }
    
        public MainWindowMV()
        {
            person = new ObservableCollection<Person>();
            person.Add(new Person("Nadun", "Dissanayake", "1999/05/20", "1", 2.8943));
            person.Add(new Person("Ishara", "Dissanayake", "1999/05/23", "2", 3.6433));
            person.Add(new Person("Yashan", "Randeer", "1999/02/01", "3", 3.5483));
            person.Add(new Person("Dushan", "Awantha", "1999/05/02", "4", 3.9999));
            person.Add(new Person("Chathura", "Madushan", "1999/11/07", "5", 3.2945));

        }


    }
}
