namespace ejercicio5_Sebastian_Rosales
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
            this.label1 = new System.Windows.Forms.Label();
            this.itxt = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.jtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de la matriz";
            // 
            // itxt
            // 
            this.itxt.Location = new System.Drawing.Point(57, 67);
            this.itxt.Name = "itxt";
            this.itxt.Size = new System.Drawing.Size(100, 20);
            this.itxt.TabIndex = 1;
            this.itxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itxt_KeyPress);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(138, 125);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // jtxt
            // 
            this.jtxt.Location = new System.Drawing.Point(196, 67);
            this.jtxt.Name = "jtxt";
            this.jtxt.Size = new System.Drawing.Size(100, 20);
            this.jtxt.TabIndex = 3;
            this.jtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jtxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columnas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jtxt);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.itxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itxt;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox jtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

