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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonbuy_Click(object sender, EventArgs e)
        {
            if (comboBoxlistmenu.Text == "")
            {
                MessageBox.Show("Choose Menu");
            }
            else
            {
                string input = comboBoxlistmenu.Text;
                listBoxnamaitem.Items.Add(comboBoxlistmenu.SelectedItem);
                listBoxharga.Items.Add(labelharga.Text);
            }
            if (listBoxnamaitem.Items.Count == 0)
            {
                buttondelete.Enabled = false;
            }
            else
            {
                buttondelete.Enabled = true;
            }

            
        }
        private void radioButtonminuman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonminuman.Checked == true)
            {
                labeltulisansize.Show();
                radioButtonsizenormal.Show();
                radioButtonsizejumbo.Show();
                comboBoxlistmenu.Items.Clear();
                this.comboBoxlistmenu.Items.Clear();
                this.comboBoxlistmenu.Items.Add("Es Teh");
                this.comboBoxlistmenu.Items.Add("Teh Hangat");
                this.comboBoxlistmenu.Items.Add("Nutrisari");
                this.comboBoxlistmenu.Items.Add("Aqua");
            }
            else if (radioButtonminuman.Checked == false)
            {
                labeltulisansize.Hide();
                radioButtonsizenormal.Hide();
                radioButtonsizejumbo.Hide();
            }
        }

        private void comboBoxlistmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] hargamakanan = new int[4] { 10000, 12000, 15000, 15000 };            
            if (radioButtonmakanan.Checked == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (comboBoxlistmenu.SelectedIndex == i)
                    {
                        string Showharga = Convert.ToString(hargamakanan[i]);
                        labelharga.Text = Showharga;
                    }
                }
            }
            int[,] hargaminuman = new int[2, 4];
            hargaminuman[0, 0] = 5000;
            hargaminuman[0, 1] = 3000;
            hargaminuman[0, 2] = 6000;
            hargaminuman[0, 3] = 2000;
            hargaminuman[1, 0] = 7000;
            hargaminuman[1, 1] = 5000;
            hargaminuman[1, 2] = 10000;
            hargaminuman[1, 3] = 5000;
            if (radioButtonminuman.Checked == true)
            {
                if (radioButtonsizejumbo.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (comboBoxlistmenu.SelectedIndex == i)
                        {
                            string Showharga = Convert.ToString(hargaminuman[1, i]);
                            labelharga.Text = Showharga;
                        }
                    }
                }
                else if (radioButtonsizenormal.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (comboBoxlistmenu.SelectedIndex == i)
                        {
                            string Showharga = Convert.ToString(hargaminuman[0, i]);
                            labelharga.Text = Showharga;
                        }
                    }
                }
            }
        }

        private void radioButtonmakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonmakanan.Checked == true)
            {
                this.comboBoxlistmenu.Items.Clear();
                this.comboBoxlistmenu.Items.Add("Nasi Goreng");
                this.comboBoxlistmenu.Items.Add("Nasi Goreng Spesial");
                this.comboBoxlistmenu.Items.Add("Nasi Goreng Pete");
                this.comboBoxlistmenu.Items.Add("Ayam Bakar");
                
            }
        }

        private void radioButtonsizenormal_CheckedChanged(object sender, EventArgs e)
        {
            int[,] hargaminuman = new int[2, 4];
            hargaminuman[0, 0] = 5000;
            hargaminuman[0, 1] = 3000;
            hargaminuman[0, 2] = 6000;
            hargaminuman[0, 3] = 2000;
            hargaminuman[1, 0] = 7000;
            hargaminuman[1, 1] = 5000;
            hargaminuman[1, 2] = 10000;
            hargaminuman[1, 3] = 5000;
            if (radioButtonminuman.Checked == true)
            {
                if (radioButtonsizejumbo.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (comboBoxlistmenu.SelectedIndex == i)
                        {
                            string Showharga = Convert.ToString(hargaminuman[1, i]);
                            labelharga.Text = Showharga;
                        }
                    }
                }
                else if (radioButtonsizenormal.Checked == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (comboBoxlistmenu.SelectedIndex == i)
                        {
                            string Showharga = Convert.ToString(hargaminuman[0,i]);
                            labelharga.Text = Showharga;
                        }
                    }
                }
            }
        }

        private void buttoncheckout_Click(object sender, EventArgs e)
        {
            Form formbaru = new Form2(this);
            formbaru.Show();

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (listBoxnamaitem.Items.Count == 0)
            {
                buttondelete.Enabled = false;
            }
            else
            {
                buttondelete.Enabled = true;
                listBoxharga.Items.RemoveAt(listBoxnamaitem.SelectedIndex);
                listBoxnamaitem.Items.RemoveAt(listBoxnamaitem.SelectedIndex);
            }
        }
    }
}
