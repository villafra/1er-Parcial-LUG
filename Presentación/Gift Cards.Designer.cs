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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblProvPais = new System.Windows.Forms.Label();
            this.comboAlcance = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboRubro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numSaldo = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaCreación = new System.Windows.Forms.DateTimePicker();
            this.txtPaisProv = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).BeginInit();
            this.grpGiftCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).BeginInit();
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
            this.dgvGiftCards.Size = new System.Drawing.Size(679, 466);
            this.dgvGiftCards.TabIndex = 0;
            this.dgvGiftCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiftCards_CellContentClick);
            // 
            // grpGiftCards
            // 
            this.grpGiftCards.Controls.Add(this.txtEstado);
            this.grpGiftCards.Controls.Add(this.lblProvPais);
            this.grpGiftCards.Controls.Add(this.comboAlcance);
            this.grpGiftCards.Controls.Add(this.label7);
            this.grpGiftCards.Controls.Add(this.ComboRubro);
            this.grpGiftCards.Controls.Add(this.label3);
            this.grpGiftCards.Controls.Add(this.label6);
            this.grpGiftCards.Controls.Add(this.numSaldo);
            this.grpGiftCards.Controls.Add(this.dtpFechaCreación);
            this.grpGiftCards.Controls.Add(this.txtPaisProv);
            this.grpGiftCards.Controls.Add(this.txtCodigo);
            this.grpGiftCards.Controls.Add(this.label5);
            this.grpGiftCards.Controls.Add(this.label4);
            this.grpGiftCards.Controls.Add(this.label1);
            this.grpGiftCards.Location = new System.Drawing.Point(25, 27);
            this.grpGiftCards.Name = "grpGiftCards";
            this.grpGiftCards.Size = new System.Drawing.Size(367, 273);
            this.grpGiftCards.TabIndex = 1;
            this.grpGiftCards.TabStop = false;
            this.grpGiftCards.Text = "Gift Cards";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(210, 109);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(130, 22);
            this.txtEstado.TabIndex = 19;
            // 
            // lblProvPais
            // 
            this.lblProvPais.AutoSize = true;
            this.lblProvPais.Location = new System.Drawing.Point(251, 200);
            this.lblProvPais.Name = "lblProvPais";
            this.lblProvPais.Size = new System.Drawing.Size(63, 16);
            this.lblProvPais.TabIndex = 18;
            this.lblProvPais.Text = "Provincia";
            // 
            // comboAlcance
            // 
            this.comboAlcance.FormattingEnabled = true;
            this.comboAlcance.Location = new System.Drawing.Point(21, 218);
            this.comboAlcance.Name = "comboAlcance";
            this.comboAlcance.Size = new System.Drawing.Size(130, 24);
            this.comboAlcance.TabIndex = 17;
            this.comboAlcance.SelectedIndexChanged += new System.EventHandler(this.comboAlcance_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alcance";
            // 
            // ComboRubro
            // 
            this.ComboRubro.FormattingEnabled = true;
            this.ComboRubro.Location = new System.Drawing.Point(119, 165);
            this.ComboRubro.Name = "ComboRubro";
            this.ComboRubro.Size = new System.Drawing.Size(129, 24);
            this.ComboRubro.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rubro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // numSaldo
            // 
            this.numSaldo.DecimalPlaces = 2;
            this.numSaldo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSaldo.Location = new System.Drawing.Point(21, 109);
            this.numSaldo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numSaldo.Name = "numSaldo";
            this.numSaldo.Size = new System.Drawing.Size(130, 22);
            this.numSaldo.TabIndex = 10;
            this.numSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaCreación
            // 
            this.dtpFechaCreación.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaCreación.Enabled = false;
            this.dtpFechaCreación.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCreación.Location = new System.Drawing.Point(200, 45);
            this.dtpFechaCreación.Name = "dtpFechaCreación";
            this.dtpFechaCreación.Size = new System.Drawing.Size(129, 22);
            this.dtpFechaCreación.TabIndex = 9;
            // 
            // txtPaisProv
            // 
            this.txtPaisProv.Location = new System.Drawing.Point(199, 220);
            this.txtPaisProv.Name = "txtPaisProv";
            this.txtPaisProv.Size = new System.Drawing.Size(162, 22);
            this.txtPaisProv.TabIndex = 8;
            this.txtPaisProv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaisProv_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(21, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 90);
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
            this.ClientSize = new System.Drawing.Size(1089, 490);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpGiftCards);
            this.Controls.Add(this.dgvGiftCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiftCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clientes";
            this.Activated += new System.EventHandler(this.frmGiftCards_Activated);
            this.Load += new System.EventHandler(this.frmGiftCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).EndInit();
            this.grpGiftCards.ResumeLayout(false);
            this.grpGiftCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiftCards;
        private System.Windows.Forms.GroupBox grpGiftCards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCreación;
        private System.Windows.Forms.TextBox txtPaisProv;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox ComboRubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSaldo;
        private System.Windows.Forms.Label lblProvPais;
        private System.Windows.Forms.ComboBox comboAlcance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
    }
}