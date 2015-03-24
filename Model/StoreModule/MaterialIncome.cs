using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Приход материала на склад
    /// </summary>
    [Custom("Caption", "Приход материала")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialIncome : MaterialManageInfo
    {
        public MaterialIncome(Session session) : base(session) { }


        protected override MaterialInfoImpl GetImplementationClass()
        {
            return new MaterialIncomeImpl(Session);
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Списано")]
        public double WriteOffAmount
        {
            get { return (_implementationObject as MaterialIncomeImpl).WriteOffAmount; }
            set { (_implementationObject as MaterialIncomeImpl).WriteOffAmount = value; }
        }


        /// <summary>
        /// Доступно к списанию
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "Доступно к списанию")]
        public Double AvailableAmount
        {
            get { return (_implementationObject as MaterialIncomeImpl).AvailableAmount; }
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "Доступно")]
        public bool Active
        {
            get { return (_implementationObject as MaterialIncomeImpl).Active; }
            set { (_implementationObject as MaterialIncomeImpl).Active = value; }
        }
    }

}
