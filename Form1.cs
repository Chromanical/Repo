using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetuhovEmployment
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void workB_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            Chart.main = this;
            chart.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
