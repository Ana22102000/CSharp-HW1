﻿using HW1.Tools;
using System.Windows;
using HW1.Tools.Managers;

namespace HW1.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {

        #region Fields
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;
        #endregion

        #region Properties
        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion


        internal MainWindowViewModel()
        {
            LoaderManager.Instance.Initialize(this);
        }

    }
}
