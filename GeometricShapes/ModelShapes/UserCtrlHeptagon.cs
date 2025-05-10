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
    public partial class UserCtrlHeptagon : UserControl, BaseShape
    {
        //variable para validar el numero positivo
        private double? validateValue = null;

        public UserCtrlHeptagon()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            Heptagon heptagon = new Heptagon(validateValue.Value);
            return heptagon.CalculateArea();
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            Heptagon heptagon = new Heptagon(validateValue.Value);
            return heptagon.CalculatePerimeter();
        }

        public bool ValidateInput()
        {
            double? side = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            return side.HasValue;
        }
    }
}
