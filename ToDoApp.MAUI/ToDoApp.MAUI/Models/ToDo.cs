using System.ComponentModel;

namespace ToDoApp.MAUI.Models
{
    public class ToDo : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set 
            {
                if (_id == value)
                    return;

                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        private string _todoName;

        public string ToDoName
        {
            get { return _todoName; }
            set 
            {
                if (_todoName == value)
                    return;

                _todoName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ToDoName)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
