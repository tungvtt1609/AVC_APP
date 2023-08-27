using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVC___remake.Properties;

namespace AVC___remake.UserControls
{
    public partial class UC_Main : UserControl
    {
        public UC_Main()
        {
            InitializeComponent();
        }

        public void ChangeImg(ushort avc_SttValue)
        {
            ushort temp = avc_SttValue;
            switch (temp)
            {
                case 0:
                    {
                        pictureBox1.Image = Resources._0;
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Resources._1;
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Resources._2;
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Resources._3;
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Image = Resources._4;
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Image = Resources._5;
                        break;
                    }
                default:
                    {
                        pictureBox1.Image = Resources._0;
                        break;
                    }
            }
        }

        delegate void LabelDisplay_CallBack();
        public void DisplayInformationUpdate()
        {
            LabelDisplay();

        }

        public void LabelDisplay()
        {
            if (InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    lb_InputDC.Text = Settings.Default.main_DC_link.ToString("0.00");
                    lb_InputF.Text = Settings.Default.main_Freq.ToString("0.00");
                    lb_InputVa.Text = Settings.Default.main_Input_Va.ToString("0.00");
                    lb_InputVb.Text = Settings.Default.main_Input_Vb.ToString("0.00");
                    lb_InputVc.Text = Settings.Default.main_Input_Vc.ToString("0.00");
                    lb_OutputIa.Text = Settings.Default.main_Output_Ia.ToString("0.00");
                    lb_OutputIb.Text = Settings.Default.main_Output_Ib.ToString("0.00");
                    lb_OutputIc.Text = Settings.Default.main_Output_Ic.ToString("0.00");
                    lb_OutputVa.Text = Settings.Default.main_Output_Va.ToString("0.00");
                    lb_OutputVb.Text = Settings.Default.main_Output_Vb.ToString("0.00");
                    lb_OutputVc.Text = Settings.Default.main_Output_Vc.ToString("0.00");
                }));
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_OutputVb_Click(object sender, EventArgs e)
        {

        }

        private void UC_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
