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
            this.Teclados = new System.Windows.Forms.TabPage();
            this.tabControlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.Adaptador);
            this.tabControlMenu.Controls.Add(this.Teclados);
            this.tabControlMenu.Location = new System.Drawing.Point(24, 12);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(984, 463);
            this.tabControlMenu.TabIndex = 0;
            // 
            // Adaptador
            // 
            this.Adaptador.Location = new System.Drawing.Point(4, 22);
            this.Adaptador.Name = "Adaptador";
            this.Adaptador.Padding = new System.Windows.Forms.Padding(3);
            this.Adaptador.Size = new System.Drawing.Size(976, 437);
            this.Adaptador.TabIndex = 0;
            this.Adaptador.Text = "Adaptadores de Red";
            this.Adaptador.UseVisualStyleBackColor = true;
            this.Adaptador.Click += new System.EventHandler(this.Adaptador_Click);
            // 
            // Teclados
            // 
            this.Teclados.Location = new System.Drawing.Point(4, 22);
            this.Teclados.Name = "Teclados";
            this.Teclados.Padding = new System.Windows.Forms.Padding(3);
            this.Teclados.Size = new System.Drawing.Size(976, 437);
            this.Teclados.TabIndex = 1;
            this.Teclados.Text = "Teclados";
            this.Teclados.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 501);
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
        private System.Windows.Forms.TabPage Teclados;
    }
}

