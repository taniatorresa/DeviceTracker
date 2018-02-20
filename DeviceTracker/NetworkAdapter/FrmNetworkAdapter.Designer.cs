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
            this.stsMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNetworkAdapters
            // 
            this.grpNetworkAdapters.Location = new System.Drawing.Point(13, 22);
            this.grpNetworkAdapters.Name = "grpNetworkAdapters";
            this.grpNetworkAdapters.Size = new System.Drawing.Size(624, 247);
            this.grpNetworkAdapters.TabIndex = 0;
            this.grpNetworkAdapters.TabStop = false;
            this.grpNetworkAdapters.Text = "Adapatdores de Red";
            // 
            // stsMessage
            // 
            this.stsMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbResult});
            this.stsMessage.Location = new System.Drawing.Point(0, 320);
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(649, 22);
            this.stsMessage.TabIndex = 1;
            this.stsMessage.Text = "statusStrip1";
            // 
            // tsslbResult
            // 
            this.tsslbResult.Name = "tsslbResult";
            this.tsslbResult.Size = new System.Drawing.Size(0, 17);
            this.tsslbResult.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // FrmNetworkAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 342);
            this.Controls.Add(this.stsMessage);
            this.Controls.Add(this.grpNetworkAdapters);
            this.Name = "FrmNetworkAdapter";
            this.Text = "NetworkAdapter";
            this.stsMessage.ResumeLayout(false);
            this.stsMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNetworkAdapters;
        private System.Windows.Forms.StatusStrip stsMessage;
        private System.Windows.Forms.ToolStripStatusLabel tsslbResult;
    }
}