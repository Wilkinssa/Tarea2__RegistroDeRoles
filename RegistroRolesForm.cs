using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_RegistroDeRoles.BLL;
using Tarea2_RegistroDeRoles.DAL;
using Tarea2_RegistroDeRoles.Entidades;

namespace Tarea2_RegistroDeRoles
{
    public partial class RegistroRolesForm : Form
    {
        public RegistroRolesForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RolesIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            RolesIdTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            FechaCreacionDateTimeP.Value = DateTime.Now;
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();
            try
            {
                rol.rolesId = Convert.ToInt32(RolesIdTextBox.Text);
            }
            catch (Exception)
            {
                throw;
            }
            
            rol.descripcion = DescripcionTextBox.Text;
            rol.fechaCreacion = FechaCreacionDateTimeP.Value;

            return rol;
        }
        private bool EstaEnLaBD()
        {
            Roles rol = RolesBLL.Buscar(Convert.ToInt32(RolesIdTextBox.Text));
            return (rol != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;

            if (!Validar())
                return;

            try
            {
                rol = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato invalido en ID", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            

            if (!EstaEnLaBD() && !RolesBLL.ExisteDescripcion(DescripcionTextBox.Text))
                paso = RolesBLL.Guardar(rol);
                
            else
            {
                
                MessageBox.Show("No se puede guardar el rol ya que este existe. Verifique Id o Descripcion", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;   
               
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            Actualizar_ConsulaRoles();
        }

        private bool Validar()
        {
            bool paso = true;

            if (RolesIdTextBox.Text == String.Empty)
            {
                RolesIdTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
              
                DescripcionTextBox.Focus();
                paso = false;
            }
            Actualizar_ConsulaRoles();
            return paso;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Actualizar_ConsulaRoles()
        {
            Contexto contexto = new Contexto();
            ConsultaRolesDataGridView.DataSource = contexto.Roles.ToList();
            contexto.Dispose();
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(RolesIdTextBox.Text, out id);

            Limpiar();

            if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado","Exito", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Actualizar_ConsulaRoles();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;

            if (!Validar())
                return;
           
            try
            {
                rol = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato invalido en ID", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            
            if (EstaEnLaBD())
            {
                paso = RolesBLL.Modificar(rol);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el rol ya que este no existe!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            Actualizar_ConsulaRoles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
