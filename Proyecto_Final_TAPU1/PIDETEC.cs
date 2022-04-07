using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_TAPU1
{
    
    public partial class PIDETEC : Form 
    {
        //Instanciasion de objeto de la clase(Forma) imagenes
        FrmImagenes MostrarImagen = new FrmImagenes();
  
        //Declaracion de variables globales
        public int Precio = 0;
        public int totalHotCakes = 0;
        public int totalSandwich = 0;
        public int totalMolletes = 0;
        public int totalRefrescos = 0;
        public int totalYogurt = 0;
        public int totalGorditas = 0;

        //constructor cargadoel contenido de una variable de la forma login
        public PIDETEC(string usuarioaMostrar)
        {
            InitializeComponent();
            //Cambia le texto del menu mostrando el nombre del usuario conectado
            usuarioConectadoToolStripMenuItem.Text = ("Usuario Conectado:"+ usuarioaMostrar);
        }

        private void PIDETEC_Load(object sender, EventArgs e)
        {
            
        }
        //Cuando se da click en un elemento del menu
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instancia un nuevo objeto de la forma login
            FrmLogin Regreso = new FrmLogin();
            //cierra el menu y da regreso al login
            this.Hide();
            Regreso.Show();
        }
        #region Botones
        //Cuado el cursor esta  posicionado encima del boton
        private void Btn_Gorditas_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.Gorditas();
            MostrarImagen.Show();
        }
        //Cuando se da click en el boton
        private void Btn_Gorditas_Click(object sender, EventArgs e)
        {
            //Establecemos un limkte de avance en elpreogresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_Gorditas.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 10;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay
                totalGorditas = totalGorditas + 1;
                lblGorditas.Text = totalGorditas.ToString();
            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_Gorditas.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cuando el cursor se posisiona ensima del boton
        private void Btn_Molletes_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.Mollete();
            MostrarImagen.Show();
        }
        //Cuando se de unclick en el boton
        private void Btn_Molletes_Click(object sender, EventArgs e)
        {
            
            //Establecemos un limkte de avance en elpreogresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_Molletes.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 20;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay
                totalMolletes = totalMolletes + 1;
                lblMolletes.Text = totalMolletes.ToString();
            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_Molletes.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Cuando el cursor esta sobre el boton
        private void Btn_Sandwich_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.Sandwich();
            MostrarImagen.Show();
        }
        //Cuando se da click en el boton
        private void Btn_Sandwich_Click(object sender, EventArgs e)
        {
            
            //Establecemos un limite al progresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_Sandwich.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 20;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay
                totalSandwich = totalSandwich + 1;
                lblSandwich.Text = totalSandwich.ToString();

            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_Sandwich.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cuando el cursor de estar sobre el boton
        private void Btn_HotCakes_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.HotCake();
            MostrarImagen.Show();
        }
        //Cuando se da click en el boton
        private void Btn_HotCakes_Click(object sender, EventArgs e)
        {
            
            //Establecemos un limite al progresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_Hotcake.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 20;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay
                totalHotCakes = totalHotCakes + 1;
                lblHotCakes.Text = totalHotCakes.ToString();
            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_Hotcake.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cuando el cursor de estar sobre el boton
        private void Btn_Yogurt_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.Yogurt();
            MostrarImagen.Show();
        }
        //Cuando se da click en el boton
        private void Btn_Yogurt_Click(object sender, EventArgs e)
        {
            
            //Establecemos un limite al progresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_Yogurt.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 20;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay
                totalYogurt = totalYogurt + 1;
                lblYogurt.Text = totalYogurt.ToString();
            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_Yogurt.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cuando el cursor esta sobre el boton
        private void Btn_Refresco_MouseHover(object sender, EventArgs e)
        {
            //Mostrara un nuevo form con una imagen cargada
            MostrarImagen.Refresco();
            MostrarImagen.Show();

        }
         //Cuando se da click en el boton
    private void Btn_Refresco_Click(object sender, EventArgs e)
        {
            
            //Establecemos un limite al progresbar
            if (ProgresB_Gorditas.Value < 10)
            {
                ProgresB_refresco.Value++;
                //Sumaremos 10 a la variable Precio
                Precio = Precio + 15;
                //Mostramos El valor de la variable Precio para indicar el costo
                Lbl_APagar.Text = Precio.ToString();
                //Mostrar la cantidad de articulos hay 
                totalRefrescos = totalRefrescos + 1;
                lblRefresco.Text = totalRefrescos.ToString();
            }
            //Si el limite del progras vara mostrara un mensaje
            if (ProgresB_refresco.Value == 11)
            {
                //Mostrar un mensaje de advertencia
                MessageBox.Show("No es posible agregar mas de este producto", "PIDETEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Botones_MouseLeave

        //Cuando el cursor deja de estar sobre el boton
        private void Btn_Gorditas_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }
        //Cuando el cursor deja de estar sobre el boton
        private void Btn_Molletes_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }
        //Cuando el cursor deja de estar sobre el boton
        private void Btn_Sandwich_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }
        //Cuando el cursor deja de estar sobre el boton
        private void Btn_HotCakes_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }
        //Cuando el cursor deja de estar sobre el boton
        private void Btn_Yogurt_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }
        //Cuando el cursor deja de estar sobre el boton
        private void Btn_Refresco_MouseLeave(object sender, EventArgs e)
        {
            //el objeto del form imagen da llamado a un metodo de la forma imagenes
            MostrarImagen.FrmSolo();
        }

        #endregion

        #endregion
    }
}
