using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class Calc
    {
        //Строка с примером
        public string Example = "";
        //Строка с действиями
        string Sign = "+-*/";
        
        //Переменная определяющая был ли уже использован знак действия
       public bool SignUsed = false;

        //Метод составления примера
        public void ExampleConcat(char symbol)
        {
            //Определяем символ как цифру
            bool IsSign = false;
            
            //Проверяем символ на знак действия
            for(int i = 0; i < Sign.Length; i++)
            {
                if (Sign[i] == symbol) IsSign = true;
            }
            //Если символ являеется знаком действия
            if (IsSign)
            {
                if (Example.Length == 0)
                {
                    MessageBox.Show("Введите первое число!");
                    return;
                }
                //Записываем последний символ в примере
                char LastSymbol = Example[Example.Length - 1];
                //Проверяем является ли последний символ знаком действия
                bool LastSymbolIsSign = false;
                for (int i = 0; i < Sign.Length; i++)
                {
                    if (Sign[i] == LastSymbol)
                    {
                        LastSymbolIsSign = true;
                    }
                }
                //Если последний символ знак действия удаляем его и ставим новый
                if (LastSymbolIsSign)
                {
                    BackSymbol();
                    Example += symbol;
                    SignUsed = true;

                }
                //Если последний символ цифра, то добавляем к нему знак действия
                else if(SignUsed == false)
                {
                    Example += symbol;
                    SignUsed = true;
                }



            }
            //Если символ цифра, то добавляем его к примеру
            else if (IsSign == false)
            {
                Example += symbol;
                return;
            }
        }

        //Метод удаления последнего символа из примера
        public void BackSymbol()
        {
            //Записываем длину примера в переменную
            int lenght = Example.Length - 1;
            //Создаем дополнительную переменную, куда записываем пример
            string text = Example;
            //Обнуляем пример
            Example = "";
            //Перезаписываем пример без последнего символа
            for (int i = 0; i < lenght; i++)
            {
                Example += text[i];
            }
        }

        //Метод подсчета примера
        public void Summ()
        {
            if (Example.Length == 0)
            {
                MessageBox.Show("Введите первое число!");
                return;
            }

            //Создаем переменную для отображения индекса знака действия в примере
            int SignIndex = -1;
            int i = 0;
            
            //Ищем знак и индекс знака в примере
            while(SignIndex == -1)
            {
                SignIndex = Example.IndexOf(Sign[i]);
                if(SignIndex != -1)
                {
                    break;
                }
                else
                {
                    if (i == Sign.Length-1)
                    {
                        MessageBox.Show("В выражении нет знака действия");
                        return;
                    }  
                    else i++;
                }
            }
            //Создаем переменные куда запишем первое, второе число и результат их вычисления
            float a;
            float b;
            float summ;
            a = Convert.ToSingle(Example.Substring(0, SignIndex));
            int length = Example.Length - SignIndex-1;
            try
            {
                b = Convert.ToSingle(Example.Substring(SignIndex + 1, length));
            }
            catch
            {
                MessageBox.Show("Введите второе число!");
                return;
            }
            
            //В зависимости от знака выполняем одно из действий
            switch (i)
            {
                case 0:
                    summ = a + b;
                    Example = summ.ToString();
                    break;
                case 1:
                    summ = a - b;
                    Example = summ.ToString();
                    break;
                case 2:
                    summ = a * b;
                    Example = summ.ToString();
                    break;
                case 3:
                    summ = a / b;
                    Example = summ.ToString();
                    break;  
            }
                
        }

    }
}
