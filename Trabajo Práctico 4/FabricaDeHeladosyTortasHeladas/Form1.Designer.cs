
namespace FabricaDeHeladosyTortasHeladas
{
    partial class Form1
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clbListaDeGustos = new System.Windows.Forms.CheckedListBox();
            this.btnIniciarFabricacion = new System.Windows.Forms.Button();
            this.txbNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.cmbTipoDeProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblSeleccionGusto = new System.Windows.Forms.Label();
            this.lblNuevoPedido = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnPreparacion = new System.Windows.Forms.Label();
            this.dgvEnPreparacion = new System.Windows.Forms.DataGridView();
            this.numPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvFinalizados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(768, 585);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clbListaDeGustos
            // 
            this.clbListaDeGustos.FormattingEnabled = true;
            this.clbListaDeGustos.Location = new System.Drawing.Point(731, 213);
            this.clbListaDeGustos.Name = "clbListaDeGustos";
            this.clbListaDeGustos.Size = new System.Drawing.Size(241, 124);
            this.clbListaDeGustos.TabIndex = 1;
            this.clbListaDeGustos.SelectedIndexChanged += new System.EventHandler(this.clbListaDeGustos_SelectedIndexChanged);
            this.clbListaDeGustos.DoubleClick += new System.EventHandler(this.clbListaDeGustos_DoubleClick);
            // 
            // btnIniciarFabricacion
            // 
            this.btnIniciarFabricacion.Location = new System.Drawing.Point(898, 585);
            this.btnIniciarFabricacion.Name = "btnIniciarFabricacion";
            this.btnIniciarFabricacion.Size = new System.Drawing.Size(130, 38);
            this.btnIniciarFabricacion.TabIndex = 3;
            this.btnIniciarFabricacion.Text = "Iniciar Fabricación";
            this.btnIniciarFabricacion.UseVisualStyleBackColor = true;
            this.btnIniciarFabricacion.Click += new System.EventHandler(this.btnIniciarFabricacion_Click);
            // 
            // txbNombreEmpleado
            // 
            this.txbNombreEmpleado.Location = new System.Drawing.Point(779, 95);
            this.txbNombreEmpleado.Name = "txbNombreEmpleado";
            this.txbNombreEmpleado.Size = new System.Drawing.Size(136, 20);
            this.txbNombreEmpleado.TabIndex = 4;
            this.txbNombreEmpleado.TextChanged += new System.EventHandler(this.txbNombreEmpleado_TextChanged);
            this.txbNombreEmpleado.Leave += new System.EventHandler(this.txbNombreEmpleado_Leave);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(683, 98);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmpleado.TabIndex = 5;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(941, 544);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(1002, 544);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotal.TabIndex = 7;
            this.lblMontoTotal.Text = "0";
            // 
            // cmbTipoDeProducto
            // 
            this.cmbTipoDeProducto.FormattingEnabled = true;
            this.cmbTipoDeProducto.Location = new System.Drawing.Point(779, 127);
            this.cmbTipoDeProducto.Name = "cmbTipoDeProducto";
            this.cmbTipoDeProducto.Size = new System.Drawing.Size(136, 21);
            this.cmbTipoDeProducto.TabIndex = 8;
            this.cmbTipoDeProducto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedIndexChanged);
            this.cmbTipoDeProducto.SelectedValueChanged += new System.EventHandler(this.cmbTipoDeProducto_SelectedValueChanged);
            this.cmbTipoDeProducto.TextChanged += new System.EventHandler(this.cmbTipoDeProducto_TextChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(683, 130);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(78, 13);
            this.lblTipoProducto.TabIndex = 9;
            this.lblTipoProducto.Text = "Elegir producto";
            // 
            // lblSeleccionGusto
            // 
            this.lblSeleccionGusto.AutoSize = true;
            this.lblSeleccionGusto.Location = new System.Drawing.Point(802, 197);
            this.lblSeleccionGusto.Name = "lblSeleccionGusto";
            this.lblSeleccionGusto.Size = new System.Drawing.Size(97, 13);
            this.lblSeleccionGusto.TabIndex = 10;
            this.lblSeleccionGusto.Text = "Seleccionar gustos";
            // 
            // lblNuevoPedido
            // 
            this.lblNuevoPedido.AutoSize = true;
            this.lblNuevoPedido.Location = new System.Drawing.Point(802, 65);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(89, 13);
            this.lblNuevoPedido.TabIndex = 11;
            this.lblNuevoPedido.Text = "NUEVO PEDIDO";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPedido.Location = new System.Drawing.Point(731, 356);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(241, 23);
            this.btnAgregarPedido.TabIndex = 12;
            this.btnAgregarPedido.Text = "AGREGAR AL CARRITO";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tamaño";
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Location = new System.Drawing.Point(779, 162);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(136, 21);
            this.cmbTamanio.TabIndex = 19;
            this.cmbTamanio.SelectedValueChanged += new System.EventHandler(this.cmbTamanio_SelectedValueChanged);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeColumns = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroPedido,
            this.Tam,
            this.Tipo,
            this.precio,
            this.sabor,
            this.Sabor2,
            this.Sabor3,
            this.Sabor4});
            this.dgvCarrito.Location = new System.Drawing.Point(556, 428);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(532, 113);
            this.dgvCarrito.TabIndex = 20;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Numero Pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tam
            // 
            this.Tam.HeaderText = "Tamaño";
            this.Tam.Name = "Tam";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // sabor
            // 
            this.sabor.HeaderText = "Sabor1";
            this.sabor.Name = "sabor";
            // 
            // Sabor2
            // 
            this.Sabor2.HeaderText = "Sabor2";
            this.Sabor2.Name = "Sabor2";
            // 
            // Sabor3
            // 
            this.Sabor3.HeaderText = "Sabor3";
            this.Sabor3.Name = "Sabor3";
            // 
            // Sabor4
            // 
            this.Sabor4.HeaderText = "Sabor4";
            this.Sabor4.Name = "Sabor4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fabrica de Helados y Tortas Heladas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Proceso del Fabricado";
            // 
            // lblEnPreparacion
            // 
            this.lblEnPreparacion.AutoSize = true;
            this.lblEnPreparacion.Location = new System.Drawing.Point(160, 102);
            this.lblEnPreparacion.Name = "lblEnPreparacion";
            this.lblEnPreparacion.Size = new System.Drawing.Size(153, 13);
            this.lblEnPreparacion.TabIndex = 25;
            this.lblEnPreparacion.Text = "PEDIDOS EN PREPARACIÓN";
            // 
            // dgvEnPreparacion
            // 
            this.dgvEnPreparacion.AllowUserToDeleteRows = false;
            this.dgvEnPreparacion.AllowUserToResizeColumns = false;
            this.dgvEnPreparacion.AllowUserToResizeRows = false;
            this.dgvEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnPreparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPedido,
            this.Empleado,
            this.total});
            this.dgvEnPreparacion.Location = new System.Drawing.Point(27, 130);
            this.dgvEnPreparacion.Name = "dgvEnPreparacion";
            this.dgvEnPreparacion.ReadOnly = true;
            this.dgvEnPreparacion.Size = new System.Drawing.Size(442, 210);
            this.dgvEnPreparacion.TabIndex = 26;
            // 
            // numPedido
            // 
            this.numPedido.HeaderText = "Numero de pedido";
            this.numPedido.Name = "numPedido";
            this.numPedido.ReadOnly = true;
            this.numPedido.Width = 150;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Monto Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "PEDIDOS FINALIZADOS";
            // 
            // dgvFinalizados
            // 
            this.dgvFinalizados.AllowUserToDeleteRows = false;
            this.dgvFinalizados.AllowUserToResizeColumns = false;
            this.dgvFinalizados.AllowUserToResizeRows = false;
            this.dgvFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalizados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvFinalizados.Location = new System.Drawing.Point(27, 403);
            this.dgvFinalizados.Name = "dgvFinalizados";
            this.dgvFinalizados.ReadOnly = true;
            this.dgvFinalizados.Size = new System.Drawing.Size(442, 210);
            this.dgvFinalizados.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero de pedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "CARRITO DE PRODUCCIÓN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvFinalizados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEnPreparacion);
            this.Controls.Add(this.lblEnPreparacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblNuevoPedido);
            this.Controls.Add(this.lblSeleccionGusto);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.cmbTipoDeProducto);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txbNombreEmpleado);
            this.Controls.Add(this.btnIniciarFabricacion);
            this.Controls.Add(this.clbListaDeGustos);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguilera.Kevin.2A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox clbListaDeGustos;
        private System.Windows.Forms.Button btnIniciarFabricacion;
        private System.Windows.Forms.TextBox txbNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.ComboBox cmbTipoDeProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblSeleccionGusto;
        private System.Windows.Forms.Label lblNuevoPedido;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnPreparacion;
        private System.Windows.Forms.DataGridView dgvEnPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label5;
    }
}

