namespace jcajamarcaS3.Views;

public partial class vLogin : ContentPage
{
	string usuario = " ";
	string contrasena = " ";

	public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string usuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
		usuario = usuarioNuevo;
		contrasena = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			string usuarioIngresado = txtUsuario.Text;
			string contrasenaIngresada = txtContrasena.Text;			
			if(usuario==usuarioIngresado && contrasena==contrasenaIngresada)
			{
				await Navigation.PushAsync(new vPrincipal(usuario));
			}
			else
			{
				await DisplayAlertAsync("Error", "Usuario/contraseña incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
        }
		catch (Exception ex)
		{
			await DisplayAlertAsync("Error", ex.Message, "Cerrar");
			
		}
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new vRegistro());
    }
}