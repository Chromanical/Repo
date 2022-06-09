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
    public partial class Chart : Form
    {
        public static MainWindow main = null;
        public Chart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR2_PetuhovDataSet.Вакансии". При необходимости она может быть перемещена или удалена.
            this.вакансииTableAdapter.Fill(this.pR2_PetuhovDataSet.Вакансии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pR2_PetuhovDataSet.Безработные". При необходимости она может быть перемещена или удалена.
            this.безработныеTableAdapter.Fill(this.pR2_PetuhovDataSet.Безработные);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.вакансииTableAdapter.Update(this.pR2_PetuhovDataSet.Вакансии);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.безработныеTableAdapter.Update(this.pR2_PetuhovDataSet.Безработные);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
