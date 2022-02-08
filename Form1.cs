/*Условие: Разработать алгоритм и программу обработки одномерных массивов используя единственный цикл*/
/**Задача 1.4.2 Условие: При заданных X1, X2...Xn найти массив элементов Y1, Y2...Yn по правилу 
Yk = {1-sinXk | Xk>0) && (1-cosXk | Xk <=0)} при этом подсчитать число неотрицательных Xk*/
/*
 Condition: Develop an algorithm and program for processing one-dimensional arrays using a single loop */
/**Task 1.4.2 Condition: Given X1, X2...Xn, find an array of elements Y1, Y2...Yn by the rule
Yk = {1-sinXk | Xk>0) && (1-cosXk | Xk <=0)} while counting the number of non-negative Xk
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSarp_1_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double PI = 3.141592653589793238463;                    //константа числа Пи
        double ArrayOneCycle(int x)
        {
            double Y = 0;                                            //результат функциии
            Y = 1 - Math.Sin(x * PI / 180);                          //переводим с градусов в радианы и вычисляем функцию
            return Y;
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelInputEl_Click(object sender, EventArgs e)
        {

        }

        private void buttonInputEl_Click(object sender, EventArgs e)
        {
            short positive = 0;                                             //кол-во полож. значений
            string[] param = textBoxInputEl.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = param.Length;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(param[i]);
                if (arr[i] >= 0)
                    positive++;
            }
            double[,] tableXY = new double[n, 2];
            dataGridView1.RowCount = n;                             //кол-во строк
            dataGridView1.ColumnCount = 2;                          //столбцов
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].HeaderText = "Y";

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < 2; j++)                                         //заполняем значения X
                {
                    if (j == 0)                                                     //для X
                    {
                        tableXY[i, j] = arr[i];
                        dataGridView1.Rows[i].Cells[j].Value = tableXY[i, j];
                    }
                    if (j == 1)
                    {
                        tableXY[i, j] = ArrayOneCycle(arr[i]);                            //передаем методу ArrCalc эл. Х;
                        dataGridView1.Rows[i].Cells[j].Value = tableXY[i, j].ToString("0.####");
                    }

                }
            }
            labelPosElem.Text = labelPosElem.Text + positive.ToString();
            positive = 0;                                                                  //сбросить счетчик
        }
    }
}