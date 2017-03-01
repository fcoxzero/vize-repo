using System;

using Xamarin.Forms;

namespace Demo6
{
	public class App : Application
	{


		public static CarouselPage Main;

		static zoneDatabase zoneDB;
		static AppDatabase database;


		public static byte[] IPbyte = new byte[4];
		public static string IPaddress, IPaddressP, IPaddressL, port, textInput, iosError, tipoError, falseNum, entroAca, nombreVendedor, ServerIPaddress;
		//public static Task<string> IPaddressL2;
		public static double xdata, ydata, zdata;
		//network=true por prueba
		public static bool listen, busy, configflag, portbusy, isConnected, status, network, banderaDimmer, banderapickerRoom, banderaActiva = true;
		public static int count = 0, TCPport, codigoErrorSocket = 0, codigoErrorPrueba = 0, banderaPrueba = 0, ServerTCPport, banderaVentaInventario = 1, banderaTarjetaEfectivo = 1, banderaTarjetaEfectivo2 = 1;


		public static AppDatabase Database
		{
			get { return database; }
		}

		public static zoneDatabase ZoneDB
		{
			get { return zoneDB; }
		}


		public App()
		{
			// The root page of your application
			/*
			var content = new ContentPage
			{
				Title = "Demo6",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};

			MainPage = new NavigationPage(content);  
            */



			Main = new CarouselPage
			{
				Children =
				{
					new ControlPage1(),
					//new SettingsPage2(),
					//new SettingsPage4(),
					//new SettingsPage5()
					//new SettingsPage()
					//new SettingsPage4(),
					//new SettingsPage5()
					//new SettingsPage()
				}
			};

			MainPage = Main;


			//String paginaActual = " ";

			//paginaActual = Main.CurrentPage

			//MainPage.CurrentPageChanged += OnCurrentPageChanged;


			Main.CurrentPageChanged += (sender, args) =>
			{

				String currentPageString = Main.CurrentPage.ToString();


				Console.WriteLine("Cambio del Page en String : " + currentPageString);


				Console.WriteLine("Estoy probando tiempo de compilación");


				//Dependiendo de si la página es de ventas o inventario 
				//se da valor a la bandera para indicar hacia que pantalla
				//mandar los datos 

				//Para Ventas

				if (currentPageString.Contains("SettingsPage"))
				{

					App.banderaVentaInventario = 1;


					Constructors.labelTotalCantidad.Text = "0";

					//Constructors.veggies.Clear();
					Constructors.objetosPasteles.Clear();



				}

				//Para Inventarios

				if (currentPageString.Contains("SettingsPage4"))
				{

					App.banderaVentaInventario = 2;

					//Constructors.veggiesinventario.Clear();
					Constructors.objetosPastelesInventario.Clear();

				}



			};





		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}




