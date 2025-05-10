using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapes.Utility;

namespace GeometricShapes.ModelShapes
{
    public partial class UserCtrlCircle : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue = null;

        //constructor de la clase UserCtrlCircle
        public UserCtrlCircle()
        {
            InitializeComponent();
        }

        // Método para calcular el área
        public double? CalculateArea()
        {
            Circle circle = new Circle(validateValue.Value);
            return circle.CalculateArea();
        }

        // Método para calcular el perímetro
        public double? CalculatePerimeter()
        {
            Circle circle = new Circle(validateValue.Value);
            return circle.CalculatePerimeter();
        }

        public bool ValidateInput()
        {
            validateValue = FuncValidation.ValidatePositiveNumber(txtRadius, "Radio");
            return validateValue.HasValue;
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            validateValue = null;
        }

    }
}
