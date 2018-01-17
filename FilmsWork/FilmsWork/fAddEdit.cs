using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------
namespace FilmsWork
{
    public partial class fAddEdit : Form
    {
        public fAddEdit()
        {
            InitializeComponent();

            if (Functions.getInstance().EditChange)
            {
                tBTitle.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Title;
                mtBYear.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Year.ToString();
                mtBRuntime.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Runtime.ToString();
                cBGenre.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Genre;
                cBLanguage.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Language;
                tBDirector.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Director;
                rTBDescription.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Description;
                cBViewed.Checked = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].Viewed;
                tbPicPath.Text = Functions.getInstance().GetList()[Functions.getInstance().SelectedIndexForEdit].PicturePath;
                pbSearchResult.Image = Image.FromFile(tbPicPath.Text);
            }
        }

        private void bOk_Click(object sender, EventArgs e)  
        {
            if (Functions.getInstance().EditChange)
            {
                int index = Functions.getInstance().SelectedIndexForEdit;

                Functions.getInstance().GetList()[index].Description = rTBDescription.Text;
                Functions.getInstance().GetList()[index].Director = tBDirector.Text;
                Functions.getInstance().GetList()[index].Genre = cBGenre.Text;
                Functions.getInstance().GetList()[index].Language = cBLanguage.Text;
                Functions.getInstance().GetList()[index].PicturePath = tbPicPath.Text;
                Functions.getInstance().GetList()[index].Runtime = Convert.ToInt32(mtBRuntime.Text);
                Functions.getInstance().GetList()[index].Title = tBTitle.Text;
                Functions.getInstance().GetList()[index].Viewed = cBViewed.Checked;
                Functions.getInstance().GetList()[index].Year = Convert.ToInt32(mtBYear.Text);
            }
            else
            {
                Film temp = new Film(tBTitle.Text, Convert.ToInt32(mtBYear.Text), Convert.ToInt32(mtBRuntime.Text), cBGenre.Text, cBLanguage.Text, tBDirector.Text, rTBDescription.Text, cBViewed.Checked, tbPicPath.Text);

                Functions.getInstance().AddFilm(temp);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Functions.getInstance().CancelAdd = false;
        }

        private void bAddPic_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Application.ExecutablePath;
            openFileDialog.Filter = "Bmp(*.BMP)|*.BMP| Jpg(*.jpg)|*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        tbPicPath.Text = openFileDialog.FileName;
                        pbSearchResult.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
         
        private void bSearch_Click(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                var uri = new Uri($@"http://www.omdbapi.com/?apikey=dbf23902");
                uri = uri.AddParameter("t", tbSearch.Text);
                var data = webClient.DownloadString(uri);
                //richTextBox1.Text = data;
                //tbSearch.Text = data;

                dynamic obj = JObject.Parse(data);
                //richTextBox1.Text = obj.Title;

                if (obj.Response == "False")
                {
                    MessageBox.Show((string)obj.Error);
                    return;
                }

                if (!File.Exists(@"pics\"))
                    Directory.CreateDirectory(@"pics\");

                if (obj.Poster != "N/A")
                {
                    webClient.DownloadFile((string)obj.Poster, $@"pics\{obj.imdbID}.jpg");
                    pbSearchResult.Image = Image.FromFile($@"pics\{obj.imdbID}.jpg");
                    int length = tbPicPath.Text.Length;
                    tbPicPath.Text = tbPicPath.Text.Remove(length - 13);
                    tbPicPath.Text += "pics\\" + obj.imdbID + ".jpg";
                    tbPicPath.Text = Application.ExecutablePath;
                }

                tBTitle.Text = obj.Title;

                mtBYear.Text = "0";
                if (obj.Year != "N/A")
                    mtBYear.Text = obj.Year;

                mtBRuntime.Text = "0";
                if (obj.Runtime != "N/A")
                    mtBRuntime.Text = obj.Runtime;

                cBGenre.Text = obj.Genre;
                cBLanguage.Text = obj.Language;
                tBDirector.Text = obj.Director;
                rTBDescription.Text = obj.Plot;
            }
        }
    }
}
//-------------------------------------------------