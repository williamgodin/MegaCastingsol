using Megacasting.DBLib;
using MegaCastWPF.Proxy;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.ViewModel
{
    class ViewModelAddWindowCasting
    {
        #region Fields
        /// <summary>
        /// Unique
        /// </summary>
        private Casting _SelectedItem;

        private Personne _SelectedPersonne;

        private Type_de_contrat _SelectedContrat;

        private Métier _SelectedMetier;

        private AddCastingProxy _Proxy;

        /// <summary>
        /// Listes
        /// </summary>
        public IEnumerable<Casting> _Items;
        public IEnumerable<Personne> _Personnes;
        public IEnumerable<Type_de_contrat> _Contrats;
        public IEnumerable<Métier> _Metiers;
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
        public Personne SelectedPersonne
        {
            get { return _SelectedPersonne; }
            set { _SelectedPersonne = value; }
        }
        public Type_de_contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        public Métier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        public AddCastingProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }

        /// <summary>
        /// Listes
        /// </summary>
        public IEnumerable<Casting> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        public IEnumerable<Personne> Personnes
        {
            get { return _Personnes; }
            set { _Personnes = value; }
        }
        public IEnumerable<Type_de_contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        public IEnumerable<Métier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        #endregion
        #region Constructor
        /// <summary>
        /// Créer la fenêtre d'ajout d'un casting
        /// </summary>
        /// <param name="Personnes">Permet l'affichage des organisateur</param>
        /// <param name="contrats">Permet l'affichage des tpes de contrats</param>
        /// <param name="metiers">Permet l'affichage des métiers</param>
        public ViewModelAddWindowCasting(IEnumerable<Personne> Personnes, IEnumerable<Type_de_contrat> contrats, IEnumerable<Métier> metiers)
        {
            this.Proxy = new AddCastingProxy();
            this.Personnes = Personnes;
            this.Contrats = contrats;
            this.Metiers = metiers;
        }



        #endregion
    }
}
