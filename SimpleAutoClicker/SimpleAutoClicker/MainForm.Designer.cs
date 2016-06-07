namespace SimpleAutoClicker {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nmrInterval = new System.Windows.Forms.NumericUpDown();
            this.btnSetInterval = new System.Windows.Forms.Button();
            this.txtSingleClickKey = new System.Windows.Forms.TextBox();
            this.btnSetSingleClickKey = new System.Windows.Forms.Button();
            this.btnSetAutoClickKey = new System.Windows.Forms.Button();
            this.txtAutoClickKey = new System.Windows.Forms.TextBox();
            this.btnSetEmergencyStopKey = new System.Windows.Forms.Button();
            this.txtEmergencyStopKey = new System.Windows.Forms.TextBox();
            this.lblExplaination = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrInterval
            // 
            this.nmrInterval.Location = new System.Drawing.Point(12, 12);
            this.nmrInterval.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nmrInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrInterval.Name = "nmrInterval";
            this.nmrInterval.Size = new System.Drawing.Size(256, 22);
            this.nmrInterval.TabIndex = 0;
            this.nmrInterval.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnSetInterval
            // 
            this.btnSetInterval.Location = new System.Drawing.Point(274, 9);
            this.btnSetInterval.Name = "btnSetInterval";
            this.btnSetInterval.Size = new System.Drawing.Size(190, 27);
            this.btnSetInterval.TabIndex = 1;
            this.btnSetInterval.Text = "Set Interval (ms)";
            this.btnSetInterval.UseVisualStyleBackColor = true;
            this.btnSetInterval.Click += new System.EventHandler(this.btnSetInterval_Click);
            // 
            // txtSingleClickKey
            // 
            this.txtSingleClickKey.Location = new System.Drawing.Point(12, 41);
            this.txtSingleClickKey.Name = "txtSingleClickKey";
            this.txtSingleClickKey.Size = new System.Drawing.Size(256, 22);
            this.txtSingleClickKey.TabIndex = 2;
            this.txtSingleClickKey.Text = "VK_F2";
            // 
            // btnSetSingleClickKey
            // 
            this.btnSetSingleClickKey.Location = new System.Drawing.Point(274, 39);
            this.btnSetSingleClickKey.Name = "btnSetSingleClickKey";
            this.btnSetSingleClickKey.Size = new System.Drawing.Size(190, 27);
            this.btnSetSingleClickKey.TabIndex = 3;
            this.btnSetSingleClickKey.Text = "Set Single Click Key";
            this.btnSetSingleClickKey.UseVisualStyleBackColor = true;
            this.btnSetSingleClickKey.Click += new System.EventHandler(this.btnSetSingleClickKey_Click);
            // 
            // btnSetAutoClickKey
            // 
            this.btnSetAutoClickKey.Location = new System.Drawing.Point(274, 69);
            this.btnSetAutoClickKey.Name = "btnSetAutoClickKey";
            this.btnSetAutoClickKey.Size = new System.Drawing.Size(190, 27);
            this.btnSetAutoClickKey.TabIndex = 5;
            this.btnSetAutoClickKey.Text = "Set Auto Click Key";
            this.btnSetAutoClickKey.UseVisualStyleBackColor = true;
            this.btnSetAutoClickKey.Click += new System.EventHandler(this.btnSetAutoClickKey_Click);
            // 
            // txtAutoClickKey
            // 
            this.txtAutoClickKey.Location = new System.Drawing.Point(12, 71);
            this.txtAutoClickKey.Name = "txtAutoClickKey";
            this.txtAutoClickKey.Size = new System.Drawing.Size(256, 22);
            this.txtAutoClickKey.TabIndex = 4;
            this.txtAutoClickKey.Text = "VK_F4";
            // 
            // btnSetEmergencyStopKey
            // 
            this.btnSetEmergencyStopKey.Location = new System.Drawing.Point(274, 100);
            this.btnSetEmergencyStopKey.Name = "btnSetEmergencyStopKey";
            this.btnSetEmergencyStopKey.Size = new System.Drawing.Size(190, 27);
            this.btnSetEmergencyStopKey.TabIndex = 7;
            this.btnSetEmergencyStopKey.Text = "Set Emergency Stop Key";
            this.btnSetEmergencyStopKey.UseVisualStyleBackColor = true;
            this.btnSetEmergencyStopKey.Click += new System.EventHandler(this.btnSetEmergencyStopKey_Click);
            // 
            // txtEmergencyStopKey
            // 
            this.txtEmergencyStopKey.Location = new System.Drawing.Point(12, 102);
            this.txtEmergencyStopKey.Name = "txtEmergencyStopKey";
            this.txtEmergencyStopKey.Size = new System.Drawing.Size(256, 22);
            this.txtEmergencyStopKey.TabIndex = 6;
            this.txtEmergencyStopKey.Text = "VK_CONTROL+VK_SHIFT+VK_MENU";
            // 
            // lblExplaination
            // 
            this.lblExplaination.AutoSize = true;
            this.lblExplaination.Location = new System.Drawing.Point(9, 130);
            this.lblExplaination.Name = "lblExplaination";
            this.lblExplaination.Size = new System.Drawing.Size(448, 153);
            this.lblExplaination.TabIndex = 8;
            this.lblExplaination.Text = resources.GetString("lblExplaination.Text");
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(12, 302);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(66, 17);
            this.lblNotification.TabIndex = 9;
            this.lblNotification.Text = "Welcome";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 328);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblExplaination);
            this.Controls.Add(this.btnSetEmergencyStopKey);
            this.Controls.Add(this.txtEmergencyStopKey);
            this.Controls.Add(this.btnSetAutoClickKey);
            this.Controls.Add(this.txtAutoClickKey);
            this.Controls.Add(this.btnSetSingleClickKey);
            this.Controls.Add(this.txtSingleClickKey);
            this.Controls.Add(this.btnSetInterval);
            this.Controls.Add(this.nmrInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SimpleAutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.nmrInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrInterval;
        private System.Windows.Forms.Button btnSetInterval;
        private System.Windows.Forms.TextBox txtSingleClickKey;
        private System.Windows.Forms.Button btnSetSingleClickKey;
        private System.Windows.Forms.Button btnSetAutoClickKey;
        private System.Windows.Forms.TextBox txtAutoClickKey;
        private System.Windows.Forms.Button btnSetEmergencyStopKey;
        private System.Windows.Forms.TextBox txtEmergencyStopKey;
        private System.Windows.Forms.Label lblExplaination;
        private System.Windows.Forms.Label lblNotification;
    }
}

