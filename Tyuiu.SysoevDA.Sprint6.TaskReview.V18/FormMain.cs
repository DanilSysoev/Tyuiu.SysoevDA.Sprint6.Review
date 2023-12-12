using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SysoevDA.Sprint6.TaskReview.V18.Lib;

namespace Tyuiu.SysoevDA.Sprint6.TaskReview.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random rnd = new Random();
        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(textBoxVarN_SDA.Text);
            int columns = Convert.ToInt32(textBoxVarM_SDA.Text);
            int min = Convert.ToInt32(textBoxVarn1_SDA.Text);
            int max = Convert.ToInt32(textBoxVarn2_SDA.Text);
            int NumbMin = Convert.ToInt32(textBoxVarK_SDA.Text);
            int NumbMax = Convert.ToInt32(textBoxVarL_SDA.Text);
            int NumbStr = Convert.ToInt32(textBoxVarR_SDA.Text);

            if (!((min < max) && (NumbMin < NumbMax) && (NumbStr <= rows - 1) && (NumbMax <= columns)))
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int[,] array = new int[rows, columns];
                int temp = 0;
                for (int i = 0; i < rows; i++)
                {
                    temp = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        if (temp == 3)
                        {

                            array[i, j] = array[i, j - 3] + array[i, j - 2] + array[i, j - 1];
                            temp = 0;
                        }
                        else
                        {
                            array[i, j] = rnd.Next(min, max);
                            if (temp <3)
                                temp++;
                        }
                    }
                }
                try
                { 
                    var res = ds.GetMatrix(array, min, max, NumbStr, NumbMin, NumbMax);
                    dataGridViewArray_SDA.RowCount = rows;
                    dataGridViewArray_SDA.ColumnCount = columns;
                    for (int i = 0; i < columns; i++)
                        dataGridViewArray_SDA.Columns[i].Width = 30;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridViewArray_SDA.Rows[i].Cells[j].Value = array[i, j];
                        }
                    }
                    textBoxResult_SDA.Text = Convert.ToString(res);
                }
                catch
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }   
}
