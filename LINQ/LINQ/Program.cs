using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Las tres partes de una consulta con LINQ
            // 1. Obtener el origen de datos
            int[] resultados = new int[] { 97, 92, 81, 60, 55, 100 };

            // 2. Definir la expresión del query (consulta)
            IEnumerable<int> resultadosQuery =
                from resultado in resultados
                where (resultado % 2) == 0
                select resultado;

            // 3. Ejecutar el query (consulta)
            foreach (int nota in resultadosQuery)
                Console.WriteLine(nota);

            Console.ReadLine();
        }
    }
}
