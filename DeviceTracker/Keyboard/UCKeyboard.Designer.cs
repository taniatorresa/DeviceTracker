namespace DeviceTracker.Keyboard
{
    partial class UCKeyboard
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pctKeyboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctKeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(51, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(234, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "label2";
            // 
            // pctKeyboard
            // 
            this.pctKeyboard.Location = new System.Drawing.Point(13, 13);
            this.pctKeyboard.Name = "pctKeyboard";
            this.pctKeyboard.Size = new System.Drawing.Size(22, 23);
            this.pctKeyboard.TabIndex = 3;
            this.pctKeyboard.TabStop = false;
            // 
            // UCKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctKeyboard);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbName);
            this.Name = "UCKeyboard";
            this.Size = new System.Drawing.Size(415, 39);
            this.Load += new System.EventHandler(this.UCKeyboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctKeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox pctKeyboard;
    }
}
