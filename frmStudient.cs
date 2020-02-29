using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.DataAccess.Data;

namespace FileManager.Presentation.WinSite
{
    public partial class frmStudient : Form
    {
        public frmStudient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Name = txtBoxName.Text;
            var Surname = txtBoxName.Text;
            var Age = txtBoxAge.Text;
            var TypeOfFile = CmbFiles.SelectedItem;
            IFileFactory ifile = StudientDao.TypeFile(TypeOfFile.ToString());

        }

        
    }
}
