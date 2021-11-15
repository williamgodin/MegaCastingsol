using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megacasting.DBLib;

namespace MegaCastWPF.ViewModel
{

    /// <summary>
    /// Modèle-vue pour la vue d'un diffuseur
    /// </summary>
    class ViewModelBroadcaster : ViewModelViewBase
    {

        #region Fields
        /// <summary>
        /// Broadcater
        /// </summary>
        private Professionnel _SelectedItem;

        /// <summary>
        /// Liste des broadcaster
        /// </summary>
        public ObservableCollection<Professionnel> _Items;
        #endregion
        #region Properties
        public Professionnel SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public ObservableCollection<Professionnel> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        #endregion
        #region Builder
        public ViewModelBroadcaster() : base()
        {
            this.Items = this.Entities.Professionnel.Local;
        }
        #endregion




    }
}
