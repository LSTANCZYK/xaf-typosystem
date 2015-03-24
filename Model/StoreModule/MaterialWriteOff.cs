using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;
using DigiPrint.Module.Model.OrderModule;
using DigiPrint.Module.Model.OperationsModule;

namespace DigiPrint.Module.Model.StoreModule
{

    /// <summary>
    /// Списание материала со склада в производство
    /// </summary>
    [Custom("Caption", "Списание материала")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialWriteOff : MaterialManageInfo
    {
        public MaterialWriteOff(Session session) : base(session) { }

        protected override MaterialInfoImpl GetImplementationClass()
        {
            return new MaterialWriteOffImpl(Session);
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Заказ")]
        public Order Order
        {
            //get { return (_implementationBaseObject as MaterialWriteOffImpl).Order; }
            //set { (_implementationBaseObject as MaterialWriteOffImpl).Order = value; }
            get { return (Order)GetImplementorPropertyValue(this._implementationObject, "Order"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Order", value); }
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Операция")]
        public Operation Operation
        {
            //get { return (_implementationBaseObject as MaterialWriteOffImpl).Operation; }
            //set { (_implementationBaseObject as MaterialWriteOffImpl).Operation = value; }
            get { return (Operation)GetImplementorPropertyValue(this._implementationObject, "Operation"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Operation", value); }
        }

        
    }

}
