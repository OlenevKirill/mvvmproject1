using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace mvvm
{

    public class SmokingViewModel : INotifyPropertyChanged
    {
        private SmokingModel _model;
        private string _agent;
        private string _agent2;

        public SmokingViewModel()
        {
            _model = new SmokingModel();
            StartCommand = new RelayCommand(Start);
        }

        public string Agent
        {
            get => _agent;
            set
            {
                _agent = value;
                OnPropertyChanged();
            }
        }

        public string Agent2
        {
            get => _agent2;
            set
            {
                _agent2 = value;
                OnPropertyChanged();
            }
        }

        public ICommand StartCommand { get; }

        private void Start()
        {
            Agent = "Посредник кладет на стол табак и бумагу";
            Agent2 = "Курильщик со спичками скручивает сигарету и курит";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}