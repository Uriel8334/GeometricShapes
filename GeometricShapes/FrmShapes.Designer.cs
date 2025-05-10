namespace GeometricShapes
{
    partial class FrmShapes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxShapes = new System.Windows.Forms.ComboBox();
            this.grpTypeShape = new System.Windows.Forms.GroupBox();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpTypeShape.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxShapes
            // 
            this.boxShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxShapes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.boxShapes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxShapes.ForeColor = System.Drawing.Color.Black;
            this.boxShapes.FormattingEnabled = true;
            this.boxShapes.ItemHeight = 23;
            this.boxShapes.Items.AddRange(new object[] {
            "Círculo",
            "Cuadrado",
            "Decágono",
            "Deltoide",
            "Elipse",
            "Eneágono",
            "Heptágono",
            "Hexágono",
            "Octágono",
            "Pentágono",
            "Rectángulo",
            "Rombo",
            "Romboide",
            "Trapecio",
            "Trapecio Isósceles",
            "Triángulo",
            "Trapezoide",
            "Ovalo"});
            this.boxShapes.Location = new System.Drawing.Point(8, 33);
            this.boxShapes.Margin = new System.Windows.Forms.Padding(5);
            this.boxShapes.MaxDropDownItems = 5;
            this.boxShapes.Name = "boxShapes";
            this.boxShapes.Size = new System.Drawing.Size(257, 31);
            this.boxShapes.TabIndex = 3;
            this.boxShapes.Text = "Seleccione una opción";
            this.boxShapes.SelectedIndexChanged += new System.EventHandler(this.boxShapes_SelectedIndexChanged);
            // 
            // grpTypeShape
            // 
            this.grpTypeShape.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTypeShape.Controls.Add(this.grpOutputs);
            this.grpTypeShape.Controls.Add(this.lblTitle);
            this.grpTypeShape.Controls.Add(this.panelShapes);
            this.grpTypeShape.Controls.Add(this.btnExit);
            this.grpTypeShape.Controls.Add(this.boxShapes);
            this.grpTypeShape.Controls.Add(this.btnReset);
            this.grpTypeShape.Controls.Add(this.btnCalculate);
            this.grpTypeShape.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTypeShape.Location = new System.Drawing.Point(12, 12);
            this.grpTypeShape.Name = "grpTypeShape";
            this.grpTypeShape.Size = new System.Drawing.Size(724, 644);
            this.grpTypeShape.TabIndex = 4;
            this.grpTypeShape.TabStop = false;
            this.grpTypeShape.Text = "Tipos de Figuras";
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.lblPerimeter);
            this.grpOutputs.Controls.Add(this.txtPerimeter);
            this.grpOutputs.Controls.Add(this.lblArea);
            this.grpOutputs.Controls.Add(this.txtArea);
            this.grpOutputs.Location = new System.Drawing.Point(8, 525);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(710, 109);
            this.grpOutputs.TabIndex = 10;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Datos de Salidas";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(255, 44);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(102, 23);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "Perimetro";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(386, 44);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(121, 32);
            this.txtPerimeter.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(20, 44);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 23);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(83, 44);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(121, 32);
            this.txtArea.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(296, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Figura";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelShapes
            // 
            this.panelShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShapes.Location = new System.Drawing.Point(8, 97);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(710, 422);
            this.panelShapes.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(394, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 31);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 33);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 31);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FrmShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 663);
            this.Controls.Add(this.grpTypeShape);
            this.Name = "FrmShapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras Geometricas";
            this.grpTypeShape.ResumeLayout(false);
            this.grpTypeShape.PerformLayout();
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox boxShapes;
        private System.Windows.Forms.GroupBox grpTypeShape;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
    }
}