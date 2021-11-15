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
        #region Field

        private MegacastingEntities _Entities;

        #endregion
        #region Properties
        public MegacastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }
        #endregion
        public ViewModelViewBase()
        {
            this.Entities = new MegacastingEntities();
        }
    }
}
