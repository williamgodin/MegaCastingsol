using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megacasting.DBLib;
using MegaCastWPF.Views;
using MegaCastWPF.Views.AddViews;

namespace MegaCastWPF.ViewModel
{

    /// <summary>
    /// Modèle-vue pour la vue d'un diffuseur
    /// </summary>
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

        private List<Civilité> _civilite;



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
        public List<Civilité> civilite
        {
            get { return _civilite; }
            set { _civilite = value; }
        }
        #endregion
        #region Builder
        public ViewModelArtist() : base()
        {
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Personne.Local;
        }
        #endregion
        #region Method

        public void AddItem()
        {
            this.Entities.Civilité.ToList();
            ViewModelAddWindowBroadcaster vm = new ViewModelAddWindowBroadcaster(this.Entities.Civilité.Local);
            AddArtistWindow addArtistWindow = new AddArtistWindow();
            addArtistWindow.DataContext = vm;
            addArtistWindow.ShowDialog();

            if (addArtistWindow.DialogResult.GetValueOrDefault())
            {

                Artiste artiste = new Artiste();
                artiste.Civilité = vm.Proxy.Civilite;
                artiste.Id_Civilite = vm.Proxy.Civilite.Id_Civilite;
                artiste.Nom = vm.Proxy.Lastname;
                artiste.Prenom = vm.Proxy.Firstname;
                artiste.Ville = vm.Proxy.City;
                artiste.Adresse = vm.Proxy.Address;
                artiste.Email = vm.Proxy.Email;
                artiste.Telephone = vm.Proxy.Phone;
                this.SelectedItem = artiste;
                this.Entities.Personne.Add(artiste);
                this.Entities.SaveChanges();
            }
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
