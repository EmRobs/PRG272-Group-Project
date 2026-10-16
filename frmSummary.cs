using Rehabilitation_Records_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rehabilitation_Records_System
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        FileHandler handler = new FileHandler();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GetValue(string line)
        {
            string[] parts = line.Split(':');
            return parts.Length > 1 ? parts[1].Trim() : "";
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                handler.GenerateSummary();

                // Read all lines from summary.txt
                string summary = Path.Combine(Application.StartupPath, "summary.txt");
                string[] lines = File.ReadAllLines(summary);

                // Display summary information
                txtTotal.Text = GetValue(lines[4]);
                txtAge.Text = GetValue(lines[5]);
                txtScore.Text = GetValue(lines[6]);

                txtCritical.Text = GetValue(lines[9]);
                txtSerious.Text = GetValue(lines[10]);
                txtStable.Text = GetValue(lines[11]);
                txtRecovering.Text = GetValue(lines[12]);
                txtRelease.Text = GetValue(lines[13]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to display summary: " + ex.Message);
            }
            

        }

    }
}
