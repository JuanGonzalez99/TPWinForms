namespace TPWinForm
{
    partial class frmObjetos
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
            this.lblObjeto = new System.Windows.Forms.Label();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ListaIzquierda = new System.Windows.Forms.ListBox();
            this.ListaDerecha = new System.Windows.Forms.ListBox();
            this.btnMoverTodos = new System.Windows.Forms.Button();
            this.btnMoverDerecha = new System.Windows.Forms.Button();
            this.btnMoverIzquierda = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Location = new System.Drawing.Point(48, 55);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(96, 13);
            this.lblObjeto.TabIndex = 0;
            this.lblObjeto.Text = "Nombre del objeto:";
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(141, 52);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(146, 20);
            this.txtObjeto.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(293, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 29);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ListaIzquierda
            // 
            this.ListaIzquierda.FormattingEnabled = true;
            this.ListaIzquierda.Location = new System.Drawing.Point(12, 96);
            this.ListaIzquierda.Name = "ListaIzquierda";
            this.ListaIzquierda.Size = new System.Drawing.Size(338, 316);
            this.ListaIzquierda.TabIndex = 3;
            // 
            // ListaDerecha
            // 
            this.ListaDerecha.FormattingEnabled = true;
            this.ListaDerecha.Location = new System.Drawing.Point(450, 96);
            this.ListaDerecha.Name = "ListaDerecha";
            this.ListaDerecha.Size = new System.Drawing.Size(338, 316);
            this.ListaDerecha.TabIndex = 4;
            // 
            // btnMoverTodos
            // 
            this.btnMoverTodos.Location = new System.Drawing.Point(356, 96);
            this.btnMoverTodos.Name = "btnMoverTodos";
            this.btnMoverTodos.Size = new System.Drawing.Size(88, 30);
            this.btnMoverTodos.TabIndex = 5;
            this.btnMoverTodos.Text = ">>";
            this.btnMoverTodos.UseVisualStyleBackColor = true;
            this.btnMoverTodos.Click += new System.EventHandler(this.btnMoverTodos_Click);
            // 
            // btnMoverDerecha
            // 
            this.btnMoverDerecha.Location = new System.Drawing.Point(356, 132);
            this.btnMoverDerecha.Name = "btnMoverDerecha";
            this.btnMoverDerecha.Size = new System.Drawing.Size(88, 30);
            this.btnMoverDerecha.TabIndex = 6;
            this.btnMoverDerecha.Text = ">";
            this.btnMoverDerecha.UseVisualStyleBackColor = true;
            this.btnMoverDerecha.Click += new System.EventHandler(this.btnMoverDerecha_Click);
            // 
            // btnMoverIzquierda
            // 
            this.btnMoverIzquierda.Location = new System.Drawing.Point(356, 168);
            this.btnMoverIzquierda.Name = "btnMoverIzquierda";
            this.btnMoverIzquierda.Size = new System.Drawing.Size(88, 30);
            this.btnMoverIzquierda.TabIndex = 7;
            this.btnMoverIzquierda.Text = "<";
            this.btnMoverIzquierda.UseVisualStyleBackColor = true;
            this.btnMoverIzquierda.Click += new System.EventHandler(this.btnMoverIzquierda_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(356, 204);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 30);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMoverIzquierda);
            this.Controls.Add(this.btnMoverDerecha);
            this.Controls.Add(this.btnMoverTodos);
            this.Controls.Add(this.ListaDerecha);
            this.Controls.Add(this.ListaIzquierda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtObjeto);
            this.Controls.Add(this.lblObjeto);
            this.Name = "frmObjetos";
            this.Text = "frmObjetos";
            this.Load += new System.EventHandler(this.frmObjetos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox ListaIzquierda;
        private System.Windows.Forms.ListBox ListaDerecha;
        private System.Windows.Forms.Button btnMoverTodos;
        private System.Windows.Forms.Button btnMoverDerecha;
        private System.Windows.Forms.Button btnMoverIzquierda;
        private System.Windows.Forms.Button btnBorrar;
    }
}