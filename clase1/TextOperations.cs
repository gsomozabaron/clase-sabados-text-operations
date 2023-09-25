using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace clase1
{
    internal class TextOperations
    {
        /// <summary>
        /// ●ContarPalabras(string texto): Cuenta la cantidad de letras que contiene el texto;
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns>cantidad de letras</returns>
        static public int ContarLetras(string palabra)
        {
            int CantidadLetras = 0;
            CantidadLetras = palabra.Length;
            Console.WriteLine("cantidad de palabras en {0},{1}", palabra, CantidadLetras);
            return CantidadLetras;
        }

        /// <summary>
        /// ContarPalabras(string texto): Cuenta la cantidad de palabras que contiene el texto;
        /// </summary>
        /// <param name="palabras"></param>
        /// <returns>cantidad de palabras separadas por espacio</returns>
        static public int ContarPalabras(string palabras)
        {
            string[] SepararPalabras = palabras.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int cantidadPalabras = SepararPalabras.Length;
            Console.WriteLine("cantidad de palabras en {0},{1}", palabras, cantidadPalabras);
            return cantidadPalabras;
        }

        /// <summary>
        /// ● int ContarVocales(string palabra): Cuenta la cantidad de vocales que contiene una palabra.
        /// </summary>
        /// <param name="palabra"></param>
        /// <param name="vocal">si vocal = true cuenta vocales, si es false cuenta consonantes </param>
        /// <returns>cantidad de vocales o consonantes</returns>
        static public int ContarVocales(string palabra, bool vocal)
        {
            int cantidadVocales = 0;
            int cantidadConsonantes = 0;
            char[] caracteres = palabra.ToCharArray();
            foreach (char caracter in caracteres)
            {
                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                {
                    if (vocal)
                    {
                        cantidadVocales++;
                    }
                }
                else
                {
                    cantidadConsonantes++;
                }
            }
            if (vocal)
            {
                Console.WriteLine("cantidad de vocales en {0}: {1}", palabra, cantidadVocales);
            }
            else
            {
                Console.WriteLine("cantidad de consonantes en {0}: {1}", palabra, cantidadConsonantes);
            }
            return cantidadVocales;
        }

        /// <summary>
        ///  string ReemplazarCaracter(string palabra, char original, char nuevo):Reemplaza el carácter original por el indicado.
        /// </summary>
        /// <param name="palabra">palabra original</param>
        /// <param name="original">caracter a cambiar</param>
        /// <param name="nuevo">nuevo caracter</param>
        /// <returns>palabra modificada</returns>
        static public string ReemplazarCaracter(string palabra, char original, char nuevo)
        {
            if (palabra.Contains(original.ToString()))
            {
                palabra = palabra.Replace(original, nuevo);
            }
            Console.WriteLine($"palabra modificada: {palabra}");
            return palabra;
        }

        /// <summary>
        ///  bool ConvertirStringAEntero(string texto, int xxx numeroEntero): Devuelve si
        /// es posible convertir un texto a entero y si es posible lo devuelve en la
        /// variable numeroEntero.
        /// </summary>
        /// <param name="texto">La cadena de texto que se intentará convertir.</param>
        /// <param name="numeroEntero">La variable donde se almacenará el resultado de la conversión si es exitosa.</param>
        /// <returns>True si la conversión fue exitosa y se almacena el valor en numeroEntero; False en caso contrario.</returns>
        static public bool ConvertirStringAEntero(string texto)
        {
            int numeroEntero = 0;
            bool esInt = int.TryParse(texto, out numeroEntero);
            if (esInt)
            {
                Console.WriteLine($"{texto} se puede convertir a entero");
            }
                else { Console.WriteLine($"{texto} no se puede convertir a entero");
            }
        return esInt;
        }

       










}
}
/*Métodos:
● StringBuilder ConvertirStringASB(string palabra): Recibe un string y lo guarda
en un StringBuilder.

● StringBuilder ConvertirParrafoASB(string parrafo): Recibe un párrafo y
guarda cada frase en una línea nueva de un StringBuilder. Cada frase finaliza
cuando encontramos un punto (.).

● void MostrarTexto(string mensaje, string texto): Muestra por consola el
mensaje y el texto recibido.

● void MostrarTextoSB(StringBuilder texto): Muestra por consola el texto
recibido.*/
