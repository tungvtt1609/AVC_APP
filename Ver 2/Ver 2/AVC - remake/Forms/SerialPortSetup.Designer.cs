namespace AVC___remake.Forms
{
    partial class SerialPortSetup
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.cB_Name = new System.Windows.Forms.ComboBox();
            this.cB_BaudRate = new System.Windows.Forms.ComboBox();
            this.cB_StopBits = new System.Windows.Forms.ComboBox();
            this.cB_Parity = new System.Windows.Forms.ComboBox();
            this.cB_DataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_Scan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(280, 219);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(121, 24);
            this.bt_Connect.TabIndex = 5;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // cB_Name
            // 
            this.cB_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Name.FormattingEnabled = true;
            this.cB_Name.Location = new System.Drawing.Point(110, 87);
            this.cB_Name.Name = "cB_Name";
            this.cB_Name.Size = new System.Drawing.Size(121, 24);
            this.cB_Name.TabIndex = 0;
            // 
            // cB_BaudRate
            // 
            this.cB_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_BaudRate.FormattingEnabled = true;
            this.cB_BaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cB_BaudRate.Location = new System.Drawing.Point(280, 87);
            this.cB_BaudRate.Name = "cB_BaudRate";
            this.cB_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.cB_BaudRate.TabIndex = 1;
            // 
            // cB_StopBits
            // 
            this.cB_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_StopBits.FormattingEnabled = true;
            this.cB_StopBits.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.cB_StopBits.Location = new System.Drawing.Point(280, 156);
            this.cB_StopBits.Name = "cB_StopBits";
            this.cB_StopBits.Size = new System.Drawing.Size(121, 24);
            this.cB_StopBits.TabIndex = 3;
            // 
            // cB_Parity
            // 
            this.cB_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Parity.FormattingEnabled = true;
            this.cB_Parity.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cB_Parity.Location = new System.Drawing.Point(110, 220);
            this.cB_Parity.Name = "cB_Parity";
            this.cB_Parity.Size = new System.Drawing.Size(121, 24);
            this.cB_Parity.TabIndex = 4;
            // 
            // cB_DataBits
            // 
            this.cB_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_DataBits.FormattingEnabled = true;
            this.cB_DataBits.Items.AddRange(new object[] {
            "8",
            "9"});
            this.cB_DataBits.Location = new System.Drawing.Point(110, 156);
            this.cB_DataBits.Name = "cB_DataBits";
            this.cB_DataBits.Size = new System.Drawing.Size(121, 24);
            this.cB_DataBits.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parity";
            // 
            // t_Scan
            // 
            this.t_Scan.Interval = 250;
            this.t_Scan.Tick += new System.EventHandler(this.t_Scan_Tick);
            // 
            // SerialPortSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_DataBits);
            this.Controls.Add(this.cB_Parity);
            this.Controls.Add(this.cB_StopBits);
            this.Controls.Add(this.cB_BaudRate);
            this.Controls.Add(this.cB_Name);
            this.Controls.Add(this.bt_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SerialPortSetup";
            this.Text = "Communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.ComboBox cB_Name;
        private System.Windows.Forms.ComboBox cB_BaudRate;
        private System.Windows.Forms.ComboBox cB_StopBits;
        private System.Windows.Forms.ComboBox cB_Parity;
        private System.Windows.Forms.ComboBox cB_DataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer t_Scan;
    }
}

