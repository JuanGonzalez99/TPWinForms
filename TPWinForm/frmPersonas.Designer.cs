﻿namespace TPWinForm
{
    partial class frmPersonas
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
            this.gboSexo = new System.Windows.Forms.GroupBox();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gboMusica = new System.Windows.Forms.GroupBox();
            this.chbTango = new System.Windows.Forms.CheckBox();
            this.chbCumbia = new System.Windows.Forms.CheckBox();
            this.chbJazz = new System.Windows.Forms.CheckBox();
            this.chbRap = new System.Windows.Forms.CheckBox();
            this.chbRock = new System.Windows.Forms.CheckBox();
            this.chbClasica = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gboSexo.SuspendLayout();
            this.gboMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gboSexo
            // 
            this.gboSexo.Controls.Add(this.rbtnOtro);
            this.gboSexo.Controls.Add(this.rbtnFemenino);
            this.gboSexo.Controls.Add(this.rbtnMasculino);
            this.gboSexo.Location = new System.Drawing.Point(253, 24);
            this.gboSexo.Name = "gboSexo";
            this.gboSexo.Size = new System.Drawing.Size(107, 108);
            this.gboSexo.TabIndex = 0;
            this.gboSexo.TabStop = false;
            this.gboSexo.Text = "Sexo";
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Location = new System.Drawing.Point(19, 73);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtnOtro.TabIndex = 2;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "Otro";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(19, 48);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(19, 24);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 97);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 94);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(137, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(19, 160);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(63, 13);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Nacimiento:";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(88, 158);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(197, 20);
            this.dtpNacimiento.TabIndex = 6;
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(291, 160);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 13);
            this.lblEdad.TabIndex = 7;
            // 
            // gboMusica
            // 
            this.gboMusica.Controls.Add(this.chbTango);
            this.gboMusica.Controls.Add(this.chbCumbia);
            this.gboMusica.Controls.Add(this.chbJazz);
            this.gboMusica.Controls.Add(this.chbRap);
            this.gboMusica.Controls.Add(this.chbRock);
            this.gboMusica.Controls.Add(this.chbClasica);
            this.gboMusica.Location = new System.Drawing.Point(22, 202);
            this.gboMusica.Name = "gboMusica";
            this.gboMusica.Size = new System.Drawing.Size(338, 88);
            this.gboMusica.TabIndex = 8;
            this.gboMusica.TabStop = false;
            this.gboMusica.Text = "Música favorita";
            // 
            // chbTango
            // 
            this.chbTango.AutoSize = true;
            this.chbTango.Location = new System.Drawing.Point(260, 53);
            this.chbTango.Name = "chbTango";
            this.chbTango.Size = new System.Drawing.Size(57, 17);
            this.chbTango.TabIndex = 5;
            this.chbTango.Text = "Tango";
            this.chbTango.UseVisualStyleBackColor = true;
            // 
            // chbCumbia
            // 
            this.chbCumbia.AutoSize = true;
            this.chbCumbia.Location = new System.Drawing.Point(260, 30);
            this.chbCumbia.Name = "chbCumbia";
            this.chbCumbia.Size = new System.Drawing.Size(61, 17);
            this.chbCumbia.TabIndex = 4;
            this.chbCumbia.Text = "Cumbia";
            this.chbCumbia.UseVisualStyleBackColor = true;
            // 
            // chbJazz
            // 
            this.chbJazz.AutoSize = true;
            this.chbJazz.Location = new System.Drawing.Point(142, 53);
            this.chbJazz.Name = "chbJazz";
            this.chbJazz.Size = new System.Drawing.Size(47, 17);
            this.chbJazz.TabIndex = 3;
            this.chbJazz.Text = "Jazz";
            this.chbJazz.UseVisualStyleBackColor = true;
            // 
            // chbRap
            // 
            this.chbRap.AutoSize = true;
            this.chbRap.Location = new System.Drawing.Point(142, 30);
            this.chbRap.Name = "chbRap";
            this.chbRap.Size = new System.Drawing.Size(46, 17);
            this.chbRap.TabIndex = 2;
            this.chbRap.Text = "Rap";
            this.chbRap.UseVisualStyleBackColor = true;
            // 
            // chbRock
            // 
            this.chbRock.AutoSize = true;
            this.chbRock.Location = new System.Drawing.Point(18, 53);
            this.chbRock.Name = "chbRock";
            this.chbRock.Size = new System.Drawing.Size(52, 17);
            this.chbRock.TabIndex = 1;
            this.chbRock.Text = "Rock";
            this.chbRock.UseVisualStyleBackColor = true;
            // 
            // chbClasica
            // 
            this.chbClasica.AutoSize = true;
            this.chbClasica.Location = new System.Drawing.Point(18, 30);
            this.chbClasica.Name = "chbClasica";
            this.chbClasica.Size = new System.Drawing.Size(60, 17);
            this.chbClasica.TabIndex = 0;
            this.chbClasica.Text = "Clásica";
            this.chbClasica.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(40, 378);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 35);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(221, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(97, 327);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(122, 21);
            this.cboColor.TabIndex = 11;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(19, 330);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color favorito:";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeColumns = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(382, 24);
            this.dgvPersonas.MultiSelect = false;
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(550, 324);
            this.dgvPersonas.TabIndex = 13;
            this.dgvPersonas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPersonas_RowHeaderMouseClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(484, 378);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 35);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(701, 378);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 437);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboMusica);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gboSexo);
            this.Name = "frmPersonas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.frmPersonas_Load);
            this.gboSexo.ResumeLayout(false);
            this.gboSexo.PerformLayout();
            this.gboMusica.ResumeLayout(false);
            this.gboMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSexo;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gboMusica;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox chbTango;
        private System.Windows.Forms.CheckBox chbCumbia;
        private System.Windows.Forms.CheckBox chbJazz;
        private System.Windows.Forms.CheckBox chbRap;
        private System.Windows.Forms.CheckBox chbRock;
        private System.Windows.Forms.CheckBox chbClasica;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

