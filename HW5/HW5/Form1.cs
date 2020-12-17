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

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }
        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
           // this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Ratings' 資料表。您可以視需要進行移動或移除。
            this.ratingsTableAdapter.Fill(this.machine_goDataSet.Ratings);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet1.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter1.Fill(this.machine_goDataSet1.Users);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet3.Status' 資料表。您可以視需要進行移動或移除。
            this.statusTableAdapter.Fill(this.machine_goDataSet3.Status);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet2.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.machine_goDataSet2.Products);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet1.Ad' 資料表。您可以視需要進行移動或移除。
            this.adTableAdapter1.Fill(this.machine_goDataSet1.Ad);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Transactions' 資料表。您可以視需要進行移動或移除。
            this.transactionsTableAdapter.Fill(this.machine_goDataSet.Transactions);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Ad' 資料表。您可以視需要進行移動或移除。
            this.adTableAdapter.Fill(this.machine_goDataSet.Ad);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.machine_goDataSet.Categories);
            // TODO: 這行程式碼會將資料載入 'machine_goDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter.Fill(this.machine_goDataSet.Users);

        }

        private void bindingNavigator3_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.adBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {
          
        }


        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter.InsertQuery(int.Parse(textBox1.Text),textBox2.Text);
            MessageBox.Show("categories successfully added.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersTableAdapter.InsertQuery(int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show("users successfully added.");
        }

        private void adDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton21_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.adBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.machine_goDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adTableAdapter.InsertQuery(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), textBox11.Text);
            MessageBox.Show("AD successfully added.");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            transactionsTableAdapter.InsertQuery(int.Parse(comboBox3.Text), int.Parse(comboBox4.Text), int.Parse(comboBox5.Text), int.Parse(textBox10.Text), int.Parse(comboBox6.Text));
            MessageBox.Show("Transactions successfully added.");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.FillBy(this.machine_goDataSet.Products, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
 
}
