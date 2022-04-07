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
    public partial class FrmImagenes : Form
    {
        
        public FrmImagenes()
        {
            InitializeComponent();
            //Cambiamos el color de la forma
            this.BackColor = Color.Black;
            //El color de la forma se hace transparente
            this.TransparencyKey = Color.Black;
        }

        private void FrmImagenes_Load(object sender, EventArgs e)
        {

        }
        //Metodo que cambiara la imagen del picturebox
        public void Gorditas()
        {
            PB_MostrarImagen.Image = Properties.Resources.Gorditas2;
        }
        //Metodo que cambiara la imagen del picturebox
        public void Sandwich()
        {
            PB_MostrarImagen.Image = Properties.Resources.Sandwich2;
        }
        //Metodo que cambiara la imagen del picturebox
        public void Mollete()
        {
            PB_MostrarImagen.Image = Properties.Resources.Molletes2;
        }
        //Metodo que cambiara la imagen del picturebox
        public void HotCake()
        {
            PB_MostrarImagen.Image = Properties.Resources.HotCakes2;
        }
        //Metodo que cambiara la imagen del picturebox
        public void Yogurt()
        {
            PB_MostrarImagen.Image = Properties.Resources.Yogurt_Remove;
        }
        //Metodo que cambiara la imagen del picturebox
        public void Refresco()
        {
            PB_MostrarImagen.Image = Properties.Resources.Refrescos2;
        }
        //Metodo que cerrara el formulario 
        public void FrmSolo()
        {
            //PB_MostrarImagen.Hide();
            this.Hide();
        }

        private void PB_MostrarImagen_Click(object sender, EventArgs e)
        {

        }

    }    
}
