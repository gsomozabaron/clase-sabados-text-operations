using System.Text;

namespace clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string palabra = "peluca";
            string palabras = "peluca magica y mugrienta";
 
            int cantidad = TextOperations.ContarLetras(palabra);
            
            int CantidadPalabras = TextOperations.ContarPalabras(palabras);
            
            bool vocal = true;
            int ContarVocales = TextOperations.ContarVocales(palabra,vocal);

            vocal = false;
            int ContarConsonantes = TextOperations.ContarVocales(palabra,vocal);

            char original = 'p';
            char nuevo = 'd';
            string reemplazarCaracter = TextOperations.ReemplazarCaracter(palabra, original, nuevo);

            string texto = "125";
            bool esInt = TextOperations.ConvertirStringAEntero(texto);

            texto = "a125";
            esInt = TextOperations.ConvertirStringAEntero(texto);
            




        }
    }
}