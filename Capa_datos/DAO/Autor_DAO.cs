using Capa_datos.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos.DAO
{
    public class Autor_DAO
    {
        public Autor_DAO()
        {
        }  
        public List<Autor> mostrar()
        {
            List<Autor> lista_autores = new List<Autor>();
            StreamReader sr = new StreamReader("Autores.txt");

            String linea;
            while ((linea = sr.ReadLine()) != null) // Se coloca "sr.ReadLine()", adentro, pq sino crea un bucle infinito
            {
                Autor autor = new Autor();
                autor.Codigo = linea.Split(';')[0];
                autor.Nombre = linea.Split(';')[1];
                autor.Apellido= linea.Split(';')[2];
                autor.Ciclo = linea.Split(';')[3];
                autor.Curso = linea.Split(';')[4];
                autor.Carrera = linea.Split(';')[5];

                lista_autores.Add(autor);
            }
            return lista_autores;
        }
    }
}
