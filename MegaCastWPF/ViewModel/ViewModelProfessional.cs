using Megacasting.DBLib;
using MegaCastWPF.Views.AddViews;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelProfessional : ViewModelViewBase
    {
        #region Fields
        /// <summary>
        /// Professesional
        /// </summary>
        private Personne _SelectedItem;

        /// <summary>
        /// Liste des professionels
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
        public ViewModelProfessional() : base()
        {
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Personne.Local;
        }
        #endregion
        #region Method
        public void AddItem()
        {
            this.Entities.Civilité.ToList();
            ViewModelAddWindowProfessional vm = new ViewModelAddWindowProfessional(this.Entities.Civilité.Local);
            AddWindowProfessional AddWindowProfessional = new AddWindowProfessional();
            AddWindowProfessional.DataContext = vm;
            AddWindowProfessional.ShowDialog();


            if (AddWindowProfessional.DialogResult.GetValueOrDefault())
            {

                Personne professionnel = new Personne();
                professionnel.Id_Civilite = vm.Proxy._SelectedCivilite.Id_Civilite;
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
            if (SelectedItem != null)
            {
                this.Entities.Personne.Remove(SelectedItem);
                this.Entities.SaveChanges();
            }
        }

        #endregion
    }
}
