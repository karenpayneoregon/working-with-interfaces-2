using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using SqlOperationsEntityFrameworkCore.Models;

namespace SqlOperationsEntityFrameworkCore.Projections
{
    public class Product : INotifyPropertyChanged
    {
        private string _productName;
        private short? _unitsInStock;

        public int ProductId { get; set; }
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock
        {
            get => _unitsInStock;
            set
            {
                _unitsInStock = value;
                OnPropertyChanged();
            }
        }

        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }

        public override string ToString() => ProductName;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Expression<Func<Products, Product>> Projection =>
            product => new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                SupplierName = product.Supplier.CompanyName,
                SupplierId = product.SupplierId,
                QuantityPerUnit = product.QuantityPerUnit,
                ReorderLevel = product.ReorderLevel,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                CategoryId = product.CategoryId,
                CategoryName = product.Category.CategoryName
            };

    }

}
