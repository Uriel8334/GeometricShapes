using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    //clase interfaz para los metodos de las figuras geometricas
    public interface BaseShape
    {
        double? CalculateArea(); //metodo para calcular el area
        double? CalculatePerimeter(); //metodo para calcular el perimetro
        bool ValidateInput(); //metodo para validar los ingresos de datos para que sean positivos
    }
}
