using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using WPFRepetition.Managers;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class LeftViewModel : ObservableObject
    {

        #region Fields

        private readonly DataModel _dataModel;

        #endregion

        #region Commands

        public IRelayCommand CountUpCommand { get; }

        #endregion

        #region Props

        public int Counter
        {
            get => _dataModel.Counter;
            set
            {
                _dataModel.Counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        #endregion

        public LeftViewModel(DataModel dataModel)
        {
            _dataModel = dataModel;
            CountUpCommand = new RelayCommand(() => Counter++);
        }
    }
}
