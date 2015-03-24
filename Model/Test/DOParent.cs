using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.StoreModule;

namespace DigiPrint.Module.Model.Test
{
    
    [NonPersistent]
    public abstract class DOParent : BaseObject
    {
        public DOParent(Session session) : base(session) { }

        private string _name;

        [Custom("Caption", "Название от родителя")]
        public virtual string ParentName
        {
            get { return _name; }
            set { SetPropertyValue<string>("ParentName", ref _name, value); }
        }


        private Paper _paper;

        [Custom("Caption", "Бумага")]
        public Paper Paper
        {
            get
            {
                return _paper;
            }
            set
            {
                SetPropertyValue("Paper", ref _paper, value);
            }
        }

       
    }

}
