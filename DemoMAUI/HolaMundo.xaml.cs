namespace DemoMAUI;

public partial class HolaMundo : ContentPage
{
	public Button MiBoton { get; set; }
	private string IdiomaActual {get;set;} = "en";
	public HolaMundo()
	{
		InitializeComponent();
	}

	private void traducir(object sender, EventArgs e)
	{
		if (IdiomaActual == "en") {
			LabelMensaje.Text = "Bienvenido a .NET MAUI";
			ButtonTraducir.Text = "Translate";
			IdiomaActual = "es";
		}
		else
		{
			LabelMensaje.Text = "Welcome to .NET MAUI";
			ButtonTraducir.Text = "Traducir";
			IdiomaActual = "en";
		}
	}
}