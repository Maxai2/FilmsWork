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

            for (int i = 0; i < Functions.getInstance().FilmCount(); i++)
                dGTable.Rows.Add(Functions.getInstance().GetFilm(i).Title, Functions.getInstance().GetFilm(i).Runtime, Functions.getInstance().GetFilm(i).Viewed);

            //dGTable.Refresh();

            NOLOAD:

            listBeginnerCount = Functions.getInstance().FilmCount();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Functions.getInstance().CancelAdd = true;

            fAddEdit add = new fAddEdit();
            add.ShowDialog();

            add.Dispose();

            if (Functions.getInstance().CancelAdd)
            {
                dGTable.Invalidate();
                int lastIndex = Functions.getInstance().FilmCount() - 1;

                dGTable.Rows.Add(Functions.getInstance().GetFilm(lastIndex).Title, Functions.getInstance().GetFilm(lastIndex).Runtime, Functions.getInstance().GetFilm(lastIndex).Viewed);

                dGTable.Refresh();
            }
        }
         
        private void FilmsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Functions.getInstance().FilmCount() == 0)
            {
                File.Delete("Films.dat");
                return;
            }
            if (listBeginnerCount != Functions.getInstance().FilmCount())
            {
                using (var fStream = new FileStream("Films.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(fStream, Functions.getInstance().GetList());
                }
            }
        }

        private void dGTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Functions.getInstance().GetList().Remove(Functions.getInstance().GetList()[e.RowIndex]);
            pbPicture.Image = null;
            pbPicture.Invalidate();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (Functions.getInstance().FilmCount() == 0)
            {
                MessageBox.Show("No films to edit!");
                return;
            }
            Functions.getInstance().EditChange = true;
            fAddEdit edit = new fAddEdit();
            edit.Text = "Edit";

            edit.ShowDialog();
            edit.Dispose();

            Functions.getInstance().EditChange = false;
            dGTable.Rows.Clear();

            for (int i = 0; i < Functions.getInstance().FilmCount(); i++)
                dGTable.Rows.Add(Functions.getInstance().GetFilm(i).Title, Functions.getInstance().GetFilm(i).Runtime, Functions.getInstance().GetFilm(i).Viewed);
        }

        private void dGTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            lbDescription.Items.Clear();
            rTBdescription.Clear();
            pbPicture.Image = null;

            if (dGTable.CurrentRow != null)
            {
                int index = Functions.getInstance().SelectedIndexForEdit = e.Row.Index;
                bool found = true;

                string ListName = Functions.getInstance().GetList()[index].Title;
                string DGName = dGTable[0, index].Value.ToString();

                if (ListName == DGName)
                    found = false;

                while (true)
                {
                    if (found)
                    {
                        lbDescription.Items.Add($"Title: {Functions.getInstance().GetList()[index].Title}");
                        lbDescription.Items.Add($"Year: {Functions.getInstance().GetList()[index].Year}");
                        lbDescription.Items.Add($"Genre: {Functions.getInstance().GetList()[index].Genre}");
                        lbDescription.Items.Add($"Language: {Functions.getInstance().GetList()[index].Language}");
                        lbDescription.Items.Add($"Director(s): {Functions.getInstance().GetList()[index].Director}");

                        rTBdescription.Text = Functions.getInstance().GetList()[index].Description;

                        if (Functions.getInstance().GetList()[index].PicturePath != null && Functions.getInstance().GetList()[index].PicturePath != "")
                        {
                            pbPicture.Image = Image.FromFile(Functions.getInstance().GetList()[index].PicturePath);
                            pbPicture.Invalidate();
                        }

                        break;
                    }
                    else
                    {
                        for (int i = 0; i < Functions.getInstance().FilmCount(); i++)
                        {
                            if (DGName == Functions.getInstance().GetList()[i].Title)
                            {
                                index = i;
                                found = true;
                            }
                        }
                    }
                }
            }
        }
    }
}
//-------------------------------------------------