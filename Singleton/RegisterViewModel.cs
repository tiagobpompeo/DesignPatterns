using System;
using System.ComponentModel;

namespace Singleton
{
    public class RegisterViewModel:INotifyPropertyChanged
    {
        public RegisterViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
