using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class RightViewModel : ObservableObject
    {
        #region Fields

        private readonly DataModel _dataModel;

        #endregion

        #region Commands

        public IRelayCommand CountDownCommand { get; }

        #endregion

        #region Props

        public int Counter
        {
            get => _dataModel.Counter;
            set
            {
                SetProperty(_dataModel.Counter, value, _dataModel, (model, value) => model.Counter = value);
            }
        }

        #endregion

        public RightViewModel(DataModel dataModel)
        {
            _dataModel = dataModel;
            CountDownCommand = new RelayCommand(() => Counter--);
            
        }

        public void Countup()
        {
            Counter++;
        }
    }
}
