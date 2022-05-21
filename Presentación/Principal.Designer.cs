namespace Presentación
{
    partial class frmPrincipal
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
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giftCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.giftCardsToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(1308, 28);
            this.StripMenu.TabIndex = 1;
            this.StripMenu.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asociacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // giftCardsToolStripMenuItem
            // 
            this.giftCardsToolStripMenuItem.Name = "giftCardsToolStripMenuItem";
            this.giftCardsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.giftCardsToolStripMenuItem.Text = "Gift Cards";
            this.giftCardsToolStripMenuItem.Click += new System.EventHandler(this.giftCardsToolStripMenuItem_Click);
            // 
            // asociacionesToolStripMenuItem
            // 
            this.asociacionesToolStripMenuItem.Name = "asociacionesToolStripMenuItem";
            this.asociacionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asociacionesToolStripMenuItem.Text = "Asociaciones";
            this.asociacionesToolStripMenuItem.Click += new System.EventHandler(this.asociacionesToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 528);
            this.Controls.Add(this.StripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.StripMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1er Parcial LUG";
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giftCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociacionesToolStripMenuItem;
    }
}

