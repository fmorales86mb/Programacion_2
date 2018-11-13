namespace EjercicioClase
{
    partial class Frm1
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
            this.btnLlenar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(41, 62);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(75, 23);
            this.btnLlenar.TabIndex = 0;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 167);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLlenar);
            this.Name = "Frm1";
            this.Text = "Frm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.TextBox textBox1;
    }
}