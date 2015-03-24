using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiPrint.Module.Model.Core
{
    public interface IModelObserver
    {
        void Notify(IModelEntity Entity);
    }

    public interface IModelEntity
    {
        IModelLogic ModelLogic
        {
            get;
            set;
        }

        void AddSubscriber(IModelObserver Observer);
        void RemoveSubscriber(IModelObserver Observer);
        void Notify();
    }

    public interface IModelLogic
    {
        void OnPropertyChanged();

        void OnEntityCreated();

        void OnEntityDeleted();
    }


    public interface IBusinessCase
    {
        void Execute();
    }

}
