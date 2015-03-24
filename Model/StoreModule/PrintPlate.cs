using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DigiPrint.Module.Model.StoreModule
{

    [MapInheritance(MapInheritanceType.ParentTable)]
    public class PrintPlate : Material
    {
        public PrintPlate(Session session) : base(session) { }
    }

}
