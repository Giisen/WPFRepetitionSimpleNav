using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFRepetition.Managers;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class CenterViewModel : ObservableObject
    {
        #region Fields

        private DataModel _dataModel;
        private NavigationManager _navigationManager;

        #endregion

        #region Properties

     public int Counter
        {
            
            get { return _dataModel.Counter; }
            set
            {
                SetProperty(_dataModel.Counter, value, _dataModel, (model, value) => model.Counter = value);

            }
            
        }

        #endregion

        #region Commands

        public IRelayCommand ResetCounterCommand { get; }

        public IRelayCommand NavigateLeftCommand { get; }
        public IRelayCommand NavigateRightCommand { get; }


        #endregion

        public CenterViewModel(DataModel dataModel, NavigationManager navigationManager)
        {
            _dataModel = dataModel;
            _navigationManager= navigationManager;
            ResetCounterCommand = new RelayCommand(() => Counter = 0);
            NavigateLeftCommand = new RelayCommand(() => _navigationManager.CurrentViewModel = new LeftViewModel(_dataModel, _navigationManager));
            NavigateRightCommand = new RelayCommand(() => _navigationManager.CurrentViewModel = new RightViewModel(_dataModel, _navigationManager));
                

        }
        
    }
}
