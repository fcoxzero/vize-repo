using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Xamarin.Forms;




namespace Demo6
{

	public static class Constructors
	{

		public static ObservableCollection<VeggieViewModel> veggies { get; set; }

		public static ObservableCollection<VeggieViewModel> veggiesrespaldo { get; set; }


		//Observable Collection para inventarios
		public static ObservableCollection<InventarioVeggieViewModel> veggiesinventario { get; set; }



		public static ObservableCollection<VeggieTitulo> titulos { get; set; }

		public static ObservableCollection<VeggieTituloInventario> titulosinventario { get; set; }




		public static List<Pastel> objetosPasteles = new List<Pastel>();

		//List para inventarios

		public static List<InventarioPastel> objetosPastelesInventario = new List<InventarioPastel>();



		public static bool banderaActualiza2 = true;


		//Bandera que indica si se pudo conectar el server de IOS
		public static bool banderaServerStatus = false;


		public static double totalTodo = 0;


		public static Image Speech = new Image
		{
			Source = "MICRO.PNG",
			IsVisible = false
		};

		public static Image B0 = new Image
		{
			Source = "BOTON_ONOFF.PNG"
		};

		public static Image B1 = new Image
		{
			Source = "BOTON_1.PNG"
		};

		public static Image B2 = new Image
		{
			Source = "BOTON_2.PNG"
		};

		public static Image B3 = new Image
		{
			Source = "BOTON_3.PNG"
		};

		public static Image B4 = new Image
		{
			Source = "BOTON_4.PNG"
		};

		public static Image B5 = new Image
		{
			Source = "BOTON_5.PNG"
		};


		//Nuevos Botones


		public static Image B6 = new Image
		{
			Source = "BOTON_6.PNG"
		};

		public static Image B7 = new Image
		{
			Source = "BOTON_7.PNG"
		};



		public static Image BP = new Image
		{
			Source = "BOTON_plus.PNG"
		};

		public static Image BM = new Image
		{
			Source = "BOTON_minus.PNG"
		};

		public static Image BI = new Image
		{
			Source = "BOTON_I.PNG"
		};

		public static Image BII = new Image
		{
			Source = "BOTON_II.PNG"
		};


		public static Image BIII = new Image
		{
			Source = "BOTON_III.PNG"
		};



		public static Image BR = new Image
		{
			Source = "BOTON_R.PNG"
		};

		public static Image BOFF = new Image
		{
			Source = "BOTON_STAR.PNG"
		};

		public static Image BSAVE = new Image
		{
			Source = "SAVE.PNG",
			IsVisible = false
		};


		public static Image BSAVE2 = new Image
		{
			Source = "SAVE.PNG",
			IsVisible = false
		};



		public static Image PlusOK = new Image
		{
			Source = "Limp.png",
			VerticalOptions = LayoutOptions.Center,
			IsVisible = false,
			IsEnabled = false
		};

		public static Image MinusOK = new Image
		{
			Source = "Limm.png",
			VerticalOptions = LayoutOptions.Center
		};

		public static Image IDOK = new Image
		{
			Source = "ID.png",
			VerticalOptions = LayoutOptions.Center
		};

		public static Image INTOK = new Image
		{
			Source = "Init.png",
			VerticalOptions = LayoutOptions.Center
		};


		public static Image Cambio = new Image
		{



		};




		public static async void activarLabelTotal()
		{




		}








		public static MyPicker pickerByte1 = new MyPicker
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.Center
		};

