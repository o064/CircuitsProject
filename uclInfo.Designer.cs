namespace CircuitsProject
{
    partial class uclInfo
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConnection = new System.Windows.Forms.ComboBox();
            this.lblSourceValue = new System.Windows.Forms.Label();
            this.txbSourceValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbResponse = new System.Windows.Forms.ComboBox();
            this.txbVO = new System.Windows.Forms.TextBox();
            this.txbIO = new System.Windows.Forms.TextBox();
            this.txbC = new System.Windows.Forms.TextBox();
            this.txbL = new System.Windows.Forms.TextBox();
            this.txbR = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.cbConnection);
            this.gbInfo.Controls.Add(this.lblSourceValue);
            this.gbInfo.Controls.Add(this.txbSourceValue);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.cbResponse);
            this.gbInfo.Controls.Add(this.txbVO);
            this.gbInfo.Controls.Add(this.txbIO);
            this.gbInfo.Controls.Add(this.txbC);
            this.gbInfo.Controls.Add(this.txbL);
            this.gbInfo.Controls.Add(this.txbR);
            this.gbInfo.Location = new System.Drawing.Point(4, 4);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfo.Size = new System.Drawing.Size(1063, 309);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Data";
            this.gbInfo.Enter += new System.EventHandler(this.gb_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(838, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Io:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "L:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Connection:";
            // 
            // cbConnection
            // 
            this.cbConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConnection.FormattingEnabled = true;
            this.cbConnection.Items.AddRange(new object[] {
            "Series",
            "Parallel"});
            this.cbConnection.Location = new System.Drawing.Point(239, 204);
            this.cbConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConnection.Name = "cbConnection";
            this.cbConnection.Size = new System.Drawing.Size(185, 33);
            this.cbConnection.TabIndex = 12;
            // 
            // lblSourceValue
            // 
            this.lblSourceValue.AutoSize = true;
            this.lblSourceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSourceValue.Location = new System.Drawing.Point(523, 116);
            this.lblSourceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceValue.Name = "lblSourceValue";
            this.lblSourceValue.Size = new System.Drawing.Size(135, 28);
            this.lblSourceValue.TabIndex = 11;
            this.lblSourceValue.Text = "Source Value:";
            this.lblSourceValue.Visible = false;
            // 
            // txbSourceValue
            // 
            this.txbSourceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSourceValue.Location = new System.Drawing.Point(714, 115);
            this.txbSourceValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSourceValue.Name = "txbSourceValue";
            this.txbSourceValue.Size = new System.Drawing.Size(157, 31);
            this.txbSourceValue.TabIndex = 10;
            this.txbSourceValue.Text = "0";
            this.txbSourceValue.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Response:";
            // 
            // cbResponse
            // 
            this.cbResponse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponse.FormattingEnabled = true;
            this.cbResponse.Items.AddRange(new object[] {
            "Natural",
            "Step"});
            this.cbResponse.Location = new System.Drawing.Point(239, 115);
            this.cbResponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbResponse.Name = "cbResponse";
            this.cbResponse.Size = new System.Drawing.Size(185, 33);
            this.cbResponse.TabIndex = 8;
            this.cbResponse.SelectedIndexChanged += new System.EventHandler(this.cbResponse_SelectedIndexChanged);
            // 
            // txbVO
            // 
            this.txbVO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVO.Location = new System.Drawing.Point(885, 29);
            this.txbVO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbVO.Name = "txbVO";
            this.txbVO.Size = new System.Drawing.Size(127, 31);
            this.txbVO.TabIndex = 6;
            this.txbVO.Text = "0";
            // 
            // txbIO
            // 
            this.txbIO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIO.Location = new System.Drawing.Point(671, 29);
            this.txbIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbIO.Name = "txbIO";
            this.txbIO.Size = new System.Drawing.Size(127, 31);
            this.txbIO.TabIndex = 3;
            this.txbIO.Text = "0";
            // 
            // txbC
            // 
            this.txbC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbC.Location = new System.Drawing.Point(458, 29);
            this.txbC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbC.Name = "txbC";
            this.txbC.Size = new System.Drawing.Size(127, 31);
            this.txbC.TabIndex = 2;
            this.txbC.Text = "0";
            // 
            // txbL
            // 
            this.txbL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbL.Location = new System.Drawing.Point(255, 29);
            this.txbL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbL.Name = "txbL";
            this.txbL.Size = new System.Drawing.Size(127, 31);
            this.txbL.TabIndex = 1;
            this.txbL.Text = "0";
            // 
            // txbR
            // 
            this.txbR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbR.Location = new System.Drawing.Point(48, 29);
            this.txbR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbR.Name = "txbR";
            this.txbR.Size = new System.Drawing.Size(127, 31);
            this.txbR.TabIndex = 0;
            this.txbR.Text = "0";
            this.txbR.TextChanged += new System.EventHandler(this.txbR_TextChanged);
            // 
            // uclInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uclInfo";
            this.Size = new System.Drawing.Size(1067, 316);
            this.Load += new System.EventHandler(this.Info_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gbInfo;
        public System.Windows.Forms.TextBox txbR;
        public System.Windows.Forms.TextBox txbIO;
        public System.Windows.Forms.TextBox txbC;
        public System.Windows.Forms.TextBox txbL;
        public System.Windows.Forms.TextBox txbVO;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbResponse;
        public System.Windows.Forms.Label lblSourceValue;
        public System.Windows.Forms.TextBox txbSourceValue;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbConnection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
