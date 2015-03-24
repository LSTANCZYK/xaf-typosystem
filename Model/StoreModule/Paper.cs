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
    
    [Custom("Caption","Бумага")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class Paper : Material
    {
        public Paper(Session session) : base(session) { }
    }

}
