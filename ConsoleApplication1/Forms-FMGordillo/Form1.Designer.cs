namespace Forms_FMGordillo
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
            this.label_alumno_nombre = new System.Windows.Forms.Label();
            this.textBox_alumno_nombre = new System.Windows.Forms.TextBox();
            this.label_alumno_apellido = new System.Windows.Forms.Label();
            this.textBox_alumno_apellido = new System.Windows.Forms.TextBox();
            this.label_alumno_legajo = new System.Windows.Forms.Label();
            this.textBox_alumno_legajo = new System.Windows.Forms.TextBox();
            this.listBox_alumno_materia = new System.Windows.Forms.ListBox();
            this.dateTimePicker_materia_fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox_alumno = new System.Windows.Forms.GroupBox();
            this.groupBox_materia = new System.Windows.Forms.GroupBox();
            this.comboBox_materia_nota = new System.Windows.Forms.ComboBox();
            this.comboBox_materia_nombre = new System.Windows.Forms.ComboBox();
            this.label_materia_nota = new System.Windows.Forms.Label();
            this.label_materia_fecha = new System.Windows.Forms.Label();
            this.label_materia_nombre = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.alumnoMateriaListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_alumno.SuspendLayout();
            this.groupBox_materia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoMateriaListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_alumno_nombre
            // 
            this.label_alumno_nombre.AutoSize = true;
            this.label_alumno_nombre.Location = new System.Drawing.Point(6, 16);
            this.label_alumno_nombre.Name = "label_alumno_nombre";
            this.label_alumno_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_alumno_nombre.TabIndex = 0;
            this.label_alumno_nombre.Text = "Nombre";
            // 
            // textBox_alumno_nombre
            // 
            this.textBox_alumno_nombre.Location = new System.Drawing.Point(6, 33);
            this.textBox_alumno_nombre.Name = "textBox_alumno_nombre";
            this.textBox_alumno_nombre.Size = new System.Drawing.Size(198, 20);
            this.textBox_alumno_nombre.TabIndex = 1;
            // 
            // label_alumno_apellido
            // 
            this.label_alumno_apellido.AutoSize = true;
            this.label_alumno_apellido.Location = new System.Drawing.Point(6, 60);
            this.label_alumno_apellido.Name = "label_alumno_apellido";
            this.label_alumno_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_alumno_apellido.TabIndex = 2;
            this.label_alumno_apellido.Text = "Apellido";
            // 
            // textBox_alumno_apellido
            // 
            this.textBox_alumno_apellido.Location = new System.Drawing.Point(6, 77);
            this.textBox_alumno_apellido.Name = "textBox_alumno_apellido";
            this.textBox_alumno_apellido.Size = new System.Drawing.Size(198, 20);
            this.textBox_alumno_apellido.TabIndex = 3;
            // 
            // label_alumno_legajo
            // 
            this.label_alumno_legajo.AutoSize = true;
            this.label_alumno_legajo.Location = new System.Drawing.Point(6, 104);
            this.label_alumno_legajo.Name = "label_alumno_legajo";
            this.label_alumno_legajo.Size = new System.Drawing.Size(110, 13);
            this.label_alumno_legajo.TabIndex = 4;
            this.label_alumno_legajo.Text = "Legajo (solo numeros)";
            // 
            // textBox_alumno_legajo
            // 
            this.textBox_alumno_legajo.Location = new System.Drawing.Point(6, 121);
            this.textBox_alumno_legajo.Name = "textBox_alumno_legajo";
            this.textBox_alumno_legajo.Size = new System.Drawing.Size(198, 20);
            this.textBox_alumno_legajo.TabIndex = 5;
            // 
            // listBox_alumno_materia
            // 
            this.listBox_alumno_materia.DataSource = this.alumnoMateriaListBindingSource;
            this.listBox_alumno_materia.FormattingEnabled = true;
            this.listBox_alumno_materia.Location = new System.Drawing.Point(235, 12);
            this.listBox_alumno_materia.Name = "listBox_alumno_materia";
            this.listBox_alumno_materia.Size = new System.Drawing.Size(240, 147);
            this.listBox_alumno_materia.TabIndex = 6;
            // 
            // dateTimePicker_materia_fecha
            // 
            this.dateTimePicker_materia_fecha.Location = new System.Drawing.Point(6, 75);
            this.dateTimePicker_materia_fecha.Name = "dateTimePicker_materia_fecha";
            this.dateTimePicker_materia_fecha.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_materia_fecha.TabIndex = 7;
            // 
            // groupBox_alumno
            // 
            this.groupBox_alumno.Controls.Add(this.label_alumno_nombre);
            this.groupBox_alumno.Controls.Add(this.textBox_alumno_nombre);
            this.groupBox_alumno.Controls.Add(this.label_alumno_apellido);
            this.groupBox_alumno.Controls.Add(this.textBox_alumno_legajo);
            this.groupBox_alumno.Controls.Add(this.textBox_alumno_apellido);
            this.groupBox_alumno.Controls.Add(this.label_alumno_legajo);
            this.groupBox_alumno.Location = new System.Drawing.Point(12, 12);
            this.groupBox_alumno.Name = "groupBox_alumno";
            this.groupBox_alumno.Size = new System.Drawing.Size(217, 156);
            this.groupBox_alumno.TabIndex = 8;
            this.groupBox_alumno.TabStop = false;
            this.groupBox_alumno.Text = "Datos del alumno";
            // 
            // groupBox_materia
            // 
            this.groupBox_materia.Controls.Add(this.comboBox_materia_nota);
            this.groupBox_materia.Controls.Add(this.comboBox_materia_nombre);
            this.groupBox_materia.Controls.Add(this.label_materia_nota);
            this.groupBox_materia.Controls.Add(this.label_materia_fecha);
            this.groupBox_materia.Controls.Add(this.dateTimePicker_materia_fecha);
            this.groupBox_materia.Controls.Add(this.label_materia_nombre);
            this.groupBox_materia.Location = new System.Drawing.Point(12, 174);
            this.groupBox_materia.Name = "groupBox_materia";
            this.groupBox_materia.Size = new System.Drawing.Size(217, 152);
            this.groupBox_materia.TabIndex = 9;
            this.groupBox_materia.TabStop = false;
            this.groupBox_materia.Text = "Datos de la materia";
            // 
            // comboBox_materia_nota
            // 
            this.comboBox_materia_nota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_materia_nota.FormattingEnabled = true;
            this.comboBox_materia_nota.Location = new System.Drawing.Point(6, 119);
            this.comboBox_materia_nota.Name = "comboBox_materia_nota";
            this.comboBox_materia_nota.Size = new System.Drawing.Size(44, 21);
            this.comboBox_materia_nota.TabIndex = 11;
            // 
            // comboBox_materia_nombre
            // 
            this.comboBox_materia_nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_materia_nombre.FormattingEnabled = true;
            this.comboBox_materia_nombre.Location = new System.Drawing.Point(6, 32);
            this.comboBox_materia_nombre.Name = "comboBox_materia_nombre";
            this.comboBox_materia_nombre.Size = new System.Drawing.Size(197, 21);
            this.comboBox_materia_nombre.Sorted = true;
            this.comboBox_materia_nombre.TabIndex = 10;
            // 
            // label_materia_nota
            // 
            this.label_materia_nota.AutoSize = true;
            this.label_materia_nota.Location = new System.Drawing.Point(6, 102);
            this.label_materia_nota.Name = "label_materia_nota";
            this.label_materia_nota.Size = new System.Drawing.Size(30, 13);
            this.label_materia_nota.TabIndex = 8;
            this.label_materia_nota.Text = "Nota";
            // 
            // label_materia_fecha
            // 
            this.label_materia_fecha.AutoSize = true;
            this.label_materia_fecha.Location = new System.Drawing.Point(6, 59);
            this.label_materia_fecha.Name = "label_materia_fecha";
            this.label_materia_fecha.Size = new System.Drawing.Size(37, 13);
            this.label_materia_fecha.TabIndex = 4;
            this.label_materia_fecha.Text = "Fecha";
            // 
            // label_materia_nombre
            // 
            this.label_materia_nombre.AutoSize = true;
            this.label_materia_nombre.Location = new System.Drawing.Point(6, 16);
            this.label_materia_nombre.Name = "label_materia_nombre";
            this.label_materia_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_materia_nombre.TabIndex = 3;
            this.label_materia_nombre.Text = "Nombre";
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(12, 333);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(217, 23);
            this.btn_accept.TabIndex = 10;
            this.btn_accept.Text = "Agregar alumno / materia";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // alumnoMateriaListBindingSource
            // 
            this.alumnoMateriaListBindingSource.DataSource = typeof(Forms_FMGordillo.AlumnoMateriaList);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 403);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.groupBox_materia);
            this.Controls.Add(this.groupBox_alumno);
            this.Controls.Add(this.listBox_alumno_materia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_alumno.ResumeLayout(false);
            this.groupBox_alumno.PerformLayout();
            this.groupBox_materia.ResumeLayout(false);
            this.groupBox_materia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoMateriaListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_alumno_nombre;
        private System.Windows.Forms.TextBox textBox_alumno_nombre;
        private System.Windows.Forms.Label label_alumno_apellido;
        private System.Windows.Forms.TextBox textBox_alumno_apellido;
        private System.Windows.Forms.Label label_alumno_legajo;
        private System.Windows.Forms.TextBox textBox_alumno_legajo;
        private System.Windows.Forms.ListBox listBox_alumno_materia;
        private System.Windows.Forms.DateTimePicker dateTimePicker_materia_fecha;
        private System.Windows.Forms.GroupBox groupBox_alumno;
        private System.Windows.Forms.GroupBox groupBox_materia;
        private System.Windows.Forms.Label label_materia_nombre;
        private System.Windows.Forms.Label label_materia_fecha;
        private System.Windows.Forms.Label label_materia_nota;
        private System.Windows.Forms.ComboBox comboBox_materia_nombre;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.ComboBox comboBox_materia_nota;
        private System.Windows.Forms.BindingSource alumnoMateriaListBindingSource;
    }
}

