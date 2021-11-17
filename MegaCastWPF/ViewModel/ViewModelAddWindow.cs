using Megacasting.DBLib;
using MegaCastWPF.Proxy;
using MegaCastWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelAddWindow
    {
        #region Fields
        /// <summary>
        /// Broadcater
        /// </summary>
        private Personne _SelectedItem;

        private Civilité _SelectedCivilite;

        

        private AddProxy _Proxy;

        


        /// <summary>
        /// Liste des broadcaster
        /// </summary>
        public ObservableCollection<Personne> _Items;
        #endregion
        public ObservableCollection<Civilité> _Civilites;

        #region Properties
        public Personne SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public ObservableCollection<Personne> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        public AddProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }
        public ObservableCollection<Civilité> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }
        public Civilité SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        #endregion

        #region Constructor
        public ViewModelAddWindow(ObservableCollection<Civilité> civilites)
        {
            this.Proxy = new AddProxy();
            this.Civilites = civilites;
        }

        
        #endregion

        #region Method

        #endregion
    }
}
