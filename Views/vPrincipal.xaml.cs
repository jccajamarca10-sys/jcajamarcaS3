namespace jcajamarcaS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
		lblUsuario.Text= "usuario conectado: "+ usuario;

	}
}