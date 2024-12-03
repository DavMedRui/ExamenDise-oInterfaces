using ExamenT2DMR_bueno.Modelo;

namespace ExamenT2DMR_bueno.Vistas;

public partial class DescripcionProducto : ContentPage
{
    public DescripcionProducto(Producto p)
    {
        InitializeComponent();
        BindingContext = p;
    }
}