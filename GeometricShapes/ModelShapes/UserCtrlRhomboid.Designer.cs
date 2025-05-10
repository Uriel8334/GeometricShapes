namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlRhomboid
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBaseLength = new System.Windows.Forms.Label();
            this.txtBaseLength = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblSide);
            this.grpInputs.Controls.Add(this.txtSide);
            this.grpInputs.Controls.Add(this.lblHeight);
            this.grpInputs.Controls.Add(this.txtHeight);
            this.grpInputs.Controls.Add(this.lblBaseLength);
            this.grpInputs.Controls.Add(this.txtBaseLength);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(327, 149);
            this.grpInputs.TabIndex = 7;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(22, 100);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(48, 19);
            this.lblSide.TabIndex = 8;
            this.lblSide.Text = "Lado";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(191, 100);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(121, 27);
            this.txtSide.TabIndex = 7;
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
            this.txtHeight.Location = new System.Drawing.Point(191, 67);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 27);
            this.txtHeight.TabIndex = 5;
            // 
            // lblBaseLength
            // 
            this.lblBaseLength.AutoSize = true;
            this.lblBaseLength.Location = new System.Drawing.Point(22, 34);
            this.lblBaseLength.Name = "lblBaseLength";
            this.lblBaseLength.Size = new System.Drawing.Size(45, 19);
            this.lblBaseLength.TabIndex = 2;
            this.lblBaseLength.Text = "Base";
            // 
            // txtBaseLength
            // 
            this.txtBaseLength.Location = new System.Drawing.Point(191, 34);
            this.txtBaseLength.Name = "txtBaseLength";
            this.txtBaseLength.Size = new System.Drawing.Size(121, 27);
            this.txtBaseLength.TabIndex = 0;
            // 
            // UserCtrlRhomboid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlRhomboid";
            this.Size = new System.Drawing.Size(343, 309);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblBaseLength;
        private System.Windows.Forms.TextBox txtBaseLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
    }
}
