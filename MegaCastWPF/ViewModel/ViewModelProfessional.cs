using Megacasting.DBLib;
using MegaCastWPF.Windows.Professional;
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
            ViewModelAddWindowBroadcaster vm = new ViewModelAddWindowBroadcaster(this.Entities.Civilité.Local);
            addProfessionalWindow addProfessionalWindow = new addProfessionalWindow();
            addProfessionalWindow.DataContext = vm;
            addProfessionalWindow.ShowDialog();


            if (addProfessionalWindow.DialogResult.GetValueOrDefault())
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
