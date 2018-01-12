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
    public partial class fAdd : Form
    {
        public fAdd()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)  
        {
            Film temp = new Film(tBTitle.Text, Convert.ToInt32(mtBYear.Text), Convert.ToInt32(mtBRuntime.Text), cBGenre.Text, cBLanguage.Text, tBDirector.Text, rTBDescription.Text, cBViewed.Checked);

            Functions.getInstance().AddFilm(temp);
        }
    }
}
//-------------------------------------------------