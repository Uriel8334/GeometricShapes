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
    public partial class UserCtrlRectangle : UserControl, BaseShape
    {
        public UserCtrlRectangle()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (double.TryParse(txtBase.Text, out double baseLength) && double.TryParse(txtHeight.Text, out double height))
            {
                Rectangle rectangle = new Rectangle(baseLength, height);
                return rectangle.CalculateArea();
            }
            return null;
        }

        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtBase.Text, out double baseLength) && double.TryParse(txtHeight.Text, out double height))
            {
                Rectangle rectangle = new Rectangle(baseLength, height);
                return rectangle.CalculatePerimeter();
            }
            return null;
        }
        public bool ValidateInput()
        {
            double? baseLength = FuncValidation.ValidatePositiveNumber(txtBase, "Base");
            double? height = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            return baseLength.HasValue && height.HasValue;
        }
    }
}
