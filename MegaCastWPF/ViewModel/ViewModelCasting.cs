using Megacasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelCasting : ViewModelViewBase
    {

        #region Fields
        /// <summary>
        /// Broadcater
        /// </summary>
        private Casting _SelectedItem;

        /// <summary>
        /// Liste des broadcaster
        /// </summary>
        public ObservableCollection<Casting> _Items;

       



        #endregion
        #region Properties
        public Casting SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public ObservableCollection<Casting> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        
        #endregion
        #region Builder
        public ViewModelCasting() : base()
        {
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Casting.Local;
        }
        #endregion
        #region Method

        
        public void SaveItem()
        {
            this.Entities.SaveChanges();
        }
        public void DelItem()
        {
            if (SelectedItem != null)
            {
                this.Entities.Casting.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }

        }

        #endregion
    }
}
