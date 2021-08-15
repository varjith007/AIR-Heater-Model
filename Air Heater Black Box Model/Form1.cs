using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Heater_Black_Box_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            double ControlSignal = Convert.ToDouble(textControlSignal.Text);
            int TimeConstant = Convert.ToInt32(textTimeConstant.Text);
            double Gain = Convert.ToDouble(textGain.Text);
            int TimeDelay = Convert.ToInt32(textTimeDelay.Text);
            double EnvTemparature = -1*Convert.ToDouble(textTemparature.Text);

            double calculatedTemparature = 

        }
    }
}
