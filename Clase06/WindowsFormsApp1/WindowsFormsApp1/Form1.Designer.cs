namespace WindowsFormsApp1
{
  partial class frmPrincipal
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grbManejoFrm = new System.Windows.Forms.GroupBox();
            this.btnCrearFrm = new System.Windows.Forms.Button();
            this.btnOrdenarFrms = new System.Windows.Forms.Button();
            this.grbControles = new System.Windows.Forms.GroupBox();
            this.chkPerro = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRadioButon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grbManejoFrm.SuspendLayout();
            this.grbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(196, 37);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Mostrar MessageBox";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(36, 37);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Forms";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // grbManejoFrm
            // 
            this.grbManejoFrm.Controls.Add(this.btnOrdenarFrms);
            this.grbManejoFrm.Controls.Add(this.btnCrearFrm);
            this.grbManejoFrm.Controls.Add(this.btnMostrar);
            this.grbManejoFrm.Controls.Add(this.btnAceptar);
            this.grbManejoFrm.Location = new System.Drawing.Point(21, 12);
            this.grbManejoFrm.Name = "grbManejoFrm";
            this.grbManejoFrm.Size = new System.Drawing.Size(571, 85);
            this.grbManejoFrm.TabIndex = 2;
            this.grbManejoFrm.TabStop = false;
            this.grbManejoFrm.Text = "Manejo de Formularios";
            // 
            // btnCrearFrm
            // 
            this.btnCrearFrm.Location = new System.Drawing.Point(356, 37);
            this.btnCrearFrm.Name = "btnCrearFrm";
            this.btnCrearFrm.Size = new System.Drawing.Size(75, 23);
            this.btnCrearFrm.TabIndex = 2;
            this.btnCrearFrm.Text = "Crear Form";
            this.btnCrearFrm.UseVisualStyleBackColor = true;
            this.btnCrearFrm.Click += new System.EventHandler(this.btnCrearFrm_Click);
            // 
            // btnOrdenarFrms
            // 
            this.btnOrdenarFrms.Location = new System.Drawing.Point(459, 37);
            this.btnOrdenarFrms.Name = "btnOrdenarFrms";
            this.btnOrdenarFrms.Size = new System.Drawing.Size(87, 23);
            this.btnOrdenarFrms.TabIndex = 3;
            this.btnOrdenarFrms.Text = "Ordenar Forms";
            this.btnOrdenarFrms.UseVisualStyleBackColor = true;
            this.btnOrdenarFrms.Click += new System.EventHandler(this.btnOrdenarFrms_Click);
            // 
            // grbControles
            // 
            this.grbControles.Controls.Add(this.checkBox1);
            this.grbControles.Controls.Add(this.button5);
            this.grbControles.Controls.Add(this.button4);
            this.grbControles.Controls.Add(this.button3);
            this.grbControles.Controls.Add(this.btnRadioButon);
            this.grbControles.Controls.Add(this.button1);
            this.grbControles.Controls.Add(this.tbNombre);
            this.grbControles.Controls.Add(this.rdbFemenino);
            this.grbControles.Controls.Add(this.rdbMasc);
            this.grbControles.Controls.Add(this.listBox1);
            this.grbControles.Controls.Add(this.lblNombre);
            this.grbControles.Controls.Add(this.comboBox1);
            this.grbControles.Controls.Add(this.chkPerro);
            this.grbControles.Location = new System.Drawing.Point(21, 115);
            this.grbControles.Name = "grbControles";
            this.grbControles.Size = new System.Drawing.Size(571, 308);
            this.grbControles.TabIndex = 3;
            this.grbControles.TabStop = false;
            this.grbControles.Text = "Controles Principales";
            // 
            // chkPerro
            // 
            this.chkPerro.AutoSize = true;
            this.chkPerro.Location = new System.Drawing.Point(36, 151);
            this.chkPerro.Name = "chkPerro";
            this.chkPerro.Size = new System.Drawing.Size(51, 17);
            this.chkPerro.TabIndex = 0;
            this.chkPerro.Text = "Perro";
            this.chkPerro.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(408, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(36, 88);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 4;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(36, 111);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 5;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(134, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRadioButon
            // 
            this.btnRadioButon.Location = new System.Drawing.Point(167, 88);
            this.btnRadioButon.Name = "btnRadioButon";
            this.btnRadioButon.Size = new System.Drawing.Size(116, 23);
            this.btnRadioButon.TabIndex = 8;
            this.btnRadioButon.Text = "Mostrar RadioButon";
            this.btnRadioButon.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(459, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.grbControles);
            this.Controls.Add(this.grbManejoFrm);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.grbManejoFrm.ResumeLayout(false);
            this.grbControles.ResumeLayout(false);
            this.grbControles.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox grbManejoFrm;
        private System.Windows.Forms.Button btnCrearFrm;
        private System.Windows.Forms.Button btnOrdenarFrms;
        private System.Windows.Forms.GroupBox grbControles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRadioButon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkPerro;
    }
}

