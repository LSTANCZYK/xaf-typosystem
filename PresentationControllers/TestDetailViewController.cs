using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using DigiPrint.Module.Model.Test;

namespace DigiPrint.Module.ViewControllers
{
    public partial class TestDetailViewController : ViewController
    {
        public TestDetailViewController()
        {
            InitializeComponent();
            RegisterActions(components);
            this.TargetObjectType = typeof(DOChild);
        }

        bool _activated = false;

        protected override void OnActivated()
        {
            base.OnActivated();

            ObjectSpace.ObjectChanged += new EventHandler<ObjectChangedEventArgs>(ObjectSpace_ObjectChanged);
            ObjectSpace.ObjectSaved += new EventHandler<ObjectManipulatingEventArgs>(ObjectSpace_ObjectSaved);

            ObjectSpace.ObjectSaving += new EventHandler<ObjectManipulatingEventArgs>(ObjectSpace_ObjectSaving);

            ///изменение существующего объекта
            //if (View.CurrentObject != null && !ObjectSpace.Session.IsNewObject(View.CurrentObject))
            {
                //ObjectSpace.ObjectEndEdit += new EventHandler<EndEditEventArgs>(ObjectSpace_ObjectEndEdit);
            }

            ///сохранение нового объекта
            //if (View.CurrentObject != null && ObjectSpace.Session.IsNewObject(View.CurrentObject))
            {
                //_activated = true;
            }

            //ObjectSpace.Session.
        }

        
        void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.PropertyName))
            {
                /// объект изменён внутри текущего ObjectSpace
                /// однако в базу изменения не были внесены
                string _str = "dosomething";
            }
        }


        void ObjectSpace_ObjectSaving(object sender, ObjectManipulatingEventArgs e)
        {
            ///если объект только что создан, то ObjectSpace.IsNewObject(e.Object) == true
            string _str = "dosomething";
        }


        void ObjectSpace_ObjectSaved(object sender, ObjectManipulatingEventArgs e)
        {
            /// ObjectSpace.IsNewObject(e.Object) == false - в любом случае, так как в этот момент изменения в базу данных уже внесены
            _activated = false;
        }

        protected override void OnDeactivating()
        {
            //if (_activated)
            ObjectSpace.ObjectSaved -= new EventHandler<ObjectManipulatingEventArgs>(ObjectSpace_ObjectSaved);
            ObjectSpace.ObjectChanged -= new EventHandler<ObjectChangedEventArgs>(ObjectSpace_ObjectChanged);

            base.OnDeactivating();
        }

        
    }
}
