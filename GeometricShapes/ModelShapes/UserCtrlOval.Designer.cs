namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlOval
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
            this.lblFocusB = new System.Windows.Forms.Label();
            this.txtFocusB = new System.Windows.Forms.TextBox();
            this.lblFocusA = new System.Windows.Forms.Label();
            this.txtFocusA = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblFocusB);
            this.grpInputs.Controls.Add(this.txtFocusB);
            this.grpInputs.Controls.Add(this.lblFocusA);
            this.grpInputs.Controls.Add(this.txtFocusA);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(318, 109);
            this.grpInputs.TabIndex = 9;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Datos de Entrada";
            // 
            // lblFocusB
            // 
            this.lblFocusB.AutoSize = true;
            this.lblFocusB.Location = new System.Drawing.Point(22, 67);
            this.lblFocusB.Name = "lblFocusB";
            this.lblFocusB.Size = new System.Drawing.Size(74, 19);
            this.lblFocusB.TabIndex = 6;
            this.lblFocusB.Text = "Foco (b)";
            // 
            // txtFocusB
            // 
            this.txtFocusB.Location = new System.Drawing.Point(172, 67);
            this.txtFocusB.Name = "txtFocusB";
            this.txtFocusB.Size = new System.Drawing.Size(121, 27);
            this.txtFocusB.TabIndex = 5;
            // 
            // lblFocusA
            // 
            this.lblFocusA.AutoSize = true;
            this.lblFocusA.Location = new System.Drawing.Point(22, 34);
            this.lblFocusA.Name = "lblFocusA";
            this.lblFocusA.Size = new System.Drawing.Size(74, 19);
            this.lblFocusA.TabIndex = 2;
            this.lblFocusA.Text = "Foco (a)";
            // 
            // txtFocusA
            // 
            this.txtFocusA.Location = new System.Drawing.Point(172, 34);
            this.txtFocusA.Name = "txtFocusA";
            this.txtFocusA.Size = new System.Drawing.Size(121, 27);
            this.txtFocusA.TabIndex = 0;
            // 
            // UserCtrlOval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlOval";
            this.Size = new System.Drawing.Size(419, 536);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblFocusB;
        private System.Windows.Forms.TextBox txtFocusB;
        private System.Windows.Forms.Label lblFocusA;
        private System.Windows.Forms.TextBox txtFocusA;
    }
}
