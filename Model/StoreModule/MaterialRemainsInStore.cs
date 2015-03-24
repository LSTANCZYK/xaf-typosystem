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
    /// <summary>
    /// ������� ��������� �� ������
    /// </summary>
    [Custom("Caption", "������� ��������� �� ������")]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialRemainsInStore : MaterialManageInfo
    {
        public MaterialRemainsInStore(Session session) : base(session) { }

    }

}
