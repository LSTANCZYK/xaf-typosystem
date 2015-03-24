using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DigiPrint.Module.Model.OrderModule;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Класс реализации требований к закупке материала
    /// </summary>
    [Custom("Caption", "Требование закупки")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialProcurementRequirement : MaterialInfo
    {
        public MaterialProcurementRequirement(Session session) : base(session) { }

        protected override MaterialInfoImpl GetImplementationClass()
        {
            return new MaterialProcurementRequirementImpl(Session);
        }


        /// <summary>
        /// Заказ, под который первоначально было создано данное требование
        /// </summary>
        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Заказ")]
        public Order Order
        {
            get { return (Order)GetImplementorPropertyValue(this._implementationObject, "Order"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Order", value); }
        }

    }
}
