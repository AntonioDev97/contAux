using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAux.view
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnEntrar.Select();

        }

        private void pnCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Equals("")) {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Usuario"))
            {
                txtUser.Clear();
                txtUser.ForeColor = Color.Black;
            }
            else {
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text.Equals("Contraseña"))
            {
                txtPass.Clear();
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
                
            }
            else
            {
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim().Equals(""))
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*if (txtUser.Text.Trim().Equals("Usuario") || txtUser.Text.Trim().Equals(String.Empty))
                MessageBox.Show("Verifique su usuario e intente de nuevo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPass.Text.Trim().Equals("Contraseña") || txtPass.Text.Trim().Equals(""))
                MessageBox.Show("Verifique su contraseña e intente de nuevo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                model.UserLogin usrMod = new model.UserLogin();
                usrMod.User = txtUser.Text;
                usrMod.Password = txtPass.Text;
                controller.UserLogin usrLog = new controller.UserLogin();
                if (usrLog.autentica(usrMod))
                {
                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    this.Hide();
                    menu.Show();
                }
                else
                    MessageBox.Show("Verifique sus credenciales e intente de nuevo", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }*/
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
            menu.Show();
        }
    }
}
