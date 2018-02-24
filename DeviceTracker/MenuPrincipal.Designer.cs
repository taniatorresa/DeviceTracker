namespace DeviceTracker
{
    partial class MenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.Adaptador = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.Adaptador);
            this.tabControlMenu.Controls.Add(this.tabPage2);
            this.tabControlMenu.Location = new System.Drawing.Point(22, 12);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(949, 463);
            this.tabControlMenu.TabIndex = 0;
            // 
            // Adaptador
            // 
            this.Adaptador.Location = new System.Drawing.Point(4, 22);
            this.Adaptador.Name = "Adaptador";
            this.Adaptador.Padding = new System.Windows.Forms.Padding(3);
            this.Adaptador.Size = new System.Drawing.Size(941, 437);
            this.Adaptador.TabIndex = 0;
            this.Adaptador.Text = "Adaptadores de Red";
            this.Adaptador.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teclados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 501);
            this.Controls.Add(this.tabControlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "DeviceTracker";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage Adaptador;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

