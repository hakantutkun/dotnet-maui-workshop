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

        public string TodoName
        {
            get { return _todoName; }
            set 
            {
                if (_todoName == value)
                    return;

                _todoName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TodoName)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
