using System.ComponentModel;
using System.Runtime.CompilerServices;
using WebDataMiner.Model.Properties;

namespace WebDataMiner.Model
{
    class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
