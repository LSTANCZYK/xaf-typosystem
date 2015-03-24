using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DigiPrint.Module.Model.Test
{
    
    public class DOChild : DOParent
    {
        public DOChild(Session session) : base(session) { }

        
        private string _name;
        public string ChildName
        {
            get { return _name; }
            set { SetPropertyValue<string>("ChildName", ref _name, value); }
        }

        //[Custom("Caption", "Материалы")]
        //[NoForeignKey]
        //[NonPersistent]
        //public XPCollection<Material> Materials
        //{
        //    get
        //    {
        //        return GetCollection<Material>("Materials");
        //    }
        //}
    }

}
