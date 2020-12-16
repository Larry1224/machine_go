using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EndEditOnAllBindingSources()
        {
            var BindingSourcesQuery =
                from Component bindingSources in this.components.Components
                where bindingSources is BindingSource
                select bindingSources;

            foreach (BindingSource bindingSource in BindingSourcesQuery)
            {
                bindingSource.EndEdit();
            }
        }
        

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Transactions' 資料表。您可以視需要進行移動或移除。
            this.transactionsTableAdapter.Fill(this.machine_goDataSet.Transactions);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Ad' 資料表。您可以視需要進行移動或移除。
            this.adTableAdapter.Fill(this.machine_goDataSet.Ad);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter.Fill(this.machine_goDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.machine_goDataSet.Categories);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            //this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }

        private void bindingNavigator3_RefreshItems(object sender, EventArgs e)
        {
            
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {
            
            this.Validate();
            this.adBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }
    }
}
