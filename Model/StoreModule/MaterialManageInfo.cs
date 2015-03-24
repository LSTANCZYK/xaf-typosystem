using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.StoreModule
{

    /// <summary>
    /// јбстрактный класс, объедин€ющий информацию о приходах, списани€х, остатках материалов
    /// </summary>
    /// <remarks>¬нутренн€€ реализаци€ свойств и методов делегируетс€ классу MaterialInfoImpl</remarks>
    [MapInheritance( MapInheritanceType.ParentTable)]
    public abstract class MaterialManageInfo : MaterialInfo
    {
        public MaterialManageInfo(Session session)
            : base(session)
        {
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "—клад")]
        [VisibleInListView(true)]
        public Store Store
        {
            get { return (_implementationObject as MaterialInfoImpl).Store; }
            set { (_implementationObject as MaterialInfoImpl).Store = value; }
        }


    }

}
