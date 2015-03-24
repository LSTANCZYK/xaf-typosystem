using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DigiPrint.Module.Model.OrderModule;
using DigiPrint.Module.Model.CRMModule;

namespace DigiPrint.Module.Model.StoreModule
{
    public abstract class PrintedMaterialInfo : PresentationBaseObject
    {
        public PrintedMaterialInfo(Session Session) : base(Session) { }


        [Persistent]
        [Aggregated]
        protected PrintedMaterialInfoImpl _implementationObject;


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            _implementationObject = GetImplementationClass();
            DateTime = DateTime.Now;
        }


        protected virtual PrintedMaterialInfoImpl GetImplementationClass()
        {
            return new PrintedMaterialInfoImpl(this.Session);
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Продукция")]
        [VisibleInListView(true)]
        public PrintedMaterial PrintedMaterial
        {
            get { return (PrintedMaterial)GetImplementorPropertyValue(this._implementationObject, "PrintedMaterial"); }
            set { SetImplementorPropertyValue(this._implementationObject, "PrintedMaterial", value); }
        }



        [NonPersistent]
        [Custom("Caption", "Количество")]
        [VisibleInListView(true)]
        public Double Amount
        {
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "Amount"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Amount", value); }
        }


        /// <summary>
        /// Заказ
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "Заказ")]
        [VisibleInListView(true)]
        public Order Order
        {
            get { return (Order)GetImplementorPropertyValue(this._implementationObject, "Order"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Order", value); }
        }


        /// <summary>
        /// Заказчик
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "Заказчик")]
        [VisibleInListView(true)]
        public Counteragent Counteragent
        {
            get { return (Counteragent)GetImplementorPropertyValue(this._implementationObject, "Counteragent"); }
        }


        [NonPersistent]
        [Custom("Caption", "Дата.Время")]
        [VisibleInListView(true)]
        public DateTime DateTime
        {
            get { return (DateTime)GetImplementorPropertyValue(this._implementationObject, "DateTime"); }
            set { SetImplementorPropertyValue(this._implementationObject, "DateTime", value); }
        }


        /// <summary>
        /// Дополнительный комментарий
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "Комментарий")]
        public String Description
        {
            get { return (String)GetImplementorPropertyValue(this._implementationObject, "Description"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Description", value); }
        }
    }
}
