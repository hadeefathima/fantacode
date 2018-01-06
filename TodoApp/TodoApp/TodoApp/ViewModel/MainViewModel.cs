using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp.Model;
using TodoApp.Service;
using Xamarin.Forms;

namespace TodoApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            list = new ObservableCollection<Todomodel>();
        }
        TodoService toDoService { get; } = new TodoService();
        Todomodel item = new Todomodel();
        private Todomodel _ItemSelected;
        public Todomodel objItemSelected
        {
            get
            {
                return _ItemSelected;
            }
            set
            {
                if (_ItemSelected != value)
                {
                    _ItemSelected = value;
                    OnPropertyChanged("ItemSelected");
                    task = _ItemSelected.task;
                    description = _ItemSelected.description;
                    Done = _ItemSelected.Done;
                    id = _ItemSelected.todoId;
                }
            }
        }
        private ObservableCollection<Todomodel> list { get; set; }
        public ObservableCollection<Todomodel> List
        {
            get { return list; }
            set
            {
                list = value;
                OnPropertyChanged();
            }
        }
        private string _task { get; set; }
        public string task
        {
            get { return _task; }
            set
            {
                _task = value;
                OnPropertyChanged();

            }
        }
        private int _id { get; set; }
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();

            }
        }

        private string _description { get; set; }
        public string description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged();

            }
        }
        private bool _done { get; set; }
        public bool Done
        {
            get { return _done; }
            set
            {
                _done =value;
                OnPropertyChanged();

            }
        }
        public ICommand add => (new Command(async () => await AddCommand()));
        private async Task AddCommand()

        {


            item = new Todomodel();



            item.task = task;

            item.description = description;

            item.Done = Done;



            bool res;

            try

            {    res = await toDoService.PostTodo(item);
}

            catch (Exception ex)

            {

                res = false;

            }
        }
        //private void switcht(object sender,ToggledEventArgs e)
        //{
        //    bool ist = e.Value;
        //    Done = ist;
        //    OnPropertyChanged("Done");

        //}
      
        public ICommand up => (new Command(async () => await updateCommand()));
        private async Task updateCommand()

        {

            
            item = new Todomodel();



            item.task = task;

            item.description = description;

            item.Done = Done;

            item.todoId = id;

            bool res;

            try

            {
                res = await toDoService.PutTodo(item);
            }

            catch (Exception ex)

            {

                res = false;

            }
        }
        public ICommand doneb => (new Command(async () => await doneCommand()));
        private async Task doneCommand()

        {
            // task = objItemSelected.task;


            item.task = task;
            item.description = description;
            item.todoId = id;
            item.Done = Done;
         

            bool res;

            try

            {
                res = await toDoService.PutTodo(item);
            }

            catch (Exception ex)

            {

                res = false;

            }
        }
        public ICommand delete => (new Command(async () => await deleteCommand()));
        private async Task deleteCommand()
        {
            //item = new Todomodel();



            //item.todoId = id;
            task = objItemSelected.task;
            description = objItemSelected.description;
            id = objItemSelected.todoId;

            bool res;
            try
            {
                res = await toDoService.DeleteTodo(id);
            }
            catch(Exception ex)
            { res = false; }
        }
        public ICommand views => (new Command(async () => await displayCommand()));

        public bool IsToggled { get; private set; }

        private async Task displayCommand()
        {
            try
            {
                List = new ObservableCollection<Todomodel>();

                var res = await toDoService.GetTodoList();
                if (res != null)
                {
                    foreach (var x in res)
                    {
                        List.Add(x);
                    }
                 }
                

            }

            catch (Exception ex)

            {
                task = "wrong";
                OnPropertyChanged("task");


            }
        }
        public event PropertyChangedEventHandler PropertyChanged;



        public void OnPropertyChanged([CallerMemberName]string name = "") =>

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    }
}
