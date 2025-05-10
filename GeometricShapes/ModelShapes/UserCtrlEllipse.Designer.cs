namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlEllipse
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
            this.lblMajorRadius = new System.Windows.Forms.Label();
            this.txtMajorRadius = new System.Windows.Forms.TextBox();
            this.lblMinorRadius = new System.Windows.Forms.Label();
            this.txtMinorRadius = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblMajorRadius);
            this.grpInputs.Controls.Add(this.txtMajorRadius);
            this.grpInputs.Controls.Add(this.lblMinorRadius);
            this.grpInputs.Controls.Add(this.txtMinorRadius);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(318, 109);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblMajorRadius
            // 
            this.lblMajorRadius.AutoSize = true;
            this.lblMajorRadius.Location = new System.Drawing.Point(22, 67);
            this.lblMajorRadius.Name = "lblMajorRadius";
            this.lblMajorRadius.Size = new System.Drawing.Size(136, 19);
            this.lblMajorRadius.TabIndex = 6;
            this.lblMajorRadius.Text = "Radio mayor (b)";
            // 
            // txtMajorRadius
            // 
            this.txtMajorRadius.Location = new System.Drawing.Point(172, 67);
            this.txtMajorRadius.Name = "txtMajorRadius";
            this.txtMajorRadius.Size = new System.Drawing.Size(121, 27);
            this.txtMajorRadius.TabIndex = 5;
            // 
            // lblMinorRadius
            // 
            this.lblMinorRadius.AutoSize = true;
            this.lblMinorRadius.Location = new System.Drawing.Point(22, 34);
            this.lblMinorRadius.Name = "lblMinorRadius";
            this.lblMinorRadius.Size = new System.Drawing.Size(136, 19);
            this.lblMinorRadius.TabIndex = 2;
            this.lblMinorRadius.Text = "Radio menor (a)";
            // 
            // txtMinorRadius
            // 
            this.txtMinorRadius.Location = new System.Drawing.Point(172, 34);
            this.txtMinorRadius.Name = "txtMinorRadius";
            this.txtMinorRadius.Size = new System.Drawing.Size(121, 27);
            this.txtMinorRadius.TabIndex = 0;
            // 
            // UserCtrlEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlEllipse";
            this.Size = new System.Drawing.Size(334, 304);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblMinorRadius;
        private System.Windows.Forms.TextBox txtMinorRadius;
        private System.Windows.Forms.Label lblMajorRadius;
        private System.Windows.Forms.TextBox txtMajorRadius;
    }
}
