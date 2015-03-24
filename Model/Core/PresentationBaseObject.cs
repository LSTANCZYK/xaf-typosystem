using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DigiPrint.Module.Model.Logic;
using System.Collections;
using System.Collections.Generic;

namespace DigiPrint.Module.Model.Core
{
    /// <summary>
    /// ������� ��� ���� ��������������� �������
    /// </summary>
    /// <remarks>��������������� ������ �� �������� ������ ��������������� ������-��������, 
    /// �� �������� ��� ����������� ��� ����������� ���� � ������������ ��� ��������� ������������� ���������� XAF</remarks>
    [NonPersistent]
    [Browsable(false)]
    public abstract class PresentationBaseObject : ModelBaseObject
    {

        #region Constructors

        public PresentationBaseObject(Session session)
            : base(session)
        {
        }
        #endregion


        #region Methods

        /// <summary>
        /// ��������� ������� �������� ������ �������
        /// </summary>
        /// <remarks>������ ������ �� ����� ����������</remarks>
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }


        /// <summary>
        /// ���������� �����, ����������� ������ � ����� ���������� ��� ������� ������ �������������
        /// </summary>
        /// <returns></returns>
        //protected virtual ImplementationBaseObject GetImplementationClass()
        //{
        //    return null;
        //}


        protected Object GetImplementorPropertyValue(ImplementationBaseObject ImplementorBaseObject, string PropertyName)
        {
            return ImplementorBaseObject.GetMemberValue(PropertyName);
        }

        protected void SetImplementorPropertyValue(ImplementationBaseObject ImplementorBaseObject, string PropertyName, object Value)
        {
            ImplementorBaseObject.SetMemberValue(PropertyName, Value);
        }

       
        #endregion

    }

}
