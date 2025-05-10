namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlRectangle
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
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblHeight);
            this.grpInputs.Controls.Add(this.txtHeight);
            this.grpInputs.Controls.Add(this.lblBase);
            this.grpInputs.Controls.Add(this.txtBase);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(271, 125);
            this.grpInputs.TabIndex = 9;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 67);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 19);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Altura";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(120, 67);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 27);
            this.txtHeight.TabIndex = 5;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(22, 34);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(45, 19);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(120, 34);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(121, 27);
            this.txtBase.TabIndex = 0;
            // 
            // UserCtrlRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlRectangle";
            this.Size = new System.Drawing.Size(333, 305);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
    }
}
