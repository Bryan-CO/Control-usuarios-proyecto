using Capa_Presentacion.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos.DAO
{
    public class Usuarios_DAO
    {
        //Creo e inicializo la lista donde se almacenaran los objetos de usuarios
        List<Usuario> lista_usuarios = new List<Usuario>();
        List<Usuario> nueva_lista = new List<Usuario>();
        //Creo el objeto usuario, esto es equivalente a solo poner por ejemplo: int numero;
        Usuario usuario;
        public bool respuesta;
        public Usuarios_DAO()
        {
            StreamReader sr = new StreamReader("Usuarios.txt");

            String linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario usuario = new Usuario();

                usuario.codigo = linea.Split(';')[0];
                usuario.usuario = linea.Split(';')[1];
                usuario.contraseña = linea.Split(';')[2];
                usuario.nombres = linea.Split(';')[3];
                usuario.apellidos = linea.Split(';')[4];
                usuario.foto = linea.Split(';')[5];

                nueva_lista.Add(usuario);
            }
            sr.Close();
        }
        public int cant() //Este metodo es para verificar que se añadio un nuevo usuario, y me muestre la cantidad de datos en el List
        {
            return lista_usuarios.Count();
        }
        public void agregar(String codigo, String user, String pass, String nombre, String apellido, String foto) //Con esto agrego un nuevo usuario
        {
            usuario = new Usuario();
            usuario.codigo = codigo;
            usuario.usuario = user;
            usuario.contraseña = pass;
            usuario.nombres = nombre;
            usuario.apellidos = apellido;
            usuario.foto = foto;
            nueva_lista.Add(usuario);
            StreamWriter sw = new StreamWriter("Usuarios.txt", true);
            sw.WriteLine(usuario.codigo + ";" + usuario.usuario + ";" + usuario.contraseña + ";" + usuario.nombres + ";" +
                usuario.apellidos + ";" + usuario.foto);

            sw.Close();
        }
        public String[] ingresar(String username, String password) //Ingreso, no olvidar tmb permisos, con un combobox, si es el rol admin o solo un trabajador
                                                                   //para asi brindar los permisos correspondientes
        {
            String[] credenciales = null;
            StreamReader sr = new StreamReader("Usuarios.txt");
            String linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario usuario = new Usuario();
                usuario.usuario = linea.Split(';')[1];
                usuario.contraseña = linea.Split(';')[2];
                usuario.nombres = linea.Split(';')[3];
                usuario.apellidos = linea.Split(';')[4];
                lista_usuarios.Add(usuario);
            }
            for (int i = 0; i < lista_usuarios.Count; i++)
            {
                if (lista_usuarios[i].usuario == username && lista_usuarios[i].contraseña == password)
                {
                    credenciales = new string[3];
                    credenciales[0] = lista_usuarios[i].usuario.ToString();
                    credenciales[1] = lista_usuarios[i].nombres.ToString();
                    credenciales[2] = lista_usuarios[i].apellidos.ToString();
                }
            }

            return credenciales;
        }
        public List<Usuario> mostrar()
        {

            List<Usuario> lista_usuarios = new List<Usuario>();
            StreamReader sr = new StreamReader("Usuarios.txt");

            String linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario usuario = new Usuario();
                usuario.codigo = linea.Split(';')[0];
                usuario.usuario = linea.Split(';')[1];
                usuario.contraseña = linea.Split(';')[2];
                usuario.nombres = linea.Split(';')[3];
                usuario.apellidos = linea.Split(';')[4];
                usuario.foto = linea.Split(';')[5];


                lista_usuarios.Add(usuario);
            }
            sr.Close();
            return lista_usuarios;
        }
        public void eliminar(int n)
        {
            nueva_lista.RemoveAt(n);
            StreamWriter sw = new StreamWriter("Usuarios.txt", false);
            for (int i = 0; i < nueva_lista.Count; i++)
            {

                sw.WriteLine(nueva_lista[i].codigo + ";" + nueva_lista[i].usuario + ";" + nueva_lista[i].contraseña + ";" +
                    nueva_lista[i].nombres + ";" + nueva_lista[i].apellidos + ";" + nueva_lista[i].foto);

            }
            sw.Close();
        }

        public void modificar(int fila, String codigo, String user, String pass, String nombre, String apellido, String foto)
        {
            List<Usuario> lista_modificada = new List<Usuario>();
            StreamReader sr = new StreamReader("Usuarios.txt");

            String linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario usuario = new Usuario();
                usuario.codigo = linea.Split(';')[0];
                usuario.usuario = linea.Split(';')[1];
                usuario.contraseña = linea.Split(';')[2];
                usuario.nombres = linea.Split(';')[3];
                usuario.apellidos = linea.Split(';')[4];
                usuario.foto = linea.Split(';')[5];


                lista_modificada.Add(usuario);
            }
            sr.Close();

            //Modifico la lista en el indice que le digo

            lista_modificada[fila].codigo = codigo;
            lista_modificada[fila].usuario = user;
            lista_modificada[fila].contraseña = pass;
            lista_modificada[fila].nombres = nombre;
            lista_modificada[fila].apellidos = apellido;
            lista_modificada[fila].foto = foto;

            StreamWriter sw = new StreamWriter("Usuarios.txt", false);
            for (int i = 0; i < lista_modificada.Count; i++)
            {

                sw.WriteLine(lista_modificada[i].codigo + ";" + lista_modificada[i].usuario + ";" + lista_modificada[i].contraseña + ";" +
                    lista_modificada[i].nombres + ";" + lista_modificada[i].apellidos + ";" + lista_modificada[i].foto);

            }
            sw.Close();
        }
        public Usuario mostrar_datos_modificar(int x)
        {
            return nueva_lista[x];
        }
        public Usuario buscar(String x)
        {
            Usuario usuario_encontrado = null;
            StreamReader sr = new StreamReader("Usuarios.txt");
            
            String linea;
            while ((linea = sr.ReadLine()) != null)
            {
                Usuario usuario = new Usuario();
                usuario.codigo = linea.Split(';')[0];
                usuario.usuario = linea.Split(';')[1];
                usuario.contraseña = linea.Split(';')[2];
                usuario.nombres = linea.Split(';')[3];
                usuario.apellidos = linea.Split(';')[4];
                usuario.foto = linea.Split(';')[5];

                if(x==usuario.codigo)
                {
                    usuario_encontrado = usuario;

                }
            }
            sr.Close();
            return usuario_encontrado;
        }
    }
}
