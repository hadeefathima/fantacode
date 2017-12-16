using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using task5.Models;

namespace task5.ViewModels
{
    class listviewmodel
    {
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

        public listviewmodel(ObservableCollection<TaskModel> List)

        {

            this.List = List;

        }
    }
}
