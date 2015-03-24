using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Logic;
using System.Collections;
using System.Collections.Generic;

namespace DigiPrint.Module.Model.Core
{
    /// <summary>
    /// Базовый для всех классов реализации
    /// </summary>
    /// <remarks>Классы реализации содержат логику соответствующей бизнес-сущности, 
    /// одновременно служат для хранения информации в источнике данных средствами XPO</remarks>
    [NonPersistent]
    public abstract class ImplementationBaseObject : ModelBaseObject
    {

        #region Constructors

        public ImplementationBaseObject(Session session)
            : base(session)
        {
        }
        #endregion

    }

}
