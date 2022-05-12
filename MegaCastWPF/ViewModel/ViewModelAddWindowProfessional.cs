using Megacasting.DBLib;
using MegaCastWPF.Proxy;
using MegaCastWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelAddWindowProfessional
    {
        private AddProfessionelProxy _Proxy;
        #region Fields
        /// <summary>
        /// Unique
        /// </summary>
        private Personne _SelectedItem;
        private Civilité _SelectedCivilité;


        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Personne> _Items;
        public ObservableCollection<Civilité> _Civilités;
        #endregion

        #region Properties
        /// <summary>
        /// Unique
        /// </summary>
        /// 

        public AddProfessionelProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }
        public Personne SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public Civilité SelectedCivilité
        {
            get { return _SelectedCivilité; }
            set { _SelectedCivilité = value; }
        }
        /// <summary>
        /// Liste
        /// </summary>
        public ObservableCollection<Personne> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }

        public ObservableCollection<Civilité> Civilités
        {
            get { return _Civilités; }
            set { _Civilités = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Créer la fenêtre d'ajout d'un broadcaster
        /// </summary>
        /// <param name="Civilités">Permet d'obetenir la liste des civilités</param>
        public ViewModelAddWindowProfessional(ObservableCollection<Civilité> Civilités)
        {
            this.Proxy = new AddProfessionelProxy();
            this.Civilités = Civilités;
        }


        #endregion

    }
}
