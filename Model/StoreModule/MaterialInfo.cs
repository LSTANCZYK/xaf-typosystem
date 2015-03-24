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
    /// ����������� �����, ������������ ���������� � ��������, ���������, �������� ����������
    /// </summary>
    /// <remarks>���������� ���������� ������� � ������� ������������ ������ MaterialInfoImpl</remarks>
    public abstract class MaterialInfo : PresentationBaseObject
    {
        public MaterialInfo(Session session)
            : base(session)
        {
        }

        [Persistent]
        [Aggregated]
        protected MaterialInfoImpl _implementationObject;


        public override void AfterConstruction()
        {
            base.AfterConstruction();
            _implementationObject = GetImplementationClass();
            DateTime = DateTime.Now;
        }


        protected virtual MaterialInfoImpl GetImplementationClass()
        {
            return new MaterialInfoImpl(this.Session);
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption","��������")]
        [VisibleInListView(true)]
        public Material Material
        {
            //get { return (_materialInfoImpl as MaterialInfoImpl).Material; }
            //set { (_materialInfoImpl as MaterialInfoImpl).Material = value; }
            get { return (Material)GetImplementorPropertyValue(this._implementationObject, "Material"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Material", value); }
        }


        [NoForeignKey]
        [NonPersistent]
        [Custom("Caption", "����")]
        [Custom("DisplayFormat", "{0:C}")]
        [Custom("EditMask", "C")]
        [VisibleInListView(true)]
        public Double Price
        {
            //get { return (_materialInfoImpl as MaterialInfoImpl).Price; }
            //set { (_materialInfoImpl as MaterialInfoImpl).Price = value; }
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "Price"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Price", value); }
        }



        [NonPersistent]
        [Custom("Caption", "����������")]
        [VisibleInListView(true)]
        public Double Amount
        {
            //get { return (_materialInfoImpl as MaterialInfoImpl).Amount; }
            //set { (_materialInfoImpl as MaterialInfoImpl).Amount = value; }
            get { return (Double)GetImplementorPropertyValue(this._implementationObject, "Amount"); }
            set { SetImplementorPropertyValue(this._implementationObject, "Amount", value); }
        }


        [NonPersistent]
        [Custom("Caption", "����.�����")]
        [VisibleInListView(true)]
        public DateTime DateTime
        {
            //get { return (_materialInfoImpl as MaterialInfoImpl).DateTime; }
            //set { (_materialInfoImpl as MaterialInfoImpl).DateTime = value; }
            get { return (DateTime)GetImplementorPropertyValue(this._implementationObject, "DateTime"); }
            set { SetImplementorPropertyValue(this._implementationObject, "DateTime", value); }
        }



    }

}
