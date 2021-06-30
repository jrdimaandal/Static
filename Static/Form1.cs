using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var input = sender as TextBox;
            if (input.Text != "")
            {
                if (rdbCelcius.Checked)
                {
                    lblAnswer.Text = string.Format("Temperature in Celsius: {0:F2}", TemperatureConverter.FahrenheitToCelsius(input.Text));
                }
                else
                {
                    lblAnswer.Text = string.Format("Temperature in Farenheit: {0:F2}", TemperatureConverter.CelsiusToFahrenheit(input.Text));
                }
            }

        }

        private void rdbFarenheit_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as RadioButton;
            if (checkBox.Checked)
            {
                lblEnter.Text = "Please enter the Celsius temperature: ";
            }
     
        }

        private void rdbCelcius_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as RadioButton;
            if (checkBox.Checked)
            {
                lblEnter.Text = "Please enter the Farenheit temperature: ";
            }
        }
    }
}
