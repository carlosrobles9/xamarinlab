using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion
{
    public partial class MainPage : ContentPage
    {
        List<Book> escritores;
        public MainPage()
        {
            InitializeComponent();
            escritores = new List<Book>();
            escritores.Add(new Book()
            {
                titulo = "50 Shades Of Grey"
                ,
                Autor = "E L  James",

            });
            escritores.Add(new Book()
            {
                titulo = "Bad vibes"
                ,
                Autor = "xxxTentation",

            });
            escritores.Add(new Book()
            {
                titulo = "50 Años de mala suerte"
                ,
                Autor = "Tom Acosta",

            });
            escritores.Add(new Book()
            {
                titulo = "Love and Music"
                ,
                Autor = "Chris Pack"
                ,
                

            });
        }
    }
}

