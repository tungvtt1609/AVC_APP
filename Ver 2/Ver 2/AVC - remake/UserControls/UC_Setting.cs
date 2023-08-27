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
    public partial class UC_Setting : UserControl
    {
        public AVC___remake.Forms.Main main;
        public UC_Setting()
        {
            InitializeComponent();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            Settings.Default.setting_DC_Vmax = ushort.Parse(tB_DCLink_Vmax.Text);
            Settings.Default.setting_DC_Vmin = ushort.Parse(tB_DCLink_Vmax.Text);
            Settings.Default.setting_DC_Vref = ushort.Parse(tB_DCLink_Vref.Text);

            Settings.Default.setting_In_Imax = ushort.Parse(tB_Input_Imax.Text);
            Settings.Default.setting_In_Vmax = ushort.Parse(tB_Input_Vmax.Text);
            Settings.Default.setting_In_Vmin = ushort.Parse(tB_Input_Vmin.Text);

            Settings.Default.setting_Out_Imax = ushort.Parse(tB_Output_Imax.Text);
            Settings.Default.setting_Out_Vload = ushort.Parse(tB_Output_Vload.Text);

            tB_DCLink_Vmax.ForeColor = tB_DCLink_Vmin.ForeColor = tB_DCLink_Vref.ForeColor = Color.Black;
            tB_Input_Imax.ForeColor = tB_Input_Vmax.ForeColor = tB_Input_Vmin.ForeColor = Color.Black;
            tB_Output_Imax.ForeColor = tB_Output_Vload.ForeColor = Color.Black;

            main.SaveSetting();
        }

        private void bt_Default_Click(object sender, EventArgs e)
        {
            Settings.Default.setting_In_Vmax = 300; tB_Input_Vmax.Text = "300";
            Settings.Default.setting_In_Vmin = 0;   tB_Input_Vmin.Text = "0";
            Settings.Default.setting_In_Imax = 10;  tB_Input_Imax.Text = "10";
            Settings.Default.setting_DC_Vref = 100; tB_DCLink_Vref.Text = "100";
            Settings.Default.setting_DC_Vmax = 990; tB_DCLink_Vmax.Text = "990";
            Settings.Default.setting_DC_Vmin = 0;   tB_DCLink_Vmin.Text = "0";
            Settings.Default.setting_Out_Vload = 220; tB_Output_Vload.Text = "220";
            Settings.Default.setting_Out_Imax = 10;   tB_Output_Imax.Text = "10";

            dTP_Date.Value = DateTime.Now;
            dTP_Time.Value = DateTime.Now;
        }

        private void bt_SetTime_Click(object sender, EventArgs e)
        {

            Settings.Default.setting_DateTime = (dTP_Date.Value.Date + dTP_Time.Value.TimeOfDay);
            main.modbusSlave1.SetRegisterValue(502, 1);

            //Settings.Default.Set_date = (ushort)dTP_Date.Value.Day;
            //Settings.Default.Set_month = (ushort)dTP_Date.Value.Month;
            //Settings.Default.Set_year = (ushort)dTP_Date.Value.Year;
            //Settings.Default.Set_second = (ushort)dTP_Time.Value.Second;
            //Settings.Default.Set_minute = (ushort)dTP_Time.Value.Minute;
            //Settings.Default.Set_hour = (ushort)dTP_Time.Value.Hour;
            //modbusSlave1.SetRegisterValue(506, Settings.Default.Set_date);
            //modbusSlave1.SetRegisterValue(507, Settings.Default.Set_month);
            //modbusSlave1.SetRegisterValue(508, Settings.Default.Set_year);
            //modbusSlave1.SetRegisterValue(503, Settings.Default.Set_second);
            //modbusSlave1.SetRegisterValue(504, Settings.Default.Set_minute);
            //modbusSlave1.SetRegisterValue(505, Settings.Default.Set_hour);
            //main.TimeSetting();

          
            MessageBox.Show("Set Time Done", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main.modbusSlave1.SetRegisterValue(502, 0);
        }

        char demacialChar = Convert.ToChar(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
        private void NumberPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar) && ((TextBox)sender).TextLength < 3) || char.IsControl(e.KeyChar))
            {

            }
            else
                e.Handled = true;
        }

        private void TextChangedCallBack(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Red;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dTP_Date_ValueChanged(object sender, EventArgs e)
        {
            main.modbusSlave1.SetRegisterValue(508, (ushort)dTP_Date.Value.Day);
            main.modbusSlave1.SetRegisterValue(509, (ushort)dTP_Date.Value.Month);
            main.modbusSlave1.SetRegisterValue(510, (ushort)(dTP_Date.Value.Year%100));
           

        }

        private void dTP_Time_ValueChanged(object sender, EventArgs e)
        {
            main.modbusSlave1.SetRegisterValue(505, (ushort)dTP_Time.Value.Second);
            main.modbusSlave1.SetRegisterValue(506, (ushort)dTP_Time.Value.Minute);
            main.modbusSlave1.SetRegisterValue(507, (ushort)dTP_Time.Value.Hour);
        }
    }
}
