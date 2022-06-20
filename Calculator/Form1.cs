using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Создаем экземпляр класса Calc
        Calc calc = new Calc();
       
        //При нажатии на кнопку Summ вызываем метод вычисления примера и перезаписываем решение в textbox
        private void btnSumm_Click(object sender, EventArgs e)
        {
            calc.Summ();
            tbCalc.Text = calc.Example;
        }
        //При нажатии на кнопку с минусом вызываем метод добавления нового символа в пример и перезаписываем его в textbox
        private void btnMinus_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('-');
            tbCalc.Text = calc.Example;

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat(',');
            tbCalc.Text = calc.Example;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCalc.Text = "";
            calc.Example = "";
            calc.SignUsed = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('0');
            tbCalc.Text = calc.Example;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('+');
            tbCalc.Text = calc.Example;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('3');
            tbCalc.Text = calc.Example;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('2');
            tbCalc.Text = calc.Example;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('1');
            tbCalc.Text = calc.Example;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('*');
            tbCalc.Text = calc.Example;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('6');
            tbCalc.Text = calc.Example;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('5');
            tbCalc.Text = calc.Example;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('4');
            tbCalc.Text = calc.Example;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('/');
            tbCalc.Text = calc.Example;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('9');
            tbCalc.Text = calc.Example;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('8');
            tbCalc.Text = calc.Example;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calc.ExampleConcat('7');
            tbCalc.Text = calc.Example;
        }

        //При нажатии на кнопку Back вызываем метод удаления последнего символа из примера
        private void btnBack_Click(object sender, EventArgs e)
        {
            calc.BackSymbol();
            tbCalc.Text = calc.Example;
        }
    }
}
