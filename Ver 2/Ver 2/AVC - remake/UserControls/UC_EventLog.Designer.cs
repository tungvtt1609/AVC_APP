namespace AVC___remake.UserControls
{
    partial class UC_EventLog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeError = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_reser_log = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_PageNo = new System.Windows.Forms.Label();
            this.lb_lastResetTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Time,
            this.Date,
            this.TypeError});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 361);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No.";
            this.No.Width = 109;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 216;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 242;
            // 
            // TypeError
            // 
            this.TypeError.Text = "Type Error";
            this.TypeError.Width = 497;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Reset";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_lastResetTime);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_reser_log);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lb_PageNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(637, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_reser_log
            // 
            this.btn_reser_log.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reser_log.Location = new System.Drawing.Point(679, 10);
            this.btn_reser_log.Name = "btn_reser_log";
            this.btn_reser_log.Size = new System.Drawing.Size(106, 39);
            this.btn_reser_log.TabIndex = 3;
            this.btn_reser_log.Text = "Reset";
            this.btn_reser_log.UseVisualStyleBackColor = true;
            this.btn_reser_log.Click += new System.EventHandler(this.btn_reser_log_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(603, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.lb_PageNo.AutoSize = true;
            this.lb_PageNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PageNo.Location = new System.Drawing.Point(487, 23);
            this.lb_PageNo.Name = "label2";
            this.lb_PageNo.Size = new System.Drawing.Size(110, 21);
            this.lb_PageNo.TabIndex = 2;
            this.lb_PageNo.Text = "Page No: 0/8";
            // 
            // label3
            // 
            this.lb_lastResetTime.AutoSize = true;
            this.lb_lastResetTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastResetTime.Location = new System.Drawing.Point(136, 20);
            this.lb_lastResetTime.Name = "label3";
            this.lb_lastResetTime.Size = new System.Drawing.Size(144, 21);
            this.lb_lastResetTime.TabIndex = 6;
            this.lb_lastResetTime.Text = "00:00:00 00/00/00";
            // 
            // UC_EventLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "UC_EventLog";
            this.Size = new System.Drawing.Size(800, 417);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader TypeError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_reser_log;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_PageNo;
        private System.Windows.Forms.Label lb_lastResetTime;
    }
}
