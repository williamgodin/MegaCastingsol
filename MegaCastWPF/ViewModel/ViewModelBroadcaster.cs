using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megacasting.DBLib;
using MegaCastWPF.Core;
using MegaCastWPF.Views;

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
        public ObservableCollection<Personne> _Personne;

        private List<Civilité> _civilite;

        

        #endregion
        #region Properties
        public Personne SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public ObservableCollection<Personne> Personne
        {
            get { return _Personne; }
            set { _Personne = value; }
        }
        public List<Civilité> civilite
        {
            get { return _civilite; }
            set { _civilite = value; }
        }
        #endregion
        #region Commands
        public RelayCommand CommandAddItem => new RelayCommand(
            actionParameter => this.AddItem(),
            ationPossibilityParameter => true);

       
        #endregion
        #region Builder
        public ViewModelBroadcaster() : base()
        {
            this.Entities.Personne.ToList();
            this.Personne = this.Entities.Personne.Local;
        }
        #endregion
        #region Method

        public void AddItem()
        {
            this.Entities.Civilité.ToList();
            ViewModelAddWindowBroadcaster vm = new ViewModelAddWindowBroadcaster(this.Entities.Civilité.Local);
            AddWindow addwindow = new AddWindow();
            addwindow.DataContext = vm;
            addwindow.ShowDialog();

            if (addwindow.DialogResult.Value)
            {
                Professionnel professionnel = new Professionnel();
                professionnel.Civilité = vm.Proxy.Civilite;
                professionnel.Id_Civilite = vm.Proxy.Civilite.Id_Civilite ;
                professionnel.Nom = vm.Proxy.Lastname;
                professionnel.Prenom = vm.Proxy.Firstname;
                professionnel.Ville = vm.Proxy.City;
                professionnel.Adresse = vm.Proxy.Address;
                professionnel.Email = vm.Proxy.Email;
                professionnel.Telephone = vm.Proxy.Phone;

                this.SelectedItem = professionnel;
                this.Entities.Personne.Add(professionnel);
                this.Entities.SaveChanges();
                
            }
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
