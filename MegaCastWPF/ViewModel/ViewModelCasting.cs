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
        /// Unique
        /// </summary>
        private Casting _SelectedItem;
        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Casting> _Casting;

        #endregion
        #region Properties
        /// <summary>
        /// Unique
        /// </summary>
        public Casting SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Casting> Casting
        {
            get { return _Casting; }
            set { _Casting = value; }
        }

        #endregion
        #region Commands
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
        #region Builder
        /// <summary>
        /// Initialise la page des casting les listant tous
        /// </summary>
        public ViewModelCasting() : base()
        {
            this.Entities.Casting.ToList();
            this.Casting = this.Entities.Casting.Local;
        }
        #endregion
        #region Method
        /// <summary>
        /// Lors du clique sur le boutton "AJOUTER", lancement de la fenêtre et affectation valeur avec le proxy
        /// </summary>
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
        /// <summary>
        /// Sauvegarder les données en BDD
        /// </summary>
        public void SaveItem()
        {
            this.Entities.SaveChanges();
        }
        /// <summary>
        /// Suppression des données en BDD du Casting selectionné
        /// </summary>
        public void DelItem()
        {
            if (SelectedItem != null)
            {
                this.Entities.Casting.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }

        }
        /// <summary>
        /// Lors du clique sur le boutton "MODIFIER", lancement de la fenêtre et affectation valeur avec le proxy
        /// </summary>
        public void ModifItem()
        {
            ViewModelModifWindowCasting vm = new ViewModelModifWindowCasting(this.Entities.Personne.ToList(), this.Entities.Type_de_contrat.ToList(), this.Entities.Métier.ToList());
            ViewModifCasting addwindow = new ViewModifCasting();
            addwindow.DataContext = vm;
            vm.Proxy.SelectedCasting = this.SelectedItem;
            addwindow.ShowDialog();
        }
        #endregion
    }
}
