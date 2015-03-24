using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Книжная продукция
    /// </summary>
    [Custom("Caption", "Книжная продукция")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class Books : PrintedMaterial
    {
        public Books(Session Session) : base(Session) { }
    }
}
