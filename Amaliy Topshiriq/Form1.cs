using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amaliy_Topshiriq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!int.TryParse(mSoniTextBox.Text, out int n))
            {
                MessageBox.Show("Iltimos ustunlar sonini kiriting");
                return;
            }

            if (!int.TryParse(nSoniTextBox.Text, out int m))
            {
                MessageBox.Show("Iltimos qatorlar sonini kiriting!!!");
                return;
            }


            if (dataGridView1 == null)
            {
                dataGridView1 = new DataGridView();
                this.Controls.Add(dataGridView1);
            }

            int[,] array = new int[n, m];
            Random rand = new Random();
            int positiveSum = 0;

            dataGridView1.ColumnCount = m;
            dataGridView1.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rand.Next(-1000, 101); // Tasodifiy sonlar [-1000; 100] oralig'ida
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];

                    if (array[i, j] > 0)
                    {
                        positiveSum += array[i, j];
                    }
                }
            }

            label_natija.Text = $"Musbat elementlar yig'indisi: {positiveSum}";
        
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
