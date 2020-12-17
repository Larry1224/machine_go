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


    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void onClose(object sender, FormClosingEventArgs e)
        {
            this.Hide();    // so the window appears to be closed.
            e.Cancel = true;     // and we cancel the close event so that the form will not be destroyed/disposed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
 
            if (textBox1.Text != "Admin" || textBox2.Text != "123")
            {
                    //MessageBox.Show("輸入錯誤!");
                this.textBox1.Text = "";
                this.textBox2.Text = "";

            }
            else 
            {
                count += 1;
            }


            if (count == 1)
            {
                //this.Hide();
                Form1 Form1 = new Form1();
                this.Hide();
                Form1.Show();
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
