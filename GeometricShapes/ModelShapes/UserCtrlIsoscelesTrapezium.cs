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
    public partial class UserCtrlIsoscelesTrapezium : UserControl, BaseShape
    {
        public UserCtrlIsoscelesTrapezium()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (double.TryParse(txtMinorBase.Text, out double base1) && double.TryParse(txtMajorBase.Text, out double base2) && double.TryParse(txtHeight.Text, out double height))
            {
                IsoscelesTrapezium isoscelesTrapezium = new IsoscelesTrapezium(base1, base2, height);
                return isoscelesTrapezium.CalculateArea();
            }
            return null;
        }

        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtMinorBase.Text, out double base1) && double.TryParse(txtMajorBase.Text, out double base2) && double.TryParse(txtHeight.Text, out double sideLength))
            {
                IsoscelesTrapezium isoscelesTrapezium = new IsoscelesTrapezium(base1, base2, sideLength);
                return isoscelesTrapezium.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            double? base1 = FuncValidation.ValidatePositiveNumber(txtMinorBase, "Base menor");
            double? base2 = FuncValidation.ValidatePositiveNumber(txtMajorBase, "Base mayor");
            double? height = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            return base1.HasValue && base2.HasValue && height.HasValue;
        }
    }
}
