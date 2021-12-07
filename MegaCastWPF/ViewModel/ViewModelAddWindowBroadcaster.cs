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
    class ViewModelAddWindowBroadcaster
    {
        #region Fields
        /// <summary>
        /// Unique
        /// </summary>
        private Personne _SelectedItem;
        private Civilité _SelectedCivilite;
        private AddBroadcasterProxy _Proxy;


        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Personne> _Items;
        public ObservableCollection<Civilité> _Civilites;
        #endregion

        #region Properties
        /// <summary>
        /// Unique
        /// </summary>
        public Personne SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public Civilité SelectedCivilite
        {
            get { return _SelectedCivilite; }
            set { _SelectedCivilite = value; }
        }
        public AddBroadcasterProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }
        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Personne> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        public ObservableCollection<Civilité> Civilites
        {
            get { return _Civilites; }
            set { _Civilites = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Créer la fenêtre d'ajout d'un broadcaster
        /// </summary>
        /// <param name="civilites">Permet d'obetenir la liste des civilités</param>
        public ViewModelAddWindowBroadcaster(ObservableCollection<Civilité> civilites)
        {
            this.Proxy = new AddBroadcasterProxy();
            this.Civilites = civilites;
        }


        #endregion

    }
}
