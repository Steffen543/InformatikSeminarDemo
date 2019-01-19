using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using WpfDemoApp.DataBase;
using WpfDemoApp.Model;

namespace WpfDemoApp.UI.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        public ICommand SaveCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public ObservableCollection<Book> Books
        {
            get { return GetProperty(() => Books); }
            set { SetProperty(() => Books, value); }
        }

        public Book SelectedBook
        {
            get { return GetProperty(() => SelectedBook); }
            set { SetProperty(() => SelectedBook, value); }
        }


       
        public LibraryViewModel()
        {
            SaveCommand = new DelegateCommand(SaveCommandExecute, SaveCommandCanExecute);
            DeleteCommand = new DelegateCommand(DeleteCommandExecute, DeleteCommandCanExecute);
            Books = BookDatabase.GetBooks();
        }

        public void SaveCommandExecute()
        {
            MessageBox.Show("Buch gespeichert!");
        }

        public bool SaveCommandCanExecute()
        {
            return SelectedBook != null && SelectedBook.ISBN.Length == 17;
        }

        public void DeleteCommandExecute()
        {
            MessageBox.Show("Buch gelöscht!");
        }

        public bool DeleteCommandCanExecute()
        {
            return SelectedBook != null;
        }

    }
}
