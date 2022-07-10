using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_4_cs223.model;

namespace project_4_cs223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txt_iNum.Text = "";
            txt_objName.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            save s = new save
            {
                number = txt_num.Text,
                date = dateTimePicker1.Value,
                inventoryNumber = txt_iNum.Text,
                objectname = txt_objName.Text,
                count = txt_count.Text,
                price = txt_price.Text
            };

            s.Save(s);
        }
    }
}
