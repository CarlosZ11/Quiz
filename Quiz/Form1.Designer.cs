namespace Quiz
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMunicipio = new System.Windows.Forms.RadioButton();
            this.rdDepartamento = new System.Windows.Forms.RadioButton();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listBoxDepartamento = new System.Windows.Forms.ListBox();
            this.listBoxMunicipio = new System.Windows.Forms.ListBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMunicipio);
            this.groupBox1.Controls.Add(this.rdDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdMunicipio
            // 
            this.rdMunicipio.AutoSize = true;
            this.rdMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.rdMunicipio.Location = new System.Drawing.Point(24, 61);
            this.rdMunicipio.Name = "rdMunicipio";
            this.rdMunicipio.Size = new System.Drawing.Size(70, 17);
            this.rdMunicipio.TabIndex = 1;
            this.rdMunicipio.TabStop = true;
            this.rdMunicipio.Text = "Municipio";
            this.rdMunicipio.UseVisualStyleBackColor = true;
            // 
            // rdDepartamento
            // 
            this.rdDepartamento.AutoSize = true;
            this.rdDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.rdDepartamento.Location = new System.Drawing.Point(24, 29);
            this.rdDepartamento.Name = "rdDepartamento";
            this.rdDepartamento.Size = new System.Drawing.Size(92, 17);
            this.rdDepartamento.TabIndex = 0;
            this.rdDepartamento.TabStop = true;
            this.rdDepartamento.Text = "Departamento";
            this.rdDepartamento.UseVisualStyleBackColor = true;
            this.rdDepartamento.CheckedChanged += new System.EventHandler(this.rdDepartamento_CheckedChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(207, 68);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(202, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.Form1_Load);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnAgregar.Location = new System.Drawing.Point(446, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnEliminar.Location = new System.Drawing.Point(543, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // listBoxDepartamento
            // 
            this.listBoxDepartamento.FormattingEnabled = true;
            this.listBoxDepartamento.Location = new System.Drawing.Point(28, 167);
            this.listBoxDepartamento.Name = "listBoxDepartamento";
            this.listBoxDepartamento.Size = new System.Drawing.Size(199, 225);
            this.listBoxDepartamento.TabIndex = 4;
            this.listBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.listBoxDepartamento_SelectedIndexChanged);
            // 
            // listBoxMunicipio
            // 
            this.listBoxMunicipio.FormattingEnabled = true;
            this.listBoxMunicipio.Location = new System.Drawing.Point(419, 167);
            this.listBoxMunicipio.Name = "listBoxMunicipio";
            this.listBoxMunicipio.Size = new System.Drawing.Size(199, 225);
            this.listBoxMunicipio.TabIndex = 5;
            this.listBoxMunicipio.SelectedIndexChanged += new System.EventHandler(this.listBoxMunicipio_SelectedIndexChanged);
            // 
            // btnDerecha
            // 
            this.btnDerecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnDerecha.Location = new System.Drawing.Point(284, 240);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 6;
            this.btnDerecha.Text = "==>";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnIzquierda.Location = new System.Drawing.Point(284, 282);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<==";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(7)))), ((int)(((byte)(76)))));
            this.btnLimpiar.Location = new System.Drawing.Point(284, 416);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(660, 467);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.listBoxMunicipio);
            this.Controls.Add(this.listBoxDepartamento);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMunicipio;
        private System.Windows.Forms.RadioButton rdDepartamento;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox listBoxDepartamento;
        private System.Windows.Forms.ListBox listBoxMunicipio;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

