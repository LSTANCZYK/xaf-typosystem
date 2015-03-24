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
    /// Класс для реализации логики объекта оприходования материала
    /// </summary>
    [Browsable(false)]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialIncomeImpl : MaterialInfoImpl
    {
        public MaterialIncomeImpl(Session session) : base(session) { }


        private double _writeOffAmount;
        /// <summary>
        /// Списанное количество материала из ранее оприходованного
        /// </summary>
        public Double WriteOffAmount
        {
            get { return _writeOffAmount; }
            set { SetPropertyValue<Double>("WriteOffAmount", ref _writeOffAmount, value); }
        }

        /// <summary>
        /// Доступный для списания материал данного оприходования
        /// </summary>
        public Double AvailableAmount
        {
            get { return Amount - _writeOffAmount; }
        }
    }

}
