using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DigiPrint.Module.Model.StoreModule;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;
using DigiPrint.Module.Model.Core;
using DigiPrint.Module.Model.OrderModule;

namespace DigiPrint.Module.Model.Logic
{

    /// <summary>
    /// Класс для выполнения стандартных часто используемых функций модуля Склад
    /// </summary>
    public class StoreManager : BaseBusinessSubjectManager
    {

        public StoreManager(Session Session) : base(Session) { }


        /// <summary>
        /// Возвращает суммарные остатки материала по всем складам в виде одной записи
        /// </summary>
        /// <param name="Material"></param>
        /// <param name="Store"></param>
        /// <returns></returns>
        public MaterialRemains GetTotalMaterialRemains(Material Material)
        {
            return CurrentSession.FindObject<MaterialRemains>(CriteriaOperator.Parse("Material.Oid = ?", Material.Oid));
        }


        /// <summary>
        /// Возвращает остатки материала по складу в виде одной записи
        /// </summary>
        /// <param name="Material"></param>
        /// <param name="Store"></param>
        /// <returns></returns>
        public MaterialRemainsInStore GetMaterialRemainsInStore(Material Material, Store Store)
        {
            return CurrentSession.FindObject<MaterialRemainsInStore>(CriteriaOperator.Parse("Material.Oid = ? and Store.Oid = ?", Material.Oid, Store.Oid));
        }

        /// <summary>
        /// Возвращает все несписанные оприходования
        /// </summary>
        /// <param name="SortingDirection"></param>
        /// <param name="MemberToSortBy"></param>
        /// <returns></returns>
        public IQueryable<MaterialIncome> GetAllActiveMaterialIncomes(SortingDirection SortingDirection, string MemberToSortBy)
        {
            IQueryable<MaterialIncome> _activeMaterialIncomes = CurrentSession.GetObjects
                (
                CurrentSession.GetClassInfo<MaterialIncome>(),
                CriteriaOperator.Parse("Active = ? ", true),
                new SortingCollection(new SortProperty[] { new SortProperty("DateTime", SortingDirection) }),
                int.MaxValue, false, false
                )
                as IQueryable<MaterialIncome>;

            return _activeMaterialIncomes;
        }


        /// <summary>
        /// Возвращает все несписанные оприходования по данному материалу
        /// </summary>
        /// <param name="Material">Материал</param>
        /// <param name="SortingDirection">Направление: по убыванию или возрастанию</param>
        /// <param name="MemberToSortBy">Свойство, по которому производится сортировка</param>
        /// <returns></returns>
        public IEnumerable<MaterialIncome> GetActiveMaterialIncomes(Material Material, SortingDirection SortingDirection, string MemberToSortBy)
        {
            XPCollection<MaterialIncome> _activeMaterialIncomeCollection =
                new XPCollection<MaterialIncome>
                    (PersistentCriteriaEvaluationBehavior.InTransaction, CurrentSession, CriteriaOperator.Parse("Material.Oid = ? and Active = ? ", Material.Oid, true), false);

            SortingCollection _sortCollection = new DevExpress.Xpo.SortingCollection();
            _sortCollection.Add(new SortProperty(MemberToSortBy, SortingDirection));

            _activeMaterialIncomeCollection.Sorting = _sortCollection;

            return _activeMaterialIncomeCollection.ToArray<MaterialIncome>();
        }


        /// <summary>
        /// Возвращает все несписанные ГП по данному заказу и складу
        /// </summary>
        /// <param name="PrintedMaterial">Готовая продукция</param>
        /// <param name="Order">Заказ</param>
        /// <param name="Store">Склад</param>
        /// <returns></returns>
        public PrintedMaterialRemains GetPrintedMaterialRemainsInStore(Order Order, Store Store)
        {
            return CurrentSession.FindObject<PrintedMaterialRemains>(CriteriaOperator.Parse("Order.Oid = ? and PrintedMaterial.Oid = ? and Store=?", Order.Oid, Store.Oid));
        }

        /// <summary>
        /// Возвращает средневзвешенную цену по всем остаткам коллекции
        /// </summary>
        /// <param name="MaterialIncomeCollection"></param>
        /// <returns></returns>
        public double CountWeightAveragePrice(IEnumerable<MaterialIncome> MaterialIncomeCollection)
        {
            double _price = 0.0;
            double _amount = 0.0;

            foreach (var item in MaterialIncomeCollection)
            {
                _price = (_price * _amount + item.Price * item.AvailableAmount) / (_amount + item.AvailableAmount);
                _amount = _amount + item.AvailableAmount;
            }

            return _price;
        }
    }
}
