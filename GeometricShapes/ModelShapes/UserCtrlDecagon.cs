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
    public partial class UserCtrlDecagon : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue = null;
        public UserCtrlDecagon()
        {
            InitializeComponent();
        }
        //metodo para calcular el area
        public double? CalculateArea()
        {
            if(validateValue == null)
            {
                validateValue = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            }
            if (!validateValue.HasValue)
            {
                return null;
            }
            Decagon decagon = new Decagon(validateValue.Value);
            return decagon.CalculateArea();
        }
        //metodo para calcular el perimetro 
        public double? CalculatePerimeter()
        {
            if (validateValue == null)
            {
                validateValue = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            }
            if (!validateValue.HasValue)
            {
                return null;
            }
            Decagon decagon = new Decagon(validateValue.Value);
            return decagon.CalculatePerimeter();
        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {
            validateValue = null;
        }
        public bool ValidateInput()
        {
            validateValue = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            return validateValue.HasValue;
        }
    }
}
