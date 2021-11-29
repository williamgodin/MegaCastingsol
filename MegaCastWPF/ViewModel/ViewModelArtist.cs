using Megacasting.DBLib;
using MegaCastWPF.Proxy;
using MegaCastWPF.Views;
using MegaCastWPF.Windows.Artiste;
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
        /// artiste
        /// </summary>
        private Personne _SelectedItem;

        /// <summary>
        /// Liste des artistes
        /// </summary>
        public ObservableCollection<Personne> _Items;

        private AddProxy _Proxy;

        private ObservableCollection<Civilité> _Civilités;
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


        public ObservableCollection<Civilité> Civilites
        {
            get { return _Civilités; }
            set { _Civilités = value; }
        }


        public AddProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }
        #endregion
        #region Constructor
        public ViewModelArtist() : base()
        {
            
        }
        #endregion
        #region Method
        public void AddItem()
        {
            this.Entities.Personne.ToList();
            this.Items = this.Entities.Personne.Local;
            ViewModelAddWindow vm = new ViewModelAddWindow(this.Entities.Civilité.Local);
            AddArtistWindow addArtistWindow = new AddArtistWindow();
            addArtistWindow.DataContext = vm;

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
            if (addArtistWindow.DialogResult.Value)
            {
                //Artiste artiste = new Artiste();
                artiste.Civilité = vm.Proxy.Civilite;
                artiste.Nom = vm.Proxy.FirstName;
                artiste.Prenom = vm.Proxy.LastName;
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
