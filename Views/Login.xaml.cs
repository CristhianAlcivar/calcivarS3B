namespace calcivarS3B.Views;

public partial class Login : ContentPage
{
    private string user = "x";
    private string password = "x";

    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;
    }

    private void btnInciar_Clicked(object sender, EventArgs e)
    {
        if (user.Equals(txtUsuario.Text) && password.Equals(txtContrasena.Text))
        {
            Navigation.PushAsync(new Home());
        }
        else
        {
            DisplayAlert("Error","Usuario o contraseña incorrecto","OK");
        }
    }
    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
    }
}