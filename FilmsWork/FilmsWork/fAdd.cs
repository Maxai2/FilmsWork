using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------------------------------------------
namespace FilmsWork
{
    public partial class fAdd : Form
    {
        public fAdd()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)  
        {
            string path = @"Picture\skype.jpg";

            Film temp = new Film(tBTitle.Text, Convert.ToInt32(mtBYear.Text), Convert.ToInt32(mtBRuntime.Text), cBGenre.Text, cBLanguage.Text, tBDirector.Text, rTBDescription.Text, cBViewed.Checked, path);

            Functions.getInstance().AddFilm(temp);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Functions.getInstance().CancelAdd = false;
        }

        private void bAddPic_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
//-------------------------------------------------