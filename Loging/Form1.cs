﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loging
{
    public partial class HarvardDataBase : Form
    {
        public HarvardDataBase()
        {
            InitializeComponent();
        }

        private void HarvardDataBase_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginBotton_Click(object sender, EventArgs e)
        {
            string password = PasswordTxt.Text;
            string username = UsernameTxt.Text;
            
            if (username == "juancho" & password == "123tamarindo")
            {
                MessageBox.Show("Welcome to Harvard Data Base " + username);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your password or username are not correct");
            }
           
        }

        private void ExitBotton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UsernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                PasswordTxt.Focus();
            }
        }
        private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string password = PasswordTxt.Text;
            string username = UsernameTxt.Text;

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (username == "juancho" & password == "123tamarindo")
                {
                    MessageBox.Show("Welcome to Harvard Data Base " + username);

                }
                else
                {
                    MessageBox.Show("Your password or username are not correct");
                }
            }
        }

       
    }
}
