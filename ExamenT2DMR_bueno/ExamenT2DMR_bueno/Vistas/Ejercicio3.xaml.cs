using System.Collections.ObjectModel;
using ExamenT2DMR_bueno.Modelo;

namespace ExamenT2DMR_bueno.Vistas;

public partial class Ejercicio3 : ContentPage
{
    ObservableCollection<Producto> Productos { get; set; }
    Producto seleccionado;


    public Ejercicio3()
	{
		InitializeComponent();

        Producto lapiz = new Producto
        {
            Nombre = "Lapiz HB",
            Descripcion = "Lapiz de dureza HB ideal para sombreados",
            Imagen = "lapiz.jpg",
        };

        Producto estuche = new Producto
        {
            Nombre = "Estuche de cuero",
            Descripcion = "Estuche de cuero sintetico",
            Imagen = "estuche.jpg",
            
        };

        Producto reglas = new Producto
        {
            Nombre = "Set de reglas",
            Descripcion = "Reglas de muchos colores",
            Imagen = "reglas.jpg",
            
        };

        Producto compas = new Producto
        {
            Nombre = "Compás",
            Descripcion = "Compás para hacer circulitos",
            Imagen = "compas.jpg",
            
        };

        Producto boligrafo = new Producto
        {
            Nombre = "Boligrafo BIC",
            Descripcion = "Te duran una vida y media, y más si eres informático",
            Imagen = "boligrafo.jpg",
            
        };

        Producto borrador = new Producto
        {
            Nombre = "Borrador MILÁN",
            Descripcion = "Pa borrar",
            Imagen = "borrador.jpg",
            
        };

        Producto portaminas = new Producto
        {
            Nombre = "Portaminas",
            Descripcion = "Pa cuando se te olvide el lápiz.",
            Imagen = "portaminas.jpg",

        };

        Productos = new ObservableCollection<Producto>()
        {
            lapiz,estuche,reglas,compas,boligrafo, borrador, portaminas
        };

        BindingContext = this;

        lista.ItemsSource = Productos; //Asignamos a la lista que vamos a mostrar, la que hemos creado con los animales


    }

    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Producto p)
        {
            await Navigation.PushAsync(new DescripcionProducto(p));
        }
    }
}