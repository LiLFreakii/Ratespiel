using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ratespiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessUser user = new DataAccessUser();

            dGV.DataSource = user.ReadALL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccessUser daUser = new DataAccessUser();
            User user = new User();

            //MessageBox.Show(dGV.CurrentRow.ToString());

            int Id = Convert.ToInt32(txtId.Text);

            daUser.Delete(Id);
        }
    }
}
