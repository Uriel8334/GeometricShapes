using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricShapes.Utility
{
    //clase Validaciones donde se encuentra los metodos de validacion 
    internal static class FuncValidation
    {
        //metodo para validar que el valor sea mayor a cero
        public static double? ValidatePositiveNumber(TextBox txt, string nameField)
        {
            //Se verifica que el número ingresado sea mayor a 0
            if (!double.TryParse(txt.Text, out double value) || value <= 0)
            {
                //De no ser el caso se mostrara un mensaje de error y se limpiará el campo de texto
                MessageBox.Show($"El {nameField} debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Clear();
                return null;
            }
            return value;
        }
    }
}
