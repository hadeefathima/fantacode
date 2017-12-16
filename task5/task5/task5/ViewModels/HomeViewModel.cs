using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using task5.Models;
using Xamarin.Forms;

namespace task5.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {

        private Models.TaskModel _taskmodel;
        public INavigation Navigation { get; set; }

        public ICommand viewlist { set; get; }
     private ObservableCollection<TaskModel> _list;
        public ObservableCollection<TaskModel> List

        {

            get

            {

                return _list;

            }

            set

            {

                _list = value;

            }

        }
        public Models.TaskModel TaskModel {
            get { return _taskmodel; }
            set
            {
                _taskmodel = value;

                OnPropertyChanged();
            }
        }
        public HomeViewModel(INavigation navigation)
        {
            TaskModel = new Models.TaskModel


            {

                Task4 = "",

                Task3 = "",

                Task2 = "",

                Task1 = "",



            };

            List = new ObservableCollection<TaskModel>()

            {



            };

            this.Navigation = navigation;

            this.viewlist = new Command(async () =>
            {
                List.Add(TaskModel);
                await GotoPage2();
                });
        

    }
        public async Task GotoPage2()

        {

            

            await Navigation.PushAsync(new listpage(List));

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
