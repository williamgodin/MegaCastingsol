using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megacasting.DBLib;

namespace MegaCastWPF.ViewModel
{
    /// <summary>
    /// La base des modèles-vue pour les vues
    /// </summary>
    class ViewModelViewBase
    {
        /// <summary>
        /// Fait le lien avec la base de donnée
        /// </summary>
        public ViewModelViewBase()
        {
            this.Entities = new MegacastingEntities();
        }
        #region Field
        private MegacastingEntities _Entities;

        #endregion
        #region Properties
        public MegacastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }
    }
    #endregion
}
