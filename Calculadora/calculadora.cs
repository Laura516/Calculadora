using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        bool porcent = false;


        private void Limpiar()
        {
            proceso.Text = "";
            mostrarResultado.Text = "";
            
        }



        public form1()
        {
            InitializeComponent();
        }

        clases.ClaSuma obj = new clases.ClaSuma();
        clases.ClaResta obj2 = new clases.ClaResta();
        clases.ClaDivision obj3 = new clases.ClaDivision();
        clases.ClasMultiplicacion1 obj4 = new clases.ClasMultiplicacion1();
        clases.Porcentaje percent = new clases.Porcentaje();
      

        private void siete_Click(object sender, EventArgs e)
        {
            proceso.Text += "7";

        }

        private void ocho_Click(object sender, EventArgs e)
        {
            proceso.Text += "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            proceso.Text += "9";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            proceso.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            proceso.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            proceso.Text += "6";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            proceso.Text += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            proceso.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            proceso.Text += "3";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(proceso.Text);
            proceso.Clear();


        }

        private void cero_Click(object sender, EventArgs e)
        {
            proceso.Text += "0";


        }

        private void punto_Click(object sender, EventArgs e)
        {
            proceso.Text += ",";
        }

        private void division_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(proceso.Text);
            
            proceso.Clear();
            
            

        }

      

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(proceso.Text);
           
          proceso.Clear();
            
            
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(proceso.Text);
           
          proceso.Clear();
            
            
        }

       

        private void resultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(proceso.Text);

            double result =0;

            switch (operador)
            {
                case "+":
                   
                    if (porcent)
                    {
                        result = percent.porcentaje(operador,primero, segundo);
                    }
                    else
                    {
                        result = obj.sumar(primero, segundo);
                    }
                    
                    break;
                case "-":
                    if (porcent)
                    {
                        result = percent.porcentaje(operador, primero, segundo);
                    }
                    else
                    {
                        result = obj2.Restar((primero), (segundo));
                    }
                   
                    break;
                case "*":
                    if (porcent)
                    {
                        result = percent.porcentaje(operador, primero, segundo);
                    }
                    else
                    {
                        result = obj4.Multiplicar((primero), (segundo));
                    }
                    
                    
                    break;
                case "/":
                    if (porcent)
                    {
                        result = percent.porcentaje(operador, primero, segundo);
                    }
                    else
                    {
                        result = obj3.Dividir((primero), (segundo));
                    }

                    break;

                
            }
            porcent = false;
            mostrarResultado.Text = result.ToString();

        }

        private void form1_Load(object sender, EventArgs e)
        {
            Limpiar();
            proceso.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
            proceso.Focus();
        }

        private void factorial_Click(object sender, EventArgs e)
        {

            primero = double.Parse(proceso.Text);
            double resultado= 1;
           
            for (int i= 1; i <= primero; i++)
            {
                
                resultado *= i;
                
            }
            mostrarResultado.Text = resultado.ToString();
        }

        private void porcentaje_Click(object sender, EventArgs e)
        {
            porcent = true;
          
        }
    }
}
