using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DigiPrint.Module.Model.Logic.BusinessCases;

namespace DigiPrint.Module.Model.Logic
{
    public class ModelLogic : IModelObserver, IModelLogic
    {

        #region IModelObserver
       public void Notify(IModelEntity Entity)
        {
            throw new NotImplementedException();
        } 
        #endregion  

        #region IModelLogic
        public void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public void OnEntityCreated()
        {
            throw new NotImplementedException();
        }

        public void OnEntityDeleted()
        {
            throw new NotImplementedException();
        } 
        #endregion

        /// <summary>
        /// Оприходование материала на склад
        /// </summary>
        /// <param name="objectSpace"></param>
        /// <param name="currentEntity"></param>
        public void InsertMaterialIncome(ObjectSpace objectSpace, XPBaseObject currentEntity)
        {
            BC_InsertMaterialIncome _case = new BC_InsertMaterialIncome(objectSpace, currentEntity);
            _case.Execute();
        }

        /// <summary>
        /// Внесение данных о первичных нулевых остатках материала на складах
        /// </summary>
        /// <remarks>Выполняется при первом создании данного вида материала</remarks>
        /// <param name="objectSpace"></param>
        /// <param name="currentEntity"></param>
        public void InsertInitialMaterialRemains(ObjectSpace objectSpace, XPBaseObject currentEntity)
        {
            BC_InsertMaterialRemains _case = new BC_InsertMaterialRemains(objectSpace, currentEntity);
            _case.Execute();
        }


        /// <summary>
        /// Внесение данных об отгрузке готовой продукции со склада заказчику
        /// </summary>
        /// <param name="objectSpace"></param>
        /// <param name="currentEntity"></param>
        public void InsertPrintedMaterialShipping(ObjectSpace objectSpace, XPBaseObject currentEntity)
        {
            BС_InsertPrintedMaterialShipping _case = new BС_InsertPrintedMaterialShipping(objectSpace, currentEntity);
            _case.Execute();
        }
    }
}
