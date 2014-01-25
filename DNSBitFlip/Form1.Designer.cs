namespace DNSBitFlip
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnFlipNoValidate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain:";
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(66, 13);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(261, 20);
            this.txtDomainName.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(15, 39);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(312, 186);
            this.txtOutput.TabIndex = 2;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(15, 232);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(102, 23);
            this.btnFlip.TabIndex = 3;
            this.btnFlip.Text = "Flip And Validate";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnFlipNoValidate
            // 
            this.btnFlipNoValidate.Location = new System.Drawing.Point(123, 231);
            this.btnFlipNoValidate.Name = "btnFlipNoValidate";
            this.btnFlipNoValidate.Size = new System.Drawing.Size(102, 23);
            this.btnFlipNoValidate.TabIndex = 4;
            this.btnFlipNoValidate.Text = "Flip No Validate";
            this.btnFlipNoValidate.UseVisualStyleBackColor = true;
            this.btnFlipNoValidate.Click += new System.EventHandler(this.btnFlipNoValidate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblMessage
            // 
            this.tsLblMessage.Name = "tsLblMessage";
            this.tsLblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFlipNoValidate);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DNS Bit Flip Calculator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnFlipNoValidate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblMessage;
    }
}

