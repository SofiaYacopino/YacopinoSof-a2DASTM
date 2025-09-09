using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWindowsForm
{
    public partial class FrmNuevo : Form
    {
        private int? Id;

        public FrmNuevo(int? id=null)
        {
            InitializeComponent();
            Id = id;
            if(this.Id != null)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            PeopleDB oPeopleDB = new PeopleDB();
            People oPeople = oPeopleDB.Get((int)Id);
            txtNombre.Text = oPeople.Name;
            txtEdad.Text = oPeople.Age.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PeopleDB oPeopleDB = new PeopleDB();
            try
            {
                if (Id == null)
                    oPeopleDB.Add(txtNombre.Text, int.Parse(txtEdad.Text));
                else
                    oPeopleDB.Update(txtNombre.Text, int.Parse(txtEdad.Text), (int) Id);

                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error al guardar: " + ex.Message);
            }
        }
    }
}
