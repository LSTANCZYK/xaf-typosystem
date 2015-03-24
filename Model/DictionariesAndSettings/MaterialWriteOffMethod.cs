using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiPrint.Module.Model.DictionariesAndSettings
{

    /// <summary>
    /// Метод списания материалов в производство в соответствии с учётной политикой
    /// </summary>
    public enum MaterialWriteOffMethod
    {
        /// <summary>
        /// Первый поступивший первым списывается
        /// </summary>
        FIFO,
        /// <summary>
        /// Последний поступивший первым списывается
        /// </summary>
        LIFO,
        /// <summary>
        /// Средневзвешенная цена
        /// </summary>
        WeightAverage
    }
}
