namespace GestionarGastos.Views
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpFecha = new DateTimePicker();
            cbxMetodoPago = new ComboBox();
            txtDescripcion = new TextBox();
            btnLimpiar = new Button();
            label9 = new Label();
            label10 = new Label();
            txtBuscar = new TextBox();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvTablaGastos = new DataGridView();
            cbxCategoria = new ComboBox();
            btnGuardar = new Button();
            txtMonto = new NumericUpDown();
            estadoSistema = new StatusStrip();
            lblEstatus = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMonto).BeginInit();
            estadoSistema.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(227, 11);
            label2.Name = "label2";
            label2.Size = new Size(192, 18);
            label2.TabIndex = 1;
            label2.Text = "GASTOS REGISTRADOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(98, 50);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "REGISTRAR GASTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 92);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 152);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 4;
            label5.Text = "Categoría";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 206);
            label6.Name = "label6";
            label6.Size = new Size(51, 18);
            label6.TabIndex = 5;
            label6.Text = "Monto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 264);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Fecha";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(147, 264);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 7;
            label8.Text = "Método de Pago";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(27, 287);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(106, 23);
            dtpFecha.TabIndex = 8;
            // 
            // cbxMetodoPago
            // 
            cbxMetodoPago.FormattingEnabled = true;
            cbxMetodoPago.Location = new Point(147, 286);
            cbxMetodoPago.Name = "cbxMetodoPago";
            cbxMetodoPago.Size = new Size(217, 23);
            cbxMetodoPago.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 113);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(336, 23);
            txtDescripcion.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(222, 351);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(141, 42);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 77);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 15;
            label9.Text = "Buscar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(334, 77);
            label10.Name = "label10";
            label10.Size = new Size(82, 18);
            label10.TabIndex = 16;
            label10.Text = "Categoria:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(97, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(172, 23);
            txtBuscar.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(dgvTablaGastos);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(405, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 546);
            panel1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(423, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 23);
            comboBox2.TabIndex = 26;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(97, 521);
            label16.Name = "label16";
            label16.Size = new Size(16, 15);
            label16.TabIndex = 25;
            label16.Text = "...";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(97, 488);
            label15.Name = "label15";
            label15.Size = new Size(16, 15);
            label15.TabIndex = 24;
            label15.Text = "...";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(67, 421);
            label14.Name = "label14";
            label14.Size = new Size(16, 15);
            label14.TabIndex = 23;
            label14.Text = "...";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 519);
            label13.Name = "label13";
            label13.Size = new Size(72, 17);
            label13.TabIndex = 22;
            label13.Text = "Promedio:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 486);
            label12.Name = "label12";
            label12.Size = new Size(53, 17);
            label12.TabIndex = 21;
            label12.Text = "Gastos:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(15, 420);
            label11.Name = "label11";
            label11.Size = new Size(38, 16);
            label11.TabIndex = 20;
            label11.Text = "Total:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Silver;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(397, 387);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 31);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ActiveBorder;
            btnEditar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(509, 387);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 31);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvTablaGastos
            // 
            dgvTablaGastos.AllowUserToAddRows = false;
            dgvTablaGastos.AllowUserToDeleteRows = false;
            dgvTablaGastos.AllowUserToResizeRows = false;
            dgvTablaGastos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTablaGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaGastos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTablaGastos.Location = new Point(15, 143);
            dgvTablaGastos.Name = "dgvTablaGastos";
            dgvTablaGastos.RowHeadersWidth = 51;
            dgvTablaGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaGastos.Size = new Size(571, 238);
            dgvTablaGastos.TabIndex = 2;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(27, 173);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(336, 23);
            cbxCategoria.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(32, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(133, 42);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(27, 227);
            txtMonto.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(336, 23);
            txtMonto.TabIndex = 22;
            // 
            // estadoSistema
            // 
            estadoSistema.ImageScalingSize = new Size(20, 20);
            estadoSistema.Items.AddRange(new ToolStripItem[] { lblEstatus });
            estadoSistema.Location = new Point(0, 457);
            estadoSistema.Name = "estadoSistema";
            estadoSistema.Size = new Size(1026, 22);
            estadoSistema.TabIndex = 23;
            estadoSistema.Text = "statusStrip1";
            // 
            // lblEstatus
            // 
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(19, 17);
            lblEstatus.Text = "....";
            // 
            // frmGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1026, 479);
            Controls.Add(estadoSistema);
            Controls.Add(txtMonto);
            Controls.Add(btnGuardar);
            Controls.Add(cbxCategoria);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDescripcion);
            Controls.Add(cbxMetodoPago);
            Controls.Add(dtpFecha);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGastos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTIONAR GASTOS";
            Load += frmGastos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaGastos).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMonto).EndInit();
            estadoSistema.ResumeLayout(false);
            estadoSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpFecha;
        private ComboBox comboBox1;
        private ComboBox cbxMetodoPago;
        private NumericUpDown txtMonto;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label9;
        private Label label10;
        private TextBox txtBuscar;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvTablaGastos;
        private ComboBox cbxCategoria;
        private ComboBox comboBox2;
        private Label label16;
        private Label label15;
        private Label label14;
        private StatusStrip estadoSistema;
        private ToolStripStatusLabel lblEstatus;
    }
}