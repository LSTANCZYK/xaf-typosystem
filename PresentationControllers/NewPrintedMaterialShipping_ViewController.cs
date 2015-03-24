using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace DigiPrint.Module.PresentationControllers
{
    /// <summary>
    /// Создание новой отгрузки готовой продукции со склада заказчику
    /// </summary>
    public partial class NewPrintedMaterialShipping_ViewController : DigiPrint.Module.ViewControllers.BaseViewController
    {
        public NewPrintedMaterialShipping_ViewController()
        {
            InitializeComponent();
            RegisterActions(components);
            TargetObjectType = typeof(DigiPrint.Module.Model.StoreModule.PrintedMaterialShipped);
        }

        protected override void Execute()
        {
            _modelLogic.InsertPrintedMaterialShipping(ObjectSpace, View.CurrentObject as DevExpress.Xpo.XPBaseObject);
        }
    }
}
