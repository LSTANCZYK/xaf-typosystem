using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Остатки готовой продукции
    /// </summary>
    [Custom("Caption","Остатки ГП")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class PrintedMaterialRemains : PrintedMaterialInfo
    {
        public PrintedMaterialRemains(Session Session) : base(Session) { }

        public PrintedMaterialInfoImpl PMR_GetImplementationClass()
        {
            return base.GetImplementationClass();
        }


        [NonPersistent]
        [Custom("Caption", "Отгружено")]
        [VisibleInListView(true)]
        public Double ShippedAmount
        {
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "ShippedAmount"); }
            set { SetImplementorPropertyValue(this._implementationObject, "ShippedAmount", value); }
        }


        [NonPersistent]
        [Custom("Caption", "Остаток")]
        [VisibleInListView(true)]
        public Double RemainsToBeShipped
        {
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "RemainsToBeShipped"); }
        }


        /// <summary>
        /// Отгружен полностью
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "Закрыт")]
        [VisibleInListView(true)]
        public bool Finished
        {
            get { return (bool)GetImplementorPropertyValue(this._implementationObject, "Finished"); }
        }

    }
}
