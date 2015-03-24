using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Отгрузка готовой продукции
    /// </summary>
    [Custom("Caption","Отгрузка ГП")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class PrintedMaterialShipped : PrintedMaterialInfo
    {
        public PrintedMaterialShipped(Session Session) : base(Session) { }

        public PrintedMaterialInfoImpl PMS_GetImplementationClass()
        {
            return base.GetImplementationClass();
        }
    }
}
