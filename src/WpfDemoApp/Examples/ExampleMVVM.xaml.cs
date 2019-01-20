using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfDemoApp.Annotations;
using WpfDemoApp.DataBase;

namespace WpfDemoApp.Examples
{
    /// <summary>
    /// Interaktionslogik für ExampleMVVM.xaml
    /// </summary>
    public partial class ExampleMVVM : Window
    {
        public ExampleMVVM()
        {
            InitializeComponent();
        }
    }

    public class Book : INotifyPropertyChanged
    {
        private string _isbn;
        private string _publisher;
        private string _author;
        private string _name;

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                _isbn = value;
                OnPropertyChanged();
            }
        }

        public string Publisher
        {
            get { return _publisher; }
            set {
                _publisher = value;
                OnPropertyChanged();
            }
        }

        public string Author
        {
            get { return _author; }
            set {
                _author = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Book(string isbn, string publisher, string author, string name)
        {
            ISBN = isbn;
            Publisher = publisher;
            Author = author;
            Name = name;
        }

    }

    public class ExampleMvvmViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Book> _books;
        private Book _SelectedBook;

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                _books = value;
                OnPropertyChanged();
            }
        }

        public Book SelectedBook
        {
            get { return _SelectedBook; }
            set
            {
                _SelectedBook = value;
                OnPropertyChanged();
                SaveCommand.RaiseCanExecuteChanged();
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public ButtonCommand SaveCommand { get; private set; }
        public ButtonCommand DeleteCommand { get; private set; }

        public ExampleMvvmViewModel()
        {
            Books = BookDatabase.GetExampleBooks();
            SaveCommand = new ButtonCommand(obj => SaveCommandExecute(), () => SaveCommandCanExecute());
            DeleteCommand = new ButtonCommand(obj => DeleteCommandExecute(), () => DeleteCommandCanExecute());
        }

        public void SaveCommandExecute()
        {
            MessageBox.Show("Buch gespeichert!");
        }

        public bool SaveCommandCanExecute()
        {
            return SelectedBook != null;
        }

        public void DeleteCommandExecute()
        {
            MessageBox.Show("Buch gelöscht!");
            if(SelectedBook != null)
                Books.Remove(SelectedBook);

        }

        public bool DeleteCommandCanExecute()
        {
            return SelectedBook != null;
        }
    }

  
    public class ButtonCommand : ICommand
    {
        readonly Action<object> _TargetExecuteMethod;
        readonly Func<bool> _TargetCanExecuteMethod;


        public ButtonCommand(Action<object> executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public ButtonCommand(Action<object> executeMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object parameter)
        {

            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod(parameter);
            }
        }
    }

}
