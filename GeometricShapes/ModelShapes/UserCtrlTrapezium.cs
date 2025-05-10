using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapes.ModelShapes;
using GeometricShapes.Utility;

namespace GeometricShapes.ModelShapes
{
    public partial class UserCtrlTrapezium : UserControl, BaseShape
    {
        public UserCtrlTrapezium()
        {
            InitializeComponent();
        }
        //metodo para calcular el area baseMajor, baseMinor, height, leftSide, rightSide
        public double? CalculateArea()
        {
            if (double.TryParse(txtBaseMajor.Text, out double baseMajor) && double.TryParse(txtBaseMinor.Text, out double baseMinor) && double.TryParse(txtHeight.Text, out double height) && double.TryParse(txtLeftSide.Text, out double leftSide) && double.TryParse(txtRightSide.Text, out double rightSide))
            {
                Trapezium trapezium = new Trapezium(baseMajor, baseMinor, height, leftSide, rightSide);

                return trapezium.CalculateArea();
            }
            return null;
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtBaseMajor.Text, out double baseMajor) && double.TryParse(txtBaseMinor.Text, out double baseMinor) && double.TryParse(txtHeight.Text, out double height) && double.TryParse(txtLeftSide.Text, out double leftSide) && double.TryParse(txtRightSide.Text, out double rightSide))
            {
                Trapezium trapezium = new Trapezium(baseMajor, baseMinor, height, leftSide, rightSide);
                return trapezium.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            double? baseMajor = FuncValidation.ValidatePositiveNumber(txtBaseMajor, "Base mayor");
            double? baseMinor = FuncValidation.ValidatePositiveNumber(txtBaseMinor, "Base menor");
            double? height = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            double? leftSide = FuncValidation.ValidatePositiveNumber(txtLeftSide, "Lado izquierdo");
            double? rightSide = FuncValidation.ValidatePositiveNumber(txtRightSide, "Lado derecho");
            return baseMajor.HasValue && baseMinor.HasValue && height.HasValue && leftSide.HasValue && rightSide.HasValue;
        }
    }
}
