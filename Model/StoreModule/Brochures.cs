using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Брошюры
    /// </summary>
    [Custom("Caption", "Брошюры")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class Brochures : PrintedMaterial
    {
        public Brochures(Session Session) : base(Session) { }
    }
}
