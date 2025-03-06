namespace examen_alvarado
{
    partial class form
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
            this.dniBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.nombreLabel3 = new System.Windows.Forms.Label();
            this.notaLabel = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.todosButton = new System.Windows.Forms.Button();
            this.suspensosButton = new System.Windows.Forms.Button();
            this.aprobadosButton = new System.Windows.Forms.Button();
            this.mhButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.notaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.consultarButton = new System.Windows.Forms.Button();
            this.modinotaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(185, 36);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(169, 20);
            this.dniBox.TabIndex = 0;
            this.dniBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(456, 36);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(169, 20);
            this.apellidoBox.TabIndex = 1;
            this.apellidoBox.TextChanged += new System.EventHandler(this.apellidoBox_TextChanged);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(185, 71);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(169, 20);
            this.nombreBox.TabIndex = 2;
            this.nombreBox.TextChanged += new System.EventHandler(this.nombreBox_TextChanged);
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(100, 45);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(26, 13);
            this.dniLabel.TabIndex = 4;
            this.dniLabel.Text = "DNI";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(371, 43);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(66, 13);
            this.apellidoLabel.TabIndex = 5;
            this.apellidoLabel.Text = "APELLIDOS";
            // 
            // nombreLabel3
            // 
            this.nombreLabel3.AutoSize = true;
            this.nombreLabel3.Location = new System.Drawing.Point(100, 78);
            this.nombreLabel3.Name = "nombreLabel3";
            this.nombreLabel3.Size = new System.Drawing.Size(54, 13);
            this.nombreLabel3.TabIndex = 6;
            this.nombreLabel3.Text = "NOMBRE";
            // 
            // notaLabel
            // 
            this.notaLabel.AutoSize = true;
            this.notaLabel.Location = new System.Drawing.Point(371, 78);
            this.notaLabel.Name = "notaLabel";
            this.notaLabel.Size = new System.Drawing.Size(37, 13);
            this.notaLabel.TabIndex = 7;
            this.notaLabel.Text = "NOTA";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(45, 162);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(148, 23);
            this.agregarButton.TabIndex = 8;
            this.agregarButton.Text = "AGREGAR";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // todosButton
            // 
            this.todosButton.Location = new System.Drawing.Point(45, 191);
            this.todosButton.Name = "todosButton";
            this.todosButton.Size = new System.Drawing.Size(148, 23);
            this.todosButton.TabIndex = 9;
            this.todosButton.Text = "MOSTRAR TODOS ";
            this.todosButton.UseVisualStyleBackColor = true;
            this.todosButton.Click += new System.EventHandler(this.todosButton_Click);
            // 
            // suspensosButton
            // 
            this.suspensosButton.Location = new System.Drawing.Point(45, 220);
            this.suspensosButton.Name = "suspensosButton";
            this.suspensosButton.Size = new System.Drawing.Size(148, 23);
            this.suspensosButton.TabIndex = 10;
            this.suspensosButton.Text = "MOSTRAR SUSPENSOS";
            this.suspensosButton.UseVisualStyleBackColor = true;
            this.suspensosButton.Click += new System.EventHandler(this.suspensosButton_Click);
            // 
            // aprobadosButton
            // 
            this.aprobadosButton.Location = new System.Drawing.Point(45, 249);
            this.aprobadosButton.Name = "aprobadosButton";
            this.aprobadosButton.Size = new System.Drawing.Size(148, 23);
            this.aprobadosButton.TabIndex = 11;
            this.aprobadosButton.Text = "MOSTRAR APROBADOS";
            this.aprobadosButton.UseVisualStyleBackColor = true;
            this.aprobadosButton.Click += new System.EventHandler(this.aprobadosButton_Click);
            // 
            // mhButton
            // 
            this.mhButton.Location = new System.Drawing.Point(45, 278);
            this.mhButton.Name = "mhButton";
            this.mhButton.Size = new System.Drawing.Size(148, 23);
            this.mhButton.TabIndex = 12;
            this.mhButton.Text = "MOSTRAR MH";
            this.mhButton.UseVisualStyleBackColor = true;
            this.mhButton.Click += new System.EventHandler(this.mhButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(213, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(484, 134);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // notaBox
            // 
            this.notaBox.Location = new System.Drawing.Point(456, 71);
            this.notaBox.Name = "notaBox";
            this.notaBox.Size = new System.Drawing.Size(55, 20);
            this.notaBox.TabIndex = 3;
            this.notaBox.TextChanged += new System.EventHandler(this.notaBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ABI ALVARADO EXAMEN";
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(229, 118);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 19;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(320, 118);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(75, 23);
            this.consultarButton.TabIndex = 20;
            this.consultarButton.Text = "CONSULTAR";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // modinotaButton
            // 
            this.modinotaButton.Location = new System.Drawing.Point(410, 118);
            this.modinotaButton.Name = "modinotaButton";
            this.modinotaButton.Size = new System.Drawing.Size(75, 23);
            this.modinotaButton.TabIndex = 22;
            this.modinotaButton.Text = "MODIFICAR";
            this.modinotaButton.UseVisualStyleBackColor = true;
            this.modinotaButton.Click += new System.EventHandler(this.modinotaButton_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(767, 400);
            this.Controls.Add(this.modinotaButton);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notaBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mhButton);
            this.Controls.Add(this.aprobadosButton);
            this.Controls.Add(this.suspensosButton);
            this.Controls.Add(this.todosButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.notaLabel);
            this.Controls.Add(this.nombreLabel3);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.dniBox);
            this.Name = "form";
            this.Text = "ventana calificaiones ";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label nombreLabel3;
        private System.Windows.Forms.Label notaLabel;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button todosButton;
        private System.Windows.Forms.Button suspensosButton;
        private System.Windows.Forms.Button aprobadosButton;
        private System.Windows.Forms.Button mhButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox notaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Button modinotaButton;
    }
}

