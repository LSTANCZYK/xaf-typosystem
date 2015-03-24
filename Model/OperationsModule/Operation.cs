using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.OperationsModule
{
    /// <summary>
    /// Абстрактный класс представления объекта операции
    /// </summary>
    public abstract class Operation : DigiPrint.Module.Model.Core.PresentationBaseObject
    {
        public Operation(Session session) : base(session) { }

        protected virtual OperationImpl GetImplementationClass()
        {
            return new OperationImpl(Session);
        }
    }

}
