using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class CenterViewModel : ObservableObject
    {
        #region Fields

        private DataModel _dataModel;

        #endregion

        #region Properties

        private int _counter;

       

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

        #endregion

        public CenterViewModel(DataModel dataModel)
        {
            _dataModel = dataModel;
            ResetCounterCommand = new RelayCommand(() => Counter = 0);
        }
        
    }
}
