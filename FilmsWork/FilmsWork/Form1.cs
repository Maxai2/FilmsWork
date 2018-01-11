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
    public partial class FilmsView : Form
    {   
        public FilmsView()
        {
            InitializeComponent();

            Film film = new Film("Lord", 2001, 123, "Horror", "English", "Peter", "", false);
            Functions.getInstance().AddFilm(film);

            
            dGTable.Rows.Add(film.Title, film.Year);
            dGTable.Rows.Add(film.Title, film.Year - 1);
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

        private void lbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//-------------------------------------------------