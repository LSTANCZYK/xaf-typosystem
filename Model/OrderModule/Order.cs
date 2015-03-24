using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;
using DigiPrint.Module.Model.CRMModule;

namespace DigiPrint.Module.Model.OrderModule
{

    /// <summary>
    /// Абстрактный класс представления объекта заказа
    /// </summary>
    public abstract class Order : DigiPrint.Module.Model.Core.PresentationBaseObject
    {
        public Order(Session session) : base(session) { }

        [Persistent]
        [Aggregated]
        protected OrderImpl _implementationObject;


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            _implementationObject = GetImplementationClass();
        }


        protected virtual OrderImpl GetImplementationClass()
        {
            return new OrderImpl(Session);
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Заказчик")]
        [VisibleInListView(true)]
        public Counteragent Counteragent
        {
            get { return (Counteragent)GetImplementorPropertyValue(this._implementationObject, "Counteragent"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Counteragent", value); }
        }
    }

}
