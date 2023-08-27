namespace AVC___remake.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_DateTime = new System.Windows.Forms.Label();
            this.lb_loop = new System.Windows.Forms.Label();
            this.lbl_lloop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bt_Run = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.t_ScanRegisters = new System.Windows.Forms.Timer(this.components);
            this.panel_MenuStrip = new System.Windows.Forms.Panel();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.lb_FormName = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_MenuStrip.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem,
            this.mainToolStripMenuItem,
            this.scopeToolStripMenuItem,
            this.eventLogToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.communicationToolStripMenuItem.Text = "Connect";
            this.communicationToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // scopeToolStripMenuItem
            // 
            this.scopeToolStripMenuItem.Name = "scopeToolStripMenuItem";
            this.scopeToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.scopeToolStripMenuItem.Text = "Scope";
            this.scopeToolStripMenuItem.Click += new System.EventHandler(this.scopeToolStripMenuItem_Click);
            // 
            // eventLogToolStripMenuItem
            // 
            this.eventLogToolStripMenuItem.Name = "eventLogToolStripMenuItem";
            this.eventLogToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.eventLogToolStripMenuItem.Text = "Event Log";
            this.eventLogToolStripMenuItem.Click += new System.EventHandler(this.eventLogToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.WriteBufferSize = 4096;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(69, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 417);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.lb_DateTime);
            this.panel2.Controls.Add(this.lb_loop);
            this.panel2.Controls.Add(this.lbl_lloop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(156, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 30);
            this.panel2.TabIndex = 5;
            // 
            // lb_DateTime
            // 
            this.lb_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_DateTime.AutoSize = true;
            this.lb_DateTime.BackColor = System.Drawing.Color.Red;
            this.lb_DateTime.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lb_DateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_DateTime.Location = new System.Drawing.Point(431, 1);
            this.lb_DateTime.Name = "lb_DateTime";
            this.lb_DateTime.Size = new System.Drawing.Size(212, 26);
            this.lb_DateTime.TabIndex = 12;
            this.lb_DateTime.Text = "00:00:00    00/00/00";
            // 
            // lb_loop
            // 
            this.lb_loop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_loop.AutoSize = true;
            this.lb_loop.BackColor = System.Drawing.Color.Red;
            this.lb_loop.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lb_loop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_loop.Location = new System.Drawing.Point(233, 1);
            this.lb_loop.Name = "lb_loop";
            this.lb_loop.Size = new System.Drawing.Size(36, 26);
            this.lb_loop.TabIndex = 11;
            this.lb_loop.Text = "00";
            // 
            // lbl_lloop
            // 
            this.lbl_lloop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_lloop.AutoSize = true;
            this.lbl_lloop.BackColor = System.Drawing.Color.Red;
            this.lbl_lloop.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lbl_lloop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_lloop.Location = new System.Drawing.Point(148, 0);
            this.lbl_lloop.Name = "lbl_lloop";
            this.lbl_lloop.Size = new System.Drawing.Size(90, 26);
            this.lbl_lloop.TabIndex = 10;
            this.lbl_lloop.Text = "| Loop:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "AVC 150kVA";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bt_Run
            // 
            this.bt_Run.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Run.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bt_Run.FlatAppearance.BorderSize = 0;
            this.bt_Run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bt_Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bt_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Run.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Run.ForeColor = System.Drawing.Color.Green;
            this.bt_Run.Location = new System.Drawing.Point(806, 102);
            this.bt_Run.Name = "bt_Run";
            this.bt_Run.Size = new System.Drawing.Size(138, 118);
            this.bt_Run.TabIndex = 1;
            this.bt_Run.Text = "RUN";
            this.bt_Run.UseVisualStyleBackColor = false;
            this.bt_Run.Click += new System.EventHandler(this.bt_Run_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AVC___remake.Properties.Resources.ICEA_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // t_ScanRegisters
            // 
            this.t_ScanRegisters.Enabled = true;
            this.t_ScanRegisters.Interval = 50;
            this.t_ScanRegisters.Tick += new System.EventHandler(this.t_ScanRegisters_Tick);
            // 
            // panel_MenuStrip
            // 
            this.panel_MenuStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_MenuStrip.AutoSize = true;
            this.panel_MenuStrip.Controls.Add(this.menuStrip1);
            this.panel_MenuStrip.Location = new System.Drawing.Point(0, 33);
            this.panel_MenuStrip.Name = "panel_MenuStrip";
            this.panel_MenuStrip.Size = new System.Drawing.Size(943, 31);
            this.panel_MenuStrip.TabIndex = 9;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_Title.Controls.Add(this.bt_Exit);
            this.panel_Title.Controls.Add(this.lb_FormName);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(948, 30);
            this.panel_Title.TabIndex = 10;
            this.panel_Title.DoubleClick += new System.EventHandler(this.panel_Title_DoubleClick);
            // 
            // bt_Exit
            // 
            this.bt_Exit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Exit.FlatAppearance.BorderSize = 0;
            this.bt_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Exit.Location = new System.Drawing.Point(905, 0);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(40, 30);
            this.bt_Exit.TabIndex = 12;
            this.bt_Exit.TabStop = false;
            this.bt_Exit.Text = "X";
            this.bt_Exit.UseVisualStyleBackColor = false;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // lb_FormName
            // 
            this.lb_FormName.AutoSize = true;
            this.lb_FormName.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FormName.ForeColor = System.Drawing.Color.LightGray;
            this.lb_FormName.Location = new System.Drawing.Point(20, 5);
            this.lb_FormName.Name = "lb_FormName";
            this.lb_FormName.Size = new System.Drawing.Size(37, 20);
            this.lb_FormName.TabIndex = 11;
            this.lb_FormName.Text = "AVC";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel_Title;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lb_FormName;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(199, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "ACTIVE VOLTAGE CONDITIONER";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.bt_Run);
            this.Controls.Add(this.panel_MenuStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Voltage Conditioner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_MenuStrip.ResumeLayout(false);
            this.panel_MenuStrip.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Run;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.Timer t_ScanRegisters;
        private System.Windows.Forms.Panel panel_MenuStrip;
        private System.Windows.Forms.Panel panel_Title;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lb_FormName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label lb_loop;
        private System.Windows.Forms.Label lbl_lloop;
        private System.Windows.Forms.Label lb_DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}