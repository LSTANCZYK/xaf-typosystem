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
    /// ������ ��������� �� �����
    /// </summary>
    [Custom("Caption", "������ ���������")]
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
        [Custom("Caption", "�������")]
        public double WriteOffAmount
        {
            get { return (_implementationObject as MaterialIncomeImpl).WriteOffAmount; }
            set { (_implementationObject as MaterialIncomeImpl).WriteOffAmount = value; }
        }


        /// <summary>
        /// �������� � ��������
        /// </summary>
        [NonPersistent]
        [Custom("Caption", "�������� � ��������")]
        public Double AvailableAmount
        {
            get { return (_implementationObject as MaterialIncomeImpl).AvailableAmount; }
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "��������")]
        public bool Active
        {
            get { return (_implementationObject as MaterialIncomeImpl).Active; }
            set { (_implementationObject as MaterialIncomeImpl).Active = value; }
        }
    }

}
