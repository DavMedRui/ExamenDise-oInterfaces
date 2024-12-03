namespace ExamenT2DMR_bueno.Vistas;

public partial class Ejercicio2 : ContentPage
{
	string nombre;
	string email;
	string contrasenia;
	string contraseniaConfirmacion;

	public Ejercicio2()
	{
		InitializeComponent();
	}

    private void onRegistrarClicked(object sender, EventArgs e)
    {
		nombre = txtNombre.Text;
		email = txtEmail.Text;
		contrasenia = txtContrasenia.Text;
		contraseniaConfirmacion = txtContraseniaConfirmada.Text;


		if (!string.IsNullOrWhiteSpace(nombre) & !string.IsNullOrWhiteSpace(email) 
			& !string.IsNullOrWhiteSpace(contrasenia) & !string.IsNullOrWhiteSpace(contraseniaConfirmacion))//Para comprobar que no estén vacíos ni nulos o nulos
        {
			if (!contrasenia.Equals(contraseniaConfirmacion) || contrasenia.Length<8) //Si no coinciden o si no supera el mínimo de caracteres
			{
                DisplayAlert("Error", "Las contraseñas no coinciden o no superan los 8 caracteres", "OK");
                return;
            }

			DisplayAlert("Éxito", "Registro realizado con éxito", "Ok");


		}
		else //Si hay algún campo vacío
		{
            DisplayAlert("Error", "Tienes que rellenar todos los campos", "OK");
            return;
        }

    }

    private void onLimpiarClicked(object sender, EventArgs e)
    {
        txtNombre.Text = string.Empty; 
		txtEmail.Text = string.Empty; 
		txtContrasenia.Text = string.Empty; 
		txtContraseniaConfirmada.Text = string.Empty;
    }
}