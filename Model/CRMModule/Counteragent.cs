using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.CRMModule
{

    /// <summary>
    /// Абстрактный класс представления объекта контрагента
    /// </summary>
    public abstract class Counteragent : DigiPrint.Module.Model.Core.PresentationBaseObject
    {
        public Counteragent(Session session) : base(session) { }

        protected virtual CounteragentImpl GetImplementationClass()
        {
            return new CounteragentImpl(Session);
        }
    }

}
