using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(maxtext.Text, out int value))
            {
                MessageBox.Show("Вы ввели не число!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int max = Logic.FindMax(value);
            if (value < 100)
            {
                MessageBox.Show("Введите трехзначное число!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            label_answer.Text = $"Максимальная цифра = {max}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр","Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
