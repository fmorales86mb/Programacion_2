namespace VistaForm
{
    partial class frmVistaCurso
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
            this.gbDatosCurso = new System.Windows.Forms.GroupBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dateProfesorIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblProfesorIngreso = new System.Windows.Forms.Label();
            this.txtProfesorDni = new System.Windows.Forms.TextBox();
            this.lblProfesorDni = new System.Windows.Forms.Label();
            this.txtProfesorApellido = new System.Windows.Forms.TextBox();
            this.lblProfesorApellido = new System.Windows.Forms.Label();
            this.txtProfesorNombre = new System.Windows.Forms.TextBox();
            this.lblProfesorNombre = new System.Windows.Forms.Label();
            this.cbCusroDivisiones = new System.Windows.Forms.ComboBox();
            this.lblCursoDivisiones = new System.Windows.Forms.Label();
            this.numCursoAnio = new System.Windows.Forms.NumericUpDown();
            this.lblCursoAnio = new System.Windows.Forms.Label();
            this.gbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbAlumnoDivisiones = new System.Windows.Forms.ComboBox();
            this.lblAlumnoDivision = new System.Windows.Forms.Label();
            this.numAlumnoAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAlumnoAnio = new System.Windows.Forms.Label();
            this.txtAlumnoLegajo = new System.Windows.Forms.TextBox();
            this.lblAlumnoLegajo = new System.Windows.Forms.Label();
            this.txtAlumnoApellido = new System.Windows.Forms.TextBox();
            this.lblAlumnoApellido = new System.Windows.Forms.Label();
            this.txtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.lblAlumnoNombre = new System.Windows.Forms.Label();
            this.rtxtCurso = new System.Windows.Forms.RichTextBox();
            this.gbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCursoAnio)).BeginInit();
            this.gbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlumnoAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCurso
            // 
            this.gbDatosCurso.Controls.Add(this.btnCrearCurso);
            this.gbDatosCurso.Controls.Add(this.btnMostrar);
            this.gbDatosCurso.Controls.Add(this.dateProfesorIngreso);
            this.gbDatosCurso.Controls.Add(this.lblProfesorIngreso);
            this.gbDatosCurso.Controls.Add(this.txtProfesorDni);
            this.gbDatosCurso.Controls.Add(this.lblProfesorDni);
            this.gbDatosCurso.Controls.Add(this.txtProfesorApellido);
            this.gbDatosCurso.Controls.Add(this.lblProfesorApellido);
            this.gbDatosCurso.Controls.Add(this.txtProfesorNombre);
            this.gbDatosCurso.Controls.Add(this.lblProfesorNombre);
            this.gbDatosCurso.Controls.Add(this.cbCusroDivisiones);
            this.gbDatosCurso.Controls.Add(this.lblCursoDivisiones);
            this.gbDatosCurso.Controls.Add(this.numCursoAnio);
            this.gbDatosCurso.Controls.Add(this.lblCursoAnio);
            this.gbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gbDatosCurso.Name = "gbDatosCurso";
            this.gbDatosCurso.Size = new System.Drawing.Size(298, 256);
            this.gbDatosCurso.TabIndex = 0;
            this.gbDatosCurso.TabStop = false;
            this.gbDatosCurso.Text = "Datos Curso";
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(12, 205);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(92, 36);
            this.btnCrearCurso.TabIndex = 16;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(187, 205);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 36);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dateProfesorIngreso
            // 
            this.dateProfesorIngreso.Location = new System.Drawing.Point(79, 164);
            this.dateProfesorIngreso.Name = "dateProfesorIngreso";
            this.dateProfesorIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateProfesorIngreso.TabIndex = 13;
            // 
            // lblProfesorIngreso
            // 
            this.lblProfesorIngreso.AutoSize = true;
            this.lblProfesorIngreso.Location = new System.Drawing.Point(9, 170);
            this.lblProfesorIngreso.Name = "lblProfesorIngreso";
            this.lblProfesorIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblProfesorIngreso.TabIndex = 12;
            this.lblProfesorIngreso.Text = "Ingreso";
            // 
            // txtProfesorDni
            // 
            this.txtProfesorDni.Location = new System.Drawing.Point(79, 138);
            this.txtProfesorDni.Name = "txtProfesorDni";
            this.txtProfesorDni.Size = new System.Drawing.Size(200, 20);
            this.txtProfesorDni.TabIndex = 11;
            // 
            // lblProfesorDni
            // 
            this.lblProfesorDni.AutoSize = true;
            this.lblProfesorDni.Location = new System.Drawing.Point(7, 141);
            this.lblProfesorDni.Name = "lblProfesorDni";
            this.lblProfesorDni.Size = new System.Drawing.Size(26, 13);
            this.lblProfesorDni.TabIndex = 10;
            this.lblProfesorDni.Text = "DNI";
            // 
            // txtProfesorApellido
            // 
            this.txtProfesorApellido.Location = new System.Drawing.Point(79, 112);
            this.txtProfesorApellido.Name = "txtProfesorApellido";
            this.txtProfesorApellido.Size = new System.Drawing.Size(200, 20);
            this.txtProfesorApellido.TabIndex = 9;
            // 
            // lblProfesorApellido
            // 
            this.lblProfesorApellido.AutoSize = true;
            this.lblProfesorApellido.Location = new System.Drawing.Point(7, 115);
            this.lblProfesorApellido.Name = "lblProfesorApellido";
            this.lblProfesorApellido.Size = new System.Drawing.Size(44, 13);
            this.lblProfesorApellido.TabIndex = 8;
            this.lblProfesorApellido.Text = "Apellido";
            // 
            // txtProfesorNombre
            // 
            this.txtProfesorNombre.Location = new System.Drawing.Point(79, 86);
            this.txtProfesorNombre.Name = "txtProfesorNombre";
            this.txtProfesorNombre.Size = new System.Drawing.Size(200, 20);
            this.txtProfesorNombre.TabIndex = 7;
            // 
            // lblProfesorNombre
            // 
            this.lblProfesorNombre.AutoSize = true;
            this.lblProfesorNombre.Location = new System.Drawing.Point(7, 89);
            this.lblProfesorNombre.Name = "lblProfesorNombre";
            this.lblProfesorNombre.Size = new System.Drawing.Size(44, 13);
            this.lblProfesorNombre.TabIndex = 6;
            this.lblProfesorNombre.Text = "Nombre";
            // 
            // cbCusroDivisiones
            // 
            this.cbCusroDivisiones.FormattingEnabled = true;
            this.cbCusroDivisiones.Location = new System.Drawing.Point(79, 59);
            this.cbCusroDivisiones.Name = "cbCusroDivisiones";
            this.cbCusroDivisiones.Size = new System.Drawing.Size(200, 21);
            this.cbCusroDivisiones.TabIndex = 5;
            // 
            // lblCursoDivisiones
            // 
            this.lblCursoDivisiones.AutoSize = true;
            this.lblCursoDivisiones.Location = new System.Drawing.Point(6, 62);
            this.lblCursoDivisiones.Name = "lblCursoDivisiones";
            this.lblCursoDivisiones.Size = new System.Drawing.Size(55, 13);
            this.lblCursoDivisiones.TabIndex = 4;
            this.lblCursoDivisiones.Text = "Divisiones";
            // 
            // numCursoAnio
            // 
            this.numCursoAnio.Location = new System.Drawing.Point(79, 33);
            this.numCursoAnio.Name = "numCursoAnio";
            this.numCursoAnio.Size = new System.Drawing.Size(200, 20);
            this.numCursoAnio.TabIndex = 3;
            // 
            // lblCursoAnio
            // 
            this.lblCursoAnio.AutoSize = true;
            this.lblCursoAnio.Location = new System.Drawing.Point(6, 35);
            this.lblCursoAnio.Name = "lblCursoAnio";
            this.lblCursoAnio.Size = new System.Drawing.Size(26, 13);
            this.lblCursoAnio.TabIndex = 2;
            this.lblCursoAnio.Text = "Año";
            // 
            // gbDatosAlumno
            // 
            this.gbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gbDatosAlumno.Controls.Add(this.cbAlumnoDivisiones);
            this.gbDatosAlumno.Controls.Add(this.lblAlumnoDivision);
            this.gbDatosAlumno.Controls.Add(this.numAlumnoAnio);
            this.gbDatosAlumno.Controls.Add(this.lblAlumnoAnio);
            this.gbDatosAlumno.Controls.Add(this.txtAlumnoLegajo);
            this.gbDatosAlumno.Controls.Add(this.lblAlumnoLegajo);
            this.gbDatosAlumno.Controls.Add(this.txtAlumnoApellido);
            this.gbDatosAlumno.Controls.Add(this.lblAlumnoApellido);
            this.gbDatosAlumno.Controls.Add(this.txtAlumnoNombre);
            this.gbDatosAlumno.Controls.Add(this.lblAlumnoNombre);
            this.gbDatosAlumno.Location = new System.Drawing.Point(316, 12);
            this.gbDatosAlumno.Name = "gbDatosAlumno";
            this.gbDatosAlumno.Size = new System.Drawing.Size(294, 256);
            this.gbDatosAlumno.TabIndex = 2;
            this.gbDatosAlumno.TabStop = false;
            this.gbDatosAlumno.Text = "Datos Alumno";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(192, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 36);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbAlumnoDivisiones
            // 
            this.cbAlumnoDivisiones.FormattingEnabled = true;
            this.cbAlumnoDivisiones.Location = new System.Drawing.Point(84, 138);
            this.cbAlumnoDivisiones.Name = "cbAlumnoDivisiones";
            this.cbAlumnoDivisiones.Size = new System.Drawing.Size(200, 21);
            this.cbAlumnoDivisiones.TabIndex = 34;
            // 
            // lblAlumnoDivision
            // 
            this.lblAlumnoDivision.AutoSize = true;
            this.lblAlumnoDivision.Location = new System.Drawing.Point(11, 141);
            this.lblAlumnoDivision.Name = "lblAlumnoDivision";
            this.lblAlumnoDivision.Size = new System.Drawing.Size(55, 13);
            this.lblAlumnoDivision.TabIndex = 33;
            this.lblAlumnoDivision.Text = "Divisiones";
            // 
            // numAlumnoAnio
            // 
            this.numAlumnoAnio.Location = new System.Drawing.Point(84, 110);
            this.numAlumnoAnio.Name = "numAlumnoAnio";
            this.numAlumnoAnio.Size = new System.Drawing.Size(200, 20);
            this.numAlumnoAnio.TabIndex = 32;
            // 
            // lblAlumnoAnio
            // 
            this.lblAlumnoAnio.AutoSize = true;
            this.lblAlumnoAnio.Location = new System.Drawing.Point(14, 112);
            this.lblAlumnoAnio.Name = "lblAlumnoAnio";
            this.lblAlumnoAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAlumnoAnio.TabIndex = 31;
            this.lblAlumnoAnio.Text = "Año";
            // 
            // txtAlumnoLegajo
            // 
            this.txtAlumnoLegajo.Location = new System.Drawing.Point(84, 84);
            this.txtAlumnoLegajo.Name = "txtAlumnoLegajo";
            this.txtAlumnoLegajo.Size = new System.Drawing.Size(200, 20);
            this.txtAlumnoLegajo.TabIndex = 26;
            // 
            // lblAlumnoLegajo
            // 
            this.lblAlumnoLegajo.AutoSize = true;
            this.lblAlumnoLegajo.Location = new System.Drawing.Point(12, 87);
            this.lblAlumnoLegajo.Name = "lblAlumnoLegajo";
            this.lblAlumnoLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblAlumnoLegajo.TabIndex = 25;
            this.lblAlumnoLegajo.Text = "Legajo";
            // 
            // txtAlumnoApellido
            // 
            this.txtAlumnoApellido.Location = new System.Drawing.Point(84, 58);
            this.txtAlumnoApellido.Name = "txtAlumnoApellido";
            this.txtAlumnoApellido.Size = new System.Drawing.Size(200, 20);
            this.txtAlumnoApellido.TabIndex = 24;
            // 
            // lblAlumnoApellido
            // 
            this.lblAlumnoApellido.AutoSize = true;
            this.lblAlumnoApellido.Location = new System.Drawing.Point(12, 61);
            this.lblAlumnoApellido.Name = "lblAlumnoApellido";
            this.lblAlumnoApellido.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoApellido.TabIndex = 23;
            this.lblAlumnoApellido.Text = "Apellido";
            // 
            // txtAlumnoNombre
            // 
            this.txtAlumnoNombre.Location = new System.Drawing.Point(84, 32);
            this.txtAlumnoNombre.Name = "txtAlumnoNombre";
            this.txtAlumnoNombre.Size = new System.Drawing.Size(200, 20);
            this.txtAlumnoNombre.TabIndex = 22;
            // 
            // lblAlumnoNombre
            // 
            this.lblAlumnoNombre.AutoSize = true;
            this.lblAlumnoNombre.Location = new System.Drawing.Point(12, 35);
            this.lblAlumnoNombre.Name = "lblAlumnoNombre";
            this.lblAlumnoNombre.Size = new System.Drawing.Size(44, 13);
            this.lblAlumnoNombre.TabIndex = 21;
            this.lblAlumnoNombre.Text = "Nombre";
            // 
            // rtxtCurso
            // 
            this.rtxtCurso.Location = new System.Drawing.Point(12, 274);
            this.rtxtCurso.Name = "rtxtCurso";
            this.rtxtCurso.ReadOnly = true;
            this.rtxtCurso.Size = new System.Drawing.Size(598, 164);
            this.rtxtCurso.TabIndex = 3;
            this.rtxtCurso.Text = "";
            // 
            // frmVistaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 449);
            this.Controls.Add(this.rtxtCurso);
            this.Controls.Add(this.gbDatosAlumno);
            this.Controls.Add(this.gbDatosCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVistaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista del Curso";
            this.Load += new System.EventHandler(this.frmVistaCurso_Load);
            this.gbDatosCurso.ResumeLayout(false);
            this.gbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCursoAnio)).EndInit();
            this.gbDatosAlumno.ResumeLayout(false);
            this.gbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlumnoAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCurso;
        private System.Windows.Forms.Label lblCursoAnio;
        private System.Windows.Forms.GroupBox gbDatosAlumno;
        private System.Windows.Forms.TextBox txtProfesorDni;
        private System.Windows.Forms.Label lblProfesorDni;
        private System.Windows.Forms.TextBox txtProfesorApellido;
        private System.Windows.Forms.Label lblProfesorApellido;
        private System.Windows.Forms.TextBox txtProfesorNombre;
        private System.Windows.Forms.Label lblProfesorNombre;
        private System.Windows.Forms.ComboBox cbCusroDivisiones;
        private System.Windows.Forms.Label lblCursoDivisiones;
        private System.Windows.Forms.NumericUpDown numCursoAnio;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DateTimePicker dateProfesorIngreso;
        private System.Windows.Forms.Label lblProfesorIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbAlumnoDivisiones;
        private System.Windows.Forms.Label lblAlumnoDivision;
        private System.Windows.Forms.NumericUpDown numAlumnoAnio;
        private System.Windows.Forms.Label lblAlumnoAnio;
        private System.Windows.Forms.TextBox txtAlumnoLegajo;
        private System.Windows.Forms.Label lblAlumnoLegajo;
        private System.Windows.Forms.TextBox txtAlumnoApellido;
        private System.Windows.Forms.Label lblAlumnoApellido;
        private System.Windows.Forms.TextBox txtAlumnoNombre;
        private System.Windows.Forms.Label lblAlumnoNombre;
        private System.Windows.Forms.RichTextBox rtxtCurso;
    }
}

