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
    /// Класс для реализации логики объекта-требования к закупке материалов в связи с недостачей для выполнения определённого заказа
    /// </summary>
    [Browsable(false)]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialProcurementRequirementImpl : MaterialInfoImpl
    {
        public MaterialProcurementRequirementImpl(Session session) : base(session) { }


        private double _procuredAmount;
        /// <summary>
        /// Закупленное по данному требованию количество
        /// </summary>
        /// <remarks>Может быть меньше изначально необходимого</remarks>
        public Double ProcuredAmount
        {
            get { return _procuredAmount; }
            set { SetPropertyValue<Double>("ProcuredAmount", ref _procuredAmount, value); }
        }

        /// <summary>
        /// По-прежнему необходимое количество с учётом уже закупленного
        /// </summary>
        public Double StillRequiredAmount
        {
            get { return Amount - _procuredAmount; }
        }
    }

}
