namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlIsoscelesTrapezium
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblMinorBase = new System.Windows.Forms.Label();
            this.txtMinorBase = new System.Windows.Forms.TextBox();
            this.lblMajorBase = new System.Windows.Forms.Label();
            this.txtMajorBase = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblHeight);
            this.grpInputs.Controls.Add(this.txtHeight);
            this.grpInputs.Controls.Add(this.lblMinorBase);
            this.grpInputs.Controls.Add(this.txtMinorBase);
            this.grpInputs.Controls.Add(this.lblMajorBase);
            this.grpInputs.Controls.Add(this.txtMajorBase);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(318, 146);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 100);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 19);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Altura";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(180, 100);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 27);
            this.txtHeight.TabIndex = 7;
            // 
            // lblMinorBase
            // 
            this.lblMinorBase.AutoSize = true;
            this.lblMinorBase.Location = new System.Drawing.Point(22, 67);
            this.lblMinorBase.Name = "lblMinorBase";
            this.lblMinorBase.Size = new System.Drawing.Size(100, 19);
            this.lblMinorBase.TabIndex = 6;
            this.lblMinorBase.Text = "Base menor";
            // 
            // txtMinorBase
            // 
            this.txtMinorBase.Location = new System.Drawing.Point(180, 67);
            this.txtMinorBase.Name = "txtMinorBase";
            this.txtMinorBase.Size = new System.Drawing.Size(121, 27);
            this.txtMinorBase.TabIndex = 5;
            // 
            // lblMajorBase
            // 
            this.lblMajorBase.AutoSize = true;
            this.lblMajorBase.Location = new System.Drawing.Point(22, 34);
            this.lblMajorBase.Name = "lblMajorBase";
            this.lblMajorBase.Size = new System.Drawing.Size(100, 19);
            this.lblMajorBase.TabIndex = 2;
            this.lblMajorBase.Text = "Base mayor";
            // 
            // txtMajorBase
            // 
            this.txtMajorBase.Location = new System.Drawing.Point(180, 34);
            this.txtMajorBase.Name = "txtMajorBase";
            this.txtMajorBase.Size = new System.Drawing.Size(121, 27);
            this.txtMajorBase.TabIndex = 0;
            // 
            // UserCtrlIsoscelesTrapezium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlIsoscelesTrapezium";
            this.Size = new System.Drawing.Size(334, 320);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblMinorBase;
        private System.Windows.Forms.TextBox txtMinorBase;
        private System.Windows.Forms.Label lblMajorBase;
        private System.Windows.Forms.TextBox txtMajorBase;
    }
}
