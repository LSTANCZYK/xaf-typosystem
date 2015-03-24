using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiPrint.Module.Model.Core
{
    public static class SystemFactory
    {
        public static IModelObserver[] GetModelObservers()
        {
            return new IModelObserver[] { new DigiPrint.Module.Model.Logic.ModelLogic() };
        }

        public static IModelLogic GetModelLogic()
        {
            return new Model.Logic.ModelLogic() as IModelLogic;
        }
    }
}
