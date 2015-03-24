using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.CRMModule
{
    /// <summary>
    /// Абстрактный класс реализации объекта Заказа
    /// </summary>
    public class CounteragentImpl : ImplementationBaseObject
    {
        public CounteragentImpl(Session Session) : base(Session) { }
    }
}
