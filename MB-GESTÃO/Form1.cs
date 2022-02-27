using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB_GESTÃO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor= Color.White;
        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Agora precisamos nos conectar ao banco de dados, então usamos o banco de dados mysql
            //OK, primeiro precisamos baixar o aplicativo xampp e o conector mysql
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frprincipal frprincipal = new Frprincipal();
            frprincipal.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(TextBox_username.Text=="MBSF" && TextBox_password.Text=="123456")
            {
                Frprincipal ds = new Frprincipal();
                ds.Show();
            }
        }
    }
}
