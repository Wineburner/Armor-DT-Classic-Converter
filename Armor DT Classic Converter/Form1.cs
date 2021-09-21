using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armor_DT_Classic_Converter
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Convert.ToDouble(textboxNVDT.Text);

                double outputDR = (4.6 / (0.06 + (1 / input)));

                outputDR = Math.Floor(outputDR);

                outputClassicDR.Text = outputDR.ToString();

                double outputDT;

                if (radioButtonHeavy.Checked)
                {
                    outputDT = input * 0.5;
                }

                else if (radioButtonMedium.Checked)
                {
                    outputDT = input * 0.3;
                }

                else if (radioButtonLight.Checked)
                {
                    outputDT = input * 0.1;
                }

                else
                {
                    outputDT = 0;
                }

                outputDT = Math.Floor(outputDT);

                outputClassicDT.Text = outputDT.ToString();

            }
            catch { }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textboxNVDT.Text = "";
            outputClassicDT.Text = "";
            outputClassicDR.Text = "";
        }
    }
}
