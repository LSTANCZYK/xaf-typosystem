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
    public partial class NewMaterial_ViewController : BaseViewController
    {
        public NewMaterial_ViewController()
        {
            InitializeComponent();
            RegisterActions(components);
            TargetObjectType = typeof(DigiPrint.Module.Model.StoreModule.Material);
        }


        protected override void Execute()
        {
            _modelLogic.InsertInitialMaterialRemains(ObjectSpace, View.CurrentObject as DevExpress.Xpo.XPBaseObject);
        }
    }
}
