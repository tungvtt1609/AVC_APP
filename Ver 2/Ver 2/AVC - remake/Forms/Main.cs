using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AVC___remake;
using AVC___remake.Scripts;
using AVC___remake.UserControls;
using AVC___remake.Properties;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace AVC___remake.Forms
{
    public partial class Main : Form
    {
        public ModbusSlave modbusSlave1;
        public SerialPortSetup communication;
        public SerialPortCommunication serialPortCommunication;
        public Scopes scopes;

        public UC_Main uC_Main;
        public UC_About uC_About;
        public UC_Setting uC_Setting;
        public UC_EventLog uC_EventLog;
        public Main()
        {
            InitializeComponent();

            modbusSlave1 = new ModbusSlave();
            modbusSlave1.slaveAddress = (byte) 0x01;

            modbusSlave1.GeneralSlave(109, 31, 19, 500);

            serialPortCommunication = new SerialPortCommunication();
            serialPortCommunication.Start(serialPort1, modbusSlave1, this);

            scopes = new Scopes();
            scopes.Visible = false;

            uC_Main = new UC_Main();
            uC_Main.Dock = DockStyle.Fill;

            panel1.Controls.Add(uC_Main);

            uC_About = new UC_About();
            uC_About.Dock = DockStyle.Fill;

            uC_Setting = new UC_Setting();
            uC_Setting.main = this;
            uC_Setting.Dock = DockStyle.Fill;

            uC_EventLog = new UC_EventLog();
            uC_EventLog.main = this;
            uC_EventLog.Dock = DockStyle.Fill;
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            communication = new SerialPortSetup(serialPort1, serialPortCommunication);
            communication.StartPosition = FormStartPosition.CenterParent;
            communication.ShowDialog();
        }

        private void bt_Run_Click(object sender, EventArgs e)
        {
            if (bt_Run.Text == "RUN")
            {
                modbusSlave1.SetRegisterValue(500, 1);
                bt_Run.Text = "STOP";
                bt_Run.ForeColor = Color.Red;
            }
            else
            {
                modbusSlave1.SetRegisterValue(500, 0);
                bt_Run.Text = "RUN";
                bt_Run.ForeColor = Color.Blue;
            }
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_Main);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_About);
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_Setting);
        }

        private void eventLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uC_EventLog);
        }

        private void scopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scopes.Visible = true;
            scopes.WindowState = FormWindowState.Normal;
            scopes.BringToFront();
        }

        ushort hardwarePreRun = 0;
        private void t_ScanRegisters_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ushort hardwareRun = modbusSlave1.GetRegisterValue(500);

                if (hardwareRun != hardwarePreRun)
                {
                    if (hardwareRun == 1)
                    {
                        bt_Run.Text = "STOP";
                        bt_Run.ForeColor = Color.Red;
                    }
                    else
                    {
                        bt_Run.Text = "RUN";
                        bt_Run.ForeColor = Color.Blue;
                    }

                    hardwarePreRun = hardwareRun;
                }
                else
                {

                }

                if (modbusSlave1.GetRegisterValue(59) == 0)
                {
                    panel2.BackColor = Color.Red;
                    label2.BackColor = Color.Red;
                    //tB_DateTimeUpdate.BackColor = Color.Red;
                    lbl_lloop.BackColor = Color.Red;
                    lb_loop.BackColor = Color.Red;
                    lb_DateTime.BackColor = Color.Red;
                }
                else
                {
                    panel2.BackColor    = Color.Green;
                    label2.BackColor    = Color.Green;
                    //tB_DateTimeUpdate.BackColor = Color.Green;
                    lbl_lloop.BackColor = Color.Green;
                    lb_loop.BackColor   = Color.Green;
                    lb_DateTime.BackColor = Color.Green;
                }

                lb_loop.Text = modbusSlave1.GetRegisterValue(56).ToString();

                string dateTime = string.Format("{0:00}:{1:00}:{2:00}    {3:00}/{4:00}/{5:00}", modbusSlave1.GetRegisterValue(65), modbusSlave1.GetRegisterValue(64), modbusSlave1.GetRegisterValue(63), modbusSlave1.GetRegisterValue(66), modbusSlave1.GetRegisterValue(67), modbusSlave1.GetRegisterValue(68));
                lb_DateTime.Text = dateTime;
                try
                {
                    Settings.Default.main_DateTime = new DateTime((int)modbusSlave1.GetRegisterValue(68), (int)modbusSlave1.GetRegisterValue(67), (int)modbusSlave1.GetRegisterValue(66), (int)modbusSlave1.GetRegisterValue(65), (int)modbusSlave1.GetRegisterValue(64), (int)modbusSlave1.GetRegisterValue(63));

                }
                catch
                {

                }

                Settings.Default.main_Input_Va  = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(31), modbusSlave1.GetRegisterValue(32));
                Settings.Default.main_Input_Vb  = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(33), modbusSlave1.GetRegisterValue(34));
                Settings.Default.main_Input_Vc  = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(35), modbusSlave1.GetRegisterValue(36));

                Settings.Default.main_Freq      = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(37), modbusSlave1.GetRegisterValue(38));

                Settings.Default.main_Output_Va = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(39), modbusSlave1.GetRegisterValue(40));
                Settings.Default.main_Output_Vb = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(41), modbusSlave1.GetRegisterValue(42));
                Settings.Default.main_Output_Vc = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(43), modbusSlave1.GetRegisterValue(44));

                Settings.Default.main_Output_Ia = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(45), modbusSlave1.GetRegisterValue(46));
                Settings.Default.main_Output_Ib = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(47), modbusSlave1.GetRegisterValue(48));
                Settings.Default.main_Output_Ic = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(49), modbusSlave1.GetRegisterValue(50));

                Settings.Default.main_DC_link   = ConvertIEEE.ToSingle(modbusSlave1.GetRegisterValue(51), modbusSlave1.GetRegisterValue(52));

                uC_Main.ChangeImg(modbusSlave1.GetRegisterValue(59));

                Thread thread1 = new Thread( new ThreadStart(uC_Main.DisplayInformationUpdate));
                thread1.IsBackground = true;
                thread1.Start();

                Thread thread3 = new Thread(new ThreadStart(uC_EventLog.UpdateLog));
                thread3.IsBackground = true;
                thread3.Start();

                Thread thread2 = new Thread(new ThreadStart(scopes.Draw));
                thread2.IsBackground = true;
                thread2.Priority = ThreadPriority.AboveNormal;
                thread2.Start();
            }
        }

        public void SaveSetting()
        {
            modbusSlave1.SetRegisterValue(511, Settings.Default.setting_DC_Vref);
            modbusSlave1.SetRegisterValue(512, Settings.Default.setting_DC_Vmin);
            modbusSlave1.SetRegisterValue(513, Settings.Default.setting_DC_Vmax);
            modbusSlave1.SetRegisterValue(514, Settings.Default.setting_In_Vmin);
            modbusSlave1.SetRegisterValue(515, Settings.Default.setting_In_Vmax);
            modbusSlave1.SetRegisterValue(516, Settings.Default.setting_In_Imax);
            modbusSlave1.SetRegisterValue(517, Settings.Default.setting_Out_Imax);
            modbusSlave1.SetRegisterValue(518, Settings.Default.setting_Out_Vload);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void panel_Title_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.FileName = "Report AVC";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                excel.Application application = new excel.Application();
                
                if (application == null)
                {
                    MessageBox.Show("Microsoft Excel isnot existing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                excel.Workbook workbook;
                excel.Worksheet worksheet;
                workbook = application.Workbooks.Add(Type.Missing);
                worksheet = workbook.Worksheets.Item[1];

                worksheet.Name = "AVC System";

                ExportScopesToExcel(worksheet);

                try
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Save done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    workbook.Close(false);
                    application.Quit();
                }
                catch
                {
                    MessageBox.Show("Save fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    workbook.Close(false);
                    application.Quit();
                }
            }
        }

        private void ExportScopesToExcel(excel.Worksheet worksheet)
        {
            worksheet.Cells[1, 1] = "No.";
            worksheet.Cells[1, 2] = "Time";
            worksheet.Cells[1, 3] = "Date";
            worksheet.Cells[1, 4] = "Input Va";
            worksheet.Cells[1, 5] = "Input Vb";
            worksheet.Cells[1, 6] = "Input Vc";
            worksheet.Cells[1, 7] = "Input DC-Link";
            worksheet.Cells[1, 8] = "Output Va";
            worksheet.Cells[1, 9] = "Output Vb";
            worksheet.Cells[1, 10] = "Output Vc";
            worksheet.Cells[1, 11] = "Output Ia";
            worksheet.Cells[1, 12] = "Output Ib";
            worksheet.Cells[1, 13] = "Output Ic";

            excel.Range range;
            range = worksheet.Columns[2];
            range.NumberFormat = "HH:mm:ss";
            range = worksheet.Columns[3];
            range.NumberFormat = "dd/MM/yy";

            int count = scopes.list_Input_Va.Count;
            int no = 0;

            for (int row = 2; row <= count + 1; row++)
            {
                worksheet.Cells[row, 1] = no + 1;

                DateTime dateTime = FromOADate(scopes.list_Input_Va[no].X);
                worksheet.Cells[row, 2] = dateTime;
                worksheet.Cells[row, 3] = dateTime;

                worksheet.Cells[row, 4] = scopes.list_Input_Va[no].Y;
                worksheet.Cells[row, 5] = scopes.list_Input_Vb[no].Y;
                worksheet.Cells[row, 6] = scopes.list_Input_Vc[no].Y;
                worksheet.Cells[row, 7] = scopes.list_DCLink_V[no].Y;
                worksheet.Cells[row, 8] = scopes.list_Output_Va[no].Y;
                worksheet.Cells[row, 9] = scopes.list_Output_Vb[no].Y;
                worksheet.Cells[row, 10] = scopes.list_Output_Vc[no].Y;
                worksheet.Cells[row, 11] = scopes.list_Output_Ia[no].Y;
                worksheet.Cells[row, 12] = scopes.list_Output_Ib[no].Y;
                worksheet.Cells[row, 13] = scopes.list_Output_Ic[no].Y;
                
                no++;
            }

        }
        public static DateTime FromOADate(double date)
        {
            long result = DoubleDateToTicks(date);
            if (result != -1)
            {
                return new DateTime(result, DateTimeKind.Unspecified);
            }

            return new DateTime(01, 01, 01, 0, 0, 0, 0);
        }

        internal static long DoubleDateToTicks(double value)
        {
            if (value >= 2958466.0 || value <= -657435.0)
                return -1L;

            long num1 = (long)(value * 86400000.0 + (value >= 0.0 ? 0.5 : -0.5));
            if (num1 < 0L)
                num1 -= num1 % 86400000L * 2L;
            long num2 = num1 + 59926435200000L;

            if (num2 < 0L || num2 >= 315537897600000L)
                return -1L;

            return num2 * 10000L;
        }
    }
}
