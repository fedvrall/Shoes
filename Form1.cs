using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = tbLog.Text;
            string password = tbPass.Text;
            using (Entities.DBModel db = new Entities.DBModel())
            {
                List<Entities.User> users = db.User.Where(x => x.UserLogin == login && x.UserPass == password).ToList();
                Entities.User user = users.FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Таких данных нет");
                    return;
                }
                else
                {
                    Helper.roleID = user.RoleID;
                    Helper.userName = user.UserName;
                    MessageBox.Show("Вы зашли как " + Helper.userName);
                }
            }
        }
    }
}
