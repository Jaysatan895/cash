using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace cash
{
    public partial class Form1 : Form
    {
        double pencil;
        double eraser;
        double paper;
        double sub;
        double tax;
        double change;
        double total;



        public Form1()
        {
            InitializeComponent();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                eraser = Convert.ToDouble(eraserImput.Text);
                paper = Convert.ToDouble(paperImput.Text);
                pencil = Convert.ToDouble(pencilImput.Text);
                sub = pencil * 0.90 + eraser * 0.45 + paper * 0.20;
                tax = sub * 0.13;
                total = tax * sub;

                subOutput.Text = $"{sub.ToString("C")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";
            }
            catch
            {
                subOutput.Text = $"Error";
                taxOutput.Text = $"Error";
                totalOutput.Text = $"Error";


            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            SoundPlayer chingPlayer = new SoundPlayer(Properties.Resources.ching);
            chingPlayer.Play();

            printOutput.Text = $"Welcome, thank you for choosing Jaysons school supplies." +
                $"your subtotal subtotal:{sub.ToString("C")} aftertaxes:{tax.ToString("C")}total cost:{total.ToString("C")} "5;

            printOutput2.Text = $"call 1800-Schooltime for questions or concerns";


        }
    }
}



