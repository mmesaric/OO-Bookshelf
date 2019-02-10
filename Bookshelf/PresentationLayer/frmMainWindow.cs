using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMainWindow : Form
    {

        private readonly MainFormController _controller;


        public frmMainWindow(MainFormController inController)
        {
            _controller = inController;

            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.Text;
            String password = passwordTextBox.Text;

            if (username == "")
            {
                MessageBox.Show("Unesite korisničko ime.");
            }
            else if (password == "")
            {
                MessageBox.Show("Unesite šifru.");
            }
            else
            {
                if (_controller.CheckAuthentication(username, password))
                {
                    _controller.ShowSearch();
                }
                else
                {
                    MessageBox.Show("Ne postoji korisnik sa zadanim podacima.");
                }
            }
        }
    }
}
