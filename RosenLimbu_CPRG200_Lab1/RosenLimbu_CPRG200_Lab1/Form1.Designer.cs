namespace RosenLimbu_CPRG200_Lab1
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
            this.grpCustomerType = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.lblKWH = new System.Windows.Forms.Label();
            this.txtResidential = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCommerce = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.lblPeak = new System.Windows.Forms.Label();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.grpCustomerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Controls.Add(this.radIndustrial);
            this.grpCustomerType.Controls.Add(this.radCommercial);
            this.grpCustomerType.Controls.Add(this.radResidential);
            this.grpCustomerType.Location = new System.Drawing.Point(47, 50);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Size = new System.Drawing.Size(167, 151);
            this.grpCustomerType.TabIndex = 0;
            this.grpCustomerType.TabStop = false;
            this.grpCustomerType.Text = "Customer Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(32, 88);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(67, 17);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(32, 65);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(79, 17);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Location = new System.Drawing.Point(32, 42);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(77, 17);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // lblKWH
            // 
            this.lblKWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWH.Location = new System.Drawing.Point(438, 70);
            this.lblKWH.Name = "lblKWH";
            this.lblKWH.Size = new System.Drawing.Size(55, 20);
            this.lblKWH.TabIndex = 1;
            this.lblKWH.Text = "KWH:";
            // 
            // txtResidential
            // 
            this.txtResidential.Location = new System.Drawing.Point(537, 72);
            this.txtResidential.Name = "txtResidential";
            this.txtResidential.Size = new System.Drawing.Size(120, 20);
            this.txtResidential.TabIndex = 2;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(537, 218);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(120, 20);
            this.txtTotalBill.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount Due";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(69, 292);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 43);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(297, 292);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 43);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(512, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 43);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCommerce
            // 
            this.txtCommerce.Location = new System.Drawing.Point(537, 72);
            this.txtCommerce.Name = "txtCommerce";
            this.txtCommerce.Size = new System.Drawing.Size(120, 20);
            this.txtCommerce.TabIndex = 8;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(537, 124);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(120, 20);
            this.txtPeak.TabIndex = 9;
            this.txtPeak.Visible = false;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(374, 122);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(119, 20);
            this.lblPeak.TabIndex = 10;
            this.lblPeak.Text = "Peak Hrs KWH:";
            this.lblPeak.Visible = false;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(537, 150);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(120, 20);
            this.txtOffPeak.TabIndex = 11;
            this.txtOffPeak.Visible = false;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeak.Location = new System.Drawing.Point(347, 148);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(146, 20);
            this.lblOffPeak.TabIndex = 12;
            this.lblOffPeak.Text = "Off-Peak Hrs KWH:";
            this.lblOffPeak.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 392);
            this.Controls.Add(this.lblOffPeak);
            this.Controls.Add(this.txtOffPeak);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.txtCommerce);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.txtResidential);
            this.Controls.Add(this.lblKWH);
            this.Controls.Add(this.grpCustomerType);
            this.Name = "Form1";
            this.Text = "Your Billing Information";
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerType;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Label lblKWH;
        private System.Windows.Forms.TextBox txtResidential;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCommerce;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.Label lblOffPeak;
    }
}

