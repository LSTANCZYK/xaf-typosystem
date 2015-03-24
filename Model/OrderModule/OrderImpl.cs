using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.Xpo;
using DigiPrint.Module.Model.CRMModule;

namespace DigiPrint.Module.Model.OrderModule
{
    /// <summary>
    /// Абстрактный класс реализации объекта Заказа
    /// </summary>
    public class OrderImpl : ImplementationBaseObject
    {
        public OrderImpl(Session Session) : base(Session) { }


        private Counteragent _counteragent;
        /// <summary>
        /// Контрагент
        /// </summary>
        public Counteragent Counteragent
        {
            get { return _counteragent; }
            set { SetPropertyValue<Counteragent>("Counteragent", ref _counteragent, value); }
        }
    }
}
