namespace CircuitsProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSimulate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinmized = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uclInfo3 = new CircuitsProject.uclInfo();
            this.uclInfo2 = new CircuitsProject.uclInfo();
            this.uclInfo1 = new CircuitsProject.uclInfo();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.LightGray;
            this.pnlMain.Controls.Add(this.btnSimulate);
            this.pnlMain.Controls.Add(this.uclInfo3);
            this.pnlMain.Controls.Add(this.uclInfo2);
            this.pnlMain.Controls.Add(this.uclInfo1);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1347, 825);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSimulate.AutoRoundedCorners = true;
            this.btnSimulate.BorderRadius = 26;
            this.btnSimulate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimulate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimulate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimulate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimulate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimulate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(145)))), ((int)(((byte)(253)))));
            this.btnSimulate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(155)))));
            this.btnSimulate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulate.ForeColor = System.Drawing.Color.White;
            this.btnSimulate.Location = new System.Drawing.Point(585, 751);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(221, 54);
            this.btnSimulate.TabIndex = 5;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(71, 762);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dr/Ahmed salem";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(67)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.btnMinmized);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 54);
            this.panel2.TabIndex = 6;
            // 
            // btnMinmized
            // 
            this.btnMinmized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinmized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinmized.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinmized.HoverState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnMinmized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinmized.Image")));
            this.btnMinmized.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinmized.ImageRotate = 0F;
            this.btnMinmized.ImageSize = new System.Drawing.Size(33, 30);
            this.btnMinmized.Location = new System.Drawing.Point(1228, 18);
            this.btnMinmized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinmized.Name = "btnMinmized";
            this.btnMinmized.PressedState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnMinmized.Size = new System.Drawing.Size(37, 26);
            this.btnMinmized.TabIndex = 4;
            this.btnMinmized.UseTransparentBackground = true;
            this.btnMinmized.Click += new System.EventHandler(this.btnMinmized_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(33, 30);
            this.btnClose.Location = new System.Drawing.Point(1283, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(46, 46);
            this.btnClose.Size = new System.Drawing.Size(37, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "RLC Simulation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1025, 762);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 34);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // uclInfo3
            // 
            this.uclInfo3.BackColor = System.Drawing.Color.Gainsboro;
            this.uclInfo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uclInfo3.Location = new System.Drawing.Point(43, 61);
            this.uclInfo3.Margin = new System.Windows.Forms.Padding(4);
            this.uclInfo3.Name = "uclInfo3";
            this.uclInfo3.Size = new System.Drawing.Size(1261, 217);
            this.uclInfo3.TabIndex = 0;
            this.uclInfo3.Load += new System.EventHandler(this.uclIInfo1_Load);
            // 
            // uclInfo2
            // 
            this.uclInfo2.BackColor = System.Drawing.Color.Gainsboro;
            this.uclInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uclInfo2.Location = new System.Drawing.Point(43, 289);
            this.uclInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.uclInfo2.Name = "uclInfo2";
            this.uclInfo2.Size = new System.Drawing.Size(1261, 217);
            this.uclInfo2.TabIndex = 0;
            this.uclInfo2.Load += new System.EventHandler(this.uclIInfo1_Load);
            // 
            // uclInfo1
            // 
            this.uclInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.uclInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uclInfo1.Location = new System.Drawing.Point(43, 518);
            this.uclInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.uclInfo1.Name = "uclInfo1";
            this.uclInfo1.Size = new System.Drawing.Size(1261, 217);
            this.uclInfo1.TabIndex = 0;
            this.uclInfo1.Load += new System.EventHandler(this.uclIInfo1_Load);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSimulate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1347, 825);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinmized;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSimulate;
        private System.Windows.Forms.Label label2;
        public uclInfo uclInfo1;
        public uclInfo uclInfo3;
        public uclInfo uclInfo2;
        private System.Windows.Forms.Label label3;
    }
}

