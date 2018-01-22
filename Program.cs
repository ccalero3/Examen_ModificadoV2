using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
//using Mono;
using NpgsqlTypes;


namespace Examen_1613550
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;port=5432;Database=Nomina1;User ID=postgres;Password=1234");
           //Instanciando al modulo  generico 
            modulo_generico modulo = new modulo_generico(con);
                     
            //Console.WriteLine(con.State);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*                  Examen de programacion Avansada                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("***********Cristhian Calero Gazo 1613550*******************************");
            Console.WriteLine("");

           
            //creando un variable tipo tabla y ejecutando el metodo captura pasando el parametro para consulta
            DataTable tabla = modulo.Captura("select * from empleado");

            foreach(DataRow fila in tabla.Rows)
            {
                  Console.WriteLine("ID :"+fila[0]+" Nombre: "+fila[1]+"Apellido : "+fila[2]);
             }
            Console.ReadKey();
    }
}
}