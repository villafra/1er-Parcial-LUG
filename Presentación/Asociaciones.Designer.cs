namespace Presentación
{
    partial class frmAsociaciones
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAsociarGiftCard = new System.Windows.Forms.Button();
            this.btnDesasociarGiftCard = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnCargarCompraCliente = new System.Windows.Forms.Button();
            this.btnEditCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBajaGiftCard = new System.Windows.Forms.Button();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.grpCompras = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.grpCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiftCards
            // 
            this.dgvGiftCards.AllowUserToAddRows = false;
            this.dgvGiftCards.AllowUserToDeleteRows = false;
            this.dgvGiftCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiftCards.Location = new System.Drawing.Point(677, 53);
            this.dgvGiftCards.Name = "dgvGiftCards";
            this.dgvGiftCards.ReadOnly = true;
            this.dgvGiftCards.RowHeadersWidth = 51;
            this.dgvGiftCards.RowTemplate.Height = 24;
            this.dgvGiftCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiftCards.Size = new System.Drawing.Size(400, 318);
            this.dgvGiftCards.TabIndex = 1;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(338, 53);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(333, 318);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // btnAsociarGiftCard
            // 
            this.btnAsociarGiftCard.Location = new System.Drawing.Point(815, 390);
            this.btnAsociarGiftCard.Name = "btnAsociarGiftCard";
            this.btnAsociarGiftCard.Size = new System.Drawing.Size(144, 23);
            this.btnAsociarGiftCard.TabIndex = 6;
            this.btnAsociarGiftCard.Text = "Asociar Gift Card";
            this.btnAsociarGiftCard.UseVisualStyleBackColor = true;
            this.btnAsociarGiftCard.Click += new System.EventHandler(this.btnAsociarGiftCard_Click);
            // 
            // btnDesasociarGiftCard
            // 
            this.btnDesasociarGiftCard.Location = new System.Drawing.Point(815, 454);
            this.btnDesasociarGiftCard.Name = "btnDesasociarGiftCard";
            this.btnDesasociarGiftCard.Size = new System.Drawing.Size(144, 23);
            this.btnDesasociarGiftCard.TabIndex = 7;
            this.btnDesasociarGiftCard.Text = "Desasociar Gift Card";
            this.btnDesasociarGiftCard.UseVisualStyleBackColor = true;
            this.btnDesasociarGiftCard.Click += new System.EventHandler(this.btnDesasociarGiftCard_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(12, 53);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(320, 318);
            this.dgvCompras.TabIndex = 8;
            // 
            // btnCargarCompraCliente
            // 
            this.btnCargarCompraCliente.Location = new System.Drawing.Point(188, 390);
            this.btnCargarCompraCliente.Name = "btnCargarCompraCliente";
            this.btnCargarCompraCliente.Size = new System.Drawing.Size(144, 23);
            this.btnCargarCompraCliente.TabIndex = 9;
            this.btnCargarCompraCliente.Text = "Cargar Compra";
            this.btnCargarCompraCliente.UseVisualStyleBackColor = true;
            this.btnCargarCompraCliente.Click += new System.EventHandler(this.btnCargarCompraCliente_Click);
            // 
            // btnEditCompra
            // 
            this.btnEditCompra.Location = new System.Drawing.Point(188, 422);
            this.btnEditCompra.Name = "btnEditCompra";
            this.btnEditCompra.Size = new System.Drawing.Size(144, 23);
            this.btnEditCompra.TabIndex = 10;
            this.btnEditCompra.Text = "Modificar Compra";
            this.btnEditCompra.UseVisualStyleBackColor = true;
            this.btnEditCompra.Click += new System.EventHandler(this.btnEditCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Listado de Gift Cards Libres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Compras Cliente";
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Location = new System.Drawing.Point(188, 454);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(144, 23);
            this.btnEliminarCompra.TabIndex = 14;
            this.btnEliminarCompra.Text = "Eliminar Compra";
            this.btnEliminarCompra.UseVisualStyleBackColor = true;
            this.btnEliminarCompra.Click += new System.EventHandler(this.btnEliminarCompra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saldo Gift Card:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(606, 390);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(32, 25);
            this.lblSaldo.TabIndex = 18;
            this.lblSaldo.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Estado Gift Card:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(619, 423);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 25);
            this.lblEstado.TabIndex = 20;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(606, 456);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(0, 25);
            this.lblFechaVencimiento.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha de Vencimiento";
            // 
            // btnBajaGiftCard
            // 
            this.btnBajaGiftCard.Location = new System.Drawing.Point(22, 454);
            this.btnBajaGiftCard.Name = "btnBajaGiftCard";
            this.btnBajaGiftCard.Size = new System.Drawing.Size(144, 23);
            this.btnBajaGiftCard.TabIndex = 23;
            this.btnBajaGiftCard.Text = "Baja Gift Card";
            this.btnBajaGiftCard.UseVisualStyleBackColor = true;
            this.btnBajaGiftCard.Click += new System.EventHandler(this.btnBajaGiftCard_Click);
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMonto.Location = new System.Drawing.Point(10, 39);
            this.numMonto.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(144, 22);
            this.numMonto.TabIndex = 24;
            this.numMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpCompras
            // 
            this.grpCompras.Controls.Add(this.numMonto);
            this.grpCompras.Controls.Add(this.label4);
            this.grpCompras.Location = new System.Drawing.Point(12, 378);
            this.grpCompras.Name = "grpCompras";
            this.grpCompras.Size = new System.Drawing.Size(170, 67);
            this.grpCompras.TabIndex = 25;
            this.grpCompras.TabStop = false;
            this.grpCompras.Text = "Compras";
            // 
            // frmAsociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 490);
            this.Controls.Add(this.btnBajaGiftCard);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCompra);
            this.Controls.Add(this.btnCargarCompraCliente);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnDesasociarGiftCard);
            this.Controls.Add(this.btnAsociarGiftCard);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dgvGiftCards);
            this.Controls.Add(this.grpCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsociaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asociaciones";
            this.Activated += new System.EventHandler(this.frmAsociaciones_Activated);
            this.Load += new System.EventHandler(this.frmAsociaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiftCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.grpCompras.ResumeLayout(false);
            this.grpCompras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiftCards;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAsociarGiftCard;
        private System.Windows.Forms.Button btnDesasociarGiftCard;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnCargarCompraCliente;
        private System.Windows.Forms.Button btnEditCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBajaGiftCard;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.GroupBox grpCompras;
    }
}