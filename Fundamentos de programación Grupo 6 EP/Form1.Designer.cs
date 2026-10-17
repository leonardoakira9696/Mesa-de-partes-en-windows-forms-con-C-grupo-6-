namespace Fundamentos_de_programación_Grupo_6_EP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GbDatosExpediente = new GroupBox();
            CbEstado = new ComboBox();
            LblEstado = new Label();
            DtpFechaRecepcion = new DateTimePicker();
            LblFechaRecepcion = new Label();
            TxtAsunto = new TextBox();
            CbTipoDocumento = new ComboBox();
            TxtRemitente = new TextBox();
            TxtCodigo = new TextBox();
            LblAsunto = new Label();
            label5 = new Label();
            LblTipoDocumento = new Label();
            label3 = new Label();
            LblRemitente = new Label();
            LblCodigo = new Label();
            GbExpedientesRegistrados = new GroupBox();
            DgvRegistro = new DataGridView();
            DgvCódigo = new DataGridViewTextBoxColumn();
            DgvRemitente = new DataGridViewTextBoxColumn();
            DgvTipoDocumento = new DataGridViewTextBoxColumn();
            DgvAsunto = new DataGridViewTextBoxColumn();
            DgvFechaRecepción = new DataGridViewTextBoxColumn();
            DgvEstado = new DataGridViewTextBoxColumn();
            GbAcciones = new GroupBox();
            BtnSalir = new Button();
            BtnLimpiar = new Button();
            BtnOrdenarCodigo = new Button();
            BtnBuscar = new Button();
            BtnRegistrar = new Button();
            GbTotal = new GroupBox();
            LblTotal = new Label();
            GbDatosExpediente.SuspendLayout();
            GbExpedientesRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRegistro).BeginInit();
            GbAcciones.SuspendLayout();
            GbTotal.SuspendLayout();
            SuspendLayout();
            // 
            // GbDatosExpediente
            // 
            GbDatosExpediente.Controls.Add(CbEstado);
            GbDatosExpediente.Controls.Add(LblEstado);
            GbDatosExpediente.Controls.Add(DtpFechaRecepcion);
            GbDatosExpediente.Controls.Add(LblFechaRecepcion);
            GbDatosExpediente.Controls.Add(TxtAsunto);
            GbDatosExpediente.Controls.Add(CbTipoDocumento);
            GbDatosExpediente.Controls.Add(TxtRemitente);
            GbDatosExpediente.Controls.Add(TxtCodigo);
            GbDatosExpediente.Controls.Add(LblAsunto);
            GbDatosExpediente.Controls.Add(label5);
            GbDatosExpediente.Controls.Add(LblTipoDocumento);
            GbDatosExpediente.Controls.Add(label3);
            GbDatosExpediente.Controls.Add(LblRemitente);
            GbDatosExpediente.Controls.Add(LblCodigo);
            GbDatosExpediente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDatosExpediente.Location = new Point(12, 12);
            GbDatosExpediente.Name = "GbDatosExpediente";
            GbDatosExpediente.Size = new Size(733, 194);
            GbDatosExpediente.TabIndex = 0;
            GbDatosExpediente.TabStop = false;
            GbDatosExpediente.Text = "Datos del Expediente";
            // 
            // CbEstado
            // 
            CbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CbEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbEstado.FormattingEnabled = true;
            CbEstado.Location = new Point(550, 64);
            CbEstado.Name = "CbEstado";
            CbEstado.Size = new Size(177, 23);
            CbEstado.TabIndex = 13;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEstado.Location = new Point(409, 67);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(45, 15);
            LblEstado.TabIndex = 12;
            LblEstado.Text = "Estado:";
            // 
            // DtpFechaRecepcion
            // 
            DtpFechaRecepcion.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpFechaRecepcion.CustomFormat = "dd/MM/yyyy";
            DtpFechaRecepcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpFechaRecepcion.Format = DateTimePickerFormat.Custom;
            DtpFechaRecepcion.Location = new Point(550, 28);
            DtpFechaRecepcion.Name = "DtpFechaRecepcion";
            DtpFechaRecepcion.Size = new Size(177, 23);
            DtpFechaRecepcion.TabIndex = 11;
            DtpFechaRecepcion.Value = new DateTime(2026, 10, 16, 0, 18, 36, 0);
            // 
            // LblFechaRecepcion
            // 
            LblFechaRecepcion.AutoSize = true;
            LblFechaRecepcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFechaRecepcion.Location = new Point(409, 31);
            LblFechaRecepcion.Name = "LblFechaRecepcion";
            LblFechaRecepcion.Size = new Size(115, 15);
            LblFechaRecepcion.TabIndex = 10;
            LblFechaRecepcion.Text = "Fecha de Recepción:";
            // 
            // TxtAsunto
            // 
            TxtAsunto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAsunto.Location = new Point(130, 148);
            TxtAsunto.Name = "TxtAsunto";
            TxtAsunto.Size = new Size(402, 23);
            TxtAsunto.TabIndex = 9;
            // 
            // CbTipoDocumento
            // 
            CbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbTipoDocumento.FormattingEnabled = true;
            CbTipoDocumento.Location = new Point(130, 109);
            CbTipoDocumento.Name = "CbTipoDocumento";
            CbTipoDocumento.Size = new Size(252, 23);
            CbTipoDocumento.TabIndex = 8;
            // 
            // TxtRemitente
            // 
            TxtRemitente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRemitente.Location = new Point(130, 67);
            TxtRemitente.Name = "TxtRemitente";
            TxtRemitente.Size = new Size(252, 23);
            TxtRemitente.TabIndex = 7;
            // 
            // TxtCodigo
            // 
            TxtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCodigo.Location = new Point(130, 28);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(193, 23);
            TxtCodigo.TabIndex = 6;
            // 
            // LblAsunto
            // 
            LblAsunto.AutoSize = true;
            LblAsunto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAsunto.Location = new Point(7, 151);
            LblAsunto.Name = "LblAsunto";
            LblAsunto.Size = new Size(48, 15);
            LblAsunto.TabIndex = 5;
            LblAsunto.Text = "Asunto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // LblTipoDocumento
            // 
            LblTipoDocumento.AutoSize = true;
            LblTipoDocumento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTipoDocumento.Location = new Point(7, 112);
            LblTipoDocumento.Name = "LblTipoDocumento";
            LblTipoDocumento.Size = new Size(115, 15);
            LblTipoDocumento.TabIndex = 3;
            LblTipoDocumento.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // LblRemitente
            // 
            LblRemitente.AutoSize = true;
            LblRemitente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblRemitente.Location = new Point(6, 67);
            LblRemitente.Name = "LblRemitente";
            LblRemitente.Size = new Size(64, 15);
            LblRemitente.TabIndex = 1;
            LblRemitente.Text = "Remitente:";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblCodigo.Location = new Point(6, 28);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(49, 15);
            LblCodigo.TabIndex = 0;
            LblCodigo.Text = "Código:";
            // 
            // GbExpedientesRegistrados
            // 
            GbExpedientesRegistrados.Controls.Add(DgvRegistro);
            GbExpedientesRegistrados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbExpedientesRegistrados.Location = new Point(12, 205);
            GbExpedientesRegistrados.Name = "GbExpedientesRegistrados";
            GbExpedientesRegistrados.Size = new Size(985, 257);
            GbExpedientesRegistrados.TabIndex = 1;
            GbExpedientesRegistrados.TabStop = false;
            GbExpedientesRegistrados.Text = "Expedientes Registrados";
            // 
            // DgvRegistro
            // 
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRegistro.Columns.AddRange(new DataGridViewColumn[] { DgvCódigo, DgvRemitente, DgvTipoDocumento, DgvAsunto, DgvFechaRecepción, DgvEstado });
            DgvRegistro.Location = new Point(6, 22);
            DgvRegistro.Name = "DgvRegistro";
            DgvRegistro.Size = new Size(973, 229);
            DgvRegistro.TabIndex = 0;
            // 
            // DgvCódigo
            // 
            DgvCódigo.HeaderText = "Código";
            DgvCódigo.Name = "DgvCódigo";
            DgvCódigo.ReadOnly = true;
            DgvCódigo.Width = 125;
            // 
            // DgvRemitente
            // 
            DgvRemitente.HeaderText = "Remitente";
            DgvRemitente.Name = "DgvRemitente";
            DgvRemitente.ReadOnly = true;
            DgvRemitente.Width = 150;
            // 
            // DgvTipoDocumento
            // 
            DgvTipoDocumento.HeaderText = "Tipo de Documento";
            DgvTipoDocumento.Name = "DgvTipoDocumento";
            DgvTipoDocumento.ReadOnly = true;
            DgvTipoDocumento.Width = 160;
            // 
            // DgvAsunto
            // 
            DgvAsunto.HeaderText = "Asunto";
            DgvAsunto.Name = "DgvAsunto";
            DgvAsunto.ReadOnly = true;
            DgvAsunto.Width = 205;
            // 
            // DgvFechaRecepción
            // 
            DgvFechaRecepción.HeaderText = "Fecha de Recepción";
            DgvFechaRecepción.Name = "DgvFechaRecepción";
            DgvFechaRecepción.ReadOnly = true;
            DgvFechaRecepción.Width = 165;
            // 
            // DgvEstado
            // 
            DgvEstado.HeaderText = "Estado";
            DgvEstado.Name = "DgvEstado";
            DgvEstado.ReadOnly = true;
            DgvEstado.Width = 125;
            // 
            // GbAcciones
            // 
            GbAcciones.Controls.Add(BtnSalir);
            GbAcciones.Controls.Add(BtnLimpiar);
            GbAcciones.Controls.Add(BtnOrdenarCodigo);
            GbAcciones.Controls.Add(BtnBuscar);
            GbAcciones.Controls.Add(BtnRegistrar);
            GbAcciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbAcciones.Location = new Point(751, 12);
            GbAcciones.Name = "GbAcciones";
            GbAcciones.Size = new Size(246, 194);
            GbAcciones.TabIndex = 2;
            GbAcciones.TabStop = false;
            GbAcciones.Text = "Acciones";
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSalir.Location = new Point(6, 157);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(234, 29);
            BtnSalir.TabIndex = 4;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(6, 122);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(234, 29);
            BtnLimpiar.TabIndex = 3;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenarCodigo
            // 
            BtnOrdenarCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnOrdenarCodigo.Location = new Point(6, 87);
            BtnOrdenarCodigo.Name = "BtnOrdenarCodigo";
            BtnOrdenarCodigo.Size = new Size(234, 29);
            BtnOrdenarCodigo.TabIndex = 2;
            BtnOrdenarCodigo.Text = "Ordenar por Código";
            BtnOrdenarCodigo.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(6, 52);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(234, 29);
            BtnBuscar.TabIndex = 1;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(6, 17);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(234, 29);
            BtnRegistrar.TabIndex = 0;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // GbTotal
            // 
            GbTotal.Controls.Add(LblTotal);
            GbTotal.Location = new Point(12, 462);
            GbTotal.Name = "GbTotal";
            GbTotal.Size = new Size(985, 43);
            GbTotal.TabIndex = 3;
            GbTotal.TabStop = false;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(7, 19);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(34, 15);
            LblTotal.TabIndex = 0;
            LblTotal.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 512);
            Controls.Add(GbTotal);
            Controls.Add(GbAcciones);
            Controls.Add(GbExpedientesRegistrados);
            Controls.Add(GbDatosExpediente);
            Name = "Form1";
            Text = "Mesa de Partes Dígital";
            GbDatosExpediente.ResumeLayout(false);
            GbDatosExpediente.PerformLayout();
            GbExpedientesRegistrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRegistro).EndInit();
            GbAcciones.ResumeLayout(false);
            GbTotal.ResumeLayout(false);
            GbTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbDatosExpediente;
        private TextBox TxtRemitente;
        private TextBox TxtCodigo;
        private Label LblAsunto;
        private Label label5;
        private Label LblTipoDocumento;
        private Label label3;
        private Label LblRemitente;
        private Label LblCodigo;
        private DateTimePicker DtpFechaRecepcion;
        private Label LblFechaRecepcion;
        private TextBox TxtAsunto;
        private ComboBox CbTipoDocumento;
        private ComboBox CbEstado;
        private Label LblEstado;
        private GroupBox GbExpedientesRegistrados;
        private GroupBox GbAcciones;
        private DataGridView DgvRegistro;
        private DataGridViewTextBoxColumn DgvCódigo;
        private DataGridViewTextBoxColumn DgvRemitente;
        private DataGridViewTextBoxColumn DgvTipoDocumento;
        private DataGridViewTextBoxColumn DgvAsunto;
        private DataGridViewTextBoxColumn DgvFechaRecepción;
        private DataGridViewTextBoxColumn DgvEstado;
        private Button BtnRegistrar;
        private Button BtnOrdenarCodigo;
        private Button BtnBuscar;
        private GroupBox GbTotal;
        private Label LblTotal;
        private Button BtnSalir;
        private Button BtnLimpiar;
    }
}
