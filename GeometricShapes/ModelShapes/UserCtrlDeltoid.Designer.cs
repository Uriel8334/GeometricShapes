namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlDeltoid
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
            this.txtSecondaryDiagonal = new System.Windows.Forms.TextBox();
            this.lblSecondaryDiagonal = new System.Windows.Forms.Label();
            this.lblPrincipalDiagonal = new System.Windows.Forms.Label();
            this.txtPrincipalDiagonal = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.txtSecondaryDiagonal);
            this.grpInputs.Controls.Add(this.lblSecondaryDiagonal);
            this.grpInputs.Controls.Add(this.lblPrincipalDiagonal);
            this.grpInputs.Controls.Add(this.txtPrincipalDiagonal);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(317, 122);
            this.grpInputs.TabIndex = 8;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // txtSecondaryDiagonal
            // 
            this.txtSecondaryDiagonal.Location = new System.Drawing.Point(185, 77);
            this.txtSecondaryDiagonal.Name = "txtSecondaryDiagonal";
            this.txtSecondaryDiagonal.Size = new System.Drawing.Size(121, 27);
            this.txtSecondaryDiagonal.TabIndex = 6;
            this.txtSecondaryDiagonal.TextChanged += new System.EventHandler(this.txtSecondaryDiagonal_TextChanged);
            // 
            // lblSecondaryDiagonal
            // 
            this.lblSecondaryDiagonal.AutoSize = true;
            this.lblSecondaryDiagonal.Location = new System.Drawing.Point(6, 77);
            this.lblSecondaryDiagonal.Name = "lblSecondaryDiagonal";
            this.lblSecondaryDiagonal.Size = new System.Drawing.Size(173, 19);
            this.lblSecondaryDiagonal.TabIndex = 5;
            this.lblSecondaryDiagonal.Text = "Diagonal secundaria";
            // 
            // lblPrincipalDiagonal
            // 
            this.lblPrincipalDiagonal.AutoSize = true;
            this.lblPrincipalDiagonal.Location = new System.Drawing.Point(6, 34);
            this.lblPrincipalDiagonal.Name = "lblPrincipalDiagonal";
            this.lblPrincipalDiagonal.Size = new System.Drawing.Size(155, 19);
            this.lblPrincipalDiagonal.TabIndex = 2;
            this.lblPrincipalDiagonal.Text = "Diagonal principal";
            // 
            // txtPrincipalDiagonal
            // 
            this.txtPrincipalDiagonal.Location = new System.Drawing.Point(185, 34);
            this.txtPrincipalDiagonal.Name = "txtPrincipalDiagonal";
            this.txtPrincipalDiagonal.Size = new System.Drawing.Size(121, 27);
            this.txtPrincipalDiagonal.TabIndex = 0;
            this.txtPrincipalDiagonal.TextChanged += new System.EventHandler(this.txtPrincipalDiagonal_TextChanged);
            // 
            // UserCtrlDeltoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlDeltoid";
            this.Size = new System.Drawing.Size(327, 162);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtSecondaryDiagonal;
        private System.Windows.Forms.Label lblSecondaryDiagonal;
        private System.Windows.Forms.Label lblPrincipalDiagonal;
        private System.Windows.Forms.TextBox txtPrincipalDiagonal;
    }
}
