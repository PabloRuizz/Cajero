using System.IO;

namespace Servidor
{
    public class FileManager
    {


        public static void sacarDinero(String id, int dinero)
        {
            string[] newLinea = getLinea(id);

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


        public static String[] getLinea(string id)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            int posicion = 0;

            if (File.Exists("TextFile1"))
            {
                foreach (var linea in File.ReadLines("TextFile1"))
                {

                    String lineaRespuesta = linea + ";" + posicion;
                    posicion++;
                    var datos = lineaRespuesta.Split(';');
                    if (datos.Length == 4 & datos[0]==id)
                    {
                        return datos;
                    }
                }
            }
            return null;
        }

        public static string crearLinea(string id,  string nombre, string cantidad)
        {
            return id + ";" + nombre + ";" + cantidad;
        }

        static void actualizarLinea(string nuevoTexto, int linea)
        {
            string archivoTemp = "archivo_temp.txt";
            using (StreamReader reader = new StreamReader("TextFile1"))
            using (StreamWriter writer = new StreamWriter(archivoTemp))
            {
                int currentLine = 1;
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
            File.Delete("TextFile1");
            File.Move(archivoTemp, "TextFile1");
        }
    }
}
