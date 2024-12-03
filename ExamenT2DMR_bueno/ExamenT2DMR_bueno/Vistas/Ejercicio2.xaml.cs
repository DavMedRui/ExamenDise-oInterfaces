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
			& !string.IsNullOrWhiteSpace(contrasenia) & !string.IsNullOrWhiteSpace(contraseniaConfirmacion))//Para comprobar que no est�n vac�os ni nulos o nulos
        {
			if (!contrasenia.Equals(contraseniaConfirmacion) || contrasenia.Length<8) //Si no coinciden o si no supera el m�nimo de caracteres
			{
                DisplayAlert("Error", "Las contrase�as no coinciden o no superan los 8 caracteres", "OK");
                return;
            }

			DisplayAlert("�xito", "Registro realizado con �xito", "Ok");


		}
		else //Si hay alg�n campo vac�o
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