namespace Presentación
{
    partial class frmGiftCards
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
            this.dgvGiftCards = new System.Windows.Forms.DataGridView();
            this.grpGiftCards = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).BeginInit();
            this.grpGiftCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiftCards
            // 
            this.dgvGiftCards.AllowUserToAddRows = false;
            this.dgvGiftCards.AllowUserToDeleteRows = false;
            this.dgvGiftCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiftCards.Location = new System.Drawing.Point(398, 12);
            this.dgvGiftCards.Name = "dgvGiftCards";
            this.dgvGiftCards.ReadOnly = true;
            this.dgvGiftCards.RowHeadersWidth = 51;
            this.dgvGiftCards.RowTemplate.Height = 24;
            this.dgvGiftCards.Size = new System.Drawing.Size(888, 466);
            this.dgvGiftCards.TabIndex = 0;
            this.dgvGiftCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // grpGiftCards
            // 
            this.grpGiftCards.Controls.Add(this.dtpFechaNac);
            this.grpGiftCards.Controls.Add(this.txtApellido);
            this.grpGiftCards.Controls.Add(this.txtNombre);
            this.grpGiftCards.Controls.Add(this.txtLegajo);
            this.grpGiftCards.Controls.Add(this.label5);
            this.grpGiftCards.Controls.Add(this.label4);
            this.grpGiftCards.Controls.Add(this.label2);
            this.grpGiftCards.Controls.Add(this.label1);
            this.grpGiftCards.Location = new System.Drawing.Point(25, 27);
            this.grpGiftCards.Name = "grpGiftCards";
            this.grpGiftCards.Size = new System.Drawing.Size(367, 273);
            this.grpGiftCards.TabIndex = 1;
            this.grpGiftCards.TabStop = false;
            this.grpGiftCards.Text = "Gift Cards";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(211, 66);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(129, 22);
            this.dtpFechaNac.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(199, 196);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(162, 22);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(8, 196);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(21, 66);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(130, 22);
            this.txtLegajo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Otorgación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(144, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nueva Gift Card";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(31, 377);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Gift Card";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(263, 377);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Gift Card";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmGiftCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 490);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpGiftCards);
            this.Controls.Add(this.dgvGiftCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiftCards";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).EndInit();
            this.grpGiftCards.ResumeLayout(false);
            this.grpGiftCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiftCards;
        private System.Windows.Forms.GroupBox grpGiftCards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}