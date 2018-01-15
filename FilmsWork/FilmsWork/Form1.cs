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
                dGTable.Rows.Add(Functions.getInstance().GetFilm(i).Title, Functions.getInstance().GetFilm(i).Runtime, Functions.getInstance().GetFilm(i).Viewed);

            dGTable.Refresh();

            NOLOAD:

            listBeginnerCount = Functions.getInstance().FilmCount();
            return;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Functions.getInstance().CancelAdd = true;

            fAddEdit add = new fAddEdit();
            add.ShowDialog();

            add.Dispose();

            if (Functions.getInstance().CancelAdd)
            {
                int lastIndex = Functions.getInstance().FilmCount() - 1;

                dGTable.Rows.Add(Functions.getInstance().GetFilm(lastIndex).Title, Functions.getInstance().GetFilm(lastIndex).Runtime, Functions.getInstance().GetFilm(lastIndex).Viewed);

                dGTable.Refresh();
            }
        }

        private void FilmsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBeginnerCount != Functions.getInstance().FilmCount())
            {
                using (var fStream = new FileStream("Films.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fStream, Functions.getInstance().GetList());
                }
            }
        }

        private void dGTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            lbDescription.Items.Clear();

            if (dGTable.CurrentRow != null)
            {
                Functions.getInstance().SelectedIndexForEdit = dGTable.CurrentRow.Index;
                //if (Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Title != dGTable.FirstDisplayedCell.Value)
                //{

                lbDescription.Items.Add($"Title:\t\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Title}");
                lbDescription.Items.Add($"Year:\t\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Year}");
                lbDescription.Items.Add($"Genre:\t\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Genre}");
                lbDescription.Items.Add($"Language:\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Language}");
                lbDescription.Items.Add($"Director(s):\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Director}");
                lbDescription.Items.Add($"Description:\t{Functions.getInstance().GetList()[dGTable.CurrentRow.Index].Description}");

                //pbPicture.Image = Image.FromFile(Functions.getInstance().GetList()[dGTable.CurrentRow.Index].PicturePath);
                //}
            }
        }

        private void dGTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Functions.getInstance().GetList().Remove(Functions.getInstance().GetList()[e.RowIndex]);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            Functions.getInstance().EditChange = true;
            fAddEdit edit = new fAddEdit();
            edit.Text = "Edit";

            edit.ShowDialog();

            edit.Dispose();
            Functions.getInstance().EditChange = false;
        }
    }
}
//-------------------------------------------------