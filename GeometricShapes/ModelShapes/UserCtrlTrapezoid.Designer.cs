namespace GeometricShapes.ModelShapes
{
    partial class UserCtrlTrapezoid
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
            this.lblBaseTwo = new System.Windows.Forms.Label();
            this.txtBaseTwo = new System.Windows.Forms.TextBox();
            this.lblBaseOne = new System.Windows.Forms.Label();
            this.txtBaseOne = new System.Windows.Forms.TextBox();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.lblHeight);
            this.grpInputs.Controls.Add(this.txtHeight);
            this.grpInputs.Controls.Add(this.lblBaseTwo);
            this.grpInputs.Controls.Add(this.txtBaseTwo);
            this.grpInputs.Controls.Add(this.lblBaseOne);
            this.grpInputs.Controls.Add(this.txtBaseOne);
            this.grpInputs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.grpInputs.Location = new System.Drawing.Point(3, 3);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(327, 149);
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
            this.txtHeight.Location = new System.Drawing.Point(191, 100);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(121, 27);
            this.txtHeight.TabIndex = 7;
            // 
            // lblBaseTwo
            // 
            this.lblBaseTwo.AutoSize = true;
            this.lblBaseTwo.Location = new System.Drawing.Point(22, 67);
            this.lblBaseTwo.Name = "lblBaseTwo";
            this.lblBaseTwo.Size = new System.Drawing.Size(58, 19);
            this.lblBaseTwo.TabIndex = 6;
            this.lblBaseTwo.Text = "Base 2";
            // 
            // txtBaseTwo
            // 
            this.txtBaseTwo.Location = new System.Drawing.Point(191, 67);
            this.txtBaseTwo.Name = "txtBaseTwo";
            this.txtBaseTwo.Size = new System.Drawing.Size(121, 27);
            this.txtBaseTwo.TabIndex = 5;
            // 
            // lblBaseOne
            // 
            this.lblBaseOne.AutoSize = true;
            this.lblBaseOne.Location = new System.Drawing.Point(22, 34);
            this.lblBaseOne.Name = "lblBaseOne";
            this.lblBaseOne.Size = new System.Drawing.Size(58, 19);
            this.lblBaseOne.TabIndex = 2;
            this.lblBaseOne.Text = "Base 1";
            // 
            // txtBaseOne
            // 
            this.txtBaseOne.Location = new System.Drawing.Point(191, 34);
            this.txtBaseOne.Name = "txtBaseOne";
            this.txtBaseOne.Size = new System.Drawing.Size(121, 27);
            this.txtBaseOne.TabIndex = 0;
            // 
            // UserCtrlTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInputs);
            this.Name = "UserCtrlTrapezoid";
            this.Size = new System.Drawing.Size(360, 445);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBaseTwo;
        private System.Windows.Forms.TextBox txtBaseTwo;
        private System.Windows.Forms.Label lblBaseOne;
        private System.Windows.Forms.TextBox txtBaseOne;
    }
}
