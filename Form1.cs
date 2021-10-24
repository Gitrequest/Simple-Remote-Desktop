using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Remote_Desktop
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            // will hide the password input
            txt_password.PasswordChar = '*';
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
        // Checks if all fields are filled with credentials
            if (txt_ip.Text== string.Empty)
            {
                txt_ip.Text = "No valid IP!";
            }

            if (txt_user.Text == string.Empty)
            {
                txt_ip.Text = "No valid User!";
            }

            if (txt_password.Text == string.Empty)
            {
                txt_ip.Text = "No valid password!";
            }


            // Validating IP
            IPAddress ip;
            string ip_input = txt_ip.Text;
            string username = txt_user.Text;
            string password = txt_password.Text;
            bool ValidateIP = IPAddress.TryParse(ip_input, out ip);


            // with validated IP it tries to connect - if an exception happens, and error popup will displayed
            if (ValidateIP)
            {
                try
                {
                    rdp_box.Server = ip_input;
                    rdp_box.UserName = username;
                    rdp_box.AdvancedSettings2.ClearTextPassword = password;
                    rdp_box.Connect();
                }
                catch
                {
                    //creates error form
                    ErrorPopup f2 = new ErrorPopup();
                    f2.ShowDialog();

                }
            }
            
            // On unvalidated IP an error will displayed
            else
            {
                txt_ip.Text = "No valid IP!";
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            //txt_password.Clear();
        }

        private void txt_ip_TextChanged(object sender, EventArgs e)
        {
            //txt_ip.Clear();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            //txt_user.Clear();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if(rdp_box.Connected.ToString()=="1")
            {
                rdp_box.Disconnect();
            }
        }
    }
}
