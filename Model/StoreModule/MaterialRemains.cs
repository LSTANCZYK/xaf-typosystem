using System;
using System.ComponentModel;
using System.Linq;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Core;

namespace DigiPrint.Module.Model.StoreModule
{

    [Custom("Caption", "������� ���������")]
    [DefaultListViewOptions( DevExpress.ExpressApp.MasterDetailMode.ListViewAndDetailView)]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MaterialRemains : MaterialInfo
    {
        public MaterialRemains(Session session) : base(session) { }

        protected override MaterialInfoImpl GetImplementationClass()
        {
            return new MaterialRemainsImpl(this.Session);
        }

        
        /// <summary>
        /// ��������� ������� ��������� �� ���� �������
        /// </summary>
        [Custom("Caption", "��������� �������")]
        [NonPersistent]
        public Double TotalAmount
        {
            //get { return (_implementationBaseObject as MaterialRemainsImpl).TotalAmount; }
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "TotalAmount"); }
        }


        /// <summary>
        /// ���������������
        /// </summary>
        [Custom("Caption", "���������������")]
        [NonPersistent]
        public Double ReservedAmount
        {
            //get { return (_implementationBaseObject as MaterialRemainsImpl).ReservedAmount; }
            //set { (_implementationBaseObject as MaterialRemainsImpl).ReservedAmount = value; }
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "ReservedAmount"); }
            set { SetImplementorPropertyValue(this._implementationObject, "ReservedAmount", value); }
        }


        /// <summary>
        /// ��������� �������
        /// </summary>
        [Custom("Caption", "��������� �������")]
        [NonPersistent]
        public Double AvailableAmount
        {
            //get { return (_implementationBaseObject as MaterialRemainsImpl).AvailableAmount; }
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "AvailableAmount"); }
        }

        /// <summary>
        /// ��������� �� �������
        /// </summary>
        [Aggregated]
        [NonPersistent]
        [Custom("Caption", "������� �� �������")]
        public XPCollection<MaterialRemainsInStore> MaterialRemainsOnStore
        {
            get
            {
                //return (_implementationBaseObject as MaterialRemainsImpl).MaterialRemainsOnStore;
                return (XPCollection<MaterialRemainsInStore>)GetImplementorPropertyValue(this._implementationObject, "MaterialRemainsOnStore");
            }
        }
    }

}
