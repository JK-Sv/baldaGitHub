using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baldaGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = 0;
            if (radioButton1.Checked)
            {
                 x = int.Parse(radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                x = int.Parse(radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                x = int.Parse(radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                x = int.Parse(radioButton4.Text);
            }

            int[][] a = new int[x][];

            int y = x;
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = new int[y];
            }

            Output_Matrix(a, dataGridView1);

        }
        static void Output_Matrix(int[][] Mas, DataGridView dtgrdvw)
        {
            //находим макс число столбцов в строках
            int max_col = Mas[0].Length;
            for (int i = 0; i < Mas.Length; i++)
                if (Mas[i].Length > max_col)
                    max_col = Mas[i].Length;
            dtgrdvw.ColumnCount = 0;//очистка
            dtgrdvw.ColumnCount = max_col;//кол-во колонок
            dtgrdvw.Rows.Add(Mas.Length);

            //установки для столбцов
            for (int i = 0; i < max_col; i++)
            {
                //запрещаем менять значения ячеек
                dtgrdvw.Columns[i].ReadOnly = true;
                //отключение режима сортировки элементов столбца
                dtgrdvw.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                //заголовок столбцов
                dtgrdvw.Columns[i].Name = i.ToString();
                dtgrdvw.Columns[i].Width = 25;//ширина столбцов
            }
        }

           
    }
}
