namespace EjercicioSalarioEmpleado
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
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.btnCalcularSalario = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa para calcular salario de empleado";
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(21, 136);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(503, 28);
            this.lblHorasTrabajadas.TabIndex = 1;
            this.lblHorasTrabajadas.Text = "Ingrese las horas trabajadas por el empleado: ";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHora.Location = new System.Drawing.Point(21, 209);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(334, 28);
            this.lblValorHora.TabIndex = 2;
            this.lblValorHora.Text = "Ingrese el valor de cada hora: ";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(554, 143);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabajadas.TabIndex = 3;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(375, 217);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 31);
            this.txtValorHora.TabIndex = 4;
            // 
            // btnCalcularSalario
            // 
            this.btnCalcularSalario.Location = new System.Drawing.Point(319, 272);
            this.btnCalcularSalario.Name = "btnCalcularSalario";
            this.btnCalcularSalario.Size = new System.Drawing.Size(117, 42);
            this.btnCalcularSalario.TabIndex = 5;
            this.btnCalcularSalario.Text = "Calcular salario";
            this.btnCalcularSalario.UseVisualStyleBackColor = true;
            this.btnCalcularSalario.Click += new System.EventHandler(this.btnCalcularSalario_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(57, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 28);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : ";
            // 
            // lblTotalSalario
            // 
            this.lblTotalSalario.AutoSize = true;
            this.lblTotalSalario.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalario.Location = new System.Drawing.Point(148, 367);
            this.lblTotalSalario.Name = "lblTotalSalario";
            this.lblTotalSalario.Size = new System.Drawing.Size(174, 28);
            this.lblTotalSalario.TabIndex = 7;
            this.lblTotalSalario.Text = "Salario a pagar";
            this.lblTotalSalario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalSalario);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcularSalario);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblHorasTrabajadas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Button btnCalcularSalario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSalario;
    }
}

