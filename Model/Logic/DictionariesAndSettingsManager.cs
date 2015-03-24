using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigiPrint.Module.Model.Core;
using DevExpress.Xpo;
using DigiPrint.Module.Model.DictionariesAndSettings;

namespace DigiPrint.Module.Model.Logic
{
    /// <summary>
    /// Класс для выполнения стандартных часто используемых функций для работы со справочниками и настройками системы
    /// </summary>
    public class DictionariesAndSettingsManager : BaseBusinessSubjectManager
    {
        public DictionariesAndSettingsManager(Session Session) : base(Session) { }

        /// <summary>
        /// Возвращает тип и правило расчёта остаточной цены списания материала в производство. ПОКА ТОЛЬКО СРЕДНЕВЗВЕШ.!
        /// </summary>
        /// <returns></returns>
        public MaterialWriteOffMethod GetMaterialWriteOffMethod()
        {
            return MaterialWriteOffMethod.WeightAverage;
        }
    }
}
