using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DigiPrint.Module.Model.Core
{
    public class BaseBusinessSubjectManager
    {
        public BaseBusinessSubjectManager(Session Session)
        { CurrentSession = Session; }

        /// <summary>
        /// Текущая сессия XPO для работы с объектами домена
        /// </summary>
        protected Session CurrentSession { get; set; }
    }
}
