using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свой_тип
{
    public class Guide
    {
        //Основные коэффициенты для перевода из одного объема в другой
        protected double meters_to_meters = 1;

        protected double milli_to_meters = 1000000;
        protected double liters_to_meters = 1000;
        protected double barels_to_meters = 8.648;
        protected double antimater_to_meters = -1;
    }

    public enum MeasureType
    { m, ml, l, br, am }

    public class Volume : Guide
    {
        //Значение и тип
        private double value = 0;

        private MeasureType type;
        private double value_in_meters = 0;
        private string ru_type = "";

        //Конструктор, сохраняющий значение в метрах кубических
        public Volume(double value, MeasureType type)
        {
            //Запись данных
            this.value = value;
            this.type = type;

            //Сохранения числа в формате метры кубические
            switch (this.type)
            {
                case MeasureType.m:
                    value_in_meters = value / meters_to_meters;
                    ru_type = "м^3";
                    break;

                case MeasureType.ml:
                    value_in_meters = value / milli_to_meters;
                    ru_type = "мл";
                    break;

                case MeasureType.l:
                    value_in_meters = value / liters_to_meters;
                    ru_type = "л";
                    break;

                case MeasureType.br:
                    value_in_meters = value / barels_to_meters;
                    ru_type = "бр";
                    break;

                case MeasureType.am:
                    value_in_meters = value / antimater_to_meters;
                    ru_type = "ам";
                    break;

                default:
                    break;
            }
        }

        //Далее приведены геттеры под каждое значение
        public double getValue()
        {
            return value;
        }

        public string getType()
        {
            return ru_type;
        }

        public double getValueInMeters()
        {
            return value_in_meters;
        }
    }

    public class Calculator
    {
        //Значения переменных
        private double num1 = 0;

        private double num2 = 0;
        private double result = 0;

        //Конструктор по умолчанию
        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        //Метод, производящий выбор операций
        public void Calculate(string operation)
        {
            switch (operation)
            {
                case "+":
                    Sum(num1, num2);
                    break;

                case "-":
                    Sub(num1, num2);
                    break;

                case "x":
                    Mult(num1, num2);
                    break;

                case "<>":
                    Comp(num1, num2);
                    break;

                default:
                    break;
            }
        }

        //Суммирование
        private void Sum(double num1, double num2)
        {
            result = num1 + num2;
        }

        //Отрицание
        private void Sub(double num1, double num2)
        {
            result = num1 - num2;
        }

        //Умножение
        private void Mult(double num1, double num2)
        {
            result = num1 * num2;
        }

        //Сравнение
        private void Comp(double num1, double num2)
        {
            if (num1 > num2)
            {
                result = num1;
            }
            else if (num1 < num2)
            {
                result = num2;
            }
            else
            {
                result = num1;
            }
        }

        //Получение результата
        public double getResult()
        {
            return result;
        }
    }

    public class Translator : Guide
    {
        //Базовые переменные для перевода
        private double value = 0;

        private double result = 0;

        public Translator(double value, MeasureType type_to)
        {
            this.value = value;

            switch (type_to)
            {
                case MeasureType.m:
                    result = value * meters_to_meters;
                    break;

                case MeasureType.ml:
                    result = value * milli_to_meters;
                    break;

                case MeasureType.l:
                    result = value * liters_to_meters;
                    break;

                case MeasureType.br:
                    result = value * barels_to_meters;
                    break;

                case MeasureType.am:
                    result = value * antimater_to_meters;
                    break;

                default:
                    break;
            }
        }

        public double getResult()
        {
            return result;
        }
    }
}