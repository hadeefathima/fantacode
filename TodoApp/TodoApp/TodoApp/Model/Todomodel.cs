using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TodoApp.Model
{
   public class Todomodel
    {
        

        string _task;

        string _description;
        

        DateTime _date;

        bool _done;

        //string id;

        //string name;

        //bool done;

        [JsonProperty(PropertyName = "todoId")]

        public int todoId { get; set; }

        
        [JsonProperty(PropertyName = "task")]

        public string task

        {

            get { return _task; }

            set { _task = value; }

        }
        [JsonProperty(PropertyName = "description")]

        public string description

        {

            get { return _description; }

            set { _description = value; }

        }
        [JsonProperty(PropertyName = "date")]

        public DateTime date

        {

            get { return _date; }

            set { _date = value; }

        }
       



        [JsonProperty(PropertyName = "done")]

        public bool Done

        {

            get { return _done; }

            set { _done = value; }

        }

        public static implicit operator Todomodel(ObservableCollection<Todomodel> v)
        {
            throw new NotImplementedException();
        }



        //[Version]

        //public string Version { get; set; }

    }
}

