using Megacasting.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastWPF.Proxy
{
    public class AddCastingProxy
    {
        private Casting _SelectedCasting;

        public Casting SelectedCasting
        {
            get { return _SelectedCasting; }
            set { _SelectedCasting = value; }
        }

        public Casting Casting { get; set; }

        public String Intitule { get; set; }
        public DateTime Date_debut_publication{ get; set; }
        public Professionnel Professionnel  { get; set; }
        public Métier Metier { get; set; }
        public Type_de_contrat Contrat { get; set; }
        public DateTime Duree_diffusion { get; set; }
        public string Coordonnée { get; set; }
        public string Description_profil { get; set; }
        public string Description_poste { get; set; }
        public string Localisation { get; set; }
        public int Nbr_poste { get; set; }
        public int Reference { get; set; }
        public AddCastingProxy()
        {
            this.Date_debut_publication = DateTime.UtcNow;
        }
    }
}
