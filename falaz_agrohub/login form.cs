using falaz_agrohub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace falaz_agrohub
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTextbox.Text;
            string password = LoginPasswordTextbox.Text;

            C_Login login = new C_Login();
            login.ceklogin(username, password);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
        }

        private void RegisterBtn_Click_1(object sender, EventArgs e)
        {
            new V_FormRegister().Show();
            this.Hide();
        }
    }
}
