using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace falaz_agrohub.Properties
{
    public class C_Login
    {
        public void ceklogin(string username, string password)
        {
            M_user db = new M_user();
            var hasil = db.GetDataUser(username, password);
            if (hasil != null)
            {
                if (hasil == "Admin")
                {
                    MessageBox.Show("Login Berhasil Sebagai Admin");
                    new V_DashboardAdmin().Show();
                }
                else
                {
                    MessageBox.Show("Login Berhasil Sebagai Operator");
                    new V_DashboardOperator().Show();
                }
            }
            else
            {
                MessageBox.Show("Login Gagal, Cek Kembali Username dan Password Anda");
                new login_form().Show();
            }
        }
        public void register(string username, string password)
        {
            M_user db = new M_user();
            db.InsertDataUser(username, password);
            if (true)
            {
                MessageBox.Show("Register Berhasil, Silahkan Login Kembali");
                new login_form().Show();
            }
            else
            {
                MessageBox.Show("Register Gagal, Coba Lagi");
                new V_FormRegister().Show();
            }
        }
    }
}
