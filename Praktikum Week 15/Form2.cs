using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_15
{
    public partial class Form2 : Form
    {
        Form opener;
        public Form2(Form parentform)
        {
            InitializeComponent();
            opener = ParentForm;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDiscount.Checked = true)
            {
                textBoxDiscount.Visible = true;
            }
            
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (checkBoxDiscount.Checked = true)
            {
                int discount = Convert.ToInt32(textBoxDiscount.Text);
      
            }
        }
    }
}
