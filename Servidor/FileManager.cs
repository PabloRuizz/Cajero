using System.IO;
using System.Runtime.Serialization;

namespace Servidor
{
    public class FileManager
    {
        public static string[] get()
        {
            int posicion = 0;
            string[] result = new string[50];
            if (File.Exists("TextFile.txt"))
            {
                foreach (var linea in File.ReadLines("TextFile.txt"))
                {
                    result[posicion] = linea;
                    posicion++;
                }
            }
            return result;
        }

        public static void sacarDinero(String id, int dinero)
        {
            string[] newLinea = getLineaId(id);

            if (newLinea != null)
            {
                int dineroCuenta=Int32.Parse(newLinea[2]);
                int linea = Int32.Parse(newLinea[3]);
                if (dineroCuenta > dinero)
                {
                    dineroCuenta = dineroCuenta - dinero;
                    newLinea[2] = dineroCuenta.ToString();


                    string lineaFinal = crearLinea(newLinea[0], newLinea[1], newLinea[2]);
                    actualizarLinea(lineaFinal, linea);
                
                
                }
            }
        }

        public static void meterDinero(String id, int dinero)
        {
            string[] newLinea = getLineaId(id);

            if (newLinea != null)
            {
                int dineroCuenta = Int32.Parse(newLinea[2]);
                int linea = Int32.Parse(newLinea[3]);
                
                    dineroCuenta = dineroCuenta + dinero;
                    newLinea[2] = dineroCuenta.ToString();


                    string lineaFinal = crearLinea(newLinea[0], newLinea[1], newLinea[2]);
                    actualizarLinea(lineaFinal, linea);



            }
        }

        public static bool CrearCuenta(string id, string nombre)
        {
            string[] lineaNombre=getLineaNombre(nombre);
            string[] lineaId=getLineaId(id);

            if (lineaNombre == null && lineaId == null) {
                using (StreamWriter writer = new StreamWriter("TextFile.txt"))
                {
                    writer.WriteLine(crearLinea(id,nombre,"0"));
                    return true;
                }
            }
            else {
                return false;
            }


        }


        public static string[] getLineaId(string id)
        {
            int posicion = 0;

            if (File.Exists("TextFile.txt"))
            {
                foreach (var linea in File.ReadLines("TextFile.txt"))
                {

                    String lineaRespuesta = linea + "," + posicion;
                    posicion++;
                    var datos = lineaRespuesta.Split(',');
                    if (datos.Length == 4 & datos[0]==id)
                    {
                        return datos;
                    }
                }
            }
            return null;
        }

        public static string[] getLineaNombre(string nombre)
        {
            int posicion = 0;

            if (File.Exists("TextFile.txt"))
            {
                foreach (var linea in File.ReadLines("TextFile.txt"))
                {

                    String lineaRespuesta = linea + "," + posicion;
                    posicion++;
                    var datos = lineaRespuesta.Split(',');
                    if (datos.Length == 4 & datos[1] == nombre)
                    {
                        return datos;
                    }
                }
            }
            return null;
        }

        public static string crearLinea(string id,  string nombre, string cantidad)
        {
            return id + "," + nombre + "," + cantidad;
        }

        static void actualizarLinea(string nuevoTexto, int linea)
        {
            string archivoTemp = "archivo_temp.txt";
            using (StreamReader reader = new StreamReader("TextFile.txt"))
            using (StreamWriter writer = new StreamWriter(archivoTemp))
            {
                int currentLine = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (currentLine == linea)
                    {
                        writer.WriteLine(nuevoTexto);
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                    currentLine++;
                }
            }   
            File.Delete("TextFile.txt");
            File.Move(archivoTemp, "TextFile.txt");
        }


        public static void eliminarLinea(string nombre)
        {
            var lines = File.ReadAllLines("TextFile.txt").ToList();

            lines.RemoveAll(line => line.Contains(nombre));

            File.WriteAllLines("TextFile.txt", lines);
        }
    }
}
