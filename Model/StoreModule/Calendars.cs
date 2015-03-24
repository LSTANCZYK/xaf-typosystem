using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Календари
    /// </summary>
    [Custom("Caption", "Календари")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class Calendars : PrintedMaterial
    {
        public Calendars(Session Session) : base(Session) { }
    }
}
