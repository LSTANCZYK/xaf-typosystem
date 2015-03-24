using System;
using System.ComponentModel;
using System.Linq;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DigiPrint.Module.Model.StoreModule
{

    /// <summary>
    /// ����� ��� ���������� ������ ������� ������������� ���������
    /// </summary>
    [Browsable(false)]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialIncomeImpl : MaterialInfoImpl
    {
        public MaterialIncomeImpl(Session session) : base(session) { }


        private double _writeOffAmount;
        /// <summary>
        /// ��������� ���������� ��������� �� ����� ���������������
        /// </summary>
        public Double WriteOffAmount
        {
            get { return _writeOffAmount; }
            set { SetPropertyValue<Double>("WriteOffAmount", ref _writeOffAmount, value); }
        }

        /// <summary>
        /// ��������� ��� �������� �������� ������� �������������
        /// </summary>
        public Double AvailableAmount
        {
            get { return Amount - _writeOffAmount; }
        }
    }

}
