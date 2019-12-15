using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacion
{
    public class Book : ContentPage
    {
        internal string titulo;
        internal string imagen;

        public Book()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }

        public string Autor { get; internal set; }
        public string Titulo { get; set; }
        public string Imagen { get; set; }
    }
}
