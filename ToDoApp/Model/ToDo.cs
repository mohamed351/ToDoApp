using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class ToDo : INotifyPropertyChanged
    {
        int _id;
        string _taskName;

        public int Id { get => _id;
            set
            {
                if (_id == value)
                    return;
                else
                {
                    _id = value;
                    this.PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Id)));

                } 
                   
            }


        }

        public string taskName
        {
            get => _taskName;
            set
            {
                if (_taskName == value)
                    return;
                else
                {
                    _taskName = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(taskName)));
                }
             
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
