using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data;

namespace FileManager.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
       public static Dictionary<int, Student> students = new Dictionary<int, Student>();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var TypeOfFile = CmbFiles.SelectedItem.ToString();
            var id = students.Count + 1;
            Student student = new Student(id, txtBoxName.Text, txtBoxSurname.Text, txtBoxAge.Text);
            students.Add(students.Count +1,student);
            IFileFactory FileCreate = FactoryProvider.GetFactory(TypeOfFile);
           var Return= FileCreate.CreateFile(TypeOfFile);
            MessageBox.Show("Insertado correctamente: "+"ID: "+id+"Name: "+txtBoxName.Text+ "Surname "+ txtBoxSurname.Text+"Edad: "+txtBoxAge.Text);

        }

        
    }
}
