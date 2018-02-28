namespace DeviceTracker.NetworkAdapter
{
    partial class FrmNetworkAdapter
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
            this.grpNetworkAdapters = new System.Windows.Forms.GroupBox();
            this.stsMessage = new System.Windows.Forms.StatusStrip();
            this.tsslbResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stsMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNetworkAdapters
            // 
            this.grpNetworkAdapters.Location = new System.Drawing.Point(13, 22);
            this.grpNetworkAdapters.Name = "grpNetworkAdapters";
            this.grpNetworkAdapters.Size = new System.Drawing.Size(590, 247);
            this.grpNetworkAdapters.TabIndex = 0;
            this.grpNetworkAdapters.TabStop = false;
            this.grpNetworkAdapters.Text = "Adapatdores de Red";
            this.grpNetworkAdapters.Enter += new System.EventHandler(this.grpNetworkAdapters_Enter);
            // 
            // stsMessage
            // 
            this.stsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbResult});
            this.stsMessage.Location = new System.Drawing.Point(0, 320);
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(958, 22);
            this.stsMessage.TabIndex = 1;
            this.stsMessage.Text = "statusStrip1";
            // 
            // tsslbResult
            // 
            this.tsslbResult.Name = "tsslbResult";
            this.tsslbResult.Size = new System.Drawing.Size(0, 17);
            this.tsslbResult.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(609, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 247);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // FrmNetworkAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stsMessage);
            this.Controls.Add(this.grpNetworkAdapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNetworkAdapter";
            this.Text = "FrmNetworkAdapter";
            this.Load += new System.EventHandler(this.FrmNetworkAdapter_Load);
            this.stsMessage.ResumeLayout(false);
            this.stsMessage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNetworkAdapters;
        private System.Windows.Forms.StatusStrip stsMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsslbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}