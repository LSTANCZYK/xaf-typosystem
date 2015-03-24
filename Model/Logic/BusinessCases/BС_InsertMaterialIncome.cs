using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DigiPrint.Module.Model.StoreModule;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.Logic.BusinessCases
{
    /// <summary>
    /// Бизнес-кейс реализует логику оприходования материала на складе
    /// </summary>
    public class BC_InsertMaterialIncome : BaseBusinessCase
    {

        public BC_InsertMaterialIncome() : base() { }

        public BC_InsertMaterialIncome(ObjectSpace currentObjectSpace, XPBaseObject currentEntity)
            : base(currentObjectSpace, currentEntity)
        {
            CurrentMaterial = (currentEntity as MaterialIncome).Material;
            CurrentStore = (currentEntity as MaterialIncome).Store;
        }


        protected Material CurrentMaterial { get; set; }
        protected Store CurrentStore { get; set; }


        public override void Execute()
        {

            StoreManager _storeManager = new StoreManager(CurrentObjectSpace.Session);


            /// найти остатки заданного материала на заданном складе, либо создать новые, если отсутствует информация
            /// 
            MaterialRemainsInStore _materialRemainsInStore = _storeManager.GetMaterialRemainsInStore(CurrentMaterial, CurrentStore);
            if (_materialRemainsInStore == null)
            {
                _materialRemainsInStore = new MaterialRemainsInStore(CurrentSession);
                _materialRemainsInStore.Material = CurrentMaterial;
                _materialRemainsInStore.Store = CurrentStore;
                _materialRemainsInStore.Amount = 0.0;
            }
            _materialRemainsInStore.Amount += (CurrentEntity as MaterialIncome).Amount;


            /// уменьшить требования к закупке
            /// 
            TestManager.ThrowException();


            /// пересчитать остаточные цены по складу В ЗАВИСИМОСТИ ОТ МЕТОДА СПИСАНИЯ!
            /// 
            Double _averageSum = 0.0;
            //if (СРЕДНЕВЗВЕШ.)
            {
                IEnumerable<MaterialIncome> _qMaterialIncomes = _storeManager.GetActiveMaterialIncomes(CurrentMaterial, DevExpress.Xpo.DB.SortingDirection.Ascending, "DateTime");
                _averageSum = _storeManager.CountWeightAveragePrice(_qMaterialIncomes);
            }


            /// найти текущие совокупные остатки и обновить значение текущей цены списания
            /// 
            MaterialRemains _totalMaterialRemains = _storeManager.GetTotalMaterialRemains(CurrentMaterial);
            _totalMaterialRemains.Price = _averageSum;
        }
    }
}
