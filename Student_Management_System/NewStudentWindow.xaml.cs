using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Student_Management_System
{
    /// <summary>
    /// Interaction logic for NewStudentWindow.xaml
    /// </summary>
    public partial class NewStudentWindow : Window
    {
        public NewStudentWindow(AddStudent A)
        {
            InitializeComponent();
            DataContext = A;
            A.CloseAction = () => Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
