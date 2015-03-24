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
    public partial class BaseViewController : ViewController
    {
        public BaseViewController()
        {
            InitializeComponent();
            RegisterActions(components);
            SetTarget();
        }

        protected virtual void SetTarget()
        {
           
        }


        protected override void OnActivated()
        {
            base.OnActivated();

            ObjectSpace.ObjectSaving += new EventHandler<ObjectManipulatingEventArgs>(ObjectSpace_ObjectSaving);
        }


        protected bool _isObjectSaving = false;
        protected DigiPrint.Module.Model.Logic.ModelLogic _modelLogic;


        void ObjectSpace_ObjectSaving(object sender, ObjectManipulatingEventArgs e)
        {
            if (_isObjectSaving)
                return;

            if (e.Object == null)
                return;

            if (ObjectSpace == null)
                return;

            _isObjectSaving = true;

            if (ObjectSpace.IsNewObject(e.Object))
            {
                if (_modelLogic == null)
                    _modelLogic = DigiPrint.Module.Model.Core.SystemFactory.GetModelLogic() as DigiPrint.Module.Model.Logic.ModelLogic;

                Execute();
            }
            ObjectSpace.ObjectSaving -= new EventHandler<ObjectManipulatingEventArgs>(ObjectSpace_ObjectSaving);

            _isObjectSaving = false;

        }

        protected virtual void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
