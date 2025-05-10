namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlEnneagon
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblSide);
            this.grpInputs.Controls.Add(this.txtSide);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(209, 79);
            this.grpInputs.TabIndex = 7;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(15, 34);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(48, 19);
            this.lblSide.TabIndex = 2;
            this.lblSide.Text = "Lado";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(69, 34);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(121, 27);
            this.txtSide.TabIndex = 0;
            // 
            // UserCtrlEnneagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlEnneagon";
            this.Size = new System.Drawing.Size(224, 261);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
    }
}
