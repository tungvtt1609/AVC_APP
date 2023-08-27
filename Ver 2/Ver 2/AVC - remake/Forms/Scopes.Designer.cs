namespace AVC___remake.Forms
{
    partial class Scopes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Title = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bt_Close = new System.Windows.Forms.Button();
            this.zGC_Input_V = new ZedGraph.ZedGraphControl();
            this.zGC_Output_V = new ZedGraph.ZedGraphControl();
            this.zGC_Output_I = new ZedGraph.ZedGraphControl();
            this.zGC_DCLink_V = new ZedGraph.ZedGraphControl();
            this.bt_Draw = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Tomato;
            this.panel_Title.Controls.Add(this.bt_Close);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(950, 30);
            this.panel_Title.TabIndex = 2;
            this.panel_Title.DoubleClick += new System.EventHandler(this.panel_Title_DoubleClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_Title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bt_Close
            // 
            this.bt_Close.FlatAppearance.BorderSize = 0;
            this.bt_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.ForeColor = System.Drawing.Color.White;
            this.bt_Close.Location = new System.Drawing.Point(900, 0);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(50, 30);
            this.bt_Close.TabIndex = 1;
            this.bt_Close.TabStop = false;
            this.bt_Close.Text = "X";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // zGC_Input_V
            // 
            this.zGC_Input_V.Location = new System.Drawing.Point(13, 37);
            this.zGC_Input_V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGC_Input_V.Name = "zGC_Input_V";
            this.zGC_Input_V.ScrollGrace = 0D;
            this.zGC_Input_V.ScrollMaxX = 0D;
            this.zGC_Input_V.ScrollMaxY = 0D;
            this.zGC_Input_V.ScrollMaxY2 = 0D;
            this.zGC_Input_V.ScrollMinX = 0D;
            this.zGC_Input_V.ScrollMinY = 0D;
            this.zGC_Input_V.ScrollMinY2 = 0D;
            this.zGC_Input_V.Size = new System.Drawing.Size(450, 300);
            this.zGC_Input_V.TabIndex = 3;
            this.zGC_Input_V.TabStop = false;
            // 
            // zGC_Output_V
            // 
            this.zGC_Output_V.Location = new System.Drawing.Point(487, 37);
            this.zGC_Output_V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGC_Output_V.Name = "zGC_Output_V";
            this.zGC_Output_V.ScrollGrace = 0D;
            this.zGC_Output_V.ScrollMaxX = 0D;
            this.zGC_Output_V.ScrollMaxY = 0D;
            this.zGC_Output_V.ScrollMaxY2 = 0D;
            this.zGC_Output_V.ScrollMinX = 0D;
            this.zGC_Output_V.ScrollMinY = 0D;
            this.zGC_Output_V.ScrollMinY2 = 0D;
            this.zGC_Output_V.Size = new System.Drawing.Size(450, 300);
            this.zGC_Output_V.TabIndex = 4;
            this.zGC_Output_V.TabStop = false;
            // 
            // zGC_Output_I
            // 
            this.zGC_Output_I.Location = new System.Drawing.Point(13, 345);
            this.zGC_Output_I.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGC_Output_I.Name = "zGC_Output_I";
            this.zGC_Output_I.ScrollGrace = 0D;
            this.zGC_Output_I.ScrollMaxX = 0D;
            this.zGC_Output_I.ScrollMaxY = 0D;
            this.zGC_Output_I.ScrollMaxY2 = 0D;
            this.zGC_Output_I.ScrollMinX = 0D;
            this.zGC_Output_I.ScrollMinY = 0D;
            this.zGC_Output_I.ScrollMinY2 = 0D;
            this.zGC_Output_I.Size = new System.Drawing.Size(450, 300);
            this.zGC_Output_I.TabIndex = 5;
            this.zGC_Output_I.TabStop = false;
            // 
            // zGC_DCLink_V
            // 
            this.zGC_DCLink_V.Location = new System.Drawing.Point(487, 345);
            this.zGC_DCLink_V.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zGC_DCLink_V.Name = "zGC_DCLink_V";
            this.zGC_DCLink_V.ScrollGrace = 0D;
            this.zGC_DCLink_V.ScrollMaxX = 0D;
            this.zGC_DCLink_V.ScrollMaxY = 0D;
            this.zGC_DCLink_V.ScrollMaxY2 = 0D;
            this.zGC_DCLink_V.ScrollMinX = 0D;
            this.zGC_DCLink_V.ScrollMinY = 0D;
            this.zGC_DCLink_V.ScrollMinY2 = 0D;
            this.zGC_DCLink_V.Size = new System.Drawing.Size(450, 300);
            this.zGC_DCLink_V.TabIndex = 6;
            this.zGC_DCLink_V.TabStop = false;
            // 
            // bt_Draw
            // 
            this.bt_Draw.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Draw.FlatAppearance.BorderSize = 0;
            this.bt_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Draw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Draw.Location = new System.Drawing.Point(12, 648);
            this.bt_Draw.Name = "bt_Draw";
            this.bt_Draw.Size = new System.Drawing.Size(451, 40);
            this.bt_Draw.TabIndex = 0;
            this.bt_Draw.Text = "Draw";
            this.bt_Draw.UseVisualStyleBackColor = false;
            this.bt_Draw.Click += new System.EventHandler(this.bt_Draw_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Clear.FlatAppearance.BorderSize = 0;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Clear.Location = new System.Drawing.Point(487, 648);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(451, 40);
            this.bt_Clear.TabIndex = 1;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.zGC_Input_V;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.zGC_DCLink_V;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.zGC_Output_I;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.zGC_Output_V;
            // 
            // Scopes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Draw);
            this.Controls.Add(this.zGC_DCLink_V);
            this.Controls.Add(this.zGC_Output_I);
            this.Controls.Add(this.zGC_Output_V);
            this.Controls.Add(this.zGC_Input_V);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scopes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_Title;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Draw;
        private ZedGraph.ZedGraphControl zGC_DCLink_V;
        private ZedGraph.ZedGraphControl zGC_Output_I;
        private ZedGraph.ZedGraphControl zGC_Output_V;
        private ZedGraph.ZedGraphControl zGC_Input_V;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}