using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripApplication.GUI
{
    public partial class MainGUI : Form
    {
        private string role;
        public MainGUI(string role)
        {
            InitializeComponent();
            this.role = role;
            labelHello.Text = $"Hello, {role}";
            logoutadminToolStripMenuItem.Text = $"Logout ({role})";
        }

        private void logoutadminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();
            this.role = "";
            this.Close();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            RouteGUI routeGUI = new RouteGUI();
            routeGUI.Show();
            this.Close();
        }

        private void btnLimousine_Click(object sender, EventArgs e)
        {
            LimousineGUI lim = new LimousineGUI();
            lim.Show();
            this.Close();
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            TripGUI trip = new TripGUI();
            trip.Show();    
            this.Close();
        }
    }
}
