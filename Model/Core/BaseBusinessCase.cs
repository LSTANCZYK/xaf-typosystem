using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DigiPrint.Module.Model.Core;
using DigiPrint.Module.Model.Logic;

namespace DigiPrint.Module.Model.Core
{
    public class BaseBusinessCase : IBusinessCase
    {
        public BaseBusinessCase()
        {
            TestManager = new TestManager(false); 
        }

        public BaseBusinessCase(ObjectSpace objectSpace, XPBaseObject currentEntity)
        {
            TestManager = new TestManager(false); 

            CurrentObjectSpace = objectSpace; 
            CurrentEntity = currentEntity; 
            CurrentSession = objectSpace.Session;
        }

        public ObjectSpace CurrentObjectSpace { get; set; }

        public Session CurrentSession { get; set; }

        public XPBaseObject CurrentEntity { get; set; }

        public TestManager TestManager { get; set; }


        public virtual void Execute() { }

    }
}
