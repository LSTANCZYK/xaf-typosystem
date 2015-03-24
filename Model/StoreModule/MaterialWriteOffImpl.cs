using System;
using System.ComponentModel;
using System.Linq;

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
    /// Класс для реализации логики объекта списания материала в производство
    /// </summary>
    [MapInheritance(MapInheritanceType.ParentTable)]
    [Browsable(false)]
    public class MaterialWriteOffImpl : MaterialInfoImpl
    {
        public MaterialWriteOffImpl(Session session) : base(session) { }


       

        private Operation _operationInfo;
        /// <summary>
        /// Операция
        /// </summary>
        public Operation Operation
        {
            get { return _operationInfo; }
            set { SetPropertyValue("Operation", ref _operationInfo, value); }
        }
    }

}
