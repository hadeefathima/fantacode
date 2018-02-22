using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestUnit.ViewModels
{
    public class MathViewModel : INotifyPropertyChanged

    {
        private int _valueA;
        public int ValueA
        {
            get { return _valueA; }
            set
            {
                _valueA = value;
                onPropertyChanged();
            }
        }
        private int _valueB;
        public int ValueB
        {
            get { return _valueB; }
            set
            {
                _valueB = value;
                onPropertyChanged();
            }
        }
        private int _result;
        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                onPropertyChanged();
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA + _valueB;

                });
            }
        }

        public ICommand MultipyCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = _valueA * _valueB;

                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected  virtual void onPropertyChanged([CallerMemberName] string propertyName =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
