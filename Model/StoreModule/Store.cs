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

    [Custom("Caption", "�����")]
    public class Store : DigiPrint.Module.Model.Core.ModelBaseObject
    {
        public Store(Session session) : base(session) { }


        private string _name;

        [Custom("Caption", "��������")]
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }
    }

}
