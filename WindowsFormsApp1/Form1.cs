using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Photo_studio". При необходимости она может быть перемещена или удалена.
            this.photo_studioTableAdapter.Fill(this.vityaDataSet.Photo_studio);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Photo_studio". При необходимости она может быть перемещена или удалена.
            this.photo_studioTableAdapter.Fill(this.vityaDataSet.Photo_studio);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.vityaDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Servicees". При необходимости она может быть перемещена или удалена.
            this.serviceesTableAdapter.Fill(this.vityaDataSet.Servicees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.vityaDataSet.Request);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vityaDataSet.Photographer". При необходимости она может быть перемещена или удалена.
            this.photographerTableAdapter.Fill(this.vityaDataSet.Photographer);

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
