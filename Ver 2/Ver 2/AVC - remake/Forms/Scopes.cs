using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using AVC___remake.Properties;

namespace AVC___remake.Forms
{
    public partial class Scopes : Form
    {
        public Scopes()
        {
            InitializeComponent();

            ZedGraphControlInit();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            panel_Title.Focus();
            this.Visible = false;
        }

        private void panel_Title_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool isDraw = false;
        private void bt_Draw_Click(object sender, EventArgs e)
        {
            panel_Title.Focus();
            isDraw = !isDraw;
            if (isDraw)
            {
                bt_Draw.Text = "Stop";
            }
            else
            {
                bt_Draw.Text = "Draw";
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            panel_Title.Focus();

            foreach (CurveItem list in pane_InputV.CurveList)
            {
                list.Clear();
            }

            foreach (CurveItem list in pane_OutputV.CurveList)
            {
                list.Clear();
            }

            foreach (CurveItem list in pane_OutputI.CurveList)
            {
                list.Clear();
            }

            list_DCLink_V.Clear();

            zGC_DCLink_V.Invalidate();
            zGC_Input_V.Invalidate();
            zGC_Output_V.Invalidate();
            zGC_Output_I.Invalidate();
        }
        GraphPane pane_InputV;
        public RollingPointPairList list_Input_Va = new RollingPointPairList(2000);
        public RollingPointPairList list_Input_Vb = new RollingPointPairList(2000);
        public RollingPointPairList list_Input_Vc = new RollingPointPairList(2000);

        GraphPane pane_OutputV;
        public RollingPointPairList list_Output_Va = new RollingPointPairList(2000);
        public RollingPointPairList list_Output_Vb = new RollingPointPairList(2000);
        public RollingPointPairList list_Output_Vc = new RollingPointPairList(2000);

        GraphPane pane_OutputI;
        public RollingPointPairList list_Output_Ia = new RollingPointPairList(2000);
        public RollingPointPairList list_Output_Ib = new RollingPointPairList(2000);
        public RollingPointPairList list_Output_Ic = new RollingPointPairList(2000);

        GraphPane pane_DCLink_V;
        public RollingPointPairList list_DCLink_V = new RollingPointPairList(2000);

        private void ZedGraphControlInit()
        {
            //Input V
            pane_InputV = zGC_Input_V.GraphPane;

            pane_InputV.Border.IsVisible = false;

            pane_InputV.Title.Text = "Input Voltage Graph";
            pane_InputV.XAxis.Title.Text = "Time";
            pane_InputV.YAxis.Title.Text = "Value";

            pane_InputV.XAxis.Type = AxisType.Date;

            pane_InputV.AddCurve("Va", list_Input_Va, Color.Blue, SymbolType.None);
            pane_InputV.AddCurve("Vb", list_Input_Vb, Color.Red, SymbolType.None);
            pane_InputV.AddCurve("Vc", list_Input_Vc, Color.SpringGreen, SymbolType.None);

            pane_InputV.XAxis.Scale.FormatAuto = true;

            //Output V
            pane_OutputV = zGC_Output_V.GraphPane;

            pane_OutputV.Border.IsVisible = false;

            pane_OutputV.Title.Text = "Output Voltage Graph";
            pane_OutputV.XAxis.Title.Text = "Time";
            pane_OutputV.YAxis.Title.Text = "Value";

            pane_OutputV.XAxis.Type = AxisType.Date;

            pane_OutputV.AddCurve("Va", list_Output_Va, Color.Blue, SymbolType.None);
            pane_OutputV.AddCurve("Vb", list_Output_Vb, Color.Red, SymbolType.None);
            pane_OutputV.AddCurve("Vc", list_Output_Vc, Color.SpringGreen, SymbolType.None);

            pane_InputV.XAxis.Scale.FormatAuto = true;

            //Output I
            pane_OutputI = zGC_Output_I.GraphPane;

            pane_OutputI.Border.IsVisible = false;

            pane_OutputI.Title.Text = "Output Current Graph";
            pane_OutputI.XAxis.Title.Text = "Time";
            pane_OutputI.YAxis.Title.Text = "Value";

            pane_OutputI.XAxis.Type = AxisType.Date;

            pane_OutputI.AddCurve("Ia", list_Output_Ia, Color.Blue, SymbolType.None);
            pane_OutputI.AddCurve("Ib", list_Output_Ib, Color.Red, SymbolType.None);
            pane_OutputI.AddCurve("Ic", list_Output_Ic, Color.SpringGreen, SymbolType.None);

            pane_OutputI.XAxis.Scale.FormatAuto = true;

            //DC link V
            pane_DCLink_V = zGC_DCLink_V.GraphPane;

            pane_DCLink_V.Border.IsVisible = false;

            pane_DCLink_V.Title.Text = "DC-Link Voltage Graph";
            pane_DCLink_V.XAxis.Title.Text = "Time";
            pane_DCLink_V.YAxis.Title.Text = "Value";

            pane_DCLink_V.XAxis.Type = AxisType.Date;

            pane_DCLink_V.AddCurve("DCLink Voltage", list_DCLink_V, Color.Navy, SymbolType.None);

            pane_DCLink_V.XAxis.Scale.FormatAuto = true;
        }

        public void Draw_Input_V()
        {
            list_Input_Va.Add(time, Settings.Default.main_Input_Va);
            list_Input_Vb.Add(time, Settings.Default.main_Input_Vb);
            list_Input_Vc.Add(time, Settings.Default.main_Input_Vc);

            pane_InputV.XAxis.Scale.FormatAuto = true;

            zGC_Input_V.AxisChange();
            zGC_Input_V.Invalidate();
        }
        public void Draw_Ouput_V()
        {
            list_Output_Va.Add(time, Settings.Default.main_Input_Va);
            list_Output_Vb.Add(time, Settings.Default.main_Input_Vb);
            list_Output_Vc.Add(time, Settings.Default.main_Input_Vc);

            pane_OutputV.XAxis.Scale.FormatAuto = true;

            zGC_Output_V.AxisChange();
            zGC_Output_V.Invalidate();
        }
        public void Draw_Output_I()
        {
            list_Output_Ia.Add(time, Settings.Default.main_Output_Ia);
            list_Output_Ib.Add(time, Settings.Default.main_Output_Ib);
            list_Output_Ic.Add(time, Settings.Default.main_Output_Ic);

            pane_OutputI.XAxis.Scale.FormatAuto = true;

            zGC_Output_I.AxisChange();
            zGC_Output_I.Invalidate();
        }
        public void Draw_DClink_V()
        {
            list_DCLink_V.Add(time, Settings.Default.main_DC_link);

            pane_DCLink_V.XAxis.Scale.FormatAuto = true;

            zGC_DCLink_V.AxisChange();
            zGC_DCLink_V.Invalidate();
        }

        XDate time;
        public void Draw()
        {
            if (isDraw)
            {
                time = Settings.Default.main_DateTime;
                Draw_Input_V();
                Draw_Ouput_V();
                Draw_Output_I();
                Draw_DClink_V();
            }
        }
    }
}
