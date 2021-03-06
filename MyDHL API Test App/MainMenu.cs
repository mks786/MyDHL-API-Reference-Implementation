﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyDHLAPI_Test_App
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.Sandpit;
        }

        private void BtnSwitchMode_Click(object sender, EventArgs e)
        {
            switch (Common.CurrentEnvironment)
            {
                case Common.MyDHLAPIEnvironment.Sandpit:
                    lblMode.Text = "## PRODUCTION ##";
                    lblMode.Font = new Font(lblMode.Font, FontStyle.Bold);
                    Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.Production;
                    Common.CurrentSoapBaseUrl = Common.soapProductionBaseUrl;
                    Common.CurrentRestBaseUrl = Common.restProductionBaseUrl;
                    break;
                case Common.MyDHLAPIEnvironment.Production:
                    if (Common.Credentials.ContainsKey(Common.MyDHLAPIEnvironment.E2ESandpit))
                    {
                        lblMode.Text = "E2E Sandpit";
                        lblMode.Font = new Font(lblMode.Font, FontStyle.Italic);
                        Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.E2ESandpit;
                        Common.CurrentSoapBaseUrl = Common.soapE2ESandpitBaseUrl;
                        Common.CurrentRestBaseUrl = Common.restE2ESandpitBaseUrl;
                    }
                    else
                    {
                        lblMode.Text = "Sandpit";
                        lblMode.Font = new Font(lblMode.Font, FontStyle.Regular);
                        Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.Sandpit;
                        Common.CurrentSoapBaseUrl = Common.soapSandpitBaseUrl;
                        Common.CurrentRestBaseUrl = Common.restSandpitBaseUrl;
                    }
                    break;
                case Common.MyDHLAPIEnvironment.E2ESandpit:
                    lblMode.Text = "E2E Production";
                    lblMode.Font = new Font(lblMode.Font, FontStyle.Regular);
                    Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.E2EProduction;
                    Common.CurrentSoapBaseUrl = Common.soapE2EProductionBaseUrl;
                    Common.CurrentRestBaseUrl = Common.restE2EProductionBaseUrl;
                    break;
                case Common.MyDHLAPIEnvironment.E2EProduction:
                    lblMode.Text = "Sandpit";
                    lblMode.Font = new Font(lblMode.Font, FontStyle.Regular);
                    Common.CurrentEnvironment = Common.MyDHLAPIEnvironment.Sandpit;
                    Common.CurrentSoapBaseUrl = Common.soapSandpitBaseUrl;
                    Common.CurrentRestBaseUrl = Common.restSandpitBaseUrl;
                    break;
            }

            Common.CurrentCredentials = Common.Credentials[Common.CurrentEnvironment];
        }

        private void BtnSOAP_Track_Click(object sender, EventArgs e)
        {
            Form frm = new SOAP.Track();
            frm.Show();
        }

        private void BtnSOAP_Ship_Click(object sender, EventArgs e)
        {
            Form frm = new SOAP.Ship();
            frm.Show();
        }

        private void BtnSOAP_EPOD_Click(object sender, EventArgs e)
        {
            Form frm = new SOAP.ePOD();
            frm.Show();
        }

        private void BtnREST_RateQuery_Click(object sender, EventArgs e)
        {
            Form frm = new REST.RateQuote();
            frm.Show();
        }

        private void BtnREST_Ship_Click(object sender, EventArgs e)
        {
            Form frm = new REST.Ship();
            frm.Show();
        }

        private void BtnREST_CreatePickup_Click(object sender, EventArgs e)
        {
            Form frm = new REST.CreatePickup();
            frm.Show();
        }

        private void BtnREST_DeletePickup_Click(object sender, EventArgs e)
        {
            Form frm = new REST.DeletePickup();
            frm.Show();
        }

        private void BtnREST_Track_Click(object sender, EventArgs e)
        {
            Form frm = new REST.Track();
            frm.Show();
        }

        private void BtnREST_ePOD_Click(object sender, EventArgs e)
        {
            Form frm = new REST.ePOD();
            frm.Show();
        }

        private void BtnAdHoc_Click(object sender, EventArgs e)
        {
            Form frm = new AdHoc();
            frm.Show();
        }
    }
}
