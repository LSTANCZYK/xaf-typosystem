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
    /// Бизнес-кейс реализует логику внесения информации об отгрузке готовой продукции со склада заказчику
    /// </summary>
    /// <remarks></remarks>
    public class BС_InsertPrintedMaterialShipping : BaseBusinessCase
    {

        public BС_InsertPrintedMaterialShipping() : base() { }

        public BС_InsertPrintedMaterialShipping(ObjectSpace currentObjectSpace, XPBaseObject currentEntity)
            : base(currentObjectSpace, currentEntity)
        {
            this._currentShipped = (currentEntity as PrintedMaterialShipped);
            _storeManager = new StoreManager(CurrentObjectSpace.Session);
        }

        // остаток ГП
        private PrintedMaterialRemains _remains;
        // отгруженная ГП
        private PrintedMaterialShipped _currentShipped;

        StoreManager _storeManager;

        public override void Execute()
        {
            //throw new NotImplementedException("НЕОБХОДИМО РЕАЛИЗОВАТЬ");
            _remains = _storeManager.GetPrintedMaterialRemainsInStore(_currentShipped.Order, _currentShipped.PMS_GetImplementationClass().Store);

            if (_remains.RemainsToBeShipped < _currentShipped.Amount)
            {
                /// Попытка отгрузить большее количество, чем есть в остатках по данному заказу, выдать ошибку и отменить сохранение!
                /// 
                TestManager.ThrowException();
                return;
            }
            else
            {
                SaveShipping();
            }
        }

        private void SaveShipping()
        {
            _currentShipped.Save();

            _remains.ShippedAmount += _currentShipped.Amount;
            _remains.DateTime = DateTime.Now;
            _remains.Save();
            //_remains = _storeManager.GetPrintedMaterialRemainsInStore(_currentShipped.PrintedMaterial, _currentShipped.Order, _currentShipped.PMS_GetImplementationClass().Store);
        }
    }
}
