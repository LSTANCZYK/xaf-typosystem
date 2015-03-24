using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.OrderModule;
using DigiPrint.Module.Model.OperationsModule;

namespace DigiPrint.Module.Model.StoreModule
{

    /// <summary>
    /// Служебный класс для реализации свойств и методов класса представления MaterialInfo
    /// </summary>
    [Browsable(false)]
    public class MaterialInfoImpl : DigiPrint.Module.Model.Core.ImplementationBaseObject
    {
        public MaterialInfoImpl(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this._active = true;
        }


        private Material _material;
        public Material Material
        {
            get { return _material; }
            set { SetPropertyValue("Material", ref _material, value); }
        }


        private Store _store;
        public Store Store
        {
            get { return _store; }
            set { SetPropertyValue("Store", ref _store, value); }
        }


        private Double _price;
        public Double Price
        {
            get { return _price; }
            set { SetPropertyValue("Price", ref _price, value); }
        }


        private Double _amount;
        public Double Amount
        {
            get { return _amount; }
            set { SetPropertyValue("Amount", ref _amount, value); }
        }


        protected DateTime _dateTime;
        [Persistent("_DateTime")]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { SetPropertyValue("DateTime", ref _dateTime, value); }
        }


        protected bool _active;
        public bool Active
        {
            get { return _active; }
            set { SetPropertyValue("Active", ref _active, value); }
        }


        private Order _order;
        /// <summary>
        /// Заказ
        /// </summary>
        public Order Order
        {
            get { return _order; }
            set { SetPropertyValue("Order", ref _order, value); }
        }


    }

}
