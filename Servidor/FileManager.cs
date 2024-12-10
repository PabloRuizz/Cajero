using System.IO;
using System.Runtime.Serialization;

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

        public static void meterDinero(String id, int dinero)
        {
            string[] newLinea = getLinea(id);

            if (newLinea != null)
            {
                int dineroCuenta = Int32.Parse(newLinea[2]);
                int linea = Int32.Parse(newLinea[3]);
                
                    dineroCuenta = dineroCuenta - dinero;
                    newLinea[2] = dineroCuenta.ToString();


                    string lineaFinal = crearLinea(newLinea[0], newLinea[1], newLinea[2]);
                    actualizarLinea(lineaFinal, linea);



            }
        }


        public static String[] getLinea(string id)
        {
          //  File.Create("TextFile1");
          //  List<Cuenta> cuentas = new List<Cuenta>();
            int posicion = 0;

            string directory = AppDomain.CurrentDomain.BaseDirectory;

            // Ruta completa al archivo FileManager1.txt en el mismo directorio
            string filePath = Path.Combine(directory, "TextFile2.txt");

            if (File.Exists("TextFile2"))
            {
                foreach (var linea in File.ReadLines("TextFile2"))
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
            File.Delete("TextFile1");
            File.Move(archivoTemp, "TextFile1");
        }
    }
}
