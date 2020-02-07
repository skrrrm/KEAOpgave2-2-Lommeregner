using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave2_2_Lommeregner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variabler
        double a, b, result;

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxTalA.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                b = Convert.ToDouble(textBoxTalB.Text); // --------- || ---------
            }
            catch
            {
                labelResult.Text = "Indtast kun tal";
            }

            result = a * b; // Lægger a og b sammen og konvertere til tekst
            labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxTalA.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                b = Convert.ToDouble(textBoxTalB.Text); // --------- || ---------
            }
            catch
            {
                labelResult.Text = "Indtast kun tal";
            }

            result = a / b; // Lægger a og b sammen og konvertere til tekst
            labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            textBoxTalA.Text = "";
            textBoxTalB.Text = "";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxTalA.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                b = Convert.ToDouble(textBoxTalB.Text); // --------- || ---------
            }
            catch
            {
                labelResult.Text = "Indtast kun tal";
            }

            result = a - b; // Lægger a og b sammen og konvertere til tekst
            labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxTalA.Text); // Konvertere textbox1 til en double, så der kan regnes på det, da det jo er en string
                b = Convert.ToDouble(textBoxTalB.Text); // --------- || ---------
            }
            catch
            {
                labelResult.Text = "Indtast kun tal";
            }

            result = a + b; // Lægger a og b sammen og konvertere til tekst
            labelResult.Text = Convert.ToString(result); // Konvertere 'res' til en string så den kan smækkes ind i 'labelResult'
        }
    }
}
