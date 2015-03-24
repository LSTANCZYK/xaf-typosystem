using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.StoreModule
{
    /// <summary>
    /// Печатная продукция
    /// </summary>
    [Custom("Caption", "Печатная продукция")]
    public abstract class PrintedMaterial : DigiPrint.Module.Model.Core.ModelBaseObject
    {
        public PrintedMaterial(Session session) : base(session) { }

        
        private string _name;

        [Custom("Caption", "Название")]
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }

    }
}
