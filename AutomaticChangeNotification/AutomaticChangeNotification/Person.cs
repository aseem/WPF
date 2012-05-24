using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomaticChangeNotification
{
   
    class Person
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                _firstName = value;
                OnFirstNameChanged();
            }
        }

        public event EventHandler FirstNameChanged;

        private void OnFirstNameChanged()
        {
            if (FirstNameChanged != null)
                FirstNameChanged(this, EventArgs.Empty);
        }


    }
}
