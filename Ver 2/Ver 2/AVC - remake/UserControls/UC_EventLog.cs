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
    public partial class UC_EventLog : UserControl
    {
        public AVC___remake.Forms.Main main;
        static string[] typesError = new string[] { "", "Shunt Run Err", "Series Run Err", "Sag Start", "Sag End", "Swell Start", "Swell End", "Shunt check Error", "Series check Error" };

        public UC_EventLog()
        {
            InitializeComponent();
            InitLog();
        }
        ListViewItem[] log = new ListViewItem[8];
        void InitLog()
        {
            for(int i = 1; i <= 8; i++)
            {
                log[i - 1] = new ListViewItem(i.ToString());
            }
            listView1.Items.AddRange(log);
        }

        public void UpdateLog()
        {
            UpdateInformation();
            if (InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    //listView1.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        log[i].SubItems.Clear();
                        log[i].Text = (i + 1).ToString();
                        string typeError = typesError[(int)main.modbusSlave1.GetRegisterValue((ushort)(75 + i * 7))];
                        string time, date;
                        
                        if (!(typeError == string.Empty))
                        {
                            time = string.Format("{0:00}:{1:00}:{2:00}", main.modbusSlave1.GetRegisterValue((ushort)(71 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(70 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(69 + 7 * i)));
                            date = string.Format("{0:00}/{1:00}/{2:00}", main.modbusSlave1.GetRegisterValue((ushort)(72 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(73 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(74 + 7 * i)));
                        }
                        else
                        {
                            time = date = string.Empty;
                        }
                       
                        
                        log[i].SubItems.Add(time);
                        log[i].SubItems.Add(date);
                        log[i].SubItems.Add(typeError);
                    }
                    
                }));
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    log[i].SubItems.Clear();
                    log[i].Text = (i + 1).ToString();
                    string typeError = typesError[(int)main.modbusSlave1.GetRegisterValue((ushort)(75 + i * 7))];
                    string time, date;

                    if (!(typeError == string.Empty))
                    {
                        time = string.Format("{0:00}:{1:00}:{2:00}", main.modbusSlave1.GetRegisterValue((ushort)(71 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(70 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(69 + 7 * i)));
                        date = string.Format("{0:00}/{1:00}/{2:00}", main.modbusSlave1.GetRegisterValue((ushort)(72 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(73 + 7 * i)), main.modbusSlave1.GetRegisterValue((ushort)(74 + 7 * i)));
                    }
                    else
                    {
                        time = date = string.Empty;
                    }


                    log[i].SubItems.Add(time);
                    log[i].SubItems.Add(date);
                    log[i].SubItems.Add(typeError);
                }
            }
        }

        private void btn_reser_log_Click(object sender, EventArgs e)
        {
            main.modbusSlave1.SetRegisterValue(501, 1);
            MessageBox.Show("Reset log done", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main.modbusSlave1.SetRegisterValue(501, 0);
        }

        private ushort logPage = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            logPage++;
            if (logPage > 7) logPage = 0;
            main.modbusSlave1.SetRegisterValue(503, logPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logPage--;
            if (logPage < 0 || logPage > 7) logPage = 7;
            main.modbusSlave1.SetRegisterValue(503, logPage);

        }

        public void UpdateInformation()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    lb_PageNo.Text = string.Format("Page No: {0}/8", main.modbusSlave1.GetRegisterValue(133));

                    lb_lastResetTime.Text = string.Format("{0:00}:{1:00}:{2:00} {3:00}/{4:00}/{5:00}", main.modbusSlave1.GetRegisterValue(136), main.modbusSlave1.GetRegisterValue(135), main.modbusSlave1.GetRegisterValue(134), main.modbusSlave1.GetRegisterValue(137), main.modbusSlave1.GetRegisterValue(138), main.modbusSlave1.GetRegisterValue(139));

                }));
            }
        }
    }
}
