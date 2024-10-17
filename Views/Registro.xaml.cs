namespace calcivarS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuario.Text;
		string contrasena = txtContrasena.Text;

		Navigation.PushAsync(new Login(usuario,contrasena));

    }
}