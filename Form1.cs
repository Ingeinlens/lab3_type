using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Свой_тип
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var measureItems = new string[]
            {
                "м^3",
                "л",
                "мл",
                "бр",
                "ам",
            };

            type1.DataSource = new List<string>(measureItems);
            type2.DataSource = new List<string>(measureItems);
            type3.DataSource = new List<string>(measureItems);
            type4.DataSource = new List<string>(measureItems);
        }

        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;

            switch (comboBox.Text)
            {
                case "ам":
                    measureType = MeasureType.am;
                    break;

                case "мл":
                    measureType = MeasureType.ml;
                    break;

                case "л":
                    measureType = MeasureType.l;
                    break;

                case "бр":
                    measureType = MeasureType.br;
                    break;

                default:
                    measureType = MeasureType.m;
                    break;
            }
            return measureType;
        }

        private void Calculate()
        {
            try
            {
                double num1 = double.Parse(volume1.Text);
                double num2 = double.Parse(volume2.Text);

                Volume vol1 = new Volume(num1, GetMeasureType(type1));
                Volume vol2 = new Volume(num2, GetMeasureType(type2));

                Calculator calculator = new Calculator(vol1.getValueInMeters(), vol2.getValueInMeters());

                calculator.Calculate(operation.Text);

                result.Text = calculator.getResult().ToString() + " м^3";
            }
            catch (FormatException)
            {
            }
        }

        private void Translate()
        {
            try
            {
                double num = double.Parse(volume3.Text);

                Volume vol = new Volume(num, GetMeasureType(type3));

                Translator translator = new Translator(vol.getValueInMeters(), GetMeasureType(type4));

                volume4.Text = translator.getResult().ToString();
            }
            catch (FormatException)
            {
            }
        }

        private void ChangeActive(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TranslateActive(object sender, EventArgs e)
        {
            Translate();
        }
    }
}