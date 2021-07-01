using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techno2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DBCoviBarEntities db = new DBCoviBarEntities())
            {
                var user = (from s in db.USUARIO where s.ID_usuario == txtUsuario.Text select s).First();

                if (user.Clave == txtPassword.Text)
                {
                    MessageBox.Show("¡BIENVENIDO! :D");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos :c");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
