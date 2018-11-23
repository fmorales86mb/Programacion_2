namespace PreParcialLabo_II
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
            this.btnArribos = new System.Windows.Forms.Button();
            this.btnArrancarTren = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArribos
            // 
            this.btnArribos.Location = new System.Drawing.Point(117, 471);
            this.btnArribos.Margin = new System.Windows.Forms.Padding(6);
            this.btnArribos.Name = "btnArribos";
            this.btnArribos.Size = new System.Drawing.Size(572, 70);
            this.btnArribos.TabIndex = 1;
            this.btnArribos.Text = "Arribos";
            this.btnArribos.UseVisualStyleBackColor = true;
            this.btnArribos.Click += new System.EventHandler(this.btnArribos_Click);
            // 
            // btnArrancarTren
            // 
            this.btnArrancarTren.Location = new System.Drawing.Point(22, 37);
            this.btnArrancarTren.Margin = new System.Windows.Forms.Padding(6);
            this.btnArrancarTren.Name = "btnArrancarTren";
            this.btnArrancarTren.Size = new System.Drawing.Size(667, 410);
            this.btnArrancarTren.TabIndex = 0;
            this.btnArrancarTren.Text = "Arrancar Tren";
            this.btnArrancarTren.UseVisualStyleBackColor = true;
            this.btnArrancarTren.Click += new System.EventHandler(this.btnArrancarTren_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDown1.Location = new System.Drawing.Point(22, 471);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 29);
            this.numericUpDown1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 569);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnArribos);
            this.Controls.Add(this.btnArrancarTren);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnArribos;
        private System.Windows.Forms.Button btnArrancarTren;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

