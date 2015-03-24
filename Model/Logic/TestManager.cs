using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiPrint.Module.Model.Logic
{
    public class TestManager
    {
        public TestManager() { }

        public TestManager(bool TurnOnNotImplementedExceptions) { ShowNotImplementedExceptions = TurnOnNotImplementedExceptions; }

        public bool ShowNotImplementedExceptions { get; set; }

        public void ThrowException()
        {
            if (ShowNotImplementedExceptions)
                throw new Exception(this.GetType().ReflectedType.ToString());
        }
    }
}
