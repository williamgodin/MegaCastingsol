using Megacasting.DBLib;
using MegaCastWPF.Core;
using MegaCastWPF.Views;
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
        public ObservableCollection<Casting> _Casting;


        public RelayCommand CommandAddItem => new RelayCommand(
            actionParameter => this.AddItem(),
            ationPossibilityParameter => true);

        public RelayCommand CommandModifItem => new RelayCommand(
            actionParameter => this.ModifItem(),
            ationPossibilityParameter => true);
        public RelayCommand CommandDelItem => new RelayCommand(
            actionParameter => this.DelItem(),
            ationPossibilityParameter => true);
        #endregion
        #region Properties
        public Casting SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public ObservableCollection<Casting> Casting
        {
            get { return _Casting; }
            set { _Casting = value; }
        }

        #endregion
        #region Builder
        public ViewModelCasting() : base()
        {
            this.Entities.Casting.ToList();
            this.Casting = this.Entities.Casting.Local;
        }
        #endregion
        #region Method

        public void AddItem()
        {
            this.Entities.Casting.ToList();
            ViewModelAddWindowCasting vm = new ViewModelAddWindowCasting(this.Entities.Personne.ToList(), this.Entities.Type_de_contrat.ToList(), this.Entities.Métier.ToList());
            AddWindowCasting addwindow = new AddWindowCasting();
            addwindow.DataContext = vm;
            addwindow.ShowDialog();

            if (addwindow.DialogResult.Value)
            {
                Casting casting = new Casting();
                casting.Intitule = vm.Proxy.Intitule;
                casting.Reference = vm.Proxy.Reference;
                casting.Date_debut_publication = vm.Proxy.Date_debut_publication;
                casting.Nbr_poste = vm.Proxy.Nbr_poste;
                casting.Localisation = vm.Proxy.Localisation;
                casting.Description_poste = vm.Proxy.Description_poste;
                casting.Description_profil = vm.Proxy.Description_profil;
                casting.Coordonnees = vm.Proxy.Coordonnée;
                casting.Duree_diffusion = vm.Proxy.Duree_diffusion;
                casting.Professionnel = vm.Proxy.Professionnel;
                casting.Type_de_contrat = vm.Proxy.Contrat;
                casting.Métier = vm.Proxy.Metier;

                this.SelectedItem = casting;
                this.Entities.Casting.Add(casting);
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
                this.Entities.Casting.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }

        }
        public void ModifItem()
        {
            ViewModelAddWindowCasting vm = new ViewModelAddWindowCasting(this.Entities.Personne.ToList(), this.Entities.Type_de_contrat.ToList(), this.Entities.Métier.ToList());
            AddWindowCasting addwindow = new AddWindowCasting();
            addwindow.DataContext = vm;
            vm.Proxy.SelectedCasting = this.SelectedItem;
            addwindow.ShowDialog();
        }
        #endregion
    }
}
