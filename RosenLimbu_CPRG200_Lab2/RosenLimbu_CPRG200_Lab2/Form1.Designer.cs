namespace RosenLimbu_CPRG200_Lab2
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
            this.components = new System.ComponentModel.Container();
            this.grpDataInput = new System.Windows.Forms.GroupBox();
            this.txtOffPeakKWH = new System.Windows.Forms.TextBox();
            this.txtPeakKWH = new System.Windows.Forms.TextBox();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.lblPeak = new System.Windows.Forms.Label();
            this.cmbCustType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKWH = new System.Windows.Forms.TextBox();
            this.lblKWH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDirectory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDataOutput = new System.Windows.Forms.GroupBox();
            this.txtTotalInd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalComm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalCharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalCust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpDataInput.SuspendLayout();
            this.grpDataOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDataInput
            // 
            this.grpDataInput.Controls.Add(this.txtOffPeakKWH);
            this.grpDataInput.Controls.Add(this.txtPeakKWH);
            this.grpDataInput.Controls.Add(this.lblOffPeak);
            this.grpDataInput.Controls.Add(this.lblPeak);
            this.grpDataInput.Controls.Add(this.cmbCustType);
            this.grpDataInput.Controls.Add(this.btnReset);
            this.grpDataInput.Controls.Add(this.btnAdd);
            this.grpDataInput.Controls.Add(this.txtKWH);
            this.grpDataInput.Controls.Add(this.lblKWH);
            this.grpDataInput.Controls.Add(this.label4);
            this.grpDataInput.Controls.Add(this.txtCustName);
            this.grpDataInput.Controls.Add(this.label3);
            this.grpDataInput.Controls.Add(this.txtAcctNo);
            this.grpDataInput.Controls.Add(this.label1);
            this.grpDataInput.Location = new System.Drawing.Point(40, 47);
            this.grpDataInput.Name = "grpDataInput";
            this.grpDataInput.Size = new System.Drawing.Size(349, 345);
            this.grpDataInput.TabIndex = 0;
            this.grpDataInput.TabStop = false;
            this.grpDataInput.Text = "Customer Information";
            // 
            // txtOffPeakKWH
            // 
            this.txtOffPeakKWH.Location = new System.Drawing.Point(179, 238);
            this.txtOffPeakKWH.Name = "txtOffPeakKWH";
            this.txtOffPeakKWH.Size = new System.Drawing.Size(117, 20);
            this.txtOffPeakKWH.TabIndex = 15;
            this.txtOffPeakKWH.Visible = false;
            // 
            // txtPeakKWH
            // 
            this.txtPeakKWH.Location = new System.Drawing.Point(179, 204);
            this.txtPeakKWH.Name = "txtPeakKWH";
            this.txtPeakKWH.Size = new System.Drawing.Size(117, 20);
            this.txtPeakKWH.TabIndex = 14;
            this.txtPeakKWH.Visible = false;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(42, 245);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(100, 13);
            this.lblOffPeak.TabIndex = 13;
            this.lblOffPeak.Text = "Off-Peak Hrs KWH:";
            this.lblOffPeak.Visible = false;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Location = new System.Drawing.Point(46, 211);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(83, 13);
            this.lblPeak.TabIndex = 12;
            this.lblPeak.Text = "Peak Hrs KWH:";
            this.lblPeak.Visible = false;
            // 
            // cmbCustType
            // 
            this.cmbCustType.FormattingEnabled = true;
            this.cmbCustType.Location = new System.Drawing.Point(179, 125);
            this.cmbCustType.Name = "cmbCustType";
            this.cmbCustType.Size = new System.Drawing.Size(117, 21);
            this.cmbCustType.TabIndex = 10;
            this.cmbCustType.SelectedIndexChanged += new System.EventHandler(this.cmbCustType_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(233, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 37);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(70, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKWH
            // 
            this.txtKWH.Location = new System.Drawing.Point(179, 172);
            this.txtKWH.Name = "txtKWH";
            this.txtKWH.Size = new System.Drawing.Size(117, 20);
            this.txtKWH.TabIndex = 7;
            // 
            // lblKWH
            // 
            this.lblKWH.AutoSize = true;
            this.lblKWH.Location = new System.Drawing.Point(79, 179);
            this.lblKWH.Name = "lblKWH";
            this.lblKWH.Size = new System.Drawing.Size(36, 13);
            this.lblKWH.TabIndex = 6;
            this.lblKWH.Text = "KWH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Type:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(179, 84);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(117, 20);
            this.txtCustName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name:";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(179, 44);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(117, 20);
            this.txtAcctNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // lstDirectory
            // 
            this.lstDirectory.FormattingEnabled = true;
            this.lstDirectory.Location = new System.Drawing.Point(521, 76);
            this.lstDirectory.Name = "lstDirectory";
            this.lstDirectory.Size = new System.Drawing.Size(452, 264);
            this.lstDirectory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Information:";
            // 
            // grpDataOutput
            // 
            this.grpDataOutput.Controls.Add(this.txtTotalInd);
            this.grpDataOutput.Controls.Add(this.label10);
            this.grpDataOutput.Controls.Add(this.txtTotalComm);
            this.grpDataOutput.Controls.Add(this.label9);
            this.grpDataOutput.Controls.Add(this.txtTotalRes);
            this.grpDataOutput.Controls.Add(this.label8);
            this.grpDataOutput.Controls.Add(this.txtTotalCharge);
            this.grpDataOutput.Controls.Add(this.label7);
            this.grpDataOutput.Controls.Add(this.txtTotalCust);
            this.grpDataOutput.Controls.Add(this.label6);
            this.grpDataOutput.Location = new System.Drawing.Point(40, 412);
            this.grpDataOutput.Name = "grpDataOutput";
            this.grpDataOutput.Size = new System.Drawing.Size(834, 138);
            this.grpDataOutput.TabIndex = 3;
            this.grpDataOutput.TabStop = false;
            this.grpDataOutput.Text = "Detailed Data Information";
            // 
            // txtTotalInd
            // 
            this.txtTotalInd.Location = new System.Drawing.Point(696, 102);
            this.txtTotalInd.Name = "txtTotalInd";
            this.txtTotalInd.Size = new System.Drawing.Size(117, 20);
            this.txtTotalInd.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Total Industrial Charge:";
            // 
            // txtTotalComm
            // 
            this.txtTotalComm.Location = new System.Drawing.Point(696, 66);
            this.txtTotalComm.Name = "txtTotalComm";
            this.txtTotalComm.Size = new System.Drawing.Size(117, 20);
            this.txtTotalComm.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Commercial Charge:";
            // 
            // txtTotalRes
            // 
            this.txtTotalRes.Location = new System.Drawing.Point(696, 28);
            this.txtTotalRes.Name = "txtTotalRes";
            this.txtTotalRes.Size = new System.Drawing.Size(117, 20);
            this.txtTotalRes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Residential Charge:";
            // 
            // txtTotalCharge
            // 
            this.txtTotalCharge.Location = new System.Drawing.Point(232, 102);
            this.txtTotalCharge.Name = "txtTotalCharge";
            this.txtTotalCharge.Size = new System.Drawing.Size(117, 20);
            this.txtTotalCharge.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Charge:";
            // 
            // txtTotalCust
            // 
            this.txtTotalCust.Location = new System.Drawing.Point(232, 28);
            this.txtTotalCust.Name = "txtTotalCust";
            this.txtTotalCust.Size = new System.Drawing.Size(117, 20);
            this.txtTotalCust.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Number of Customers:";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 620);
            this.Controls.Add(this.grpDataOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDirectory);
            this.Controls.Add(this.grpDataInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDataInput.ResumeLayout(false);
            this.grpDataInput.PerformLayout();
            this.grpDataOutput.ResumeLayout(false);
            this.grpDataOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDataInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.ListBox lstDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKWH;
        private System.Windows.Forms.Label lblKWH;
        private System.Windows.Forms.GroupBox grpDataOutput;
        private System.Windows.Forms.TextBox txtTotalInd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalComm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustType;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtOffPeakKWH;
        private System.Windows.Forms.TextBox txtPeakKWH;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

