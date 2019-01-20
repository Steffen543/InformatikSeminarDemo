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
           
        }

        protected override void OnInitializeInDesignMode()
        {
            Books = new ObservableCollection<Book>()
            {
                new Book("Test", "Test1", "Hello World", "Author", "Beschreibung"),
                new Book("Test", "Test2", "Hello World 2", "Author 2", "Beschreibung"),
                new Book("Test", "Test3", "Hello World 3", "Author 3", "Beschreibung"),
                new Book("Test", "Test4", "Hello World 4", "Author 4", "Beschreibung"),
                new Book("Test", "Test5", "Hello World 5", "Author 5", "Beschreibung")
            };
            base.OnInitializeInDesignMode();
        }

        protected override void OnInitializeInRuntime()
        {
            Books = BookDatabase.GetBooks();
            base.OnInitializeInRuntime();
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
            Books.Remove(SelectedBook);

        }

        public bool DeleteCommandCanExecute()
        {
            return SelectedBook != null;
        }

    }
}
