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
            Film temp = new Film(tBTitle.Text, Convert.ToInt32(mtBYear), Convert.ToInt32(mtBRuntime), cBGenre.Text, cBLanguage.Text, tBDirector.ToString(), rTBDescription.ToString(), Convert.ToBoolean(cBViewed));

            Functions.getInstance().AddFilm(temp);
        }
    }
}
//-------------------------------------------------