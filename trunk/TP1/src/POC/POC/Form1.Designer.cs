namespace POC
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
            this.components = new System.ComponentModel.Container();
            this.grid_TRs = new System.Windows.Forms.DataGridView();
            this.btn_nuevoModelo = new System.Windows.Forms.Button();
            this.grid_Modelos = new System.Windows.Forms.DataGridView();
            this.lbl_trs = new System.Windows.Forms.Label();
            this.lbl_modelos = new System.Windows.Forms.Label();
            this.btn_gentrs = new System.Windows.Forms.Button();
            this.btn_rompersensores = new System.Windows.Forms.Button();
            this.btn_bajarconectividad = new System.Windows.Forms.Button();
            this.btn_sensoratr = new System.Windows.Forms.Button();
            this.lbl_Datos = new System.Windows.Forms.Label();
            this.grid_mensajes = new System.Windows.Forms.DataGridView();
            this.btn_traec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoRecolectadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TRs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Modelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_TRs
            // 
            this.grid_TRs.AllowUserToAddRows = false;
            this.grid_TRs.AllowUserToDeleteRows = false;
            this.grid_TRs.AllowUserToResizeColumns = false;
            this.grid_TRs.AllowUserToResizeRows = false;
            this.grid_TRs.AutoGenerateColumns = false;
            this.grid_TRs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_TRs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_TRs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.infoRecolectadaDataGridViewTextBoxColumn,
            this.condicionServicioDataGridViewTextBoxColumn,
            this.sensoresDataGridViewTextBoxColumn});
            this.grid_TRs.DataSource = this.tRBindingSource;
            this.grid_TRs.Location = new System.Drawing.Point(12, 66);
            this.grid_TRs.Name = "grid_TRs";
            this.grid_TRs.ReadOnly = true;
            this.grid_TRs.Size = new System.Drawing.Size(1002, 174);
            this.grid_TRs.TabIndex = 2;
            // 
            // btn_nuevoModelo
            // 
            this.btn_nuevoModelo.Location = new System.Drawing.Point(11, 388);
            this.btn_nuevoModelo.Name = "btn_nuevoModelo";
            this.btn_nuevoModelo.Size = new System.Drawing.Size(109, 32);
            this.btn_nuevoModelo.TabIndex = 3;
            this.btn_nuevoModelo.Text = "Nuevo Modelo";
            this.btn_nuevoModelo.UseVisualStyleBackColor = true;
            this.btn_nuevoModelo.Click += new System.EventHandler(this.btn_nuevoModelo_Click);
            // 
            // grid_Modelos
            // 
            this.grid_Modelos.AutoGenerateColumns = false;
            this.grid_Modelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Modelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Modelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.formulaDataGridViewTextBoxColumn});
            this.grid_Modelos.DataSource = this.modeloBindingSource;
            this.grid_Modelos.Location = new System.Drawing.Point(12, 426);
            this.grid_Modelos.Name = "grid_Modelos";
            this.grid_Modelos.Size = new System.Drawing.Size(1003, 89);
            this.grid_Modelos.TabIndex = 4;
            // 
            // lbl_trs
            // 
            this.lbl_trs.AutoSize = true;
            this.lbl_trs.Location = new System.Drawing.Point(12, 9);
            this.lbl_trs.Name = "lbl_trs";
            this.lbl_trs.Size = new System.Drawing.Size(27, 13);
            this.lbl_trs.TabIndex = 5;
            this.lbl_trs.Text = "TRs";
            // 
            // lbl_modelos
            // 
            this.lbl_modelos.AutoSize = true;
            this.lbl_modelos.Location = new System.Drawing.Point(12, 372);
            this.lbl_modelos.Name = "lbl_modelos";
            this.lbl_modelos.Size = new System.Drawing.Size(47, 13);
            this.lbl_modelos.TabIndex = 6;
            this.lbl_modelos.Text = "Modelos";
            // 
            // btn_gentrs
            // 
            this.btn_gentrs.Location = new System.Drawing.Point(11, 26);
            this.btn_gentrs.Name = "btn_gentrs";
            this.btn_gentrs.Size = new System.Drawing.Size(109, 34);
            this.btn_gentrs.TabIndex = 7;
            this.btn_gentrs.Text = "Generar TRs";
            this.btn_gentrs.UseVisualStyleBackColor = true;
            this.btn_gentrs.Click += new System.EventHandler(this.btn_gentrs_Click);
            // 
            // btn_rompersensores
            // 
            this.btn_rompersensores.Enabled = false;
            this.btn_rompersensores.Location = new System.Drawing.Point(126, 26);
            this.btn_rompersensores.Name = "btn_rompersensores";
            this.btn_rompersensores.Size = new System.Drawing.Size(109, 34);
            this.btn_rompersensores.TabIndex = 8;
            this.btn_rompersensores.Text = "Romper Sensores";
            this.btn_rompersensores.UseVisualStyleBackColor = true;
            this.btn_rompersensores.Click += new System.EventHandler(this.btn_rompersensores_Click);
            // 
            // btn_bajarconectividad
            // 
            this.btn_bajarconectividad.Enabled = false;
            this.btn_bajarconectividad.Location = new System.Drawing.Point(241, 26);
            this.btn_bajarconectividad.Name = "btn_bajarconectividad";
            this.btn_bajarconectividad.Size = new System.Drawing.Size(109, 34);
            this.btn_bajarconectividad.TabIndex = 9;
            this.btn_bajarconectividad.Text = "Bajar Conectividad";
            this.btn_bajarconectividad.UseVisualStyleBackColor = true;
            this.btn_bajarconectividad.Click += new System.EventHandler(this.btn_bajarconectividad_Click);
            // 
            // btn_sensoratr
            // 
            this.btn_sensoratr.Enabled = false;
            this.btn_sensoratr.Location = new System.Drawing.Point(356, 26);
            this.btn_sensoratr.Name = "btn_sensoratr";
            this.btn_sensoratr.Size = new System.Drawing.Size(109, 34);
            this.btn_sensoratr.TabIndex = 10;
            this.btn_sensoratr.Text = "Enviar Sensor a TR";
            this.btn_sensoratr.UseVisualStyleBackColor = true;
            this.btn_sensoratr.Click += new System.EventHandler(this.btn_sensoratr_Click);
            // 
            // lbl_Datos
            // 
            this.lbl_Datos.AutoSize = true;
            this.lbl_Datos.Location = new System.Drawing.Point(13, 247);
            this.lbl_Datos.Name = "lbl_Datos";
            this.lbl_Datos.Size = new System.Drawing.Size(90, 13);
            this.lbl_Datos.TabIndex = 11;
            this.lbl_Datos.Text = "Mensajes de TRs";
            // 
            // grid_mensajes
            // 
            this.grid_mensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_mensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mensajes.Location = new System.Drawing.Point(13, 264);
            this.grid_mensajes.Name = "grid_mensajes";
            this.grid_mensajes.Size = new System.Drawing.Size(497, 105);
            this.grid_mensajes.TabIndex = 12;
            // 
            // btn_traec
            // 
            this.btn_traec.Enabled = false;
            this.btn_traec.Location = new System.Drawing.Point(471, 26);
            this.btn_traec.Name = "btn_traec";
            this.btn_traec.Size = new System.Drawing.Size(109, 34);
            this.btn_traec.TabIndex = 13;
            this.btn_traec.Text = "Enviar TR a EC";
            this.btn_traec.UseVisualStyleBackColor = true;
            this.btn_traec.Click += new System.EventHandler(this.btn_traec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Log";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(532, 264);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(483, 105);
            this.txt_log.TabIndex = 15;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.FillWeight = 52.04978F;
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // formulaDataGridViewTextBoxColumn
            // 
            this.formulaDataGridViewTextBoxColumn.DataPropertyName = "Formula";
            this.formulaDataGridViewTextBoxColumn.FillWeight = 153.0264F;
            this.formulaDataGridViewTextBoxColumn.HeaderText = "Formula";
            this.formulaDataGridViewTextBoxColumn.Name = "formulaDataGridViewTextBoxColumn";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(POC.Modelo);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 38.42924F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoRecolectadaDataGridViewTextBoxColumn
            // 
            this.infoRecolectadaDataGridViewTextBoxColumn.DataPropertyName = "InfoRecolectada";
            this.infoRecolectadaDataGridViewTextBoxColumn.FillWeight = 158.7419F;
            this.infoRecolectadaDataGridViewTextBoxColumn.HeaderText = "InfoRecolectada";
            this.infoRecolectadaDataGridViewTextBoxColumn.Name = "infoRecolectadaDataGridViewTextBoxColumn";
            this.infoRecolectadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // condicionServicioDataGridViewTextBoxColumn
            // 
            this.condicionServicioDataGridViewTextBoxColumn.DataPropertyName = "CondicionServicio";
            this.condicionServicioDataGridViewTextBoxColumn.FillWeight = 40.39233F;
            this.condicionServicioDataGridViewTextBoxColumn.HeaderText = "CondicionServicio";
            this.condicionServicioDataGridViewTextBoxColumn.Name = "condicionServicioDataGridViewTextBoxColumn";
            this.condicionServicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensoresDataGridViewTextBoxColumn
            // 
            this.sensoresDataGridViewTextBoxColumn.DataPropertyName = "Sensores";
            this.sensoresDataGridViewTextBoxColumn.FillWeight = 162.4366F;
            this.sensoresDataGridViewTextBoxColumn.HeaderText = "Sensores";
            this.sensoresDataGridViewTextBoxColumn.Name = "sensoresDataGridViewTextBoxColumn";
            this.sensoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRBindingSource
            // 
            this.tRBindingSource.DataSource = typeof(POC.TR);
            // 
            // tRBindingSource1
            // 
            this.tRBindingSource1.DataSource = typeof(POC.TR);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(POC.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(POC.Form1);
            // 
            // paqueteBindingSource
            // 
            this.paqueteBindingSource.DataSource = typeof(POC.Paquete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 527);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_traec);
            this.Controls.Add(this.grid_mensajes);
            this.Controls.Add(this.lbl_Datos);
            this.Controls.Add(this.btn_sensoratr);
            this.Controls.Add(this.btn_bajarconectividad);
            this.Controls.Add(this.btn_rompersensores);
            this.Controls.Add(this.btn_gentrs);
            this.Controls.Add(this.lbl_modelos);
            this.Controls.Add(this.lbl_trs);
            this.Controls.Add(this.grid_Modelos);
            this.Controls.Add(this.btn_nuevoModelo);
            this.Controls.Add(this.grid_TRs);
            this.Name = "Form1";
            this.Text = "Prueba de Concepto";
            ((System.ComponentModel.ISupportInitialize)(this.grid_TRs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Modelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TRs;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource tRBindingSource;
        private System.Windows.Forms.BindingSource tRBindingSource1;
        private System.Windows.Forms.Button btn_nuevoModelo;
        private System.Windows.Forms.DataGridView grid_Modelos;
        private System.Windows.Forms.Label lbl_trs;
        private System.Windows.Forms.Label lbl_modelos;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.Button btn_gentrs;
        private System.Windows.Forms.Button btn_rompersensores;
        private System.Windows.Forms.Button btn_bajarconectividad;
        private System.Windows.Forms.Button btn_sensoratr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoRecolectadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_Datos;
        private System.Windows.Forms.DataGridView grid_mensajes;
        private System.Windows.Forms.BindingSource paqueteBindingSource;
        private System.Windows.Forms.Button btn_traec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulaDataGridViewTextBoxColumn;
    }
}

