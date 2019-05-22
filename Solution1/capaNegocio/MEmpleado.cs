using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
   public class MEmpleado
    {
        bdConex test = new bdConex();

        public DataTable tabla = new DataTable();

        public string emp_no, apellido, oficio, fecha_alta, dept_no;
        public double salario, comision;
           public int direccion;

        public string Oficio
        {
            get { return oficio; }
            set { oficio = value; }
        }

        public string Dept_no
        {
            get { return dept_no; }
            set { dept_no = value; }
        }

        public double Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Fecha_alta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }

        public int Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Emp_no
        {
            get { return emp_no; }
            set { emp_no = value; }
        }


        public void insertarEmpleado()
        {
            try
            {

                String insert = "INSERT INTO Emp( emp_no, apellido, oficio, dir, Fecha_Alt, salario, comision, dept_no) VALUES('" + emp_no + "','" + apellido + "','" + oficio + "','" + direccion + "','" + fecha_alta + "','" + salario + "','" + comision + "','" + dept_no + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public void actualizarEmpleado()
        {
            try
            {
                String update = " UPDATE [dbo].[Emp] SET [Emp_No] = '" + emp_no + "' ,[Apellido] = '" + apellido + "' ,[Oficio] = '" + oficio + "',[Dir] = '" + direccion + "',[Fecha_Alt] = '" + fecha_alta + "' ,[Salario] = '" + salario + "',[Comision] = '" + comision + "' ,[Dept_No] = '" + dept_no + "'  where emp_no='" + emp_no + "'";
                
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void eliminarEmpleado()
        {
            try
            {
                String delete = "delete  from Emp where emp_no='" + emp_no + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }
        public void mostrarEmpleado()
        {
            try
            {
                String consulta = "select * from Emp";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(tabla);
                test.Desconectar();
            }
            catch
            {

            }
        }
    }
}
