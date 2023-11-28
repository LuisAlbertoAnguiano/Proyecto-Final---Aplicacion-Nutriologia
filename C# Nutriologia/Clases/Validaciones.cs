using System.Linq;

namespace C__Nutriologia.Clases
{
    public class Validaciones
    {
        // Funcion que solo permite el ingreso de caracteres tipo letra
        public static void SoloLetras(ref System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        // Funcion que solo permite el ingreso de caracteres tipo texto
        public static void SoloTexto(ref System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = false;
        }

        // Funcion para que solo permite el ingreso de caracteres tipo numerico
        public static void SoloNumeros(ref System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        // Funcion para que permite el ingreso de numeros enteros y decimales
        public static void NumerosDecimales(ref System.Windows.Forms.KeyPressEventArgs e)
        {
            char[] caracteres = new[] { '.' };

            if ((char.IsDigit(e.KeyChar) | caracteres.Contains(e.KeyChar)))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        // Funcion para que permite el ingreso de numeros enteros y letras
        public static void LetrasNumeros(ref System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) | char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
