using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.OperationsModule
{
    /// <summary>
    /// Абстрактный класс реализации объекта Заказа
    /// </summary>
    public class OperationImpl : ImplementationBaseObject
    {
        public OperationImpl(Session Session) : base(Session) { }
    }
}
