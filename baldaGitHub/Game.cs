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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            dtgrdvw.RowHeadersVisible = false;
            dtgrdvw.ColumnHeadersVisible = false;
            for (int i = 0; i < max_col; i++)
            {
                dtgrdvw.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dtgrdvw.Columns[i].Width = 25;//ширина столбцов
            }
        }
    }
}
