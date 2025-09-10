﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            PeopleDB OpeopleDB = new PeopleDB();
            dataGridView1.DataSource = OpeopleDB.Get();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnNuevoForm_Click(object sender, EventArgs e)
        {
            FrmNuevo frmNuevo = new FrmNuevo();
            frmNuevo.ShowDialog();
            Refresh();
        }

        #region helper

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }catch
            {
                return null;
            }
           
        }


        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if(Id != null)
            {
                FrmNuevo frmEdit = new FrmNuevo(Id);
                frmEdit.ShowDialog();
                Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {

                if (Id != null)
                {
                    PeopleDB oPeopleDB = new PeopleDB();
                    oPeopleDB.Delete((int)Id);
                    Refresh();
                }
            }catch(Exception ex)
            {
                throw new Exception ("Ocurrio un error al eliminar: " + ex.Message);
            }
        }
    }
}
