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
    
    public partial class FrmLogin : Form
    {
        
        //Creacion de variables globales
        public string Invitados;
        public string Usuarios;


        //Creacion de diccionario para guardar datos
        Dictionary<string, string> Alumnos = new Dictionary<string, string>();
        Dictionary<string, string> Empleados = new Dictionary<string, string>();

        #region Diccionario
        public FrmLogin()
        {
            InitializeComponent();
            //LLenando diccionario de alumnos
            Alumnos.Add("201000140","JESUS ADOLFO NATIVIDAD CANO");
            Alumnos.Add("201000072", "ESMERALDA VARELA SALINAS");
            Alumnos.Add("201000107", "HANNIA ELIZABETH QUISTIAN GOMEZ");
            Alumnos.Add("201000076", "RAMON ABARAHAM SANTANA RODRIGUEZ");
            Alumnos.Add("201000079", "ALVAREZ LOZA JOB ALBERTO");
            Alumnos.Add("201000180", "AVITIA MUÑIZ ELIENAI AZUCENA");
            Alumnos.Add("201000175", "CARRIZALES CARRILLO LUIS GAEL");
            Alumnos.Add("201000068", "CENICEROS CABRERA YOHEL");
            Alumnos.Add("201000078", "HERNANDEZ AGUILAR NAYDELIN GUADALUPE");
            Alumnos.Add("201000130", "JIMENEZ IBARRA HECTOR ADAIR");
            Alumnos.Add("201000133", "LOZA MILAN LEONARDO");
            Alumnos.Add("201000188", "OCHOA ESPARZA SANJUANA MELISSA");
            Alumnos.Add("201000152", "SCOTT CARREON PAOLA ALEJANDRA");
            Alumnos.Add("201000114", "VELASQUEZ VAZQUEZ DIANA KAREN");
            //llenando diccionario de empleados
            Empleados.Add("1","MTI. ULISES MARTINEZ RODRIGUEZ");
            Empleados.Add("2","ME. IDALIA RUIZ ARROYO");
            Empleados.Add("3", "ING. AMERICO MARTINEZ OVALLE");
            Empleados.Add("4", "ING. JOSE LUIS MOTA ESPELETA");
            Empleados.Add("5", "JARED HAZAEL GARCIA RUIZ");
            Empleados.Add("6", "LEONARDO ALVARADO ESCOBEDO");
            Empleados.Add("7", "ELIEL GUADALUPE NIÑO BORREGO");
            Empleados.Add("8", "ROBERTO CARLOS GARZA SANDOVAL");
            Empleados.Add("9", "MARCO ANTONIO CONSTANTE SANDOVAL");
            Empleados.Add("10", "WILIAMS ALAIN RAMIREZ ARREOLA");
        }
#endregion

        private void CB_Invitado_CheckedChanged(object sender, EventArgs e)
        {
            //Chequea si el cheked box esta marcado o no
            if (CB_Invitado.Checked == true)
            {
                //Si esta marcado mostrara un mensaje en pantalla haciendo una pregunta
                DialogResult Resultado = MessageBox.Show("¿Quieres ingresar como invitado?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //compara la respuesta ingresada
                if (Resultado == DialogResult.Yes)
                {
                    //Si la respuesta fue si, el textbox cambiara su contenido y obtendra el foco 
                    Txt_LoginU.Text = "Ingresa Tu Nombre";
                    //da el foco al textbox
                    Txt_LoginU.Focus();
                }
                if (Resultado == DialogResult.No)
                {
                    //Si la respuesta fue no, cierra el mensaje lanzado y da retorno a el login
                    this.CB_Invitado.Checked = false;
                }
            }
            if (CB_Invitado.Checked == false)
            {
                CB_Invitado.Checked = false;
                Txt_LoginU.Text = "Ingresa tu matricula o numero de empleado" ;
            }

        }
        private void Txt_LoginU_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificando el valor del checbox
            if (CB_Invitado.Checked == true)
            {
                //Estableciendo limites de valores aceptados en el textbox
                //Validar las pulsaciones de taclado
                if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 64|| e.KeyChar>=91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255  )
                {
                    e.Handled = true;
                    return;

                }
            }
            //Si eñ checkedbox esta desactivados
            if (CB_Invitado.Checked == false)
            {
                //Estalecera un limite de valores aceptados en el textbox
                //validar las pulsaciones de teclado
                if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
                {
                    //
                    e.Handled = true;
                   
                    return;

                }
            }
        }
        //Cuando el textbox no tenga el foco
        private void Txt_LoginU_Leave(object sender, EventArgs e)
        {
            //si el textbox no tiene texto, escribira en el
            if (Txt_LoginU.Text == string.Empty)
            {
                //Cambiara el texto mostrado en el textbos
                Txt_LoginU.Text = "Ingrese su usuario";
            }
            //Cambiara el color de las letras del textbox en caso de no tener el foco
            Txt_LoginU.ForeColor = Color.Gray;
        }

        private void Txt_LoginU_Click(object sender, EventArgs e)
        {
            //Vaciara el contenido del textbox para poder llenarlo nuevamente
            Txt_LoginU.Text = string.Empty;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Cambiara el aspecto de los botones, cargandoles imagenes
            Btn_Aceptar.BackgroundImage = Properties.Resources.select;
            Btn_Cancelar.BackgroundImage = Properties.Resources.tap;
            //Se adaptan las imagenes para que encajen con la forma del boton
            Btn_Aceptar.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Cancelar.BackgroundImageLayout = ImageLayout.Zoom;
            //Vacia el texto que muestran los eventos para que se miren bien las imagenes
            Btn_Aceptar.Text = string.Empty;
            Btn_Cancelar.Text = string.Empty;
        }

        #region Botones
        private void Btn_Aceptar_MouseMove(object sender, MouseEventArgs e)
        {
            //agrega una imagen al boton, haciendole cambiar de aspecto
            Btn_Aceptar.BackgroundImage = Properties.Resources.click;
        }

        private void Btn_Aceptar_MouseLeave(object sender, EventArgs e)
        {
            //agrega una imagen al boton, haciendole cambiar de aspecto
            Btn_Aceptar.BackgroundImage = Properties.Resources.click;
        }
        //Cuando el cursor esta sobre el boton
        private void Btn_Aceptar_MouseHover(object sender, EventArgs e)
        {
            //agrega una imagen al boton, haciendole cambiar de aspecto
            Btn_Aceptar.BackgroundImage = Properties.Resources.hand;
        }
        //Cuando se da click en el boton cancelar
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            //al presionar el boton cancelar
            //Mostrara un cuadro de dialogo preguntando si se desea salir de la aplicacion
            DialogResult res = MessageBox.Show("¿Desea salir de la aplicacion?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Si el resultado es "Si/Yes" se cerrara la aplicacion concluyendo con la ejecucion de la misma
            if (res == DialogResult.Yes)
            {
                //Cierra la aplicacion
                Application.Exit();
            }
            //Si el resultado es "No" se dara regreso al login
            if (res == DialogResult.No)
            {
                //Da retorno a el login
                return;
            }
        }
        //Cuando se da click en el boton
        public void Btn_Aceptar_Click(object sender, EventArgs e)
        //private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Instancia la clase PIDETEC
            //PIDETEC Menu = new PIDETEC(Usuarios);
            string Mensg = string.Empty;
            //Comparacion/busqueda en la caja de texto              ||=operador "or"
            if (Alumnos.ContainsKey(Txt_LoginU.Text) || Empleados.ContainsKey(Txt_LoginU.Text))
            {
                //busqueda informacion relacionada en diccionario 
                if (Alumnos.ContainsKey(Txt_LoginU.Text))
                {
                    //Guarda informacion del textbox en la variable
                    Usuarios = Alumnos[Txt_LoginU.Text].ToString();
                    //Muestra un mensaje en pantalla
                    Mensg = string.Format("Bienvenido a PIDETEC {0}, esperamos atenderlo lo mejor posible", Usuarios, MessageBoxIcon.Asterisk);
                    MessageBox.Show(Mensg);
                    //Se instancia un objeto de la clase PIDETEC, cargado con la variable usuarios
                    PIDETEC Menu = new PIDETEC(Usuarios);
                    //Oculta el formulario actual
                    this.Hide();
                    //Muestra el nuevo formulario
                    Menu.Show();
                }
                //busqueda de informacion relacionada en diccionario
                if (Empleados.ContainsKey(Txt_LoginU.Text))
                {
                    //Guarda informacion del textbox en la variable
                    Usuarios = Empleados[Txt_LoginU.Text].ToString();
                    //Muestra un mensaje en pantalla
                    Mensg = string.Format("Bienvenido a PIDETEC {0}, esperamos atenderlo lo mejor posible", Usuarios, MessageBoxIcon.None);
                    MessageBox.Show(Mensg);
                    //Se instacia un objeto de la clase PIDETEC, cargado con la variable usuarios
                    PIDETEC Menu = new PIDETEC(Usuarios);
                    //Oculta el formulario actual
                    this.Hide();
                    //muestra el nuevo formulario
                    Menu.Show();
                }
            }
            else
            {
                //Si el usuario no es encontrado mostrara un mensaje diciendolo
                if (CB_Invitado.Checked == false || Alumnos.ContainsKey(Txt_LoginU.Text) || Empleados.ContainsKey(Txt_LoginU.Text))
                {
                    //Muestra un mensaje en pantalla 
                    MessageBox.Show("Usuario no encontrado, vuelve a intentarlo", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } 

            //SI el chekedbox invitados esta activo 
             if (CB_Invitado.Checked == true)
             {
                //Se guarda la informacion del textbox en la variable Invitados
                    Invitados = Txt_LoginU.Text;
                //Muestra un mensaje en pantalla
                    Mensg = string.Format("Bienvenido a PIDETEC {0}, esperamos atenderlo lo mejor posible", Invitados, MessageBoxIcon.Hand);
                    MessageBox.Show(Mensg);
                //Instanciasion de objeto de la clase PIDETEC cargado con la variable usuarios
                PIDETEC Menu = new PIDETEC(Usuarios);
                //Oculta el formulario actual
                    this.Hide();
                //Mostrar el nuevo formulario
                    Menu.Show();
             }
             else
             {
                //dara retorno al login
                return;
             }               
            
            //En caso de no llenar el formulario saldra una ventana
            if (Txt_LoginU.Text == "Ingrese su usuario" || Txt_LoginU.Text == "")
            {
                //Se mostrara una ventana dejando un mensaje de advertencia
                DialogResult CampoVacio = MessageBox.Show("Por favor llene los datos", "Login",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }

        #endregion        

       
    }
}
