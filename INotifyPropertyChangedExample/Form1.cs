#nullable enable
using System;
using System.Diagnostics;
using System.Windows.Forms;
using INotifyPropertyChangedExample.LanguageExtensions;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SqlOperationsEntityFrameworkCore;
using SqlOperationsEntityFrameworkCore.Projections;

namespace INotifyPropertyChangedExample
{
    /// <summary>
    /// Demonstrate
    /// * Change notification in tangent with INotifyPropertyChanged in Product class
    /// </summary>
    /// <remarks>
    /// As coded the DataGridView will not sort but by implementing <see cref="SortableBindingList{T}"/>
    /// </remarks>
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Shown += OnShown;
        }

        private async void OnShown(object? sender, EventArgs e)
        {
            _bindingSource.DataSource = await DataOperations.GetProductsWithProjectionOrderByCategory();
            dataGridView1.DataSource = _bindingSource;
            
            dataGridView1.ExpandColumns();

            ProductNameTextBox.DataBindings.Add("Text", _bindingSource, "ProductName");
            ProductIdentifierTextBox.DataBindings.Add("Text", _bindingSource, "ProductId");

            CurrentButton.Enabled = _bindingSource.Count > 0;
        }
        
        
        /// <summary>
        /// Get current Product information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is null)
            {
                return;
            }

            var current = ((Product)_bindingSource.Current);
            
            Debug.WriteLine($"{current.ProductId}");
            Debug.WriteLine(current.ProductName);
            Debug.WriteLine(current.CategoryName);
            Debug.WriteLine(current.QuantityPerUnit);

            if (current.UnitPrice != null)
            {
                Debug.WriteLine($"{current.UnitPrice:C}");
            }
            else
            {
                Debug.WriteLine("???");
            }


            Debug.WriteLine(current.UnitsInStock);

            if (current.UnitsOnOrder != null)
            {
                Debug.WriteLine(current.UnitsOnOrder.Value);
            }
            else
            {
                Debug.WriteLine("???");
            }

            Debug.WriteLine(new string('-', 20));
        }
    }
}
