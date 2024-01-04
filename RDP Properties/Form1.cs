using System;
using System.Windows.Forms;
using AxMSTSCLib;

namespace RDP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private AxMsRdpClient9NotSafeForScripting rdpClient;

        public Form1()
        {
            InitializeComponent();
            //InitializeRDP();
        }

        private void InitializeRDP()
        {
            rdpClient = new AxMsRdpClient9NotSafeForScripting();
            rdpClient.Dock = DockStyle.Fill;
            this.Controls.Add(rdpClient);

            // Set other RDP client properties as needed
            rdpClient.Server = "74.235.195.24";
            rdpClient.UserName = "dharshan";
            rdpClient.AdvancedSettings9.ClearTextPassword = "@Dharshan007";

            // Optionally, set other RDP client properties here...
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                txtPhoneNumber.Visible = false;
                btn_connect.Visible = false;
                panel1.Visible = false;

                // Connect to VM
                InitializeRDP();
                rdpClient.Connect();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
