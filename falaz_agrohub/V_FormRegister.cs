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
    public partial class V_FormRegister : Form
    {
        public V_FormRegister()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = RegisterUsernameTextbox.Text;
            string password = RegisterPasswordTextbox.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.");
                return;
            }
            else
            {
                C_Login control = new C_Login();

                control.register(username, password);
                this.Hide();
            }
        }
    }
}
