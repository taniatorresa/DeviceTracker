namespace DeviceTracker.NetworkAdapter
{
    partial class UCNetworkAdapter
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctNetworkAdapter = new System.Windows.Forms.PictureBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.btnEnableDisable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctNetworkAdapter)).BeginInit();
            this.SuspendLayout();
            // 
            // pctNetworkAdapter
            // 
            this.pctNetworkAdapter.Location = new System.Drawing.Point(15, 3);
            this.pctNetworkAdapter.Name = "pctNetworkAdapter";
            this.pctNetworkAdapter.Size = new System.Drawing.Size(20, 20);
            this.pctNetworkAdapter.TabIndex = 0;
            this.pctNetworkAdapter.TabStop = false;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(41, 10);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(248, 13);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "label1                                                                       ";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Location = new System.Drawing.Point(254, 10);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(35, 13);
            this.lbConnectionStatus.TabIndex = 2;
            this.lbConnectionStatus.Text = "label2";
            // 
            // btnEnableDisable
            // 
            this.btnEnableDisable.Location = new System.Drawing.Point(400, 5);
            this.btnEnableDisable.Name = "btnEnableDisable";
            this.btnEnableDisable.Size = new System.Drawing.Size(75, 23);
            this.btnEnableDisable.TabIndex = 3;
            this.btnEnableDisable.Text = "button1";
            this.btnEnableDisable.UseVisualStyleBackColor = true;
            // 
            // UCNetworkAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnableDisable);
            this.Controls.Add(this.lbConnectionStatus);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.pctNetworkAdapter);
            this.Name = "UCNetworkAdapter";
            this.Size = new System.Drawing.Size(551, 33);
            ((System.ComponentModel.ISupportInitialize)(this.pctNetworkAdapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctNetworkAdapter;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Button btnEnableDisable;
    }
}
