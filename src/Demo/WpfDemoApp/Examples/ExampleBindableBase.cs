using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfDemoApp.Examples
{
    public class ExampleBindableBase : BindableBase
    {
        public string FirstName
        {
            get { return GetProperty(() => FirstName); }
            set { SetProperty(() => FirstName, value, OnFirstNameChanged); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value, nameof(LastName)); }
        }

        void OnFirstNameChanged()
        {

        }

    }
}
