using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------
namespace FilmsWork
{
    public partial class FilmsView : Form
    {
        int listBeginnerCount = 0;

        public FilmsView()
        {
            InitializeComponent();

            if (!File.Exists("Films.dat"))
                goto NOLOAD;

            Functions.getInstance().LoadList();

            //Film film = new Film("Lord", 2001, 123, "Horror", "English", "Peter", "", true);
            //Film film1 = new Film("B Movie", 2012, 153, "Comedy", "Russian", "", "", false);
            //Functions.getInstance().AddFilm(film);
            //Functions.getInstance().AddFilm(film1);

            for (int i = 0; i < Functions.getInstance().FilmCount(); i++)
                dGTable.Rows.Add(Functions.getInstance().GetFilm(i).Title, Functions.getInstance().GetFilm(i).Year, Functions.getInstance().GetFilm(i).Viewed);

            dGTable.Refresh();

            NOLOAD:

            listBeginnerCount = Functions.getInstance().FilmCount();
            return;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            /*DialogResult dialogResult = */
            //if (dialogResult == DialogResult.OK)
            //    Console.WriteLine("Ok");
            //else
            //if (dialogResult == DialogResult.Cancel)
            //    Console.WriteLine("Cansel");

            fAdd add = new fAdd();
            add.ShowDialog();

            add.Dispose();

            //dGTable.Rows.Clear();

            //for (int i = 0; i < Functions.getInstance().FilmCount(); i++)
            //    dGTable.Rows.Add(Functions.getInstance().GetFilm(i).Title, Functions.getInstance().GetFilm(i).Year, Functions.getInstance().GetFilm(i).Viewed);

            int lastIndex = Functions.getInstance().FilmCount() - 1;

            dGTable.Rows.Add(Functions.getInstance().GetFilm(lastIndex).Title, Functions.getInstance().GetFilm(lastIndex).Runtime, Functions.getInstance().GetFilm(lastIndex).Viewed);

            dGTable.Refresh();
        }

        private void FilmsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBeginnerCount != Functions.getInstance().FilmCount())
            {
                using (var fStream = new FileStream("Films.dat", FileMode.Append))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fStream, Functions.getInstance().GetList());
                }
            }
        }

        private void dGTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            lbDescription.Text += "!\n";
        }
    }
}
//-------------------------------------------------