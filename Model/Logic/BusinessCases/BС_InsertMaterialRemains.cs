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
    /// Бизнес-кейс реализует логику внесения первичной нулевой записи о совокупных остатках материала
    /// </summary>
    /// <remarks>Предусматривается, что данный кейс будет срабатывать только при создании нового материала в справочнике материалов</remarks>
    public class BC_InsertMaterialRemains : BaseBusinessCase
    {

        public BC_InsertMaterialRemains() : base() { }

        public BC_InsertMaterialRemains(ObjectSpace currentObjectSpace, XPBaseObject currentEntity)
            : base(currentObjectSpace, currentEntity)
        {
        }

        protected Material CurrentMaterial { get; set; }

        public override void Execute()
        {
            MaterialRemains _materialRemains = new MaterialRemains(CurrentSession)
            {
                Amount = 0.0,
                DateTime = DateTime.Now,
                Material = (CurrentEntity as Material),
                Price = 0.0,
                ReservedAmount = 0.0
            };
        }
    }
}
