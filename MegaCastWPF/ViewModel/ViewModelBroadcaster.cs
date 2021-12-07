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
    class ViewModelBroadcaster : ViewModelViewBase
    {

        #region Fields
        /// <summary>
        /// Broadcater
        /// </summary>
        private Personne _SelectedItem;

        /// <summary>
        /// Listes
        /// </summary>
        public ObservableCollection<Personne> _Personne;
        private List<Civilité> _civilite;



        #endregion
        #region Properties

        /// <summary>
        /// Broadcaster
        /// </summary>
        public Personne SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        /// <summary>
        /// Listes
        /// </summary>
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
        /// <summary>
        /// Permet d'executer le relay command
        /// </summary>
        public RelayCommand CommandAddItem => new RelayCommand(
            actionParameter => this.AddItem(),
            ationPossibilityParameter => true);// <-- si "False" permet de rentre inutilisable la case si un item Broadcaster est selectionné
        public RelayCommand CommandModifItem => new RelayCommand(
            actionParameter => this.SaveItem(),
            ationPossibilityParameter => true);
        public RelayCommand CommandDelItem => new RelayCommand(
            actionParameter => this.DelItem(),
            ationPossibilityParameter => true);

        #endregion
        #region Builder
        /// <summary>
        /// Affiche la liste des Broadcasteurs
        /// </summary>
        public ViewModelBroadcaster() : base()
        {
            this.Entities.Personne.ToList();
            this.Personne = this.Entities.Personne.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// Lors du clique sur le boutton "AJOUTER", lancement de la fenêtre et affectation valeur avec le proxy
        /// </summary>
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
                professionnel.Id_Civilite = vm.Proxy.Civilite.Id_Civilite;
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
        /// <summary>
        /// Sauvegarder les données en BDD
        /// </summary>
        public void SaveItem()
        {
            this.Entities.SaveChanges();
        }
        /// <summary>
        /// Suppression des données en BDD du Broadcaster selectionné
        /// </summary>
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
