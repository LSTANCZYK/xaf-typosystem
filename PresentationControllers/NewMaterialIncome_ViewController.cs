using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace DigiPrint.Module.ViewControllers
{
    public partial class NewMaterialIncome_ViewController : BaseViewController
    {
        public NewMaterialIncome_ViewController()
        {
            InitializeComponent();
            RegisterActions(components);
            TargetObjectType = typeof(DigiPrint.Module.Model.StoreModule.MaterialIncome);
        }


        protected override void Execute()
        {
            _modelLogic.InsertMaterialIncome(ObjectSpace, View.CurrentObject as DevExpress.Xpo.XPBaseObject);
        }
       
    }
}
