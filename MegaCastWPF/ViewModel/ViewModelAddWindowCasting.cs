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
        /// Broadcater
        /// </summary>
        private Casting _SelectedItem;

        private Personne _SelectedPersonne;

        private Type_de_contrat _SelectedContrat;

        private Métier _SelectedMetier;

        private AddCastingProxy _Proxy;




        /// <summary>
        /// Liste des broadcaster
        /// </summary>
        public IEnumerable<Casting> _Items;
        #endregion
        public IEnumerable<Personne> _Personnes;

        public IEnumerable<Type_de_contrat> _Contrats;

        public IEnumerable<Métier> _Metiers;


        #region Properties
        public Casting SelectedItem
        {
            get { return _SelectedItem; }
            set { _SelectedItem = value; }
        }
        public IEnumerable<Casting> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        public AddCastingProxy Proxy
        {
            get { return _Proxy; }
            set { _Proxy = value; }
        }
        public IEnumerable<Personne> Personnes
        {
            get { return _Personnes; }
            set { _Personnes = value; }
        }
        public Personne SelectedPersonne
        {
            get { return _SelectedPersonne; }
            set { _SelectedPersonne = value; }
        }
        public IEnumerable<Type_de_contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }
        public Type_de_contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        public IEnumerable<Métier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }
        public Métier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }
        #endregion

        #region Constructor
        public ViewModelAddWindowCasting(IEnumerable<Personne> personnes, IEnumerable<Type_de_contrat> contrats, IEnumerable<Métier> metiers)
        {
            this.Proxy = new AddCastingProxy();
            this.Personnes = personnes;
            this.Contrats = contrats;
            this.Metiers = metiers;
        }



        #endregion

        #region Method

        #endregion
    }
}
