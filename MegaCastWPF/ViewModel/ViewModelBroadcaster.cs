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
        private Personne _SelectedItem;

        /// <summary>
        /// Liste des broadcaster
        /// </summary>
        public ObservableCollection<Personne> _Items;
        #endregion
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
        #endregion
        #region Builder
        public ViewModelBroadcaster() : base()
        {
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Personne.Local;
        }
        #endregion
        #region Method
        public void AddItem()
        {
            Professionnel professionnel = new Professionnel();
            professionnel.Nom = "Nouveau Nom";
            professionnel.Prenom = "Nouvelle Prenom";
            professionnel.Ville = "Nouvelle Ville";
            professionnel.Adresse = "Nouvelle Adresse";
            professionnel.Email = "Nouvelle Email";
            professionnel.Id_Civilite = 1;


            this.SelectedItem = professionnel;
            this.Entities.Personne.Add(professionnel);
            this.Entities.SaveChanges();

        }
        public void SaveItem()
        {
            this.Entities.SaveChanges();
        }
        public void DelItem()
        {
            if(SelectedItem != null)
            {
                this.Entities.Personne.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }

        }
        #endregion




    }
}
