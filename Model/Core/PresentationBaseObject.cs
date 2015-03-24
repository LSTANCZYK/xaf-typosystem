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
    /// Базовый для всех презентационных классов
    /// </summary>
    /// <remarks>Презентационные классы не содержат логику соответствующей бизнес-сущности, 
    /// но содержат все необходимые для отображения поля и используются для генерации представления средствами XAF</remarks>
    [NonPersistent]
    [Browsable(false)]
    public abstract class PresentationBaseObject : ModelBaseObject
    {

        #region Constructors

        public PresentationBaseObject(Session session)
            : base(session)
        {
        }
        #endregion


        #region Methods

        /// <summary>
        /// Обработка события создания нового объекта
        /// </summary>
        /// <remarks>Создаёт ссылку на класс реализации</remarks>
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        /// <summary>
        /// Возвращает класс, реализующий логику и набор параметров для данного класса представления
        /// </summary>
        /// <returns></returns>
        //protected virtual ImplementationBaseObject GetImplementationClass()
        //{
        //    return null;
        //}


        protected Object GetImplementorPropertyValue(ImplementationBaseObject ImplementorBaseObject, string PropertyName)
        {
            return ImplementorBaseObject.GetMemberValue(PropertyName);
        }

        protected void SetImplementorPropertyValue(ImplementationBaseObject ImplementorBaseObject, string PropertyName, object Value)
        {
            ImplementorBaseObject.SetMemberValue(PropertyName, Value);
        }

       
        #endregion

    }

}
