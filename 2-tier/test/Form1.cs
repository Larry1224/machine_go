using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.machine_goDataSet.Products);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Transactions' 資料表。您可以視需要進行移動或移除。
            this.transactionsTableAdapter.Fill(this.machine_goDataSet.Transactions);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Payment' 資料表。您可以視需要進行移動或移除。
            this.paymentTableAdapter.Fill(this.machine_goDataSet.Payment);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.machine_goDataSet.Categories);

        }

        private void categoriesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }
    }
}
