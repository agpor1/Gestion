using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public static class GestorIdiomas
    {
        private static string idioma = "es"; // Idioma por defecto Español

        public static string Idioma
        {
            get { return idioma; }
            set
            {
                idioma = value;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            }
        }


    }
}
