using Megacasting.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelArtist : ViewModelViewBase
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
        #region Constructor
        public ViewModelArtist() : base()
        {
            
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Personne.Local;
        }
        #endregion
        #region Method
        public void AddItem()
        {

            Artiste artiste = new Artiste();
            artiste.Nom = "Nouveau Nom";
            artiste.Prenom = "Nouvelle Prenom";
            artiste.Ville = "Nouvelle Ville";
            artiste.Adresse = "Nouvelle Adresse";
            artiste.Email = "Nouvelle Email";
            artiste.Id_Civilite = 1;

            this.SelectedItem = artiste;
            this.Entities.Personne.Add(artiste);
            this.Entities.SaveChanges();

        }
        public void SaveItem()
        {
            this.Entities.SaveChanges();
        }
        public void DelItem()
        {
            if (SelectedItem != null)
            {
                this.Entities.Personne.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }

        }
        #endregion
    }
}
