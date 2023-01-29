using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.ViewModels
{
    public class ShellViewModel: Screen
    {
        string _firstName;
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
    }
}
