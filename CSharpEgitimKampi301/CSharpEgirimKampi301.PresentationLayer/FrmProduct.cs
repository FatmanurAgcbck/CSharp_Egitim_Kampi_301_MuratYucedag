﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgirimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;

        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal()); 
        }

        

        

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource= values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtProductId.Text);
            var deletedValues = _productService.TGetById(id);
            _productService.TDelete(deletedValues);
            MessageBox.Show("İşlem başarılı");
        }
    }
}
