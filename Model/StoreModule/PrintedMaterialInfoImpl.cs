using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DigiPrint.Module.Model.OrderModule;
using DigiPrint.Module.Model.CRMModule;
using System.ComponentModel;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Реализация классов готовой продукцией
    /// </summary>
    [Browsable(false)]
    [MemberDesignTimeVisibility(false)]
    public class PrintedMaterialInfoImpl : DigiPrint.Module.Model.Core.ImplementationBaseObject
    {
        public PrintedMaterialInfoImpl(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        private PrintedMaterial _printedMaterial;
        public PrintedMaterial PrintedMaterial
        {
            get { return _printedMaterial; }
            set { SetPropertyValue("PrintedMaterial", ref _printedMaterial, value); }
        }


        private Store _store;
        public Store Store
        {
            get { return _store; }
            set { SetPropertyValue("Store", ref _store, value); }
        }


        private Double _amount;
        /// <summary>
        /// Начальное количество
        /// </summary>
        public Double Amount
        {
            get { return _amount; }
            set { SetPropertyValue("Amount", ref _amount, value); }
        }

        private Double _shippedAmount;
        /// <summary>
        /// Отгруженная продукция
        /// </summary>
        public Double ShippedAmount
        {
            get { return _shippedAmount; }
            set { SetPropertyValue("ShippedAmount", ref _shippedAmount, value); }
        }


        /// <summary>
        /// Осталось отгрузить
        /// </summary>
        public Double RemainsToBeShipped
        {
            get { return _amount - _shippedAmount; }
        }


        protected DateTime _dateTime;
        [Persistent("_DateTime")]
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { SetPropertyValue("DateTime", ref _dateTime, value); }
        }


        protected bool _finished;
        /// <summary>
        /// Показывает, отгружен ли заказ полностью
        /// </summary>
        public bool Finished
        {
            get { return RemainsToBeShipped <= 0; }
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


        /// <summary>
        /// Заказчик
        /// </summary>
        public Counteragent Counteragent
        {
            get {
                if (!IsLoading && _order != null)
                    return _order.Counteragent;
                return null;
            }
        }


        private String _description;
        /// <summary>
        /// Дополнительный комментарий
        /// </summary>
        [Persistent("Description")]
        [Size(-1)]
        public String Description
        {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        } 

    }

}
