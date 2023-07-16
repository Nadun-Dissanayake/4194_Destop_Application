//using System;
//using System.Windows.Input;

//namespace Student_Management_System
//{
//    internal class Command : ICommand
//    {
//        private Action submit;
//        private MainWindowMV mainWindowMV;

//        public Command(Action submit)
//        {
//            this.submit = submit;
//        }

//        public Command(MainWindowMV mainWindowMV)
//        {
//            this.mainWindowMV = mainWindowMV;
//        }

//        public event EventHandler? CanExecuteChanged;

//        public bool CanExecute(object? parameter)
//        {
//            throw new NotImplementedException();
//        }

//        public void Execute(object? parameter)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}