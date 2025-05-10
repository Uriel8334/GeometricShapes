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
    public partial class UserCtrlDeltoid : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue1 = null;
        private double? validateValue2 = null;
        public UserCtrlDeltoid()
        {
            InitializeComponent();
        }
        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtPrincipalDiagonal, "Diagonal Principal");
            }
            if (validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtSecondaryDiagonal, "Diagonal Secundaria");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Deltoid deltoid = new Deltoid(validateValue1.Value, validateValue2.Value);
            return deltoid.CalculateArea();
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if(validateValue1 == null)
            {
                validateValue1 = FuncValidation.ValidatePositiveNumber(txtPrincipalDiagonal, "Diagonal Principal");
            }
            if(validateValue2 == null)
            {
                validateValue2 = FuncValidation.ValidatePositiveNumber(txtSecondaryDiagonal, "Diagonal Secundaria");
            }
            if (!validateValue1.HasValue || !validateValue2.HasValue)
            {
                return null;
            }
            Deltoid deltoid = new Deltoid(validateValue1.Value, validateValue2.Value);
            return deltoid.CalculatePerimeter();
        }

        private void txtPrincipalDiagonal_TextChanged(object sender, EventArgs e)
        {
            validateValue1 = null;
        }
        private void txtSecondaryDiagonal_TextChanged(object sender, EventArgs e)
        {
            validateValue2 = null;
        }

        public bool ValidateInput()
        {
            validateValue1 = FuncValidation.ValidatePositiveNumber(txtPrincipalDiagonal, "Diagonal Principal");
            validateValue2 = FuncValidation.ValidatePositiveNumber(txtSecondaryDiagonal, "Diagonal Secundaria");
            return validateValue1.HasValue && validateValue2.HasValue;
        }
    }
}
