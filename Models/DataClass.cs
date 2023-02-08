using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseSystem.Models
{
    public class DataClass
    {
        public readonly ConnectionStringClass connectionStringClass;

        public DataClass(ConnectionStringClass cs)
        {
            connectionStringClass = cs;
        }

        public IList<Item> _items;
        public IList<Purchase> _purchases;
        public IList<Issuance> _issuances;

        public IList<Item> getItemData(String data)
        {
            if (data == null)
            {
                _items = connectionStringClass.items.ToList();
            }

            _items = connectionStringClass.items.Where(x => x.item_status == data).ToList();
            return _items;
        }

        public IList<Purchase> getPurchaseData(String data)
        {
            if (data == null)
            {
                _purchases = connectionStringClass.purchases.ToList();
            }

            _purchases = connectionStringClass.purchases.Where(x => x.vendor == data).ToList();
            return _purchases;
        }

        public IList<Issuance> getIssuanceData(String data)
        {
            if (data == null)
            {
                _issuances = connectionStringClass.issuances.ToList();
            }

            _issuances = connectionStringClass.issuances.Where(x => x.emp_name == data).ToList();
            return _issuances;
        }

    }
}
