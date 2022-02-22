using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //Declaración de arreglos
            string[] nombres = new string [1];
            int[] edad = new int[1 ];

            //Se llena el arreglo de nombres
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = txt_nombre.Text;
            }

            // Se llena el arreglo de edad
            for (int i = 0; i < edad.Length; i++)
            {
                edad[i] = Convert.ToInt16(txt_edad.Text);
            }

            //Muestra los datos en el ComboBox
            for (int i = 0; i < nombres.Length; i++)
            {
                cb_registro.Items.Add("Nombre: " + (nombres[i]) + " Edad: " + (edad[i]));
            }

            //se borra los textBox para poder ingresar nuevos datos
            txt_edad.Clear();
            txt_nombre.Clear();


        }


    }
}
