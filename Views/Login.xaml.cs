namespace calcivarS3B.Views;

public partial class Login : ContentPage
{
    private Dictionary<string, string> usuarios = new Dictionary<string, string>()
    {
        { "Carlos", "carlos123" },
        { "Ana", "ana123" },
        { "Jose", "jose123" }
    };
    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        if (!Preferences.ContainsKey(usuario))
        {
            Preferences.Set(usuario, contrasena);
            DisplayAlert("Registro", $"Usuario {usuario} registrado correctamente", "OK");
        }
        else
        {
            DisplayAlert("Error", $"El usuario {usuario} ya existe", "OK");
        }
    }

    private void btnInciar_Clicked(object sender, EventArgs e)
    {
        string inputUsuario = txtUsuario.Text;
        string inputContrasena = txtContrasena.Text;

        if (usuarios.ContainsKey(inputUsuario))
        {
            string storedPassword = usuarios[inputUsuario];

            if (storedPassword == inputContrasena)
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrecto", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Usuario no registrado", "OK");
        }
    }
    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
    }
}