		public static MyPicker pickerByte2 = new MyPicker
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.Center
		};

		public static MyPicker pickerByte3 = new MyPicker
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.Center
		};

		public static MyPicker pickerRoom = new MyPicker
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.Center
		};



		public static MyPicker pickerDimmer = new MyPicker
		{
			Title = "Dimmer",
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.FillAndExpand,
			IsVisible = false
		};

		public static MyPicker pickerControl1 = new MyPicker
		{
			Title = " ",
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.FillAndExpand,
			IsVisible = false,
			IsEnabled = false
		};

		public static MyPicker pickerControl2 = new MyPicker
		{
			Title = "Orden",
			HorizontalOptions = LayoutOptions.FillAndExpand,
			VerticalOptions = LayoutOptions.FillAndExpand,
			IsVisible = false
		};



		public static Switch switcher2 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center
		};

		public static Switch switcher3 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center,
			IsVisible = false
		};



		public static Switch switcher4 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center,
			IsToggled = true
		};



		public static Switch switcher5 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center
		};



		public static Switch switcher6 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center
		};


		public static Switch switcher7 = new Switch
		{
			HorizontalOptions = LayoutOptions.Center
		};




		public static StackLayout layout2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				new Label {
					Text = "Opciones de configuración",
					FontSize = 14,
					TextColor = Color.White,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				},
				switcher2,
				new Label {
					Text = "xxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};





		public static Label serverStatus = new Label
		{
			Text = " ",
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};




		public static Label labelNetworkType = new Label
		{
			Text = "Red doméstica",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};



		public static Label labelBotonModalidad = new Label
		{
			Text = "Activar/Desactivar Modalidad",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};






		public static Label labelBotonVentiladores = new Label
		{
			Text = "Activar/Desactivar Ventiladores",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};



		public static Label labelVersion = new Label
		{
			Text = "Versión Código",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};




		public static Label labelUsuarioLogin = new Label
		{
			Text = "Usuario :",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};


		public static Label labelPasswordLogin = new Label
		{
			Text = "Contraseña :",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};





		public static StackLayout layout3 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelNetworkType,
				switcher3,
				new Label {
					Text = "xxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};


		//Layout de cambio de modalidad

		public static StackLayout layout4 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelBotonModalidad,
				switcher4,
				new Label {
					Text = "xxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};




		public static StackLayout layoutLogin = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelUsuarioLogin,
				switcher5
			}
		};


		public static Label labelBotonCortinas = new Label
		{
			Text = "Activar/Desactivar Cortinas",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};



		public static Label labelLoginPrueba = new Label
		{
			Text = "USUARIO :",
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};




		public static Entry entryEditUsuario = new Entry
		{
			Placeholder = "Ingrese Usuario",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};


		public static Entry entryPastel = new Entry
		{
			Placeholder = "Ingrese Pastel",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};






		public static Label labelLoginPassword = new Label
		{
			Text = "CONTRASEÑA :",
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.CenterAndExpand
		};



		public static Entry entryEditPassword = new Entry
		{
			Placeholder = "Ingrese Contraseña",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};


		public static StackLayout layoutPasswordLogin = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelLoginPassword,
				entryEditPassword,
				new Label {
					Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};



		public static Image myImage = new Image()
		{
			Source = FileImageSource.FromUri(
		  new Uri("http://xamarin.com/content/images/pages/index/hero-slide.jpg"))
		};



		//Botón para enviar la lista de inventario en la pantalla de inventario

		public static Button enviarInventario = new Button
		{
			Text = " Inventario ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};







		public static StackLayout layout6 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelBotonVentiladores,
				switcher6,
				new Label {
					Text = "xxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};






		//Layout7 

		public static StackLayout layout7 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelVersion,
				switcher7,
				new Label {
					Text = "xxx",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
				}
			}
		};




		public static Entry entryEditZona = new Entry
		{
			Placeholder = "                          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};





		public static Entry entryP = new Entry
		{
			Placeholder = "                          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};



		public static Entry entryL = new Entry
		{
			Placeholder = "                          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black,
			IsEnabled = true
		};









		public static Entry entryUsuario = new Entry
		{
			Placeholder = "Username",
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black
		};


		public static Entry entryPassword = new Entry
		{
			Placeholder = "Password",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			IsPassword = true,
			TextColor = Color.Black
		};




		/*
		var usernameEntry = new Entry { Placeholder = "Username" };
		var passwordEntry = new Entry
		{
			Placeholder = "Password",
			IsPassword = true
		};
        */






		public static Entry entryPort = new Entry
		{
			Placeholder = "          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black,
			IsEnabled = true
		};




		public static Entry entryServerIP = new Entry
		{
			Placeholder = "                          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black,
			IsEnabled = true
		};



		public static Entry entryServerPuerto = new Entry
		{
			Placeholder = "          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black,
			IsEnabled = true
		};



		// Entry de ingreso de cantidad

		public static Entry entryCantidad = new Entry
		{
			Placeholder = "                          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			TextColor = Color.Black,
			IsEnabled = true
		};



		// Entry de ingreso de id de pastel

		public static Entry entryIDPastel = new Entry
		{
			Placeholder = "          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			WidthRequest = 100,
			TextColor = Color.Black,
			IsEnabled = true
		};


		//entry.TextChanged += Entry_TextChanged;




		public static Entry entryIDPastel2 = new Entry
		{
			Placeholder = "          ",
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			BackgroundColor = Color.White,
			WidthRequest = 100,
			TextColor = Color.Black,
			IsEnabled = true
		};





		public static Label labelIDPastel = new Label
		{
			Text = String.Format("PRODUCTO # : "),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center

		};




		public static Label labelIDPastel2 = new Label
		{
			Text = String.Format("PRODUCTO # : "),
			Font = Font.SystemFontOfSize(NamedSize.Large),
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center

		};






		public static Label labelCantidadPasteles = new Label
		{
			Text = String.Format("Introduzca la Cantidad de Pasteles"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelTitulo1 = new Label
		{
			Text = String.Format("Concepto"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};


		public static Label labelCantidad1 = new Label
		{
			Text = String.Format("Cantidad"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};





		public static Label labelNombrePastel1 = new Label
		{
			Text = String.Format("Pastel1"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};





		public static Label labelP = new Label
		{
			Text = String.Format("DynDNS"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};


		public static Label labelL = new Label
		{
			Text = String.Format("IP doméstica"),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelLServerIP = new Label
		{
			Text = String.Format("IP Server"),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};


		public static Label labelLServerPuerto = new Label
		{
			Text = String.Format("Puerto Server"),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};





		public static Label labelPort = new Label
		{
			Text = String.Format("Puerto"),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};



		public static Label labelPickerUnico = new Label
		{
			Text = String.Format("Configuración"),
			FontSize = 12,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			IsVisible = false
		};



		public static Label labelTotal = new Label
		{
			Text = String.Format("TOTAL : "),
			FontSize = 25,
			TextColor = Color.Blue,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			IsVisible = true
		};


		public static Label labelTotalCantidad = new Label
		{
			Text = String.Format(" "),
			FontSize = 25,
			TextColor = Color.Blue,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			IsVisible = true
		};




		public static Button buttonServerStatus = new Button
		{
			Text = " Status Server",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		public static Button buttonIngresar = new Button
		{
			Text = " Ingresar ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		public static Button buttonEliminar = new Button
		{
			Text = " Eliminar ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 190,
			HeightRequest = 90,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsVisible = true
		};








		public static Button buttonEliminar2 = new Button
		{
			Text = " Eliminar ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 120,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};




		public static Button buttonGuardar = new Button
		{
			Text = " Guardar Configuración ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		//HeightRequest = 80,
		//HeightRequest = 90,




		//Text = " Enviar ",

		public static Button buttonEnviarIDPastel = new Button
		{
			Text = " Llamar Producto ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			WidthRequest = 130,
			HeightRequest = 90,
			HorizontalOptions = LayoutOptions.Center,
			IsVisible = true
		};


		// Text = " Enviar ",

		public static Button buttonEnviarIDPastel2 = new Button
		{
			Text = " Llamar Producto ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 130,
			HeightRequest = 80,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};










		public static Grid minigridRGB = new Grid
		{
			RowDefinitions = {
				new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
			},
			VerticalOptions = LayoutOptions.EndAndExpand
		};




		public static Grid minigrid10 = new Grid
		{
			RowDefinitions = {
				new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }


			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
			},
			VerticalOptions = LayoutOptions.EndAndExpand
		};






		public static Grid minigrid1 = new Grid
		{
			RowDefinitions = {
				new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }

			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
			},
			VerticalOptions = LayoutOptions.EndAndExpand
		};








		public static Grid grid7 = new Grid
		{
			RowDefinitions = {
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
				},
			ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
				}
		};










		public static Grid minigrid2 = new Grid
		{
			RowDefinitions = {
				new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
			},
			VerticalOptions = LayoutOptions.EndAndExpand
		};

		public static StackLayout configLayout = new StackLayout
		{
			Children = {
				minigrid2,
				minigrid1
			},
			VerticalOptions = LayoutOptions.EndAndExpand
		};


		//Dictionarys


		public static Dictionary<string, byte> roomlist = new Dictionary<string, byte> { };
		public static Dictionary<string, byte> Byte1list = new Dictionary<string, byte> { };
		public static Dictionary<string, byte> Byte2list = new Dictionary<string, byte> { };
		public static Dictionary<string, byte> Byte3list = new Dictionary<string, byte> { };





		/*
		public static Dictionary<string, byte> controllist2 = new Dictionary<string, byte>
		{
			{ "Apagar PIR", 0x01 }, { "Encender PIR", 0x02 }, { "Act/Des PIR", 0x08 }, { "Null1", 0x00 }, { "Borrar Memoria", 0x09 }, { "Act/Des Enc General", 0x0A }
		};
       */


		//Los ultimos nada más son con código nuevo 

		public static Dictionary<string, byte> controllist2 = new Dictionary<string, byte>
		{


			//Versión 2 : Mayo/2016

			//0{ "Cancel", 0x00 },1{ "Establecer ID", 0x00},2{ "Establecer Limite-", 0x00},3{ "Estado Inicial", 0x00},4{ "Ultimo EstadoN", 0x00},5{ "Desactivar PIR", 0x01 },6{ "Activar PIR", 0x01 }, 7{ "Encendido PIR 30s", 0x02 }, 8{ "Encendido PIR 5m", 0x02 }, 9{ "Apagar PIR", 0x08 }, 10{ "Borrar Memoria", 0x09 }, 11{ "Encendido Gral Act/Des", 0x0A },12{ "Entrada Dig Des/Act", 0x0F },13{ "EntradaN PB/SW", 0x0F },14{ "uno/dos Nodo(s)", 0x10 },15 { "Paralelo/Escalera", 0x12},16{ "Cancelar", 0x00 }


			//Versión Original

			//{ "Cancel", 0x00 },{ "Establecer ID", 0x00},{ "Establecer Limite-", 0x00},{ "Estado Inicial", 0x00},{ "Desactivar PIR", 0x01 },{ "Activar PIR", 0x01 }, { "Encendido PIR 30s", 0x02 }, { "Encendido PIR 5m", 0x02 }, { "Apagar PIR", 0x08 }, { "Borrar Memoria", 0x09 }, { "Encendido Gral Act/Des", 0x0A },{ "Entrada DigR Des/Act", 0x0F },{ "uno/dos Nodo(s)", 0x10 }, { "Paralelo/Escalera", 0x12},{ "Ultimo Estado", 0x00},{ "Entrada PB/SW", 0x0F },{ "Cancelar", 0x00 }


			//Por el momento se mandan al final de la lista


			{ "Cancel", 0x00 },{ "Establecer ID", 0x00},{ "Establecer Limite-", 0x00},{ "Estado Inicial", 0x00},{ "Ultimo Estado", 0x00},{ "Desactivar PIR", 0x01 },{ "Activar PIR", 0x01 },{ "Encendido PIR 30s", 0x02 },{ "Encendido PIR 5m", 0x02 },{ "Apagar PIR", 0x08 },{ "Borrar Memoria", 0x09 },{ "Encendido Gral Act/Des", 0x0A },{ "Entrada Dig Des/Act", 0x0F },{ "Entrada PB/SW", 0x0F },{ "uno/dos Nodo(s)", 0x10 },{ "Paralelo/Escalera", 0x12},{ "Cancelar", 0x00 }


		};



		/*
		public static Dictionary<string, int> dimmerlist = new Dictionary<string, int>
		{
			{ "Des/Act Apagador", Commands.SWITCH }, { "uno/dos Nodo(s)", Commands.UNNODO }, { "Null2" , 0x00 }, { "Paralelo/Escalera", Commands.PARALELO }, { "Null3", 0x00 }
		};
        */

		/*
		public static Dictionary<string, int> dimmerlist = new Dictionary<string, int>
		{
			{ "Des/Act Apagador", Commands.SWITCH }, { "uno/dos Nodo(s)", Commands.UNNODO }, { "Paralelo/Escalera", Commands.PARALELO }
		};
		*/



		public static bool dbFlag = false;


		public static BoxView statusBox = new BoxView();



		//Alta de ListView


		public static ListView listView1 = new ListView();
		public static ListView lstView = new ListView();
		public static ListView lstView7 = new ListView();


		public static Button borrarPantallaVentas = new Button
		{
			Text = " BorrarPantalla ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 190,
			HeightRequest = 70,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};


		//ListView de Inventario
		public static ListView lstViewTituloInventario = new ListView();

		public static ListView lstViewListaInventario = new ListView();

		//borrarPantallaVentas,

		public static StackLayout layoutIDPastel = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			HeightRequest = 65,
			Children =
			{

				labelIDPastel,
				entryIDPastel
			}
		};





		public static StackLayout layoutIDPastel2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			HeightRequest = 65,
			Children =
			{
				enviarInventario,
				labelIDPastel2,
				entryIDPastel2,
				buttonEnviarIDPastel2
			}
		};








		public static StackLayout layoutGrid7 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.Start,
			HeightRequest = 205,
			Children =
			{
				grid7
			}
		};


		//VerticalOptions = LayoutOptions.Start,


		public static StackLayout layoutListView = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.End,
			VerticalOptions = LayoutOptions.FillAndExpand,
			HeightRequest = 205,
			Children =
			{
				listView1
			}
		};



		//ListView  de Pasteles


		public static StackLayout layoutListView2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Fill,
			HeightRequest = 500,
			Children =
			{
				lstView
			}
		};


		//ListView de Titulo
		public static StackLayout layoutListView3 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Fill,
			HeightRequest = 60,
			Children =
			{
				lstView7
			}
		};



		//ListView de Titulo
		//Stack Layouts que se expanden para abarcar toda la pantalla
		public static StackLayout layoutListViewTituloInventario = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Fill,
			HeightRequest = 60,
			Children =
			{
				lstViewTituloInventario
			}
		};



		public static StackLayout layoutListViewListaInventario = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Fill,
			HeightRequest = 620,
			Children =
			{
				lstViewListaInventario
			}
		};



		/*
		listView.ItemsSource = new string[]{
            "mono",
            "monodroid",
            "monotouch",
            "monorail",
            "monodevelop",
            "monotone",
            "monopoly",
            "monomodal",
            "mononucleosis"
         };
         */



		//Picker para zonas


		public static Picker pickerZonas = new Picker
		{
			Title = "Pasteles",
			VerticalOptions = LayoutOptions.CenterAndExpand
		};



		public static Entry zonaElegida = new Entry
		{

			Placeholder = "Introduzca zona",
			TextColor = Color.Silver,
			BackgroundColor = Color.White,
			WidthRequest = 270
		};



		public static Entry entryRecibido = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 120
		};





		public static Entry entryNumeroTarjeta = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 100
		};



		public static Entry entryNumeroTarjeta2 = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 100
		};


		public static Entry entryNumeroTarjetaFactura = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 100
		};




		public static Entry entryRFC = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 250
		};



		public static Entry entryDomicilio = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 250
		};





		public static Entry entryRazonSocial = new Entry
		{

			Placeholder = " ",
			TextColor = Color.Black,
			BackgroundColor = Color.White,
			WidthRequest = 250
		};




		public static Button agregarZona = new Button
		{
			Text = "Renombrar",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};


		public static Button agregarPastel = new Button
		{
			Text = "Agregar",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};



		public static Button borrarPantalla = new Button
		{
			Text = " BorrarPantalla ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HeightRequest = 60,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};





		public static Button guardarVendedor = new Button
		{
			Text = " Guardar Vendedor ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			HeightRequest = 90,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};



		// WidthRequest = 175
		//Font = Font.SystemFontOfSize(NamedSize.Medium),

		public static Button enviarNota = new Button
		{
			Text = " Remisión ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 190,
			HeightRequest = 90,
			BorderColor = Color.Black,
			BorderWidth = 3,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};




		public static Button enviarNota2 = new Button
		{
			Text = " Remisión ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			WidthRequest = 120,
			HeightRequest = 70,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};




		public static Button enviarQR = new Button
		{
			Text = "    QR    ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 170,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};




		public static Button enviarCodigoBarras = new Button
		{
			Text = "     CB     ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 170,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};







		public static Button iniciaServer = new Button
		{
			Text = " Servidor ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};



		public static Button iniciaServerVentas = new Button
		{
			Text = " Ventas ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};



		public static Button iniciaServerInventarios = new Button
		{
			Text = " Inventario ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsEnabled = true
		};






		public static Button buttonPickerZonas = new Button
		{
			Text = " Salvar Zonas",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};


		// WidthRequest = 175
		//VerticalOptions = LayoutOptions.StartAndExpand,


		public static Button buttonCalculoTotalRecibido = new Button
		{
			Text = " Calculo Total ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			WidthRequest = 190,
			HeightRequest = 90,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			IsVisible = true
		};



		public static Button buttonCalculoTotalRecibido2 = new Button
		{
			Text = " Calculo Total ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			WidthRequest = 120,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};




		public static Button buttonTarjeta = new Button
		{
			Text = "Tarjeta",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			WidthRequest = 100,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		public static Button buttonEfectivo = new Button
		{
			Text = "Efectivo",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			WidthRequest = 100,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};


		//Butón de efectivo y tarjeta para sección de factura

		public static Button buttonTarjeta2 = new Button
		{
			Text = "Tarjeta",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			WidthRequest = 100,
			BorderWidth = 1,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		public static Button buttonEfectivo2 = new Button
		{
			Text = "Efectivo",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			WidthRequest = 100,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};



		public static Button buttonEspacio = new Button
		{
			Text = "            ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 0,
			WidthRequest = 100,
			HeightRequest = 40,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};


		public static Button buttonEspacio2 = new Button
		{
			Text = "            ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Medium),
			BackgroundColor = Color.White,
			BorderWidth = 0,
			WidthRequest = 100,
			HorizontalOptions = LayoutOptions.Center,
			IsVisible = true
		};



		public static Button buttonFactura = new Button
		{
			Text = " Enviar Factura ",
			TextColor = Color.Black,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			BackgroundColor = Color.Pink,
			BorderWidth = 1,
			WidthRequest = 300,
			HeightRequest = 90,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.StartAndExpand,
			IsVisible = true
		};




		public static Grid statusGrid = new Grid
		{
			RowDefinitions = {
				new RowDefinition { Height = new GridLength (0.25, GridUnitType.Star) },
				new RowDefinition { Height = new GridLength (1.75, GridUnitType.Star) }
			},
			ColumnDefinitions = {
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) }
			}
		};




		//Zonas interiores y swicth
		// rgbOrrooms : "Zonas Interiores"
		// rgb2rooms : switch
		// stackLay : layout que tiene el scroll 




		//Label para ConfigPage



		public static Label avisoConfig = new Label
		{
			Text = String.Format("Seleccione un pastel y después el botón 'Agregar' para agregar un pastel a la lista"),
			FontSize = 14,
			TextColor = Color.White,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};






		public static Label labelClient = new Label
		{
			Text = String.Format(" CONFIGURACIÓN CLIENTE : "),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};





		public static Label labelServer = new Label
		{
			Text = String.Format(" CONFIGURACIÓN SERVER : "),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};


		public static Label labelRecibido = new Label
		{
			Text = String.Format(" RECIBIDO : "),
			FontSize = 14,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelCambio = new Label
		{
			Text = String.Format(" CAMBIO : "),
			FontSize = 25,
			TextColor = Color.Blue,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelCalculoCambio = new Label
		{
			Text = String.Format(" "),
			FontSize = 25,
			TextColor = Color.Blue,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};



		public static Label labelTarjetaDigitos = new Label
		{
			Text = String.Format("DIGITOS TARJETA: "),
			FontSize = 15,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};





		public static Label labelRFC = new Label
		{
			Text = String.Format("RFC :               "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};



		public static Label labelDomicilio = new Label
		{
			Text = String.Format("Domicilio :       "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};


		public static Label labelEfectivoTarjeta = new Label
		{
			Text = String.Format(" Forma de Pago "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelRazonSocial = new Label
		{
			Text = String.Format("Razon Social : "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};






		public static Label labelEspacio1 = new Label
		{
			Text = String.Format("        "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		public static Label labelEspacioEfecTarj = new Label
		{
			Text = String.Format("              "),
			FontSize = 20,
			TextColor = Color.Black,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center
		};




		// iniciaServer se baja en la pantalla momentaneamente
		//buttonEliminar,

		public static StackLayout stackBotonesRemision = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 110,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonCalculoTotalRecibido,
				enviarNota,
				buttonEnviarIDPastel

			}
		};



		public static StackLayout stackBotonesFacturas = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 100,
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonFactura
			}
		};





		/*

		public static StackLayout stackBotonesRemision2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				enviarNota2,
				buttonEliminar2,
				buttonCalculoTotalRecibido2
			}
		};
		*/



		//buttonEfectivo,
		//buttonTarjeta,buttonTarjeta,
		//entryNumeroTarjeta,

		public static StackLayout stackTotalRecibido = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelRecibido,
				entryRecibido,
				labelIDPastel,
				entryIDPastel
			}
		};




		public static StackLayout stackTarjetaEfectivoFactura = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonEfectivo2,
				buttonTarjeta2,
				entryNumeroTarjetaFactura

			}
		};



		public static StackLayout stackEspacioZeta = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 20,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {

			}
		};




		public static StackLayout stackEspacioZeta2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 160,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {

			}
		};

		/*

		public static StackLayout stackBotonesEliminar = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonEliminar
			}
		};
        */


		//Se eliminan : agregarPastel,buttonEliminar,borrarPantalla,enviarNota
		//borrarPantalla

		public static StackLayout stackBotonesInventario = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 100,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				enviarQR,
				enviarCodigoBarras
			}
		};




		public static StackLayout stackBotones2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonGuardar
			}
		};






		public static StackLayout stackBotonesSwithServer = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				iniciaServerVentas,
				iniciaServerInventarios
			}
		};






		public static StackLayout stackEspacio = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 10,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {

			}
		};




		public static StackLayout stackEspacio1 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {

			}
		};


		public static StackLayout stackEspacio2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 30,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				entryNumeroTarjeta2
			}
		};





		public static StackLayout stackTotal = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelTotal,
				labelTotalCantidad,
				labelEspacio1,
				labelCambio,
				labelCalculoCambio
			}
		};



		/*
		public static StackLayout stackCambio = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelCambio,
				labelCalculoCambio
			}
		};
*/


		/*
		public static StackLayout stackTarjetaEfectivo = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				buttonEfectivo,
				buttonTarjeta,
				entryNumeroTarjeta
			}
		};
*/



		//Stacks de ConfigPage5


		public static StackLayout stackRFC = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelRFC,
				entryRFC
			}
		};



		public static StackLayout stackDomicilio = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelDomicilio,
				entryDomicilio
			}
		};




		public static StackLayout stackRazonSocial = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelRazonSocial,
				entryRazonSocial
			}
		};



		public static StackLayout stackEfecTarBorrarPantalla = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 60,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Start,
			Children = {
				labelEfectivoTarjeta,
				labelEspacioEfecTarj

			}
		};



		/*
		public static StackLayout stackTarjetaNumeros2 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HeightRequest = 40,
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Children = {
				labelTarjetaDigitos,
				entryNumeroTarjeta2
			}
		};
        */

		//Se eliminan :
		//buttonServerStatus,
		//serverStatus,
		//iniciaServer			

		//stackBotones,








		//Stacklayout base en el que se implementan los layouts secundarios
		//stackTarjetaEfectivo,
		//stackCambio,
		//stackTarjetaNumeros2,
		//stackEfecTarBorrarPantalla
		//layoutIDPastel,
		//stackEspacioZeta,


		public static ScrollView ConfigContent = new ScrollView
		{
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					stackBotonesRemision,
					stackTotalRecibido,
					stackEspacio,
					layoutListView3,
					layoutListView2,
					stackTotal
					//layout4,
					//layout7
					//layout5,
					//layout6

				}
			}
		};







		// Stack para interfaz de : FACTURAS

		public static ScrollView ConfigContent5 = new ScrollView
		{
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					stackEspacioZeta2,
					stackBotonesFacturas,
					stackTarjetaEfectivoFactura,
					buttonEspacio,
					stackRFC,
					stackDomicilio,
					stackRazonSocial
				}
			}
		};




		//Interfaz para pantalla de Inventario



		public static ScrollView ConfigContent4 = new ScrollView
		{
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					stackEspacio1,
					stackBotonesInventario,
					layoutIDPastel2,
					stackEspacio,
					layoutListViewTituloInventario,
					layoutListViewListaInventario
				}
			}
		};




		//Intrfaz para pantalla de Venta


		public static ScrollView ConfigContent2 = new ScrollView
		{

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					stackBotonesSwithServer,
					iniciaServer,
					buttonServerStatus,
					serverStatus,
					stackBotones2,
					stackEspacio2,
					labelClient,
					entryL,
					labelL,
					entryPort,
					labelPort,
					labelServer,
					entryServerIP,
					labelLServerIP,
					entryServerPuerto,
					labelLServerPuerto
				}
			}
		};


		//Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",

		/*
		new Label {
					Text = "                                      ",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
	     }
	     */

		public static StackLayout layout5 = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				labelLoginPrueba,
				entryEditUsuario
			}
		};



		//Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",

		/*
		new Label {
					Text = "                                    ",
					TextColor = Color.Black,
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.CenterAndExpand
	    }
	    */

		public static StackLayout layoutBotonGuardar = new StackLayout
		{
			Orientation = StackOrientation.Horizontal,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				guardarVendedor

			}
		};







		public static StackLayout layoutPrincipalLogin = new StackLayout
		{
			Orientation = StackOrientation.Vertical,
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Center,
			Children =
			{
				layout5,
				layoutBotonGuardar,
				myImage
			}
		};


		public static Label invisibleLabel = new Label
		{
			Text = " ",
			TextColor = Color.Black
		};





		public static Grid buttonGrid = new Grid
		{
			RowDefinitions =
			{
				new RowDefinition { Height = new GridLength (1.25, GridUnitType.Star) },
				new RowDefinition { Height = new GridLength (0.10, GridUnitType.Star) },
				new RowDefinition { Height = new GridLength (1.25, GridUnitType.Star) }
			},
			ColumnDefinitions =
			{
				new ColumnDefinition { Width = new GridLength (0.25, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				new ColumnDefinition { Width = new GridLength (0.25, GridUnitType.Star) }
			}
		};






	}
}

