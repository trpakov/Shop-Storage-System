using Shop_Store_System.BusinessLogic;
using Shop_Store_System.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Store_System.Design_Interfaces
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        loginBusinessLogic login = new loginBusinessLogic();
        loginDataAccess loginDataAccess = new loginDataAccess();
        public static string loggedIn;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login.Username = txtUsername.Text.Trim();
            login.Password = txtPassword.Text.Trim();
            login.UserType = cmbUserType.Text.Trim();

            //Проверка дали данните съвпадат
            bool sucess = loginDataAccess.loginCheck(login);

            if (sucess == true)
            {
                
                MessageBox.Show("Login Successful.");
                loggedIn = login.Username;

                //Отваряне на определена форма според usertype 
                switch (login.UserType)
                {
                    case "Admin":
                        {
                            formAdminDashboard admin = new formAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            formUserDashboard user = new formUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again");
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
