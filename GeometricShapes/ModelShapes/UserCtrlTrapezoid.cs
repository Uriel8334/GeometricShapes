using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapes.CtrlShapes;
using GeometricShapes.Utility;

namespace GeometricShapes.ModelShapes
{
    public partial class UserCtrlTrapezoid : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue1 = null;
        private double? validateValue2 = null;
        private double? validateValue3 = null;

        //metodo contructor
        public UserCtrlTrapezoid()
        {
            InitializeComponent();
        }

        //metodo para calular el area 
        public double? CalculateArea()
        {
            if (validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtBaseOne, "Base Mayor");
            }
            if (validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtBaseTwo, "Base Menor");
            }
            if (validateValue3 == null)
            {
                validateValue3 = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue || !validateValue3.HasValue)
            {
                return null;
            }
            Trapezoid trapezoid = new Trapezoid(validateValue1.Value, validateValue2.Value, validateValue3.Value);
            return trapezoid.CalculateArea();
        }

        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtBaseOne, "Base Mayor");
            }
            if (validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtBaseTwo, "Base Menor");
            }
            if (validateValue3 == null)
            {
                validateValue3 = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue || !validateValue3.HasValue)
            {
                return null;
            }
            Trapezoid trapezoid = new Trapezoid(validateValue1.Value, validateValue2.Value, validateValue3.Value);
            return trapezoid.CalculatePerimeter();
        }

        //metodo para validar positivos 
        public bool ValidateInput()
        {
            validateValue1 = FuncValidation.ValidatePositiveNumber(txtBaseOne, "Base Mayor");
            validateValue2 = FuncValidation.ValidatePositiveNumber(txtBaseTwo, "Base Menor");
            validateValue3 = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            return validateValue1.HasValue && validateValue2.HasValue && validateValue3.HasValue;

        }
    }
}
