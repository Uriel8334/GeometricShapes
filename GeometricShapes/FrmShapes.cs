using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapes.ModelShapes;


namespace GeometricShapes
{

    public partial class FrmShapes : Form
    {

        //Objeto figura actual
        private UserControl currentFigure;
        //Objeto figura base
        private BaseShape baseShape;



        public FrmShapes()
        {
            InitializeComponent();
        }

        private void boxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el grupo de controles  
            btnReset_Click(sender, e);
            this.panelShapes.Controls.Clear();

            //obtenemos el nombre de la figura seleccionada   
            string figureSelected = boxShapes.SelectedItem.ToString();

            // Crear la figura seleccionada  
            switch (figureSelected)
            {
                case "Triángulo":
                    // Crear una instancia de UserCtrlTriangle
                    // y asignarla a currentFigure
                    var userControlTriangle = new UserCtrlTriangle();
                    currentFigure = userControlTriangle;
                    baseShape = (BaseShape)userControlTriangle;
                    panelShapes.Controls.Add(userControlTriangle);
                    break;

                case "Círculo":
                    // Crear una instancia de UserCtrlCircle
                    // y asignarla a currentFigure
                    var userControlCircle = new UserCtrlCircle();
                    currentFigure = userControlCircle;
                    baseShape = (BaseShape)userControlCircle;
                    panelShapes.Controls.Add(userControlCircle);
                    break;

                case "Cuadrado":
                    // Crear una instancia de UserCtrlSquare
                    // y asignarla a currentFigure
                    var userControlSquare = new UserCtrlSquare();
                    currentFigure = userControlSquare;
                    baseShape = (BaseShape)userControlSquare;
                    panelShapes.Controls.Add(userControlSquare);
                    break;
                case "Rectángulo":
                    // Crear una instancia de UserCtrlRectangle
                    // y asignarla a currentFigure
                    var userControlRectangle = new UserCtrlRectangle();
                    currentFigure = userControlRectangle;
                    baseShape = (BaseShape)userControlRectangle;
                    panelShapes.Controls.Add(userControlRectangle);
                    break;
                case "Rombo":
                    // Crear una instancia de UserCtrlRhombus
                    // y asignarla a currentFigure
                    var userControlRhombus = new UserCtrlRhombus();
                    currentFigure = userControlRhombus;
                    baseShape = (BaseShape)userControlRhombus;
                    panelShapes.Controls.Add(userControlRhombus);
                    break;
                case "Pentágono":
                    // Crear una instancia de UserCtrlPentagon
                    // y asignarla a currentFigure
                    var userControlPentagon = new UserCtrlPentagon();
                    currentFigure = userControlPentagon;
                    baseShape = (BaseShape)userControlPentagon;
                    panelShapes.Controls.Add(userControlPentagon);
                    break;
                case "Trapecio":
                    // Crear una instancia de UserCtrlTrapezium
                    // y asignarla a currentFigure
                    var userControlTrapezium = new UserCtrlTrapezium();
                    currentFigure = userControlTrapezium;
                    baseShape = (BaseShape)userControlTrapezium;
                    panelShapes.Controls.Add(userControlTrapezium);
                    break;
                case "Octágono":
                    // Crear una instancia de UserCtrlOctagon
                    // y asignarla a currentFigure
                    var userControlOctagon = new UserCtrlOctagon();
                    currentFigure = userControlOctagon;
                    baseShape = (BaseShape)userControlOctagon;
                    panelShapes.Controls.Add(userControlOctagon);
                    break;
                case "Hexágono":
                    // Crear una instancia de UserCtrlHexagon
                    // y asignarla a currentFigure
                    var userControlHexagon = new UserCtrlHexagon();
                    currentFigure = userControlHexagon;
                    baseShape = (BaseShape)userControlHexagon;
                    panelShapes.Controls.Add(userControlHexagon);
                    break;
                case "Elipse":
                    // Crear una instancia de UserCtrlEllipse
                    // y asignarla a currentFigure
                    var userControlEllipse = new UserCtrlEllipse();
                    currentFigure = userControlEllipse;
                    baseShape = (BaseShape)userControlEllipse;
                    panelShapes.Controls.Add(userControlEllipse);
                    break;
                case "Trapecio Isósceles":
                    // Crear una instancia de UserCtrlIsoscelesTrapezium
                    // y asignarla a currentFigure
                    var userControlIsoscelesTrapezium = new UserCtrlIsoscelesTrapezium();
                    currentFigure = userControlIsoscelesTrapezium;
                    baseShape = (BaseShape)userControlIsoscelesTrapezium;
                    panelShapes.Controls.Add(userControlIsoscelesTrapezium);
                    break;
                case "Deltoide":
                    // Crear una instancia de UserCtrlDeltoid
                    // y asignarla a currentFigure
                    var userControlDeltoid = new UserCtrlDeltoid();
                    currentFigure = userControlDeltoid;
                    baseShape = (BaseShape)userControlDeltoid;
                    panelShapes.Controls.Add(userControlDeltoid);
                    break;
                case "Romboide":
                    // Crear una instancia de UserCtrlRhomboid
                    // y asignarla a currentFigure
                    var userControlRhomboid = new UserCtrlRhomboid();
                    currentFigure = userControlRhomboid;
                    baseShape = (BaseShape)userControlRhomboid;
                    panelShapes.Controls.Add(userControlRhomboid);
                    break;
                case "Heptágono":
                    // Crear una instancia de UserCtrlHeptagon
                    // y asignarla a currentFigure
                    var userControlHeptagon = new UserCtrlHeptagon();
                    currentFigure = userControlHeptagon;
                    baseShape = (BaseShape)userControlHeptagon;
                    panelShapes.Controls.Add(userControlHeptagon);
                    break;
                case "Decágono":
                    // Crear una instancia de UserCtrlDecagon
                    // y asignarla a currentFigure
                    var userControlDecagon = new UserCtrlDecagon();
                    currentFigure = userControlDecagon;
                    baseShape = (BaseShape)userControlDecagon;
                    panelShapes.Controls.Add(userControlDecagon);
                    break;
                case "Eneágono":
                    // Crear una instancia de UserCtrlEnneagon
                    // y asignarla a currentFigure
                    var userControlEnneagon = new UserCtrlEnneagon();
                    baseShape = (BaseShape)userControlEnneagon;
                    panelShapes.Controls.Add(userControlEnneagon);
                    break;
                case "Ovalo":
                    // Crear una instancia de UserCtrlOval
                    // y asignarla a currentFigure
                    var userControlOval = new UserCtrlOval();
                    currentFigure = userControlOval;
                    baseShape = (BaseShape)userControlOval;
                    panelShapes.Controls.Add(userControlOval);
                    break;
                case "Trapezoide":
                    // Crear una instancia de UserCtrlTrapezoid
                    // y asignarla a currentFigure
                    var userControlTrapezoid = new UserCtrlTrapezoid();
                    currentFigure = userControlTrapezoid;
                    baseShape = (BaseShape)userControlTrapezoid;
                    panelShapes.Controls.Add(userControlTrapezoid);
                    break;
            }

            if (currentFigure is UserControl uc)
            {
                uc.Dock = DockStyle.Fill;
                panelShapes.Controls.Add(uc);
            }
        }

        //metodo para calcular el area y el perimetro de la figura seleccionada
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //verifica que la figura seleccionada no sea nula
            if (baseShape != null && baseShape.ValidateInput())
            {
                double? area = baseShape.CalculateArea();
                double? perimetro = baseShape.CalculatePerimeter();

                if (area.HasValue && perimetro.HasValue)
                {
                    txtArea.Text = area.Value.ToString();
                    txtPerimeter.Text = perimetro.Value.ToString();
                }
            }

        }
        
        //metodo para resetear la figura
        private void btnReset_Click(object sender, EventArgs e)
        {
            //resetea los controles dentro del panel para mantener el mismo color de fondo
            foreach (Control control in panelShapes.Controls)
            {
                if (control is UserControl)
                {
                    control.Dispose();
                }
            }
            // Limpia la lista de figuras
            currentFigure = null;
        }

        //metodo para salir
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierra la aplicacion
            Application.Exit();
        }
    }
}
