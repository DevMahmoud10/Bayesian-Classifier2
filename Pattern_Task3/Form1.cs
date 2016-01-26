using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern_Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int class_no = Convert.ToInt32(textBox1.Text) + 2;
                dataGridView1.ColumnCount = class_no+1;
                for (int i = 0; i < class_no; i++)
                {
                    if (i < 2)
                    {
                        dataGridView1.Columns[i].Name = "";
                    }
                    else
                        dataGridView1.Columns[i].Name = "C" + (i - 1).ToString();
                }
                if (dataGridView1.Rows.Count == 1)
                {
                    dataGridView1.Rows.Add("Red", "MU");
                    dataGridView1.Rows.Add(" ", "Sigma");
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows.Add("Green", "MU");
                    dataGridView1.Rows.Add(" ", "Sigma");
                    dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows.Add("Blue", "MU");
                    dataGridView1.Rows.Add(" ", "Sigma");
                    dataGridView1.Rows[4].DefaultCellStyle.BackColor = Color.Blue;
                    dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.Blue;
                    dataGridView1.Rows.Add("", "Prior");
                    dataGridView1.Rows[6].DefaultCellStyle.BackColor = Color.Gray;
                }
            }
            catch
            {
                dataGridView1.ColumnCount = 2;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int action_no = Convert.ToInt32(textBox2.Text);
                int class_no = Convert.ToInt32(textBox1.Text) + 1;
                if (dataGridView2.Rows.Count > action_no)
                {
                    // for (int i = action_no - 1; i < dataGridView2.Rows.Count; i++)
                    dataGridView2.Rows.Clear();
                }
                dataGridView2.ColumnCount = class_no;
                for (int i = 0; i < class_no; i++)
                {
                    if (i < 1)
                    {
                        dataGridView2.Columns[i].Name = "";
                    }
                    else
                        dataGridView2.Columns[i].Name = "C" + (i).ToString();
                }
                if (dataGridView2.Rows.Count >= 1)//there's one row created by default
                {
                    for (int i = 0; i < action_no; i++)
                    {
                        dataGridView2.Rows.Add("A" + (i + 1));
                        
                    }
                }
            }
            catch
            {
                dataGridView2.ColumnCount = 1;
            }
        }

    }
}
