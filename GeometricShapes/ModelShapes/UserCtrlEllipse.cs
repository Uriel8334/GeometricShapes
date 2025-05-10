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
    public partial class UserCtrlEllipse : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue1 = null;
        private double? validateValue2 = null;
        public UserCtrlEllipse()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtMajorRadius, "Radio Mayor");
            }
            if (validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtMinorRadius, "Radio Menor");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Ellipse ellipse = new Ellipse(validateValue1.Value, validateValue2.Value);
            return ellipse.CalculateArea();
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtMajorRadius, "Radio Mayor");
            }
            if (validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtMinorRadius, "Radio Menor");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Ellipse ellipse = new Ellipse(validateValue1.Value, validateValue2.Value);
            return ellipse.CalculatePerimeter();
        }

        public bool ValidateInput()
        {
            validateValue1 = FuncValidation.ValidatePositiveNumber(txtMajorRadius, "Radio Mayor");
            validateValue2 = FuncValidation.ValidatePositiveNumber(txtMinorRadius, "Radio Menor");
            return validateValue1.HasValue && validateValue2.HasValue;
        }
    }
}
