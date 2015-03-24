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
    /// Базовый класс для всех объектов модели домена
    /// </summary>
    /// <remarks>Абстрактный не сохраняемый класс</remarks>
    [NonPersistent]
    public abstract class ModelBaseObject : BaseObject, IModelEntity
    {

        #region Constructors

        public ModelBaseObject(Session session)
            : base(session)
        {
            _modelObservers = new List<IModelObserver>();
        } 
        #endregion

        /// <summary>
        /// Внешние обозреватели модели
        /// </summary>
        private IList<IModelObserver> _modelObservers;

        /// <summary>
        /// Зарезервировано на будущее. Объект управления логикой модели.
        /// </summary>
        [Browsable(false)]
        public IModelLogic ModelLogic
        { get; set; }


        #region Методы
        
        protected override void OnDeleted()
        {
            base.OnDeleted();
        } 
        #endregion

        #region IModelEntity
        public void AddSubscriber(IModelObserver Observer)
        {
            _modelObservers.Add(Observer);
        }

        public virtual void RemoveSubscriber(IModelObserver Observer)
        {
            _modelObservers.Remove(Observer);
        }

        public virtual void Notify()
        {
            foreach (IModelObserver _observer in _modelObservers)
            {
                _observer.Notify(this);
            }
        } 
        #endregion
    }

}
