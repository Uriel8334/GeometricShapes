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
    public partial class UserCtrlOval : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue1 = null;
        private double? validateValue2 = null;

        //metodo contructor 
        public UserCtrlOval()
        {
            InitializeComponent();
        }

        //metodo para calcular el area 
        public double? CalculateArea()
        {
            if (validateValue1 != null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtFocusA, "Radio Mayor");
            }
            if (validateValue2 != null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtFocusB, "Radio Menor");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Oval oval = new Oval(validateValue1.Value, validateValue2.Value);
            return oval.CalculateArea();
        }

        //metodo para calcular el perimetro 
        public double? CalculatePerimeter()
        {
            if (validateValue1 != null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtFocusA, "Radio Mayor");
            }
            if (validateValue2 != null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtFocusB, "Radio Menor");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Oval oval = new Oval(validateValue1.Value, validateValue2.Value);
            return oval.CalculatePerimeter();
        }

        //metodo para validar los datos ingresados positivos 
        public bool ValidateInput()
        {
            validateValue1 = FuncValidation.ValidatePositiveNumber(txtFocusA, "Foco A");
            validateValue2 = FuncValidation.ValidatePositiveNumber(txtFocusB, "Foco B");
            return validateValue1.HasValue && validateValue2.HasValue;
        }
    }

}
