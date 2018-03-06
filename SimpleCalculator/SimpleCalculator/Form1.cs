using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int FirstValue = 0;
            int SecondValue = 0;
            bool numeric = true;
            numeric = (int.TryParse(TextFirstValue.Text, out FirstValue) &&
                int.TryParse(TextSecondValue.Text, out SecondValue));
            if (TextFirstValue.Text != null && TextSecondValue.Text != null && numeric)
                {
                if (ButtonAddition.Checked)
                {
                    ResultBox.Text = (FirstValue + SecondValue).ToString();
                }
                if (ButtonSubtraction.Checked)
                {
                    ResultBox.Text = (FirstValue - SecondValue).ToString();
                }
                if (ButtonMultiplication.Checked)
                {
                    ResultBox.Text = (FirstValue * SecondValue).ToString();
                }
                if (ButtonDivision.Checked)
                {
                    ResultBox.Text = (FirstValue / SecondValue).ToString();
                }
             
            }
            else
            {
                MessageBox.Show("Please insert a numerical value");
            }
        }
    }
}
