using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            int[,] a = new int[3, 4];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 3; i++)
                for (j = 0; j < 4; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();

            for (i = 0; i < 3; i++)
            {
                int min = a[i, 0];
                for (j = 0; j < 4; j++)
                {
                    if (min > a[i, j])
                        min = a[i, j];
                }
                textBox1.Text += Environment.NewLine + min.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

