using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------
namespace FilmsWork
{
    List<Film> FilmList = new List<Film>();

    public partial class FilmsView : Form
    {
        public FilmsView()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            fAdd add = new fAdd();
            DialogResult dialogResult = add.ShowDialog();

            if (dialogResult == DialogResult.OK)
                Console.WriteLine("Ok");
            else
            if (dialogResult == DialogResult.Cancel)
                Console.WriteLine("Cansel");

            add.Dispose();
        }
    }
}
//-------------------------------------------------