using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class EmpleadoIG : Form
    {
        MEmpleado mEmpleado = new MEmpleado();
        public EmpleadoIG()
        {
            InitializeComponent();
            cargar();
        }
        public void limpiar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.Refresh();
        }
        public void cargar()
        {
            mEmpleado.mostrarEmpleado();
             
            dataGridView1.DataSource = mEmpleado.tabla;

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mEmpleado.Emp_no = textBox1.Text;
            mEmpleado.Apellido = textBox2.Text;
            mEmpleado.Oficio = textBox3.Text;
            mEmpleado.Direccion = Convert.ToInt16(textBox4.Text);
            mEmpleado.Fecha_alta = textBox5.Text;
            mEmpleado.salario = Convert.ToDouble(textBox6.Text);
            mEmpleado.Comision =Convert.ToDouble(textBox7.Text);
            mEmpleado.Dept_no = textBox8.Text;



            mEmpleado.insertarEmpleado();
            limpiar();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mEmpleado.Emp_no = textBox1.Text;
            mEmpleado.eliminarEmpleado();
            cargar();
        }
    }
}
