using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void удалитьВсеНечетныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = elements.Text;
            string[] elementsArr = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();
            for (int i = 0; i < elementsArr.Length; i++)
            {
                if (i % 2 == 0) // Проверяем четность позиции
                {
                    if (int.TryParse(elementsArr[i], out int num))
                    {
                        if (num % 2 != 0) // Проверяем нечетность числа
                        {
                            continue; // Пропускаем нечетные числа на четных позициях
                        }
                    }
                    numbers.Add(int.Parse(elementsArr[i]));
                }
                else
                {
                    numbers.Add(int.Parse(elementsArr[i]));
                }
            }

            elements.Text = string.Join(" ", numbers); // Обновляем содержимое TextBox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int inputNumber;
            if (!int.TryParse(elements.Text, out inputNumber))
            {
                errorProviderInvalidValues.SetError(elements, "Ошибка. Пожалуйста, введите валидные значения.");
            }
            else
            {
                errorProviderInvalidValues.Clear(); // Очистка ошибки, если введены целые числа
            }

            if (string.IsNullOrEmpty(elements.Text))
            {
                errorProviderInvalidValues.SetError(elements, "Поля не должны быть пустыми.");
            }
            else
            {
                errorProviderInvalidValues.Clear(); // Очистка ошибки, если поле не пустое
            }
        }

        private void Generation_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rand.Next(1, 9); // Генерируем случайное число от 1 до 100
                numbers.Add(randomNumber); // Добавляем число в список
            }

            string numbersx2 = string.Join(" ", numbers); // Преобразуем список в строку через запятую

            elements.Text = numbersx2; // Присваиваем строку со случайными числами к текстовому полю elements
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elements.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            elements.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
