using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace WindowsFormsApp2
{
    public partial class LoginAuth : Form
    {
        private SQLiteConn conn;

        public LoginAuth()
        {
            InitializeComponent();
            conn = new SQLiteConn("Cafe.db", true);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Login(tbUser.Text, Convert.ToInt32(tbPassword.Text));
            
                
        }
    }
}
