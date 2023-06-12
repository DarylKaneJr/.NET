using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_LogIn
{
    public partial class FrmLogIN : Form
    {
        List<Usuario> listausuarios = new List<Usuario>();
        public FrmLogIN()
        {
            InitializeComponent();
            Usuario user1 = new Usuario();
            user1.User = "Nicolas";
            user1.Password = "12345";
            listausuarios.Add(user1);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            foreach(var item in listausuarios)
            {
                if(item.User == txtuser.Text && item.Password == txtpassword.Text)
                {
                    LogIn(txtuser.Text, txtpassword.Text);
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }

        }
        public void LogIn(string user,string pass)
        {
            SingletonSesion loginManager = SingletonSesion.Instance;
            bool loggedIn = loginManager.Login();
            bool isLoggedIn = loginManager.IsLoggedIn();
            if (isLoggedIn == true)
            {
                MessageBox.Show("Ha iniciado sesion");
                FrmLogOut frmlgt = new FrmLogOut();
                frmlgt.Show();
                this.Hide();
            }
        }
    }
}
