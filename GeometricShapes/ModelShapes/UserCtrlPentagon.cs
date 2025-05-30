﻿using System;
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
    public partial class UserCtrlPentagon : UserControl, BaseShape
    {
        public UserCtrlPentagon()
        {
            InitializeComponent();
        }

        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (double.TryParse(txtSide.Text, out double sideLength))
            {
                Pentagon pentagon = new Pentagon(sideLength);
                return pentagon.CalculateArea();
            }
            return null;
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtSide.Text, out double sideLength))
            {
                Pentagon pentagon = new Pentagon(sideLength);
                return pentagon.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            double? side = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            return side.HasValue;
        }
    }
}
