namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlRhombus
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
            this.lblMajorDiagonal = new System.Windows.Forms.Label();
            this.txtMajorDiagonal = new System.Windows.Forms.TextBox();
            this.lblMinorDiagonal = new System.Windows.Forms.Label();
            this.txtMinorDiagonal = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblSide);
            this.grpInputs.Controls.Add(this.txtSide);
            this.grpInputs.Controls.Add(this.lblMajorDiagonal);
            this.grpInputs.Controls.Add(this.txtMajorDiagonal);
            this.grpInputs.Controls.Add(this.lblMinorDiagonal);
            this.grpInputs.Controls.Add(this.txtMinorDiagonal);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(322, 148);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(22, 100);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(48, 19);
            this.lblSide.TabIndex = 10;
            this.lblSide.Text = "Lado";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(191, 100);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(121, 27);
            this.txtSide.TabIndex = 9;
            // 
            // lblMajorDiagonal
            // 
            this.lblMajorDiagonal.AutoSize = true;
            this.lblMajorDiagonal.Location = new System.Drawing.Point(22, 67);
            this.lblMajorDiagonal.Name = "lblMajorDiagonal";
            this.lblMajorDiagonal.Size = new System.Drawing.Size(136, 19);
            this.lblMajorDiagonal.TabIndex = 6;
            this.lblMajorDiagonal.Text = "Diagonal mayor";
            // 
            // txtMajorDiagonal
            // 
            this.txtMajorDiagonal.Location = new System.Drawing.Point(191, 67);
            this.txtMajorDiagonal.Name = "txtMajorDiagonal";
            this.txtMajorDiagonal.Size = new System.Drawing.Size(121, 27);
            this.txtMajorDiagonal.TabIndex = 5;
            // 
            // lblMinorDiagonal
            // 
            this.lblMinorDiagonal.AutoSize = true;
            this.lblMinorDiagonal.Location = new System.Drawing.Point(22, 34);
            this.lblMinorDiagonal.Name = "lblMinorDiagonal";
            this.lblMinorDiagonal.Size = new System.Drawing.Size(136, 19);
            this.lblMinorDiagonal.TabIndex = 2;
            this.lblMinorDiagonal.Text = "Diagonal menor";
            // 
            // txtMinorDiagonal
            // 
            this.txtMinorDiagonal.Location = new System.Drawing.Point(191, 34);
            this.txtMinorDiagonal.Name = "txtMinorDiagonal";
            this.txtMinorDiagonal.Size = new System.Drawing.Size(121, 27);
            this.txtMinorDiagonal.TabIndex = 0;
            // 
            // UserCtrlRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlRhombus";
            this.Size = new System.Drawing.Size(342, 341);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblMajorDiagonal;
        private System.Windows.Forms.TextBox txtMajorDiagonal;
        private System.Windows.Forms.Label lblMinorDiagonal;
        private System.Windows.Forms.TextBox txtMinorDiagonal;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
    }
}
