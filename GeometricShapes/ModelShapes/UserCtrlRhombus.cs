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
    public partial class UserCtrlRhombus : UserControl, BaseShape
    {
        public UserCtrlRhombus()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (double.TryParse(txtMajorDiagonal.Text, out double majorDiagonal) && double.TryParse(txtMinorDiagonal.Text, out double minorDiagonal) && double.TryParse(txtSide.Text, out double side))
            {
                Rhombus rhombus = new Rhombus(majorDiagonal, minorDiagonal, side);
                return rhombus.CalculateArea();
            }
            return null;
        }

        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtMajorDiagonal.Text, out double majorDiagonal) && double.TryParse(txtMinorDiagonal.Text, out double minorDiagonal) && double.TryParse(txtSide.Text, out double side))
            {
                Rhombus rhombus = new Rhombus(majorDiagonal, minorDiagonal, side);
                return rhombus.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            double? majorDiagonal = FuncValidation.ValidatePositiveNumber(txtMajorDiagonal, "Diagonal Mayor");
            double? minorDiagonal = FuncValidation.ValidatePositiveNumber(txtMinorDiagonal, "Diagonal Menor");
            double? side = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            return majorDiagonal.HasValue && minorDiagonal.HasValue && side.HasValue;
        }
    }
}
