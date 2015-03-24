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
    /// Класс, реализующий логику класса совокупных остатков материала
    /// </summary>
    [Browsable(false)]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialRemainsImpl : MaterialInfoImpl
    {
        public MaterialRemainsImpl(Session session) : base(session) { }


        private XPCollection<MaterialRemainsInStore> _materialRemainsOnStore;

        /// <summary>
        /// Суммарный остаток данного материала по всем складам
        /// </summary>
        public Double TotalAmount
        {
            get
            {
                Double _totalAmount = 0.0;
                if (_materialRemainsOnStore == null)
                    FillMaterialRemainsOnStore();
                
                foreach (var item in _materialRemainsOnStore)
                    _totalAmount += item.Amount;

                return _totalAmount;
            }
        }


        private double _reservedAmount;
        public Double ReservedAmount
        {
            get { return _reservedAmount; }
            set { SetPropertyValue<Double>("ReservedAmount", ref _reservedAmount, value); }
        }


        /// <summary>
        /// Совокупный (по всем складам) доступный остаток
        /// </summary>
        public Double AvailableAmount
        {
            get { return TotalAmount - _reservedAmount; }
        }


        /// <summary>
        /// Коллекция записей остаток материала на складе для данного материала
        /// </summary>
        [Aggregated]
        public XPCollection<MaterialRemainsInStore> MaterialRemainsOnStore
        {
            get
            {
                if (_materialRemainsOnStore == null)
                {
                    FillMaterialRemainsOnStore();
                }

                return _materialRemainsOnStore;
            }
        }

        private void FillMaterialRemainsOnStore()
        {
            XPQuery<MaterialRemainsInStore> _xpquery = new XPQuery<MaterialRemainsInStore>(Session);
            var qItems = from _materialremain in _xpquery
                         where _materialremain.Material == this.Material
                         select _materialremain;

            XPCollection<MaterialRemainsInStore> _xpMaterialremains = new XPCollection<MaterialRemainsInStore>(Session, false);
            _xpMaterialremains.AddRange(qItems.ToArray<MaterialRemainsInStore>());
            _materialRemainsOnStore = _xpMaterialremains;
        }
    }

}
