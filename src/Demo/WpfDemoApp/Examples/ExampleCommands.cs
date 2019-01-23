using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Mvvm;

namespace WpfDemoApp.Examples
{
    public class ExampleCommands : ViewModelBase
    {
        public DelegateCommand Command1 { get; private set; }
        public DelegateCommand<string> CommandWithParameter { get; private set; }

        public ExampleCommands()
        {
            Command1 = new DelegateCommand(() => { MessageBox.Show("Hello"); });
            Command1 = new DelegateCommand(Command1Execute);
            Command1 = new DelegateCommand(Command1Execute, Command1CanExecute);

            CommandWithParameter = new DelegateCommand<string>((parameter) => MessageBox.Show(parameter));
            CommandWithParameter = new DelegateCommand<string>(CommandWithParameterExecute);
            CommandWithParameter = new DelegateCommand<string>(CommandWithParameterExecute, CommandWithParameterCanExecute);
        }

        void Command1Execute()
        {
            MessageBox.Show("Hello");
        }
        bool Command1CanExecute()
        {
            return true;
        }

        void CommandWithParameterExecute(string parameter)
        {
            MessageBox.Show(parameter);
        }
        bool CommandWithParameterCanExecute(string parameter)
        {
            return true;
        }
    }
}
